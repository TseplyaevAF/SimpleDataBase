using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace DataBase
{
    public class DataWork
    {
        //ObservableCollection<MusicFile> musicFiles = new ObservableCollection<MusicFile>();
        ArrayList musicFiles = new ArrayList();

        /// <summary>
        /// Добавление песни в коллекцию
        /// </summary>
        /// <param name="artistName"></param>
        /// <param name="songTitle"></param>
        /// <param name="yearRelease"></param>
        /// <param name="songGenre"></param>
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
        /// <param name="number"></param>
        public void DeleteMusicFile(int number) => musicFiles.RemoveAt(number);

        /// <summary>
        /// Изменить имя исполнителя у заданного элемента
        /// </summary>
        /// <param name="artist"></param>
        /// <param name="index"></param>
        public void ChangeArtistName(string artist, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.ArtistName = artist;
        }

        /// <summary>
        /// Изменить название песни у заданного элемента
        /// </summary>
        /// <param name="song"></param>
        /// <param name="index"></param>
        public void ChangeSongTittle(string song, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.SongTitle = song;
        }

        /// <summary>
        /// Изменить год релиза песни у заданного элемента
        /// </summary>
        /// <param name="year"></param>
        /// <param name="index"></param>
        public void ChangeYearRelease(ushort year, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.YearRelease = year;
        }

        /// <summary>
        /// Изменить жанр песни у заданного элемента
        /// </summary>
        /// <param name="genre"></param>
        /// <param name="index"></param>
        public void ChangeGenreSong(string genre, int index)
        {
            MusicFile music = (MusicFile)MusicFiles[index];
            music.SongGenre = genre;
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
