using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordVader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList words = new ArrayList();
        string temp_word;
        string first_letter;
        string last_letter;
        string mid_letter;
        string shuffled_mid;
        private void txtgiris_TextChanged(object sender, EventArgs e)
        {
            if (txtgiris.Text != "") btnok.Enabled = true;
            else btnok.Enabled = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            txtcikis.Text = "";
            words.Clear();
            
            txtgiris.Text += " ";
            Method(txtgiris.Text);

        }

        void Method(string txt)
        {
            foreach(char letter in txt)
            {
                if (letter.ToString() != " " && letter.ToString() != "." && letter.ToString() != ",")
                {
                    temp_word += letter.ToString();
                }
                else
                {
                    if(temp_word != "") words.Add(temp_word);
                    temp_word = "";
                }
            }
            
            foreach(string word in words)
            {
                int word_length = word.Length;
                if (word_length < 4) txtcikis.Text += word + " ";
                else
                {
                    first_letter = word.Substring(0, 1);
                    last_letter = word.Substring(word.Length - 1);
                    mid_letter = word.Substring(1, word.Length - 2);
                    int mid_lenght = mid_letter.Length;
                    Random random = new Random();
                    int random_index = 0;
                    for (int i = 0; i < mid_lenght; i++)
                    {
                        random_index = random.Next(0, mid_letter.Length);
                        shuffled_mid += mid_letter[random_index];
                        mid_letter = mid_letter.Remove(random_index,1);
                    }
                    string new_word = first_letter + shuffled_mid + last_letter;
                    txtcikis.Text += new_word + " ";
                    shuffled_mid = "";
                }
            }

        }
    }
}
