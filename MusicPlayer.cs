using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        MusicDirectory MD = new MusicDirectory();
        string curItem = "";
        double dTime = 0.0D;


        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            string[] Music = MD.R_FolderContentPublic();
            LB_Songs.DataSource = Delimit(Music);
            LB_Songs.Refresh();
        }

        private string[] Delimit(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i].Remove(0, MD.R_DirPublic().Length+1);
            }

            return x;
        }
        
        private void B_Play_Click(object sender, EventArgs e)
        {
            string path = MD.R_DirPublic();
            MD.PL_MusicPublic(path + @"\" + curItem, dTime);
            T_Time.Enabled = true;
        }

        private void B_Pause_Click(object sender, EventArgs e)
        {
            MD.P_MusicPublic();
            T_Time.Enabled = false;
        }

        private void LB_Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            curItem = LB_Songs.SelectedItem.ToString();                  
        }

        private void T_Time_Tick(object sender, EventArgs e)
        {
            L_Time.Text = MD.T_MusicPublic();
            dTime = MD.T_DoubleMusicPublic();

        }

        private void B_Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

    }
}
