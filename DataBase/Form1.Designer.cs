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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForSearch = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.panelSearchRecord = new System.Windows.Forms.Panel();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxFAQ = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSearchRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.artist,
            this.song,
            this.year,
            this.genre});
            this.dataGridViewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(565, 238);
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
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(441, 87);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 38);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Удалить всё";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearRow
            // 
            this.btnClearRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnClearRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRow.FlatAppearance.BorderSize = 0;
            this.btnClearRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRow.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRow.ForeColor = System.Drawing.Color.White;
            this.btnClearRow.Location = new System.Drawing.Point(441, 134);
            this.btnClearRow.Name = "btnClearRow";
            this.btnClearRow.Size = new System.Drawing.Size(136, 46);
            this.btnClearRow.TabIndex = 10;
            this.btnClearRow.Text = "Удалить выделенное";
            this.btnClearRow.UseVisualStyleBackColor = false;
            this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(43, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxForSearch
            // 
            this.textBoxForSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForSearch.Location = new System.Drawing.Point(43, 35);
            this.textBoxForSearch.Name = "textBoxForSearch";
            this.textBoxForSearch.Size = new System.Drawing.Size(140, 22);
            this.textBoxForSearch.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecord.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddRecord.Location = new System.Drawing.Point(244, 134);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(191, 46);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(335, 103);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre.TabIndex = 7;
            // 
            // textBoxSong
            // 
            this.textBoxSong.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSong.Location = new System.Drawing.Point(130, 129);
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.Size = new System.Drawing.Size(100, 22);
            this.textBoxSong.TabIndex = 4;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArtist.Location = new System.Drawing.Point(130, 103);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.textBoxArtist.TabIndex = 0;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenre.Location = new System.Drawing.Point(240, 103);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(90, 20);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Жанр песни:";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArtist.Location = new System.Drawing.Point(15, 106);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(98, 20);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "Исполнитель:";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSong.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSong.Location = new System.Drawing.Point(15, 132);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(116, 20);
            this.labelSong.TabIndex = 2;
            this.labelSong.Text = "Название песни:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(130, 158);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear.TabIndex = 5;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.SystemColors.Control;
            this.labelYear.Location = new System.Drawing.Point(15, 159);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(97, 20);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Год выпуска:";
            // 
            // panelSearchRecord
            // 
            this.panelSearchRecord.Controls.Add(this.btnSearch);
            this.panelSearchRecord.Controls.Add(this.label1);
            this.panelSearchRecord.Controls.Add(this.textBoxForSearch);
            this.panelSearchRecord.Location = new System.Drawing.Point(158, 85);
            this.panelSearchRecord.Name = "panelSearchRecord";
            this.panelSearchRecord.Size = new System.Drawing.Size(219, 95);
            this.panelSearchRecord.TabIndex = 16;
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpen.Image")));
            this.pictureBoxOpen.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(46, 40);
            this.pictureBoxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpen.TabIndex = 17;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.Click += new System.EventHandler(this.pictureBoxOpen_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(85, 41);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(46, 40);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 18;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(158, 41);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(46, 40);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 19;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // pictureBoxFAQ
            // 
            this.pictureBoxFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFAQ.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFAQ.Image")));
            this.pictureBoxFAQ.Location = new System.Drawing.Point(305, 41);
            this.pictureBoxFAQ.Name = "pictureBoxFAQ";
            this.pictureBoxFAQ.Size = new System.Drawing.Size(46, 40);
            this.pictureBoxFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFAQ.TabIndex = 20;
            this.pictureBoxFAQ.TabStop = false;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(229, 41);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(46, 40);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 21;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSave.Location = new System.Drawing.Point(480, 33);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(97, 20);
            this.labelSave.TabIndex = 22;
            this.labelSave.Text = "Сохранение...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(589, 430);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.pictureBoxFAQ);
            this.Controls.Add(this.textBoxSong);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.panelSearchRecord);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.btnClearRow);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(795, 469);
            this.MinimumSize = new System.Drawing.Size(395, 469);
            this.Name = "Form1";
            this.Text = "База данных музыки";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSearchRecord.ResumeLayout(false);
            this.panelSearchRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Panel panelSearchRecord;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxFAQ;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Timer timer1;
    }
}

