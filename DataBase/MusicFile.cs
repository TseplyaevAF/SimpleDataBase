﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class MusicFile
    {
        string artistName; // имя исполнителя/группы
        string songTitle; // название композиции
        ushort yearRelease; // год выпуска песни
        string songGenre; // жанр песни
        ushort songID; // id песни

        public MusicFile(string artistName, string songTitle, ushort yearRelease, string songGenre)
        {
            this.artistName = artistName;
            this.songTitle = songTitle;
            this.yearRelease = yearRelease;
            this.songGenre = songGenre;
            Random n = new Random();
            songID = (ushort)n.Next(0, 1000);
        }

        public string ArtistName
        {
            get
            {
                return artistName;
            }

            set
            {
                artistName = value;
            }
        }

        public string SongTitle
        {
            get
            {
                return songTitle;
            }

            set
            {
                songTitle = value;
            }
        }

        public ushort YearRelease
        {
            get
            {
                return yearRelease;
            }

            set
            {
                yearRelease = value;
            }
        }

        public string SongGenre
        {
            get
            {
                return songGenre;
            }

            set
            {
                songGenre = value;
            }
        }

        public ushort SongID
        {
            get
            {
                return songID;
            }
        }
    }
}