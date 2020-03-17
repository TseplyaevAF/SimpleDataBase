using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO;

namespace DataBase
{
    public class DataWork
    {
        ArrayList musicFiles = new ArrayList();

        /// <summary>
        /// Добавление песни в коллекцию
        /// </summary>
        public void AddMusicFile(ushort id, string artistName, string songTitle, 
            ushort yearRelease, string songGenre)
        {
            MusicFile song = new MusicFile(id, artistName, songTitle, yearRelease, songGenre);
            musicFiles.Add(song);
        }

        /// <summary>
        /// Удаление всей коллекции
        /// </summary>
        public void DeleteMusic() => musicFiles.Clear();

        /// <summary>
        /// Удаление элемента коллекции по индексу
        /// </summary>
        public void DeleteMusicFile(int number) => musicFiles.RemoveAt(number);

        /// <summary>
        /// Изменить имя исполнителя у заданного элемента
        /// </summary>
        public void ChangeArtistName(string artist, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.ArtistName = artist;
        }

        /// <summary>
        /// Изменить название песни у заданного элемента
        /// </summary>
        public void ChangeSongTittle(string song, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.SongTitle = song;
        }

        /// <summary>
        /// Изменить год релиза песни у заданного элемента
        /// </summary>
        public void ChangeYearRelease(ushort year, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.YearRelease = year;
        }

        /// <summary>
        /// Изменить жанр песни у заданного элемента
        /// </summary>
        public void ChangeGenreSong(string genre, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.SongGenre = genre;
        }

        /// <summary>
        /// Сохранение коллекции в файл
        /// </summary>
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (MusicFile s in musicFiles)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// <summary>
        /// Восстанавливает коллекцию, записанную в файл
        /// </summary>
        public void OpenFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            if (musicFiles.Count != 0)
                DeleteMusic();
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);
                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string artist = dataFromFile[1];
                    string song = dataFromFile[2];
                    ushort year = (ushort)Convert.ToInt32(dataFromFile[3]);
                    string genre = dataFromFile[4];
                    AddMusicFile(id, artist, song, year, genre);
                }
            }
        }

        /// <summary>
        /// Поиск по заданному id и возвращение индекса элемента
        /// </summary>
        public int SearchById(ushort id)
        {
            for (int i = 0; i < musicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)musicFiles[i];
                if (music.SongID == id)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Поиск по заданному году выпуска и возвращение индекса элемента
        /// </summary>
        public int SearchByYearRelease(ushort year)
        {
            for (int i = 0; i < musicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)musicFiles[i];
                if (music.YearRelease == year)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Поиск по заданному исполнителю и возвращение индекса элемента
        /// </summary>
        public int SearchByArtistName(string name)
        {
            name = name.ToLower(); // перевод в нижний регистр
            name = name.Replace(" ", "");
            string str;
            for (int i = 0; i < musicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)musicFiles[i];
                str = music.ArtistName.ToLower();
                str = str.Replace(" ", "");
                if (str.Contains(name))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Поиск элемента по заданной песни и возвращение его индекса
        /// </summary>
        public int SearchBySongTittle(string song)
        {
            song = song.ToLower(); // перевод в нижний регистр
            song = song.Replace(" ", "");
            string str;
            for (int i = 0; i < musicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)musicFiles[i];
                str = music.SongTitle.ToLower();
                str = str.Replace(" ", "");
                if (str.Contains(song))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Поиск по заданному жанру и возвращение индекса элемента
        /// </summary>
        public int SearchByGenre(string genre)
        {
            genre = genre.ToLower(); // перевод в нижний регистр
            genre = genre.Replace(" ", "");
            string str;
            for (int i = 0; i < musicFiles.Count; i++)
            {
                MusicFile music = (MusicFile)musicFiles[i];
                str = music.SongGenre.ToLower();
                str = str.Replace(" ", "");
                if (str.Contains(genre))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Вернуть коллекцию
        /// </summary>
        public ArrayList MusicFiles
        {
            get
            {
                return musicFiles;
            }
        }
    }
}
