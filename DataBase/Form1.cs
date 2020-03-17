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
        public Form1()
        {
            InitializeComponent();
            dataGridViewTable.Rows[0].ReadOnly = true;
            dataGridViewTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            ForYearAndId.Visible = false;
            comboBoxParameters.Text = comboBoxParameters.Items[0].ToString();
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
            if (data.MusicFiles.Count == 0)
                return;
            dataGridViewTable.ClearSelection();
            int parameter = comboBoxParameters.SelectedIndex;
            int ind;
            if (parameter == 0)
            {
                ind = data.SearchById((ushort)Convert.ToInt32(ForYearAndId.Value));
                if (ind == -1)
                {
                    MessageBox.Show("Элемент не найден!");
                    return;
                }
                dataGridViewTable.Rows[ind].Selected = true;
                dataGridViewTable.CurrentCell = dataGridViewTable[0, ind];
            }

            else if (parameter == 1)
            {
                ind = data.SearchByArtistName(textBoxForSearch.Text);
                if (ind == -1)
                {
                    MessageBox.Show("Элемент не найден!");
                    return;
                }
                dataGridViewTable.Rows[ind].Selected = true;
                dataGridViewTable.CurrentCell = dataGridViewTable[0, ind];
            }

            else if (parameter == 2)
            {
                ind = data.SearchBySongTittle(textBoxForSearch.Text);
                if (ind == -1)
                {
                    MessageBox.Show("Элемент не найден!");
                    return;
                }
                dataGridViewTable.Rows[ind].Selected = true;
                dataGridViewTable.CurrentCell = dataGridViewTable[0, ind];
            }

            else if (parameter == 3)
            {
                ind = data.SearchByYearRelease((ushort)Convert.ToInt32(ForYearAndId.Value));
                if (ind == -1)
                {
                    MessageBox.Show("Элемент не найден!");
                    return;
                }
                dataGridViewTable.Rows[ind].Selected = true;
                dataGridViewTable.CurrentCell = dataGridViewTable[0, ind];
            }

            else if (parameter == 4)
            {
                ind = data.SearchByGenre(textBoxForSearch.Text);
                if (ind == -1)
                {
                    MessageBox.Show("Элемент не найден!");
                    return;
                }
                dataGridViewTable.Rows[ind].Selected = true;
                dataGridViewTable.CurrentCell = dataGridViewTable[0, ind];
            }
        }

        private void comboBoxParameters_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((comboBoxParameters.SelectedIndex == 0) || (comboBoxParameters.SelectedIndex == 3))
            {
                ForYearAndId.Visible = true;
                textBoxForSearch.Visible = false;
            } else
            {
                ForYearAndId.Visible = false;
                textBoxForSearch.Visible = true;
            }
        }
    }
}
