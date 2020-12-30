using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace imageRater
{
    public partial class imageRaterMain : Form
    {
        public imageRaterMain()
        {
            InitializeComponent();

            // Set picturebox mode so the images fir correctly horizontal vs portrait
            leftPictureBox.SizeMode     = PictureBoxSizeMode.Zoom;
            centerPictureBox.SizeMode   = PictureBoxSizeMode.Zoom;
            rightPictureBox.SizeMode    = PictureBoxSizeMode.Zoom;
        }

        private string[] files;     // Holds the filenames
        private int[] recentlyUsed  = new int[3]; // Pictures that are currently displayed
        //private int[] availableNums = new int[Gallery.Count];
        List<int> availableNums = new List<int>();

        struct Picture
        {
            public int      rating;         // The like rating of a picture
            public int      timesSelected;  // Number of times the file has been chosen
            public string   name;           // The file name    -> file.jpg
            public string   source;         // Full file source -> c:\users\file1.jpg
        }

        private int leftPicNum, centerPicNum, rightPicNum;

        List<Picture> Gallery = new List<Picture>();    // Contains all pictures from a folder
        // !!!!!!!!!!!!!!!!!!! Must check to see if there was already a folder in use
        // so that pictures arent combined across folders

        // Refreshes all 3 picture boxes with new images from Gallery (contains source)
        public void GetPictures()
        {
            // Get random seed
            Random rnd = new Random();


            // Make sure each number is unique to not dupe pics
            bool unique = false;
            while (unique == false)
            {
                // Get random numbers
                //leftPicNum   = rnd.Next(Gallery.Count);
                //centerPicNum = rnd.Next(Gallery.Count);
                //rightPicNum  = rnd.Next(Gallery.Count);

                leftPicNum = rnd.Next(0, availableNums.Count);
                availableNums.RemoveAt(leftPicNum);

                centerPicNum = rnd.Next(0, availableNums.Count);
                availableNums.RemoveAt(centerPicNum);

                rightPicNum = rnd.Next(0, availableNums.Count);
                availableNums.RemoveAt(rightPicNum);


                // Exit if all numbers are !=
                if (leftPicNum   != centerPicNum &&
                    leftPicNum   != rightPicNum  &&
                    centerPicNum != rightPicNum)
                {
                    //availableNums.Capacity = Gallery.Count; // Resert the gallery capacity 
                    // Reset gallery size (INCREASE)
                    for (int i = 0; i < 3; ++i)
                        availableNums.Add(-1);

                    // Put the old recently used pic nums back into available to be selected
                    availableNums.Insert(recentlyUsed[0], recentlyUsed[0]);
                    availableNums.Insert(recentlyUsed[1], recentlyUsed[1]);
                    availableNums.Insert(recentlyUsed[2], recentlyUsed[2]);

                    // Reset the gallery size (DECREASE)
                    for (int i = 0; i < 3; ++i)
                        availableNums.RemoveAt(availableNums.Count-1);

                    // Set the new recently used to the pictures that will be displayed
                    recentlyUsed[0] = leftPicNum;
                    recentlyUsed[1] = centerPicNum;
                    recentlyUsed[2] = rightPicNum;

                    unique = true;
                }
                else // Numbers weren't unique. reset the available list of pics
                {
                    // Reset gallery size (INCREASE)
                    for (int i = 0; i < 3; ++i)
                        availableNums.Add(-1);

                    availableNums.Insert(leftPicNum, leftPicNum);       // Insert at leftpicnum the leftpicnum
                    availableNums.Insert(centerPicNum, centerPicNum);   // Insert at centerpicnum the centerpicnum
                    availableNums.Insert(rightPicNum, rightPicNum);     // Insert at rightpicnum the rightpicnum

                    // Reset the gallery size (DECREASE)
                    for (int i = 0; i < 3; ++i)
                        availableNums.RemoveAt(availableNums.Count - 1);
                }
            }

            // Show the image and update the image label
            leftImageLabel.Text = Gallery[leftPicNum].name;
            Bitmap leftImage = new Bitmap(Gallery[leftPicNum].source);
            //leftPictureBox.ImageLocation = Gallery[leftPicNum].source;
            leftPictureBox.Image = leftImage;
            
            centerImageLabel.Text = Gallery[centerPicNum].name;
            Bitmap centerImage = new Bitmap(Gallery[centerPicNum].source);
            //centerPictureBox.ImageLocation = Gallery[centerPicNum].source;
            centerPictureBox.Image = centerImage;
            
            rightImageLabel.Text = Gallery[rightPicNum].name;
            Bitmap rightimage = new Bitmap(Gallery[rightPicNum].source);
            //rightPictureBox.ImageLocation = Gallery[rightPicNum].source;
            rightPictureBox.Image = rightimage;
        }


        // choose a folder to rate images from
        private void chooseFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt to save the current session 
            // if there are items in gallery
            if (Gallery.Count > 0)
                PromptUserForSave();

            Gallery.Clear();    // Clear the gallery

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();  // Create folder browser

            folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;   // Set desktop as directory

            DialogResult result = folderBrowser.ShowDialog();               // Get the folder

            // Get the files from the folder
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                files = Directory.GetFiles(folderBrowser.SelectedPath);    // Gets all the names of files

                // Remove the directory i.e. c:/users/name/testfolder/file1.jpg -> file1.jpg
                // and store the picture source in gallery
                for (int i=0; i<files.Length; ++i)
                {
                    Picture pic = new Picture();            // Create pic
                    pic.source = files[i];                  // Store full file source

                    string[] dir = files[i].Split('\\');    // Split the array
                    files[i] = dir[dir.Length - 1];         // Store last element

                    pic.name            = files[i];         // Store source
                    pic.timesSelected   = 0;                // Initialize to 0
                    pic.rating          = 0;                // Initialize to 0

                    Gallery.Add(pic);
                }
                
                // Make all pics available to be displayed
                for (int i = 0; i < Gallery.Count; ++i)
                    availableNums.Add(i);

                // Put pictures in
                GetPictures();
            }
        }


        // While form is closing
        // Save info from gallery to file
        private void imageRaterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveFile();
            PromptUserForSave();
        }


        // User chooses a file to continue a rating session from
        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt to save the current session 
            // if there are items in gallery
            if (Gallery.Count > 0)
                PromptUserForSave();

            // Empty the gallery
            Gallery.Clear();

            OpenFileDialog openFile = new OpenFileDialog();

            // Sets the desktop as initial directory
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // string curDir = Environment.CurrentDirectory;        // sets directory to current
            openFile.InitialDirectory = path;

            // Dialog result
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // A file was selected
                // Read all the file lines into an array
                files = File.ReadAllLines(openFile.FileName);

                // Loop through array and parse data storing in Gallery
                // This WILL ERASE all current info in Gallery
                for (int i=0; i<files.Length; ++i)
                {
                    // Split the line
                    string[] split_line = files[i].Split(',');

                    // Store data into temp pic
                    Picture tempPic = new Picture();
                    tempPic.source  = split_line[0];
                    tempPic.name    = split_line[1];
                    tempPic.timesSelected = int.Parse(split_line[2]);
                    tempPic.rating  = int.Parse(split_line[3]);

                    // Store pic into gallery
                    Gallery.Add(tempPic);
                    //Gallery[i] = tempPic;
                    //Gallery.Insert(i, tempPic);
                }
            }
            else
            {
                MessageBox.Show("The operation was cancelled");
                return;
            }

            GetPictures();
        }


        // Update picture info based on radio buttons   
        private void ratePicturesButton_Click(object sender, EventArgs e)
        {
            // Error check if a folder has been selected
            if (files == null)
            {
                MessageBox.Show("You must select a folder first");
                return;
            }

            // Check the logic of the rate (radio buttons)
            int leftNum, rightNum, centerNum;
            
            leftNum   = int.Parse(GetSelectedRadioButtonText(leftGroupBox));
            centerNum = int.Parse(GetSelectedRadioButtonText(centerGroupBox));
            rightNum  = int.Parse(GetSelectedRadioButtonText(rightGroupBox));
            
            
            // Checking if there are same numbers selected
            if (leftNum   == centerNum ||
                leftNum   == rightNum  ||
                centerNum == rightNum)
            {
                // There is an error. User must retry
                MessageBox.Show("You must select different ratings. Please Retry.");
                return;
            }

            // add ratings  and timesSelected to the picture
            // update the pic in the gallery
            //LEFT pic
            Picture tempPic = Gallery[leftPicNum]; // Have to use temp pic since lists use copies
            tempPic.rating += leftNum;
            ++tempPic.timesSelected;
            Gallery[leftPicNum] = tempPic;

            // CENTER pic
            tempPic = Gallery[centerPicNum];
            tempPic.rating += centerNum;
            ++tempPic.timesSelected;
            Gallery[centerPicNum] = tempPic;

            // RIGHT pic
            tempPic = Gallery[rightPicNum];
            tempPic.rating += rightNum;
            ++tempPic.timesSelected;
            Gallery[rightPicNum] = tempPic;

            
            GetPictures();      // Get a new set of pictures
        }


        // Get the value of a radio button from a groupbox
        private string GetSelectedRadioButtonText(GroupBox grb)
        {
            return grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }


        // Saves the contents of Gallery to a file
        private void SaveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog(); 
            saveFile.Filter = "Text Files | *.txt";         // The save as type in the dialog box
            saveFile.DefaultExt = "txt";                    // The default extension

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Save the file
                StreamWriter outputFile = File.CreateText(saveFile.FileName);

                /*---------------------------------------
             *  Store the picture info
             *  source, name, timesSelected, rating
             *  ---------------------------------------
             */
                String fileLine;
                for (int i = 0; i < Gallery.Count; ++i)
                {
                    fileLine = Gallery[i].source + "," +
                               Gallery[i].name + "," +
                               Gallery[i].timesSelected.ToString() + "," +
                               Gallery[i].rating.ToString();

                    outputFile.WriteLine(fileLine);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("The save operation was cancelled");
                return;
            }
        }


        // Displays msgBox with buttons prompting user for save
        private void PromptUserForSave()
        {
            String msg = "Do you want to save this session?";
            string cap = "Save";

            // Prompts the user
            var result = MessageBox.Show(msg, cap,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Yes
                SaveFile();
            }
        }
    }
}
