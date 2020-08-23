using System;
using System.IO;
using System.Windows.Forms;

namespace CVM
{
    public partial class Form1 : Form
    {
        public static string filelocation = "";
        public static string fileoutput = "";
        public static string hex = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Title = "Browse Video Files",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Video (*.mp4)|*.mp4*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            OpenFileDialog openFileDialog2 = openFileDialog1;
            if (openFileDialog2.ShowDialog() != DialogResult.OK)
                return;
            filelocation = openFileDialog2.FileName;
        }

        private void convert_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = filelocation,
                Title = "Browse output location.",
                CheckPathExists = true,
                FileName = "CVMoutput.mp4",
                RestoreDirectory = true,
                Filter = "Video (*.mp4)|*.mp4*"
            };
            SaveFileDialog saveFileDialog2 = saveFileDialog1;
            if (saveFileDialog2.ShowDialog() != DialogResult.OK)
                return;
            fileoutput = saveFileDialog2.FileName;

            if (filelocation.EndsWith(".mp4"))
            {
                byte[] bytes = File.ReadAllBytes(filelocation);
                int num1 = -1;
                foreach (int num2 in bytes)
                {
                    ++num1;
                    if (num2 == 109 & bytes[num1 + 1] == (byte)118 & bytes[num1 + 2] == (byte)104 & bytes[num1 + 3] == (byte)100)
                        break;
                }
                if (this.customduration.Checked)
                {
                    int num2 = Decimal.ToInt32(this.timeHour.Value * 3600M + this.timeMinute.Value * 60M + this.timeSecond.Value) * 1000;
                    bytes[num1 + 16] = (byte)0;
                    bytes[num1 + 17] = (byte)0;
                    bytes[num1 + 18] = (byte)3;
                    bytes[num1 + 19] = (byte)232;
                    bytes[num1 + 20] = (byte)(num2 >> 24);
                    bytes[num1 + 21] = (byte)(num2 >> 16);
                    bytes[num1 + 22] = (byte)(num2 >> 8);
                    bytes[num1 + 23] = (byte)num2;
                    int num3 = (int)MessageBox.Show("Successfully converted the video to the specified time.");
                }
                else if (this.longestpossible.Checked)
                {
                    bytes[num1 + 16] = (byte)0;
                    bytes[num1 + 17] = (byte)0;
                    bytes[num1 + 18] = (byte)0;
                    bytes[num1 + 19] = (byte)1;
                    bytes[num1 + 20] = (byte)127;
                    bytes[num1 + 21] = byte.MaxValue;
                    bytes[num1 + 22] = byte.MaxValue;
                    bytes[num1 + 23] = byte.MaxValue;
                    int num2 = (int)MessageBox.Show("Successfully converted the video to the longest possible time.");
                }
                else if (this.negativetime.Checked)
                {
                    bytes[num1 + 16] = (byte)0;
                    bytes[num1 + 17] = (byte)0;
                    bytes[num1 + 18] = (byte)0;
                    bytes[num1 + 19] = (byte)1;
                    bytes[num1 + 20] = byte.MaxValue;
                    bytes[num1 + 21] = byte.MaxValue;
                    bytes[num1 + 22] = byte.MaxValue;
                    bytes[num1 + 23] = (byte)240;
                    int num2 = (int)MessageBox.Show("Successfully converted the video to a negative time.");
                }
                else
                {
                    int num4 = (int)MessageBox.Show("Please select an option");
                }
                if (fileoutput.EndsWith("mp4"))
                {
                    File.WriteAllBytes(fileoutput, bytes);
                }
                else if (fileoutput.EndsWith("mp4") == false)
                {
                    File.WriteAllBytes(fileoutput + ".mp4", bytes);
                }
            }
            else if (filelocation.Length == 0)
            {
                int num5 = (int)MessageBox.Show("Please select an file input location.");
            }
            else
            {
                if (fileoutput.Length != 0)
                    return;
                int num1 = (int)MessageBox.Show("Please select an file output location.");
            }
        }
    }
}