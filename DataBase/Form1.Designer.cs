namespace DataBase
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
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.artist,
            this.song,
            this.year,
            this.genre});
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(544, 238);
            this.dataGridViewTable.TabIndex = 0;
            this.dataGridViewTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewTable_CellBeginEdit);
            this.dataGridViewTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // artist
            // 
            this.artist.HeaderText = "Исполнитель";
            this.artist.Name = "artist";
            // 
            // song
            // 
            this.song.HeaderText = "Композиция";
            this.song.Name = "song";
            // 
            // year
            // 
            this.year.HeaderText = "Год выпуска";
            this.year.Name = "year";
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRecord);
            this.groupBox1.Controls.Add(this.textBoxGenre);
            this.groupBox1.Controls.Add(this.labelGenre);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.textBoxSong);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.labelSong);
            this.groupBox1.Controls.Add(this.labelArtist);
            this.groupBox1.Controls.Add(this.textBoxArtist);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая запись:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecord.Location = new System.Drawing.Point(235, 52);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(191, 46);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(326, 26);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.Location = new System.Drawing.Point(232, 29);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(75, 16);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Жанр песни:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(116, 76);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear.TabIndex = 5;
            // 
            // textBoxSong
            // 
            this.textBoxSong.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSong.Location = new System.Drawing.Point(116, 52);
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.Size = new System.Drawing.Size(100, 22);
            this.textBoxSong.TabIndex = 4;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(6, 82);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(81, 16);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Год выпуска:";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSong.Location = new System.Drawing.Point(6, 55);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(97, 16);
            this.labelSong.TabIndex = 2;
            this.labelSong.Text = "Название песни:";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArtist.Location = new System.Drawing.Point(6, 29);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(84, 16);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "Исполнитель:";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArtist.Location = new System.Drawing.Point(116, 26);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.textBoxArtist.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAll.Location = new System.Drawing.Point(562, 188);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 48);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Удалить всё";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearRow
            // 
            this.btnClearRow.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRow.Location = new System.Drawing.Point(562, 242);
            this.btnClearRow.Name = "btnClearRow";
            this.btnClearRow.Size = new System.Drawing.Size(112, 46);
            this.btnClearRow.TabIndex = 10;
            this.btnClearRow.Text = "Удалить выделенное";
            this.btnClearRow.UseVisualStyleBackColor = true;
            this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 430);
            this.Controls.Add(this.btnClearRow);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(695, 469);
            this.MinimumSize = new System.Drawing.Size(695, 469);
            this.Name = "Form1";
            this.Text = "База данных музыки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn song;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

