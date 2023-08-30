using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game
{
    public partial class Form1 : Form
    {
        int funeSpeed;
        int HP;
        const int maxHP = 10;

        PictureBox[] hpBar;

        PictureBox[] bullets;
        int bulletsSpeed;

        PictureBox[] enemies;
        int sizeEnemy;
        int enemiesSpeed;

        int score;

        WindowsMediaPlayer Shoot;
        WindowsMediaPlayer music;
        WindowsMediaPlayer kill;
        WindowsMediaPlayer death;
        WindowsMediaPlayer damage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Fune_Click(object sender, EventArgs e)
        {

        }

        private void LeftMove_Tick(object sender, EventArgs e)
        {
            if (Fune.Left > 50)
            {
                Fune.Left -= funeSpeed;
            }
        }

        private void RightMove_Tick(object sender, EventArgs e)
        {
            if (Fune.Right < 950)
            {
                Fune.Left += funeSpeed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funeSpeed = 50;
            HP = maxHP;

            hpBar = new PictureBox[HP];
            for (int i = 0; i < HP; i++)
            {
                int size = 1000 / HP;
                hpBar[i] = new PictureBox();
                hpBar[i].Visible = true;
                hpBar[i].Size = new Size(size, 20);
                hpBar[i].Location = new Point(i * size, 730);
                hpBar[i].BackColor = Color.White;

                this.Controls.Add(hpBar[i]);
            }

            bullets = new PictureBox[1];
            bulletsSpeed = 60;

            enemies = new PictureBox[4];
            sizeEnemy = 50;
            enemiesSpeed = 3;

            score = 0;

            Random rnd = new Random();
            Image enemyImage = Image.FromFile("Assets\\Enemy.png");

            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "Voice\\shoot.wav";
            music = new WindowsMediaPlayer();
            music.URL = "Voice\\music.mp3";
            kill = new WindowsMediaPlayer();
            kill.URL = "Voice\\kill.wav";
            death = new WindowsMediaPlayer();
            death.URL = "Voice\\death.wav";
            damage = new WindowsMediaPlayer();
            damage.URL = "Voice\\damage.wav";

            Shoot.controls.stop();
            kill.controls.stop();
            death.controls.stop();
            damage.controls.stop();

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].BackColor = Color.Black;
                enemies[i].Image = enemyImage;
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].Location = new Point(rnd.Next(100, 900), rnd.Next(-1000, 0));

                this.Controls.Add(enemies[i]);
            }

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(5, 20);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }

            music.controls.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                LeftMove.Start();
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                RightMove.Start();
            }

            if (e.KeyCode == Keys.Space)
            {
                Shoot.controls.stop();
                Shoot.controls.play();

                for (int i = 0; i < bullets.Length; i++)
                {
                    Intersect();

                    if (bullets[i].Top < 1000)
                    {
                        bullets[i].Location = new Point(Fune.Location.X + 27, Fune.Location.Y + 30 + i * 50);
                    }

                }
            }

            if (e.KeyCode == Keys.R)
            {
                Restart();
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                LeftMove.Stop();
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                RightMove.Stop();
            }
        }

        private void moveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Top -= bulletsSpeed;
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }

        private void MoveEnemies(PictureBox[] enemies, int speed)
        {
            Random rnd = new Random();

            Intersect();

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Top += speed;
                if (enemies[i].Top > 750)
                {
                    enemies[i].Location = new Point(rnd.Next(100, 900), rnd.Next(-1000, 0));
                    HP -= 1;
                    damage.controls.stop();
                    damage.controls.play();
                    HPBar(HP);
                    if (HP <= 0)
                    {
                        EndGame();
                    }
                }
            }
        }

        private void Intersect()
        {
            Random rnd = new Random();
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    score++;
                    label2.Text = score.ToString();
                    kill.controls.stop();
                    kill.controls.play();

                    enemies[i].Location = new Point(rnd.Next(100, 900), rnd.Next(-500, 0));
                    bullets[0].Location = new Point(3000, 1000);
                }

                if (Fune.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    HP -= 3;
                    damage.controls.stop();
                    damage.controls.play();
                    HPBar(HP);
                    enemies[i].Location = new Point(rnd.Next(100, 900), rnd.Next(-1000, 0));
                    if (HP <= 0)
                    {
                        EndGame();
                    }
                }
            }
        }

        private void EndGame()
        {
            gameOver.Visible = true;
            RestartText.Visible = true;
            Fune.Visible = false;
            HPBar(-1);

            MoveEnemiesTimer.Stop();
            moveBulletsTimer.Stop();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void HPBar(int HP)
        {
            for (int i = 0; i < HP; i++)
            {
                hpBar[i].Visible = true;
            }

            if (HP < 0)
            {
                death.controls.play();
                for (int i = 0; i < maxHP; i++)
                {
                    hpBar[i].Visible = false;
                }
                return;
            }

            for (int i = HP; i < maxHP; i++)
            {
                hpBar[i].Visible = false;
            }
        }

        private void Restart()
        {
            gameOver.Visible = false;
            RestartText.Visible = false;

            HP = maxHP;
            HPBar(HP);

            Fune.Visible = true;
            MoveEnemiesTimer.Start();
            moveBulletsTimer.Start();
            score = 0;
            label2.Text = score.ToString();

            Random rnd = new Random();

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Location = new Point(rnd.Next(100, 900), rnd.Next(-1000, 0));
            }

            music.controls.stop();
            music.controls.play();
        }
    }
}
