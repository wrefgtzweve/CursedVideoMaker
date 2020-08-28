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
        public static byte[] bytes;

        public Form1()
        {
            InitializeComponent();
        }

        public static byte[] watermark(byte[] input)
        {
            int pos = -88;
            Array.Resize(ref input, input.Length + 88);
            int[] mark = { 32, 68, 117, 114, 97, 116, 105, 111, 110, 32, 101, 100, 105, 116, 101, 100, 32, 117, 115, 105, 110, 103, 32, 67, 86, 77, 32, 71, 105, 116, 104, 117, 98, 32, 117, 114, 108, 58, 32, 104, 116, 116, 112, 115, 58, 47, 47, 103, 105, 116, 104, 117, 98, 46, 99, 111, 109, 47, 119, 114, 101, 102, 103, 116, 122, 119, 101, 118, 101, 47, 67, 117, 114, 115, 101, 100, 86, 105, 100, 101, 111, 77, 97, 107, 101, 114 };
            foreach (byte bit in mark)
            {
                pos++;
                input[input.Length + pos] = bit;
            };
            return input;
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
                    if (num2 == 109 & bytes[num1 + 1] == 118 & bytes[num1 + 2] == 104 & bytes[num1 + 3] == 100)
                        break;
                }
                if (customduration.Checked)
                {
                    int num2 = Decimal.ToInt32(timeHour.Value * 3600 + timeMinute.Value * 60 + timeSecond.Value) * 1000;
                    bytes[num1 + 16] = 0;
                    bytes[num1 + 17] = 0;
                    bytes[num1 + 18] = 3;
                    bytes[num1 + 19] = 232;
                    bytes[num1 + 20] = (byte)(num2 >> 24);
                    bytes[num1 + 21] = (byte)(num2 >> 16);
                    bytes[num1 + 22] = (byte)(num2 >> 8);
                    bytes[num1 + 23] = (byte)num2;
                    bytes = watermark(bytes);
                    MessageBox.Show("Successfully converted the video to the specified time.");
                }
                else if (longestpossible.Checked)
                {
                    bytes[num1 + 16] = 0;
                    bytes[num1 + 17] = 0;
                    bytes[num1 + 18] = 0;
                    bytes[num1 + 19] = 1;
                    bytes[num1 + 20] = 127;
                    bytes[num1 + 21] = byte.MaxValue;
                    bytes[num1 + 22] = byte.MaxValue;
                    bytes[num1 + 23] = byte.MaxValue;
                    bytes = watermark(bytes);
                    MessageBox.Show("Successfully converted the video to the longest possible time.");
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
                    bytes = watermark(bytes);
                    MessageBox.Show("Successfully converted the video to a negative time.");
                }
                else
                {
                    MessageBox.Show("Please select an option");
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
                MessageBox.Show("Please select an file input location.");
            }
            else
            {
                if (fileoutput.Length != 0)
                    return;
                MessageBox.Show("Please select an file output location.");
            }
        }
    }
}