using NAudio.Wave;
using NAudio.Vorbis;
using System;
using System.IO;
using NVorbis;

namespace WindowsMusic1
{
    public partial class Form1 : Form
    {
        string[] files;
        List<string> localmusiclist = new List<string> { };
        private WaveOutEvent waveOut;
        private VorbisWaveReader vorbisFileReader;
        private const int VOLUME_STEP = 5; // 音量调节步进值

        public Form1()
        {
            InitializeComponent();
            // 初始化音量
            trackBar1.Value = 50;
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value + "%";
        }

        private void musicplay(string filename)
        {
            string extension = Path.GetExtension(filename);
            if (extension == ".ogg")
            {
                if (vorbisFileReader != null)
                {
                    if (waveOut.PlaybackState != PlaybackState.Stopped)
                    {
                        waveOut.Stop();
                        vorbisFileReader.Dispose();
                    }
                }
                vorbisFileReader = new VorbisWaveReader(filename);
                waveOut = new WaveOutEvent();
                waveOut.Init(vorbisFileReader);
                waveOut.Play();
            }
            else
            {
                if (vorbisFileReader != null)
                {
                    if (waveOut.PlaybackState != PlaybackState.Stopped)
                    {
                        waveOut.Stop();
                        vorbisFileReader.Dispose();
                    }
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void musicpause(string filename)
        {
            string extension = Path.GetExtension(filename);
            if (extension == ".ogg")
            {
                waveOut.Pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ѡ����Ƶ|*.mp3;*,wav;*,flac;*.ogg";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                if (files != null)
                {
                    Array.Clear(files, 0, files.Length);
                }
                files = openFileDialog1.FileNames;

                string[] array = files;

                foreach (string x in array)
                {
                    listBox1.Items.Add(x);
                    localmusiclist.Add(x);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (localmusiclist.Count > 0)
            {
                axWindowsMediaPlayer1.URL = localmusiclist[listBox1.SelectedIndex];
                musicplay(axWindowsMediaPlayer1.URL);
                label1.Text = Path.GetFileNameWithoutExtension(axWindowsMediaPlayer1.URL);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicpause(axWindowsMediaPlayer1.URL);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nextIndex = listBox1.SelectedIndex + 1;
            if (nextIndex >= localmusiclist.Count)
            {
                nextIndex = 0;
            }
            axWindowsMediaPlayer1.URL = localmusiclist[nextIndex];
            musicplay(axWindowsMediaPlayer1.URL);
            label1.Text = Path.GetFileNameWithoutExtension(localmusiclist[nextIndex]);
            listBox1.SelectedIndex = nextIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicplay(axWindowsMediaPlayer1.URL);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] supportedExtensions = { "*.mp3", "*.wav", "*.flac", "*.ogg" };
                List<string> musicFiles = new List<string>();

                foreach (string extension in supportedExtensions)
                {
                    musicFiles.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath, extension, SearchOption.AllDirectories));
                }

                if (musicFiles.Count > 0)
                {
                    listBox1.Items.Clear();
                    localmusiclist.Clear();
                    if (files != null)
                    {
                        Array.Clear(files, 0, files.Length);
                    }
                    files = musicFiles.ToArray();

                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));
                        localmusiclist.Add(file);
                    }
                }
                else
                {
                    MessageBox.Show("所选文件夹中没有找到支持的音乐文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (localmusiclist.Count > 0 && listBox1.SelectedIndex != -1)
            {
                int previousIndex = listBox1.SelectedIndex - 1;
                if (previousIndex < 0)
                {
                    previousIndex = localmusiclist.Count - 1;
                }
                axWindowsMediaPlayer1.URL = localmusiclist[previousIndex];
                musicplay(axWindowsMediaPlayer1.URL);
                label1.Text = Path.GetFileNameWithoutExtension(localmusiclist[previousIndex]);
                listBox1.SelectedIndex = previousIndex;
            }
        }

        private void volumeDownButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value >= VOLUME_STEP)
            {
                trackBar1.Value -= VOLUME_STEP;
            }
            else
            {
                trackBar1.Value = 0;
            }
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value + "%";
        }

        private void volumeUpButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 100 - VOLUME_STEP)
            {
                trackBar1.Value += VOLUME_STEP;
            }
            else
            {
                trackBar1.Value = 100;
            }
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value + "%";
        }
    }
}
