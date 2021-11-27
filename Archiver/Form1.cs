using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unzip_archive_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы должны выбрать оба поля!!!", "Сообщение");
            }
            else
            {
                Archiver.DeCompress(textBox1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                flag = true;
            }

            if (flag == true)
            {
                MessageBox.Show("Файл успешно разархивирован", "Сообщение");
            }
        }

        private void archive_files_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Вы должны выбрать оба поля!!!", "Сообщение");
            }
            else
            {
                Archiver.Compress(textBox4.Text, textBox3.Text);
                textBox3.Text = "";
                textBox4.Text = "";
                flag = true;
            }

            if (flag == true)
            {
                MessageBox.Show("Файл успешно архивирован", "Сообщение");
            }
        }

        private void add_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void select_archive_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.arc)|*.arc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            openFileDialog1.Filter = null;
        }

        private void select_folder_unzipped_files_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void select_folder_for_archive_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
