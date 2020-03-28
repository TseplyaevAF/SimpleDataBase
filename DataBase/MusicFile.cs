using System;
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

        public MusicFile(ushort songID, string artistName, string songTitle, ushort yearRelease, string songGenre)
        {
            if ((artistName == "") || (songTitle == "") || (songGenre == ""))
                throw new Exception("Все поля должны быть заполнены!");
            this.artistName = artistName;
            this.songTitle = songTitle;
            this.songGenre = songGenre;
            if ((yearRelease < 1900) || (yearRelease > DateTime.Now.Year))
                throw new Exception("Год выпуска не раньше 1900 и не позднее " + DateTime.Now.Year);
            this.yearRelease = yearRelease;
            this.songID = songID;
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
            set
            {
                songID = value;
            }
        }

        public override string ToString()
        {
            return songID + "|" + artistName + "|" + songTitle + "|" +
                yearRelease + "|" + songGenre;
        }
    }
}
