using System;
using System.IO;
using System.Windows.Forms;

namespace QWERTY
{
    public partial class FormQwerty : Form
    {
        public FormQwerty()
        {
            InitializeComponent();
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            string line = "";

            string path = Application.StartupPath + @"\qwerty.txt";
            StreamReader streamReader = new StreamReader(path);

            line = streamReader.ReadLine();

            TxtResult.Text = Translate(line);

        }

        private string Translate(string text)
        {
            string dvorak = "`1!234567890[]'<.PYFGCRL?+AOEUIDHTNS-;QJKXBMWVZ";
            string qwerty = "`1!234567890-=QWERTYUIOP[]ASDFGHJKL;'ZXCVBNM<>?";

            string result = "";
            string input;

            for (int i = 0; i < text.Length; i++)
            {
                input = text.Substring(i, 1);

                if (input == " ")
                {
                    result += " ";
                }

                for (int j = 0; j < dvorak.Length; j++)
                {
                    if (input == dvorak[j].ToString())
                    {
                        result += qwerty[j];
                    }
                    else if (input == dvorak[j].ToString().ToLower())
                    {
                        result += qwerty[j].ToString().ToLower();
                    }
                }
            }
            return result;
        }
    }
}
