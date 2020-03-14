using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        DataWork data = new DataWork();
        public Form1()
        {
            InitializeComponent();
            dataGridViewTable.Rows[0].ReadOnly = true;
            dataGridViewTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string artist = textBoxArtist.Text;
                string song = textBoxSong.Text;
                ushort year = (ushort)Convert.ToInt32(textBoxYear.Text);
                string genre = textBoxGenre.Text;
                data.AddMusicFile(artist, song, year, genre);
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
            int ind = dataGridViewTable.SelectedCells[0].RowIndex;
            if (ind == count-1) return;
            data.DeleteMusicFile(ind);
            dataGridViewTable.Rows.RemoveAt(ind);
        }

        private void dataGridViewTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indRow = dataGridViewTable.Rows[e.RowIndex].Index;
            int indColumn = dataGridViewTable.Columns[e.ColumnIndex].Index;
            object value = dataGridViewTable.Rows[indRow].Cells[indColumn].Value;
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
    }
}
