using NAudio.Wave;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class FrmAudioPlayer : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private OpenFileDialog openFileDialog;
        private string[] filesPaths;
        private int indexFilesPaths;
        private Task time;


        public FrmAudioPlayer()
        {
            InitializeComponent();

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);

            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Audio Files (*.wav;*.mp3;*.m4a)|*.wav;*.mp3;*.m4a";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesPaths = openFileDialog.FileNames;
                indexFilesPaths = 0;
                ChargeSong();
                UpdateListBoxFiles();
            }
            
            openFileDialog.Dispose();
        }

        private void ChargeSong()
        {
            waveOut?.Dispose();
            audioFile?.Dispose();

            lblName.Text = System.IO.Path.GetFileName(filesPaths[indexFilesPaths]);

            audioFile = new AudioFileReader(filesPaths[indexFilesPaths]);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFile);
            waveOut.PlaybackStopped += NextSongWhenItEnds;

            txtVolume.Text = "50";
        }

        private void UpdateListBoxFiles()
        {
            lstFiles.Items.Clear();
            foreach (string filePath in filesPaths)
            {
                lstFiles.Items.Add(filePath.Substring(filePath.LastIndexOf("\\") + 1));
            }
        }

        private void NextSongWhenItEnds(object sender, StoppedEventArgs e)
        {
            indexFilesPaths++;

            if (indexFilesPaths == filesPaths.Length)
            {
                indexFilesPaths = 0;
            }

            ChargeSong();
            waveOut.Play();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                if (lstFiles.SelectedIndex != -1)
                {
                    btnStop_Click(sender, e);
                    indexFilesPaths = lstFiles.SelectedIndex;
                    ChargeSong();
                }
                waveOut.Play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.PlaybackStopped -= NextSongWhenItEnds;
                waveOut.Stop();
                audioFile.Position = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (filesPaths != null && indexFilesPaths < filesPaths.Length)
            {
                btnStop_Click(sender, e);
                NextSongWhenItEnds(waveOut, new StoppedEventArgs());
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (filesPaths != null && indexFilesPaths > 0)
            {
                btnStop_Click(sender, e);
                indexFilesPaths -= 1;
                ChargeSong();
                waveOut.Play();
            }
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Volume = float.Parse(txtVolume.Text) / 100;
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.Volume + 0.05f < 1)
            {
                txtVolume.Text = (float.Parse(txtVolume.Text) + 5).ToString();
            }
            else
            {
                if (waveOut != null && waveOut.Volume < 1 && waveOut.Volume > 0.95)
                {
                    txtVolume.Text = "100";
                }
            }


        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.Volume - 0.05f > 0)
            {
                txtVolume.Text = (float.Parse(txtVolume.Text) - 5).ToString();
            }
            else
            {
                if (waveOut != null && waveOut.Volume < 0.05 && waveOut.Volume > 0)
                {
                    txtVolume.Text = "0";
                }
            }
        }

        private void FrmAudioPlayer_Load(object sender, EventArgs e)
        {

        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.Items.Count > 0)
            {
                btnStop_Click(sender, e);
                indexFilesPaths = lstFiles.SelectedIndex;
                ChargeSong();
                waveOut.Play();
            }
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesPaths != null)
            {
                Array.Sort(filesPaths);
                UpdateListBoxFiles();
            }
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesPaths != null)
            {
                Array.Sort(filesPaths);
                Array.Reverse(filesPaths);
                UpdateListBoxFiles();
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = (audioFile.TotalTime / TimeSpan.FromSeconds(trackBar.Maximum)) * TimeSpan.FromSeconds(trackBar.Value);
            }
        }
    }
}
