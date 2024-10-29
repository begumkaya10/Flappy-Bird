using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        // Oyun değişkenleri
        int pipeSpeed = 8;           // Boru hızı
        int gravity = 5;             // Yerçekimi kuvveti
        int jumpForce = -15;         // Kuşun zıplama kuvveti
        int score = 0;               // Puan
        //int gap = 150;             // Borular arasındaki boşluk
        Random rand = new Random();  // Rastgele sayılar için
        bool isGameOver = false;     // Oyun durumu

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        // Oyun başlangıç ayarları
        public void StartGame()
        {
            score = 0;
            gravity = 5;
            isGameOver = false;
            label1.Text = "SCORE: " + score;

            pictureBox_Bird.Top = 200;
            pictureBox_Bottom.Left = this.ClientSize.Width;
            pictureBox_Top.Left = this.ClientSize.Width + 100;

            RandomizePipes();
            timer_GameControl.Start();
        }

        // Oyun zamanlayıcısına bağlı metod (her tick'te çağrılır)
        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Kuşun yerçekimi etkisiyle hareketi
            if (pictureBox_Bird.Top + pictureBox_Bird.Height > pictureBox_Ground.Top)
            {
                pictureBox_Bird.Top = pictureBox_Ground.Top - pictureBox_Bird.Height;
                EndGame();
            }
            else
            {
                pictureBox_Bird.Top += gravity;
            }

            // Boruları sola hareket ettir
            pictureBox_Bottom.Left -= pipeSpeed;
            pictureBox_Top.Left -= pipeSpeed;

            // Skoru güncelle
            label1.Text = "SCORE: " + score;

            // Borular ekranın solundan çıkarsa yeniden konumlandır
            if (pictureBox_Bottom.Left < -150)
            {
                pictureBox_Bottom.Left = this.ClientSize.Width;
                RandomizePipes();
                score++;
            }
            if (pictureBox_Top.Left < -180)
            {
                pictureBox_Top.Left = this.ClientSize.Width + 100;
                RandomizePipes();
                score++;
            }

            // Çarpma kontrolü
            if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Bottom.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Top.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) ||
                pictureBox_Bird.Top < 0)
            {
                EndGame();
            }

            // Skor belirli bir seviyeyi geçerse boru hızı artırılır
            if (score > 30)
            {
                pipeSpeed = 15;
            }
        }

        // Rastgele boru yüksekliklerini ayarla
        public void RandomizePipes()
        {
            int gap = 200; // Kuşun geçebileceği sabit boşluk
            int pipeMinHeight = 30; // Minimum üst boru yüksekliği
            int pipeMaxHeight = pictureBox_Ground.Top - gap - pipeMinHeight;

            // Üst borunun yüksekliğini rastgele ayarla
            int randomTopHeight = rand.Next(pipeMinHeight, pipeMaxHeight);
            pictureBox_Top.Height = randomTopHeight;
            pictureBox_Top.Top = 0;

            // Alt borunun yüksekliğini ve pozisyonunu ayarla
            pictureBox_Bottom.Height = pictureBox_Ground.Top - randomTopHeight - gap;
            pictureBox_Bottom.Top = pictureBox_Ground.Top - pictureBox_Bottom.Height;
        }

        // Oyun bittiğinde yapılacak işlemler
        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER! Press R to Restart";
            isGameOver = true;
        }

        // Oyunu yeniden başlat
        public void RestartGame()
        {
            StartGame();
        }

        // Klavyeden tuşa basıldığında yapılacak işlemler
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // Boşluk tuşuna basıldığında kuşu zıplat
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                gravity = jumpForce;
            }

            // "R" tuşuna basıldığında oyunu yeniden başlat
            if (e.KeyCode == Keys.R && isGameOver)
            {
                RestartGame();
            }
        }

        // Klavyeden tuş bırakıldığında yapılacak işlemler
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // Boşluk tuşu bırakıldığında yerçekimi tekrar devreye girer
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                gravity = 5;
            }
        }

        private void pictureBox_Top_Click(object sender, EventArgs e)
        {
            // Bu alan gerektiğinde eklenebilir.
        }
    }
}

