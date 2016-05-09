using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    class MusicDirectory
    {
        WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.IWMPPlaylist playlist;
       
        //Path Variables
        string DesktopPath;
        string Folder;
        //Holding Variable
        string prevMusic;

        public MusicDirectory()
        {
            playlist = wmplayer.playlistCollection.newPlaylist("myplaylist");
            DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Folder = System.IO.Path.Combine(DesktopPath, "MusicFolder");
            if(!System.IO.File.Exists(Folder))
            {
                System.IO.Directory.CreateDirectory(Folder);
            }
            prevMusic = " ";
        }

        //Public

        public string[] R_FolderContentPublic()
        {
            return R_FolderContentPrivate();
        }

        public void PL_MusicPublic(string Music, double Time)
        {
            PL_MusicPrivate(Music, Time);
        }

        public string P_MusicPublic()
        {
            return P_MusicPrivate();
        }

        public void S_MusicPublic()
        {
            S_MusicPrivate();
        }

        public string T_MusicPublic()
        {
           return T_MusicPrivate();
        }

        public double T_DoubleMusicPublic()
        {
            return T_DoubleMusicPrivate();
        }

        public string R_DirPublic()
        {
            return R_DirPrivate();
        }

        //Private

        private string[] R_FolderContentPrivate()
        {
            string[] Music = System.IO.Directory.GetFiles(Folder);
#if DEBUG
            foreach (string var in Music)
            {
                MessageBox.Show(var, "Debug", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
#endif      
            return Music;
        }

        private void PL_MusicPrivate(string Music, double Time)
        {
            if(Music != prevMusic)
            {
                wmplayer.URL = Music;
                if (prevMusic == " ")
                {
                    prevMusic = Music;
                }

                else if (prevMusic != Music)
                {
                    Time = 0.0D;
                    prevMusic = Music;
                }

                else
                {
                    wmplayer.controls.currentPosition = Time;
                }
                wmplayer.controls.play();
            }
           
        }

        private string P_MusicPrivate()
        {
            wmplayer.controls.pause();
            return wmplayer.controls.currentPosition.ToString();
        }

        private void S_MusicPrivate()
        {
            wmplayer.currentPlaylist = playlist;
            wmplayer.settings.setMode("shuffle", true);
        }

        private string T_MusicPrivate()
        {
            return wmplayer.controls.currentPositionString;
        }

        private double T_DoubleMusicPrivate()
        {
            return wmplayer.controls.currentPosition;
        }

        private string R_DirPrivate()
        {
            return Folder;
        }
    }   
}
