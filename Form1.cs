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
using YoutubeExtractor;
using System.Threading;


namespace Mp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(textBox1.Text);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(comboBox1.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader Downloader = new VideoDownloader(video, Path.Combine(textBox2.Text + "\\", video.Title + video.VideoExtension));
            Downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { Downloader.Execute(); }) { IsBackground = true };
            thread.Start();





        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = (int)e.ProgressPercentage;
                label4.Text = string.Format("{0,0.##}", e.ProgressPercentage) + " %";
                progressBar1.Update();
            }
            ));
        }
    }
}
