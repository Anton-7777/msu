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
    public partial class ArchiverApp : Form
    {
        public ArchiverApp()
        {
            InitializeComponent();
        }

        private void Unzip_archive_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (Archive.Text == "" || Folder_for_unzip_file.Text == "") {
                MessageBox.Show("Вы должны выбрать оба поля!!!", "Сообщение");
            }
            else {
                Archiver.DeCompress(Archive.Text, Folder_for_unzip_file.Text);
                Archive.Text = "";
                Folder_for_unzip_file.Text = "";
                flag = true;
            }

            if (flag == true) {
                MessageBox.Show("Файл успешно разархивирован", "Сообщение");
            }
        }

        private void Archive_files_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (Archive_folder.Text == "" || File_to_archive.Text == "") {
                MessageBox.Show("Вы должны выбрать оба поля!!!", "Сообщение");
            }
            else {
                Archiver.Compress(File_to_archive.Text, Archive_folder.Text);
                Archive_folder.Text = "";
                File_to_archive.Text = "";
                flag = true;
            }

            if (flag == true) {
                MessageBox.Show("Файл успешно архивирован", "Сообщение");
            }
        }

        private void Add_file_Click(object sender, EventArgs e)
        {
            if (file_selection_dialog.ShowDialog() == DialogResult.OK) {
                File_to_archive.Text = file_selection_dialog.FileName;
            }
        }

        private void Select_archive_Click(object sender, EventArgs e)
        {
            file_selection_dialog.Filter = "txt files (*.arc)|*.arc";

            if (file_selection_dialog.ShowDialog() == DialogResult.OK) {
                Archive.Text = file_selection_dialog.FileName;
            }

            file_selection_dialog.Filter = null;
        }

        private void Select_folder_unzipped_files_Click(object sender, EventArgs e)
        {
            if (folder_selection_dialog.ShowDialog() == DialogResult.OK) {
                Folder_for_unzip_file.Text = folder_selection_dialog.SelectedPath;
            }
        }

        private void Select_folder_for_archive_Click(object sender, EventArgs e)
        {
            if (folder_selection_dialog.ShowDialog() == DialogResult.OK) {
                Archive_folder.Text = folder_selection_dialog.SelectedPath;
            }
        }
    }
}
