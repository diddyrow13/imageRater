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
        }

        string[] files;     // Holds the filenames

        struct Picture
        {
            public int      rating;         // The like rating of a picture
            public int      timesSelected;  // Number of times the file has been chosen
            public string   name;           // The file name    -> file.jpg
            public string   source;         // Full file source -> c:\users\file1.jpg
        }

        int leftPicNum, centerPicNum, rightPicNum;

        List<Picture> Gallery = new List<Picture>();    // Contains all pictures from a folder
        // !!!!!!!!!!!!!!!!!!! Must check to see if there was already a folder in use
        // so that pictures arent combined across folders

        // Refreshes all 3 picture boxes with new images from Gallery (contains source)
        public void GetPictures()
        {
            // Get random number
            Random rnd = new Random();


            // Make sure each number is unique to not dupe pics
            bool unique = false;
            while (unique == false)
            {
                // Get random numbers
                leftPicNum = rnd.Next(Gallery.Count);
                centerPicNum = rnd.Next(Gallery.Count);
                rightPicNum = rnd.Next(Gallery.Count);
                
                // Exit if all numbers are !=
                if (leftPicNum != centerPicNum &&
                    leftPicNum != rightPicNum &&
                    centerPicNum != rightPicNum)
                {
                    unique = true;
                }
            }

            // Show the image and update the image label
            leftImageLabel.Text = Gallery[leftPicNum].name;
            leftPictureBox.ImageLocation = Gallery[leftPicNum].source;
            
            centerImageLabel.Text = Gallery[centerPicNum].name;
            centerPictureBox.ImageLocation = Gallery[centerPicNum].source;
            
            rightImageLabel.Text = Gallery[rightPicNum].name;
            rightPictureBox.ImageLocation = Gallery[rightPicNum].source;
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
