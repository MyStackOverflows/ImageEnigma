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

/* Developed by Paul I. Unger from Unger Software Solutions
 * Essentially a combination of two unreleased bits of software, PixelHide and TextHide.
 * Began development on January 13 2020, released on */

namespace ImageEnigma
{
    public partial class ImageEnigmaForm : Form
    {
        public ImageEnigmaForm()
        {
            InitializeComponent();
        }

        /* PixelHide works by encoding each character in the message into a number from 0-255 (00-FF in hex),
         * then taking any combo of red, green, or blue, puts that encoded character into the red, green, or blue
         * slots determined by the aforementioned combo. This combo is itself encoded into a separate special pixel
         * that the decoding mechanism uses to determine which of the RGB values to decode, and how far into the
         * image to decode. The rest of the values in the pixels of the image are random nonsense, there to make
         * the image seem completely random. Another method worth looking into is [r, g, b] --> [value, x, y],
         * where one of r, g, or b is used to hold the value of the encoded character, while the other two are
         * used to hold the x and y coords of the next value. You then go to the coords and the cycle repeats.
         * However, this method can make a max image size of 256x256 which is 65,536‬ possible characters, while
         * my method can have infinite - and depending on the combo chosen, could take up less space as 3 values
         * per pixel is more efficient than 1 value per pixel. */
        string[] validHex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "A", "B", "C", "D", "E", "F" };
        #region PixelHide Code
        Random rnd = new Random();

        // Calculates the smallest side length of a square that will have enough pixels for the message
        private int PixelHideCalculateBounds()
        {
            string message = PixelHideMessageTextBox.Text;
            int pixelsNeeded = (int)(message.Length / PixelHideGetNumOfChecks()) + 1;
            int sideLength = (int)Math.Sqrt(pixelsNeeded) + 1;
            return sideLength;
        }

        

        private List<int> PixelHideGetXY(string colour, Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (ColorTranslator.ToHtml(bmp.GetPixel(x, y)).Equals(colour))
                        return new List<int>() { x, y };
                }
            }
            return null;
        }

        private string PixelHideFindSignificantPixelColor(Bitmap bmp)
        {
            List<string> pixels = new List<string>()
            {
                "#FFFFFF",
                "#FFFF00",
                "#FF00FF",
                "#00FFFF",
                "#FF0000",
                "#00FF00",
                "#0000FF"
            };
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (pixels.Contains(ColorTranslator.ToHtml(bmp.GetPixel(x, y))))
                        return ColorTranslator.ToHtml(bmp.GetPixel(x, y));
                }
            }
            return null;
        }

        private string PixelHideGenerateSignificantPixelColor()
        {
            List<string> rgb = new List<string>() { "00", "00", "00" };
            if (PixelHideRedValueCheckBox.Checked) { rgb[0] = "FF"; }
            if (PixelHideGreenValueCheckBox.Checked) { rgb[1] = "FF"; }
            if (PixelHideBlueValueCheckBox.Checked) { rgb[2] = "FF"; }
            return "#" + string.Join("", rgb);
        }

        private int PixelHideGetNumOfChecks()
        {
            int numOfChecks = 0;
            if (PixelHideRedValueCheckBox.Checked) { numOfChecks++; }
            if (PixelHideGreenValueCheckBox.Checked) { numOfChecks++; }
            if (PixelHideBlueValueCheckBox.Checked) { numOfChecks++; }
            return numOfChecks;
        }
        #endregion

        #region ChaseHide Code
        private List<int> ChaseHideFindSignificantPixelXY(Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    string colour = ColorTranslator.ToHtml(bmp.GetPixel(x, y));
                    if (colour.Substring(1, 2).Equals("FF") ||
                        colour.Substring(3, 2).Equals("FF") ||
                        colour.Substring(5, 2).Equals("FF"))
                    {
                        return new List<int>() { x, y };
                    }
                }
            }
            return null;
        }

        private string ChaseHideFindSignificantPixelColor(Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    string colour = ColorTranslator.ToHtml(bmp.GetPixel(x, y));
                    if (colour.Substring(1, 2).Equals("FF") ||
                        colour.Substring(3, 2).Equals("FF") ||
                        colour.Substring(5, 2).Equals("FF"))
                    {
                        return colour;
                    }
                }
            }
            return null;
        }

        private string ChaseHideGenerateSignificantPixelColor()
        {
            List<string> rgb = new List<string>() { "00", "00", "00" };
            rgb[0] = ChaseHideRedValueRadioButton.Checked ? "FF" : RandomHexValue(new List<string>() { "00", "FF" });
            rgb[1] = ChaseHideGreenValueRadioButton.Checked ? "FF" : RandomHexValue(new List<string>() { "00", "FF" });
            rgb[2] = ChaseHideBlueValueRadioButton.Checked ? "FF" : RandomHexValue(new List<string>() { "00", "FF" });
            return "#" + string.Join("", rgb);
        }

        private Tuple<string, int, int> ChaseHideDecodePixel(Bitmap bmp, int startX, int startY, string sigColour)
        {
            string colour = ColorTranslator.ToHtml(bmp.GetPixel(startX, startY));
            string decoded = "";
            int x = 0, y = 0;
            if (sigColour.Substring(1, 2).Equals("FF"))
            {
                decoded = ((char)Convert.ToInt32(colour.Substring(1, 2), 16)).ToString();
                x = Convert.ToInt32(colour.Substring(3, 2), 16);
                y = Convert.ToInt32(colour.Substring(5, 2), 16);
            }
            if (sigColour.Substring(3, 2).Equals("FF"))
            {
                decoded = ((char)Convert.ToInt32(colour.Substring(3, 2), 16)).ToString();
                x = Convert.ToInt32(colour.Substring(1, 2), 16);
                y = Convert.ToInt32(colour.Substring(5, 2), 16);
            }
            if (sigColour.Substring(5, 2).Equals("FF"))
            {
                decoded = ((char)Convert.ToInt32(colour.Substring(5, 2), 16)).ToString();
                x = Convert.ToInt32(colour.Substring(1, 2), 16);
                y = Convert.ToInt32(colour.Substring(3, 2), 16);
            }
            return new Tuple<string, int, int>(decoded, x, y);
        }

        private string ChaseHideEncodePixel(char character, List<Tuple<int, int>> usedXY)
        {
            List<string> rgb = new List<string>() { "00", "00", "00" };
            rgb[0] = ChaseHideRedValueRadioButton.Checked ? Convert.ToString(((int)character), 16) : RandomHexValue(new List<string>() { "00", "FF" });
            rgb[1] = ChaseHideGreenValueRadioButton.Checked ? Convert.ToString(((int)character), 16) : RandomHexValue(new List<string>() { "00", "FF" });
            rgb[2] = ChaseHideBlueValueRadioButton.Checked ? Convert.ToString(((int)character), 16) : RandomHexValue(new List<string>() { "00", "FF" });
            return "#" + string.Join("", rgb);
        }
        #endregion

        #region TextHide Code
        string txtFileName = "txtFile.txt";
        string txtFilePath = "";

        private void TextHideMain()
        {
            TextHideCreateTXTFile(TextHideToAddTextBox.Lines);
            string newFilePath = "";
            DialogResult chosenFile = SaveFile.ShowDialog();
            if (chosenFile == DialogResult.OK)
                newFilePath = SaveFile.FileName;
            else
            {
                MessageBox.Show("If you want the hidden message file, you must choose a place to save the file.");
                return;
            }
            TextHideRunCommand(TextHideImageFileTextBox.Text, txtFilePath, newFilePath);
            File.Delete(txtFilePath);
        }

        private void TextHideRunCommand(string imgFilePath, string txtFilePath, string newFilePath)
        {
            string args = "/C copy /b \"" + imgFilePath + "\" + \"" + txtFilePath + "\" \"" + newFilePath + "\"";
            System.Diagnostics.Process hideImage = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = args;
            hideImage.StartInfo = startInfo;
            hideImage.Start();
            hideImage.WaitForExit();
        }

        private void TextHideCreateTXTFile(string[] toAdd)
        {
            List<string> lines = new List<string> { "", "" };
            foreach (string i in toAdd)
                lines.Add(i);
            FileStream txtFile = File.Create(txtFileName);
            txtFile.Close();
            FileInfo txtFileInfo = new FileInfo(txtFileName);
            txtFilePath = txtFileInfo.FullName;
            File.WriteAllLines(txtFilePath, lines);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(txtFilePath))
                File.Delete(txtFilePath);
        }
        #endregion

        #region PixelHide, ChaseHide, and TextHide shared code
        private string RandomHexValue(List<string> notAllowed)
        {
            string choice = "";
            for (int i = 0; i < 2; i++)
                choice += validHex[rnd.Next(17)];
            while (notAllowed.Contains(choice))
            {
                choice = "";
                for (int i = 0; i < 2; i++)
                    choice += validHex[rnd.Next(17)];
            }
            return choice;
        }

        // This is where all the decoding happens
        private void dragDrop(object sender, DragEventArgs e)
        {
            if (ImageHideTabControl.SelectedTab.Equals(PixelHideTabPage))
            {
                string[] DragDropName = (string[])e.Data.GetData(DataFormats.FileDrop);
                string name = DragDropName[0];
                string ext = name.Substring(int.Parse((name.Length - 4).ToString()), 4);
                if (ext.Equals(".jpg") || ext.Equals(".png"))
                {
                    Bitmap bmp = new Bitmap(name);
                    string output = "";
                    string encodingColour = PixelHideFindSignificantPixelColor(bmp);
                    bool decodeRed = encodingColour.Substring(1, 2).Equals("FF") ? true : false;
                    bool decodeGreen = encodingColour.Substring(3, 2).Equals("FF") ? true : false;
                    bool decodeBlue = encodingColour.Substring(5, 2).Equals("FF") ? true : false;
                    bool continueDecoding = true;
                    List<int> border = PixelHideGetXY(encodingColour, bmp);
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            if (continueDecoding)
                            {
                                if (x.Equals(border[0]) && y.Equals(border[1]))
                                {
                                    continueDecoding = false;
                                    break;
                                }
                                string hexString = ColorTranslator.ToHtml(bmp.GetPixel(x, y));
                                if (decodeRed)
                                    output += ((char)Convert.ToInt32(hexString.Substring(1, 2), 16)).ToString();
                                if (decodeGreen)
                                    output += ((char)Convert.ToInt32(hexString.Substring(3, 2), 16)).ToString();
                                if (decodeBlue)
                                    output += ((char)Convert.ToInt32(hexString.Substring(5, 2), 16)).ToString();
                            }
                        }
                    }
                    output = output.Trim();
                    bmp.Dispose();
                    Form form = new HelpForm("Decoded message", output);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You must drag-drop a *.jpg or a *.png file.");
                }
            }
            else if (ImageHideTabControl.SelectedTab.Equals(ChaseHideTabPage))
            {
                string[] DragDropName = (string[])e.Data.GetData(DataFormats.FileDrop);
                string name = DragDropName[0];
                string ext = name.Substring(int.Parse((name.Length - 4).ToString()), 4);
                if (ext.Equals(".jpg") || ext.Equals(".png"))
                {
                    Bitmap bmp = new Bitmap(name);
                    string output = "";
                    string startColour = ChaseHideFindSignificantPixelColor(bmp);
                    int startX = ChaseHideFindSignificantPixelXY(bmp)[0];
                    int startY = ChaseHideFindSignificantPixelXY(bmp)[1];
                    while (!ChaseHideDecodePixel(bmp, startX, startY, startColour).Item2.Equals(0) &&
                           !ChaseHideDecodePixel(bmp, startX, startY, startColour).Item3.Equals(0))
                    {
                        Tuple<string, int, int> tuple = ChaseHideDecodePixel(bmp, startX, startY, startColour);
                        output += tuple.Item1;
                        startX = tuple.Item2;
                        startY = tuple.Item3;
                    }
                    output = output.Trim();
                    bmp.Dispose();
                    Form form = new HelpForm("Decoded message", output);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You must drag-drop a *.jpg or a *.png file.");
                }
            }
            else if (ImageHideTabControl.SelectedTab.Equals(TextHideTabPage))
            {
                string[] DragDropName = (string[])e.Data.GetData(DataFormats.FileDrop);
                string name = DragDropName[0];
                string ext = name.Substring(int.Parse((name.Length - 4).ToString()), 4);
                if (ext.Equals(".jpg") || ext.Equals(".png"))
                    TextHideImageFileTextBox.Text = name;
                else
                    MessageBox.Show("You must drag-drop a *.jpg or a *.png file.");
            }
            
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // This is where all the encoding happens
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("PixelHideCreateButton"))
            {
                if (PixelHideGetNumOfChecks().Equals(0))
                {
                    MessageBox.Show("You cannot leave all of the RGB values unchecked; then you wouldn't have a message!");
                    return;
                }
                string message = PixelHideMessageTextBox.Text;
                int sideLength = PixelHideCalculateBounds() + 1;
                int numOfChecks = PixelHideGetNumOfChecks();

                Bitmap bmp = new Bitmap(sideLength, sideLength);
                int num = 0;
                bool sigPixelSet = false;
                for (int y = 0; y < sideLength; y++)
                {
                    for (int x = 0; x < sideLength; x++)
                    {
                        string hexColourString = "#";
                        #region Logic for adding RGB values only to the values checked
                        if (!sigPixelSet && num >= message.Length)
                        {
                            hexColourString = PixelHideGenerateSignificantPixelColor();
                            sigPixelSet = true;
                        }
                        else if (sigPixelSet)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                hexColourString += RandomHexValue(new List<string>() { "00", "FF" });
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                string toAdd;
                                try { toAdd = Convert.ToString((int)(message[num].ToString()[0]), 16).ToUpper(); }
                                // ^-- turn the char of <message> into uppercase hexadecimal, store it in <toAdd>
                                catch (IndexOutOfRangeException) { toAdd = "20"; }
                                // ^-- if message has been fully encoded, add a space instead
                                while (toAdd.Length < 2) { toAdd = "0" + toAdd; } // make sure <toAdd> is the right length (pad with 0)
                                if (i.Equals(0) && (PixelHideRedValueCheckBox.Checked)) { hexColourString += toAdd; num++; }
                                else if (i.Equals(1) && (PixelHideGreenValueCheckBox.Checked)) { hexColourString += toAdd; num++; }
                                else if (i.Equals(2) && (PixelHideBlueValueCheckBox.Checked)) { hexColourString += toAdd; num++; }
                                else { hexColourString += RandomHexValue(new List<string>() { "00", "FF" }); }
                            }
                        }
                        #endregion
                        bmp.SetPixel(x, y, ColorTranslator.FromHtml(hexColourString));
                    }
                }
                string filePath = "";
                DialogResult chosenFile = SaveFile.ShowDialog();
                if (chosenFile == DialogResult.OK)
                    filePath = SaveFile.FileName;
                else
                {
                    MessageBox.Show("If you want the hidden message file, you must choose a place to save the file.");
                    bmp.Dispose();
                    return;
                }
                bmp.Save(filePath);
            }
            else if (button.Name.Equals("ChaseHideCreateButton"))
            {
                List<Tuple<int, int>> UsedXY = new List<Tuple<int, int>>();
                string message = ChaseHideMessageTextBox.Text;
                Bitmap bmp = new Bitmap(256, 256);
            }
            else if (button.Name.Equals("TextHideBrowseButton"))
            {
                DialogResult chosenFile = OpenFile.ShowDialog();
                if (chosenFile == DialogResult.OK)
                    TextHideImageFileTextBox.Text = OpenFile.FileName;
                else
                    MessageBox.Show("You must pick a file to add hidden text to it.");
            }
            else if (button.Name.Equals("TextHideAddHiddenTextButton"))
            {
                if (File.Exists(TextHideImageFileTextBox.Text) && TextHideToAddTextBox.Text != "")
                    TextHideMain();
                else
                    MessageBox.Show("You must choose an image file or type some text to be hidden.");
            }
        }

        // UPDATE CHASEHIDE HELP/ABOUT TEXT SENT TO HELPFORM
        private void LinkLabelClicked(object sender, EventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            if (label.Name.Equals("TextHideHelpLabel"))
            {
                string help = "TextHide is a program that hides a message in an image file in the form of text. " +
                    "Essentially, the TextHide program adds text after the encoded pixel values by utilizing some nifty batch commands. " +
                    "Simply select an image to add text to by clicking on the 'Browse' button, or by dragging a *.png or *.jpg file into the window. " +
                    "Following that, type out your message in the larger text box. When you've written all that you want to, click the 'Add Hidden Text' button. " +
                    "Choose what to call and where to save your new image file and then click 'Save'. " +
                    "If you wish to view the message you hid in the image file, simply select the image file in Windows Explorer and " +
                    "right click on it. Select the 'Open With' option, and open the image file with Notepad, or some other simple text editor. " +
                    "Scroll to the bottom of the gibberish and voila! There is your message!";
                Form form = new HelpForm("TextHide Help/About", help);
                form.ShowDialog();
            }
            else if (label.Name.Equals("PixelHideHelpLabel"))
            {
                string help = "PixelHide is a program that hides a message in an image file in the form of pixels. " +
                    "Essentially, the PixelHide program uses the RGB values of each pixel in an image to hold values of the message. " +
                    "The rest of the values in the pixels is randomized. Simply choose a combo of red, green and blue values by checking " +
                    "the checkboxes. Type your message in the large text box, then click the 'Create' button. Select a filename and save " +
                    "your picture. When you want to decode your message, select the file in Windows Explorer and drag/drop it onto the " +
                    "'PixelHide' tab of this program. The message will pop up in a read-only text box.";
                Form form = new HelpForm("PixelHide Help/About", help);
                form.ShowDialog();
            }
            else if (label.Name.Equals("ChaseHideHelpLabel"))
            {

            }
        }
        #endregion
    }
}