namespace Archiver
{
    partial class ArchiverApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.File_to_archive = new System.Windows.Forms.TextBox();
            this.Select_folder_for_archive = new System.Windows.Forms.Button();
            this.Archive_folder = new System.Windows.Forms.TextBox();
            this.Label_archive_folder = new System.Windows.Forms.Label();
            this.Label_file_to_archive = new System.Windows.Forms.Label();
            this.Add_file = new System.Windows.Forms.Button();
            this.Archive_files = new System.Windows.Forms.Button();
            this.Select_folder_unzipped_files = new System.Windows.Forms.Button();
            this.Select_archive = new System.Windows.Forms.Button();
            this.Label_folder_for_unzip_file = new System.Windows.Forms.Label();
            this.Label_archive = new System.Windows.Forms.Label();
            this.Folder_for_unzip_file = new System.Windows.Forms.TextBox();
            this.Archive = new System.Windows.Forms.TextBox();
            this.Unzip_archive = new System.Windows.Forms.Button();
            this.folder_selection_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.file_selection_dialog = new System.Windows.Forms.OpenFileDialog();
            this.Label_unzip_the_file = new System.Windows.Forms.Label();
            this.Label_file_archiving = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // File_to_archive
            // 
            this.File_to_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_to_archive.Location = new System.Drawing.Point(31, 94);
            this.File_to_archive.Name = "File_to_archive";
            this.File_to_archive.ReadOnly = true;
            this.File_to_archive.Size = new System.Drawing.Size(548, 29);
            this.File_to_archive.TabIndex = 11;
            // 
            // Select_folder_for_archive
            // 
            this.Select_folder_for_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_folder_for_archive.Location = new System.Drawing.Point(608, 162);
            this.Select_folder_for_archive.Name = "Select_folder_for_archive";
            this.Select_folder_for_archive.Size = new System.Drawing.Size(243, 30);
            this.Select_folder_for_archive.TabIndex = 10;
            this.Select_folder_for_archive.Text = "Выбрать папку для архива";
            this.Select_folder_for_archive.UseVisualStyleBackColor = true;
            this.Select_folder_for_archive.Click += new System.EventHandler(this.Select_folder_for_archive_Click);
            // 
            // Archive_folder
            // 
            this.Archive_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archive_folder.Location = new System.Drawing.Point(31, 162);
            this.Archive_folder.Name = "Archive_folder";
            this.Archive_folder.ReadOnly = true;
            this.Archive_folder.Size = new System.Drawing.Size(548, 30);
            this.Archive_folder.TabIndex = 9;
            // 
            // Label_archive_folder
            // 
            this.Label_archive_folder.AutoSize = true;
            this.Label_archive_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_archive_folder.Location = new System.Drawing.Point(26, 134);
            this.Label_archive_folder.Name = "Label_archive_folder";
            this.Label_archive_folder.Size = new System.Drawing.Size(174, 25);
            this.Label_archive_folder.TabIndex = 8;
            this.Label_archive_folder.Text = "Папка для архива";
            // 
            // Label_file_to_archive
            // 
            this.Label_file_to_archive.AutoSize = true;
            this.Label_file_to_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_file_to_archive.Location = new System.Drawing.Point(26, 66);
            this.Label_file_to_archive.Name = "Label_file_to_archive";
            this.Label_file_to_archive.Size = new System.Drawing.Size(247, 25);
            this.Label_file_to_archive.TabIndex = 7;
            this.Label_file_to_archive.Text = "Файл для архивирования";
            // 
            // Add_file
            // 
            this.Add_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_file.Location = new System.Drawing.Point(608, 94);
            this.Add_file.Name = "Add_file";
            this.Add_file.Size = new System.Drawing.Size(243, 29);
            this.Add_file.TabIndex = 3;
            this.Add_file.Text = "Добавить файл";
            this.Add_file.UseVisualStyleBackColor = true;
            this.Add_file.Click += new System.EventHandler(this.Add_file_Click);
            // 
            // Archive_files
            // 
            this.Archive_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archive_files.Location = new System.Drawing.Point(299, 210);
            this.Archive_files.Name = "Archive_files";
            this.Archive_files.Size = new System.Drawing.Size(280, 45);
            this.Archive_files.TabIndex = 0;
            this.Archive_files.Text = "Архивировать файл";
            this.Archive_files.UseVisualStyleBackColor = true;
            this.Archive_files.Click += new System.EventHandler(this.Archive_files_Click);
            // 
            // Select_folder_unzipped_files
            // 
            this.Select_folder_unzipped_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_folder_unzipped_files.Location = new System.Drawing.Point(608, 451);
            this.Select_folder_unzipped_files.Name = "Select_folder_unzipped_files";
            this.Select_folder_unzipped_files.Size = new System.Drawing.Size(243, 30);
            this.Select_folder_unzipped_files.TabIndex = 6;
            this.Select_folder_unzipped_files.Text = "Выбрать папку для файла";
            this.Select_folder_unzipped_files.UseVisualStyleBackColor = true;
            this.Select_folder_unzipped_files.Click += new System.EventHandler(this.Select_folder_unzipped_files_Click);
            // 
            // Select_archive
            // 
            this.Select_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_archive.Location = new System.Drawing.Point(608, 383);
            this.Select_archive.Name = "Select_archive";
            this.Select_archive.Size = new System.Drawing.Size(243, 30);
            this.Select_archive.TabIndex = 5;
            this.Select_archive.Text = "Выбрать архив";
            this.Select_archive.UseVisualStyleBackColor = true;
            this.Select_archive.Click += new System.EventHandler(this.Select_archive_Click);
            // 
            // Label_folder_for_unzip_file
            // 
            this.Label_folder_for_unzip_file.AutoSize = true;
            this.Label_folder_for_unzip_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_folder_for_unzip_file.Location = new System.Drawing.Point(26, 423);
            this.Label_folder_for_unzip_file.Name = "Label_folder_for_unzip_file";
            this.Label_folder_for_unzip_file.Size = new System.Drawing.Size(368, 25);
            this.Label_folder_for_unzip_file.TabIndex = 4;
            this.Label_folder_for_unzip_file.Text = "Папка для разархивированного файла";
            // 
            // Label_archive
            // 
            this.Label_archive.AutoSize = true;
            this.Label_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_archive.Location = new System.Drawing.Point(26, 355);
            this.Label_archive.Name = "Label_archive";
            this.Label_archive.Size = new System.Drawing.Size(67, 25);
            this.Label_archive.TabIndex = 3;
            this.Label_archive.Text = "Архив";
            // 
            // Folder_for_unzip_file
            // 
            this.Folder_for_unzip_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Folder_for_unzip_file.Location = new System.Drawing.Point(31, 451);
            this.Folder_for_unzip_file.Name = "Folder_for_unzip_file";
            this.Folder_for_unzip_file.ReadOnly = true;
            this.Folder_for_unzip_file.Size = new System.Drawing.Size(548, 30);
            this.Folder_for_unzip_file.TabIndex = 2;
            // 
            // Archive
            // 
            this.Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archive.Location = new System.Drawing.Point(31, 383);
            this.Archive.Name = "Archive";
            this.Archive.ReadOnly = true;
            this.Archive.Size = new System.Drawing.Size(548, 30);
            this.Archive.TabIndex = 1;
            // 
            // Unzip_archive
            // 
            this.Unzip_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unzip_archive.Location = new System.Drawing.Point(299, 499);
            this.Unzip_archive.Name = "Unzip_archive";
            this.Unzip_archive.Size = new System.Drawing.Size(280, 45);
            this.Unzip_archive.TabIndex = 0;
            this.Unzip_archive.Text = "Разархивировать архив";
            this.Unzip_archive.UseVisualStyleBackColor = true;
            this.Unzip_archive.Click += new System.EventHandler(this.Unzip_archive_Click);
            // 
            // file_selection_dialog
            // 
            this.file_selection_dialog.FileName = "файл";
            // 
            // Label_unzip_the_file
            // 
            this.Label_unzip_the_file.AutoSize = true;
            this.Label_unzip_the_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_unzip_the_file.Location = new System.Drawing.Point(252, 298);
            this.Label_unzip_the_file.Name = "Label_unzip_the_file";
            this.Label_unzip_the_file.Size = new System.Drawing.Size(384, 37);
            this.Label_unzip_the_file.TabIndex = 12;
            this.Label_unzip_the_file.Text = "Разархивирование файла";
            // 
            // Label_file_archiving
            // 
            this.Label_file_archiving.AutoSize = true;
            this.Label_file_archiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_file_archiving.Location = new System.Drawing.Point(281, 9);
            this.Label_file_archiving.Name = "Label_file_archiving";
            this.Label_file_archiving.Size = new System.Drawing.Size(334, 37);
            this.Label_file_archiving.TabIndex = 13;
            this.Label_file_archiving.Text = "Архивирование файла";
            // 
            // ArchiverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 576);
            this.Controls.Add(this.Label_file_archiving);
            this.Controls.Add(this.Label_unzip_the_file);
            this.Controls.Add(this.Label_archive_folder);
            this.Controls.Add(this.File_to_archive);
            this.Controls.Add(this.Label_file_to_archive);
            this.Controls.Add(this.Label_archive);
            this.Controls.Add(this.Archive_folder);
            this.Controls.Add(this.Select_folder_for_archive);
            this.Controls.Add(this.Label_folder_for_unzip_file);
            this.Controls.Add(this.Select_archive);
            this.Controls.Add(this.Add_file);
            this.Controls.Add(this.Select_folder_unzipped_files);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.Archive_files);
            this.Controls.Add(this.Unzip_archive);
            this.Controls.Add(this.Folder_for_unzip_file);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 615);
            this.MinimumSize = new System.Drawing.Size(910, 615);
            this.Name = "ArchiverApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Archive_files;
        private System.Windows.Forms.Button Unzip_archive;
        private System.Windows.Forms.Button Add_file;
        private System.Windows.Forms.Label Label_archive;
        private System.Windows.Forms.TextBox Folder_for_unzip_file;
        private System.Windows.Forms.TextBox Archive;
        private System.Windows.Forms.Button Select_folder_unzipped_files;
        private System.Windows.Forms.Button Select_archive;
        private System.Windows.Forms.Label Label_folder_for_unzip_file;
        private System.Windows.Forms.FolderBrowserDialog folder_selection_dialog;
        private System.Windows.Forms.OpenFileDialog file_selection_dialog;
        private System.Windows.Forms.Button Select_folder_for_archive;
        private System.Windows.Forms.TextBox Archive_folder;
        private System.Windows.Forms.Label Label_archive_folder;
        private System.Windows.Forms.Label Label_file_to_archive;
        private System.Windows.Forms.TextBox File_to_archive;
        private System.Windows.Forms.Label Label_unzip_the_file;
        private System.Windows.Forms.Label Label_file_archiving;
    }
}