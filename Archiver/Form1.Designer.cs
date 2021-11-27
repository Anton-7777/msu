
namespace Archiver
{
    partial class Form1
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.select_folder_for_archive = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_file = new System.Windows.Forms.Button();
            this.archive_files = new System.Windows.Forms.Button();
            this.select_folder_unzipped_files = new System.Windows.Forms.Button();
            this.select_archive = new System.Windows.Forms.Button();
            this.label_folder_for_unzip_files = new System.Windows.Forms.Label();
            this.label_archive = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unzip_archive = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(31, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(548, 29);
            this.textBox4.TabIndex = 11;
            // 
            // select_folder_for_archive
            // 
            this.select_folder_for_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_folder_for_archive.Location = new System.Drawing.Point(608, 162);
            this.select_folder_for_archive.Name = "select_folder_for_archive";
            this.select_folder_for_archive.Size = new System.Drawing.Size(243, 30);
            this.select_folder_for_archive.TabIndex = 10;
            this.select_folder_for_archive.Text = "Выбрать папку";
            this.select_folder_for_archive.UseVisualStyleBackColor = true;
            this.select_folder_for_archive.Click += new System.EventHandler(this.select_folder_for_archive_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(31, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(548, 30);
            this.textBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Папка для архива";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Файлы для архивирования";
            // 
            // add_file
            // 
            this.add_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_file.Location = new System.Drawing.Point(608, 94);
            this.add_file.Name = "add_file";
            this.add_file.Size = new System.Drawing.Size(243, 29);
            this.add_file.TabIndex = 3;
            this.add_file.Text = "Добавить файл";
            this.add_file.UseVisualStyleBackColor = true;
            this.add_file.Click += new System.EventHandler(this.add_file_Click);
            // 
            // archive_files
            // 
            this.archive_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archive_files.Location = new System.Drawing.Point(299, 210);
            this.archive_files.Name = "archive_files";
            this.archive_files.Size = new System.Drawing.Size(280, 45);
            this.archive_files.TabIndex = 0;
            this.archive_files.Text = "Архивировать файл";
            this.archive_files.UseVisualStyleBackColor = true;
            this.archive_files.Click += new System.EventHandler(this.archive_files_Click);
            // 
            // select_folder_unzipped_files
            // 
            this.select_folder_unzipped_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_folder_unzipped_files.Location = new System.Drawing.Point(608, 451);
            this.select_folder_unzipped_files.Name = "select_folder_unzipped_files";
            this.select_folder_unzipped_files.Size = new System.Drawing.Size(243, 30);
            this.select_folder_unzipped_files.TabIndex = 6;
            this.select_folder_unzipped_files.Text = "Выбрать папку";
            this.select_folder_unzipped_files.UseVisualStyleBackColor = true;
            this.select_folder_unzipped_files.Click += new System.EventHandler(this.select_folder_unzipped_files_Click);
            // 
            // select_archive
            // 
            this.select_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_archive.Location = new System.Drawing.Point(608, 383);
            this.select_archive.Name = "select_archive";
            this.select_archive.Size = new System.Drawing.Size(243, 30);
            this.select_archive.TabIndex = 5;
            this.select_archive.Text = "Выбрать архив";
            this.select_archive.UseVisualStyleBackColor = true;
            this.select_archive.Click += new System.EventHandler(this.select_archive_Click);
            // 
            // label_folder_for_unzip_files
            // 
            this.label_folder_for_unzip_files.AutoSize = true;
            this.label_folder_for_unzip_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_folder_for_unzip_files.Location = new System.Drawing.Point(26, 423);
            this.label_folder_for_unzip_files.Name = "label_folder_for_unzip_files";
            this.label_folder_for_unzip_files.Size = new System.Drawing.Size(373, 25);
            this.label_folder_for_unzip_files.TabIndex = 4;
            this.label_folder_for_unzip_files.Text = "Папка для разархивированных файлов";
            // 
            // label_archive
            // 
            this.label_archive.AutoSize = true;
            this.label_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_archive.Location = new System.Drawing.Point(26, 355);
            this.label_archive.Name = "label_archive";
            this.label_archive.Size = new System.Drawing.Size(67, 25);
            this.label_archive.TabIndex = 3;
            this.label_archive.Text = "Архив";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(31, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(548, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(31, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(548, 30);
            this.textBox1.TabIndex = 1;
            // 
            // unzip_archive
            // 
            this.unzip_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unzip_archive.Location = new System.Drawing.Point(299, 499);
            this.unzip_archive.Name = "unzip_archive";
            this.unzip_archive.Size = new System.Drawing.Size(280, 45);
            this.unzip_archive.TabIndex = 0;
            this.unzip_archive.Text = "Разархивировать архив";
            this.unzip_archive.UseVisualStyleBackColor = true;
            this.unzip_archive.Click += new System.EventHandler(this.unzip_archive_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(252, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Разархивирование файла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(281, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Архивирование файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 576);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_archive);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.select_folder_for_archive);
            this.Controls.Add(this.label_folder_for_unzip_files);
            this.Controls.Add(this.select_archive);
            this.Controls.Add(this.add_file);
            this.Controls.Add(this.select_folder_unzipped_files);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.archive_files);
            this.Controls.Add(this.unzip_archive);
            this.Controls.Add(this.textBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 615);
            this.MinimumSize = new System.Drawing.Size(910, 615);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button archive_files;
        private System.Windows.Forms.Button unzip_archive;
        private System.Windows.Forms.Button add_file;
        private System.Windows.Forms.Label label_archive;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button select_folder_unzipped_files;
        private System.Windows.Forms.Button select_archive;
        private System.Windows.Forms.Label label_folder_for_unzip_files;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button select_folder_for_archive;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

