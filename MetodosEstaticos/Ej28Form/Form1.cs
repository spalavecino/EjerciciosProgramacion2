using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Ej28Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string textEntered = txtRTB.Text.Trim();
            string[] words = textEntered.Replace("\n", " ").Replace("  ", " ").Split();
            Dictionary<string, int> distinctWords = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if(distinctWords.ContainsKey(word.ToLower()))
                {
                    distinctWords[word.ToLower()] += 1;
                }
                else
                {
                    distinctWords.Add(word.ToLower(), 1);
                }
            }

            distinctWords = distinctWords.OrderByDescending(word => word.Value).ToDictionary(word => word.Key, word => word.Value);
            Dictionary<string, int> topThreeWords = distinctWords.Take(3).ToDictionary(count => count.Key, count => count.Value);

            StringBuilder str = new StringBuilder();

            foreach (KeyValuePair<string, int> word in distinctWords)
            {
                str.AppendFormat("{0}  -   {1}\n", word.Key, word.Value);
            }

            txtRTB.Text = str.ToString();

            str.Clear();
            str.Append("Las palabras mas escritas fueron: \n\n");

            foreach (KeyValuePair<string, int> word in topThreeWords)
            {
                str.AppendFormat("{0}  -   {1}\n", word.Key, word.Value);
            }

            MessageBox.Show(str.ToString());
        }
    }
}
