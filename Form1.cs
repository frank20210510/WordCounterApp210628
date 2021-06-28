using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounterApp
{
    public partial class Form1 : Form
    {

        //OK=========================================================================================================
        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //OK=========================================================================================================


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private void btn_createWordList_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            String[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            foreach (String word in wordsArray)
            {
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }
        }





        private void btn_sortWordList_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }




        private void btn_countWords_Click(object sender, EventArgs e)
        {
            String allWords = textBox1.Text;
            String[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            //change the array into a list. A list has more features than an array.

            List<WordCounter> wordCounters = new List<WordCounter>();


            foreach (string w in wordsArray)
            {
                WordCounter foundWord = wordCounters.Find(x => x.word == w);
                if (foundWord == null)
                {
                    wordCounters.Add(new WordCounter(w, 1));
                }
                else
                {
                    foundWord.frequency++;
                }


            }


            listView1.Columns.Add("Word", 100);
            listView1.Columns.Add("Frequency", 70);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //listView1.Sorting = SortOrder.Descending;

            foreach (WordCounter word in wordCounters)
            {
                String[] rowItem = new string[] { word.word, word.frequency.ToString() };
                listView1.Items.Add(new ListViewItem(rowItem));
            }

        }
    }
}
