using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBase
{
    public partial class Form1 : Form
    {
        DataWork data = new DataWork();
        string oldValue = "";
        string filename = "";
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            dataGridViewTable.Rows[0].ReadOnly = true;
            dataGridViewTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            panelSearchRecord.Visible = false;
            labelSave.Visible = false;
            timer.Interval = 5000;
            pictureBoxAdd.Size = new Size(56, 48);
        }

        // Генерация не повторяющихся id
        public ushort generateID()
        {
            Random r = new Random();
            int id = r.Next(0, 1000);
            for (int i = 0; i < data.MusicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)data.MusicFiles[i];
                if (music.SongID == id)
                {
                    i = 0;
                    id = r.Next(0, 1000);
                }
            }
            return (ushort)id;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string artist = textBoxArtist.Text;
                string song = textBoxSong.Text;
                ushort year = (ushort)Convert.ToInt32(textBoxYear.Text);
                string genre = textBoxGenre.Text;
                textBoxArtist.Text = "";
                textBoxSong.Text = "";
                textBoxYear.Text = "";
                textBoxGenre.Text = "";
                data.AddMusicFile(generateID(), artist, song, year, genre);
                int n = data.MusicFiles.Count;
                MusicFile music = (MusicFile)data.MusicFiles[n - 1];
                dataGridViewTable.Rows.Add(music.SongID, artist, song, year, genre);
                BanChangeColumn(n - 1);
            } catch
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        // Запретить редактировать столбец по указанному индексу
        private void BanChangeColumn(int index) =>
            dataGridViewTable.Rows[index].Cells[0].ReadOnly = true;

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (data.MusicFiles.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите удалить все элементы?", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    data.DeleteMusic();
                    dataGridViewTable.Rows.Clear();
                }
            }
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            int count = dataGridViewTable.Rows.Count;
            foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
            {
                int index = row.Index; // индекс выбранной строки
                if (index == count - 1) return;
                data.DeleteMusicFile(index);
                dataGridViewTable.Rows.RemoveAt(index);
            }
        }

        private void dataGridViewTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indRow = dataGridViewTable.Rows[e.RowIndex].Index;
            int indColumn = dataGridViewTable.Columns[e.ColumnIndex].Index;
            object value = dataGridViewTable.Rows[indRow].Cells[indColumn].Value;
            // Если значение не было введено, то оставляем старое
            if (value is null)
            {
                MessageBox.Show("Вы не ввели значение.");
                dataGridViewTable.Rows[indRow].Cells[indColumn].Value = oldValue;
                return;
            }
            if (indColumn == 1)
            {
                data.ChangeArtistName((string)value, indRow);
            } 
            else
            if (indColumn == 2)
            {
                data.ChangeSongTittle((string)value, indRow);
            }
            else
            if (indColumn == 3)
            {
                data.ChangeYearRelease((ushort)Convert.ToInt32(value), indRow);
            }
            else
            if (indColumn == 4)
            {
                data.ChangeGenreSong((string)value, indRow);
            }
        }
        
        private void dataGridViewTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                oldValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        // Сохранение данных в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
                this.Text = filename + " - База данных музыки";
            }
            timer.Start();
            data.SaveToFile(filename);
        }

        // Восстановление данных из файла в таблицу и в список
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            this.Text = filename + " - База данных музыки";
            dataGridViewTable.Rows.Clear();
            data.OpenFile(filename);
            for (int i = 0; i < data.MusicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)data.MusicFiles[i];
                dataGridViewTable.Rows.Add(music.SongID, music.ArtistName, 
                    music.SongTitle, music.YearRelease, music.SongGenre);
                BanChangeColumn(i);
            }
            // последнюю строку запрещаем редактировать
            dataGridViewTable.Rows[data.MusicFiles.Count].ReadOnly = true;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((data.MusicFiles.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите создать новый файл?" + "\r\n" +
                    "Изменения в текущем не сохранятся!", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных музыки";
                    filename = "";
                    data.DeleteMusic();
                    dataGridViewTable.Rows.Clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((data.MusicFiles.Count == 0) || (textBoxForSearch.Text == ""))
                return;
            dataGridViewTable.ClearSelection();
            List<int> foundElements = data.SearchMusicFile(textBoxForSearch.Text);
            if (foundElements[0] == -1)
            {
                MessageBox.Show("Ничего не удалось найти!");
                return;
            }
            dataGridViewTable.CurrentCell = dataGridViewTable[0, foundElements[0]];
            for (int i = 0; i < foundElements.Count; i++)
            {
                dataGridViewTable.Rows[foundElements[i]].Selected = true;
            }
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            labelArtist.Visible = false;
            labelSong.Visible = false;
            labelGenre.Visible = false;
            labelYear.Visible = false;
            textBoxArtist.Visible = false;
            textBoxSong.Visible = false;
            textBoxGenre.Visible = false;
            textBoxYear.Visible = false;
            btnAddRecord.Visible = false;
            panelSearchRecord.Visible = true;
            pictureBoxAdd.Size = new Size(46, 40);
            pictureBoxSearch.Size = new Size(56, 48);
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            labelArtist.Visible = true;
            labelSong.Visible = true;
            labelGenre.Visible = true;
            labelYear.Visible = true;
            textBoxArtist.Visible = true;
            textBoxSong.Visible = true;
            textBoxGenre.Visible = true;
            textBoxYear.Visible = true;
            btnAddRecord.Visible = true;
            panelSearchRecord.Visible = false;
            pictureBoxAdd.Size = new Size(56, 48);
            pictureBoxSearch.Size = new Size(46, 40);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.S))
            {
                сохранитьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
            }
            else if ((e.Control) && (e.KeyCode == Keys.O))
            {
                открытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
            }
            else if ((e.Control) && (e.KeyCode == Keys.N))
            {
                создатьToolStripMenuItem_Click(создатьToolStripMenuItem, null);
            }
        }
    }
}