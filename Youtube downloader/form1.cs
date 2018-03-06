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
using YoutubeExplode;
using System.Net.Http;
using System.Threading;






namespace Youtube_downloader{

    public partial class formHome : Form {
        
        private bool mouseDown;
        private Point lastLocation;
        public formHome(){
            InitializeComponent();
        }

        private void formMain_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void formMain_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void formMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private async void buttonSavelocation_Click (object sender, EventArgs e)
        {
            if(txtSavelocation.Text == "")
            {
                MessageBox.Show("You did not enter a valid save location.");
            }
            else
            {



                for (int i = 0; i < txtUserinput.Lines.Length - 1; i++)
                {
                    lblStatus.Text = "Getting data about your song";
                    Webbrowser.Navigate("https://www.youtube.com/results?search_query=" + txtUserinput.Lines[i]);
                    var id = YoutubeClient.ParseVideoId(txtUserinput.Lines[i]);
                    var client = new YoutubeClient();
                    var video = await client.GetVideoAsync(id);

                    var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);
                    var streamInfo = streamInfoSet.Audio.FirstOrDefault();

                    var ext = streamInfo.Container;
                    lblStatus.Text = ("Downloading: " + video.Title);
                    await client.DownloadMediaStreamAsync(streamInfo, (txtSavelocation.Text + "/" + video.Title + "." + ext));
                }
                    MessageBox.Show("Downloads completed");
           }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            browseSavelocation.ShowDialog();
            txtSavelocation.Text = browseSavelocation.SelectedPath;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
                    }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
                    }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon.Visible = true;
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblStatus.Text = Webbrowser.Document.GetElementsByTagName("h3")[0].GetElementsByTagName("a")[0].GetAttribute("href");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


    }
}
