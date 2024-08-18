using NAudio.Wave;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class FrmAudioPlayer : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private OpenFileDialog openFileDialog;


        public FrmAudioPlayer()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);

            openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Audio Files (*.wav;*.mp3)|*.wav;*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                waveOut?.Dispose();
                audioFile?.Dispose();

                string filePath = openFileDialog.FileName;
                lblName.Text = filePath;

                audioFile = new AudioFileReader(filePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFile);

                txtVolume.Text = "50";
            }

            openFileDialog.Dispose();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
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
                waveOut.Stop();
                audioFile.Position = 0; // Reiniciar la posición del archivo para la próxima reproducción
            }
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            if(waveOut != null)
            {
                waveOut.Volume = float.Parse(txtVolume.Text) / 100;
            }
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(waveOut != null && waveOut.Volume + 0.05f < 1)
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
                if(waveOut != null && waveOut.Volume < 0.05 && waveOut.Volume > 0)
                {
                    txtVolume.Text = "0";
                }
            }
        }

        private void FrmAudioPlayer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
