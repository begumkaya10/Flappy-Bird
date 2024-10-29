namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_Top = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Bird
            // 
            this.pictureBox_Bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.pictureBox_Bird.Location = new System.Drawing.Point(105, 304);
            this.pictureBox_Bird.Name = "pictureBox_Bird";
            this.pictureBox_Bird.Size = new System.Drawing.Size(100, 104);
            this.pictureBox_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bird.TabIndex = 0;
            this.pictureBox_Bird.TabStop = false;
            // 
            // pictureBox_Top
            // 
            this.pictureBox_Top.Image = global::FlappyBirdGame.Properties.Resources.pipes__1_;
            this.pictureBox_Top.Location = new System.Drawing.Point(437, -2);
            this.pictureBox_Top.Name = "pictureBox_Top";
            this.pictureBox_Top.Size = new System.Drawing.Size(123, 237);
            this.pictureBox_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Top.TabIndex = 0;
            this.pictureBox_Top.TabStop = false;
            this.pictureBox_Top.Click += new System.EventHandler(this.pictureBox_Top_Click);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ground.Image")));
            this.pictureBox_Ground.Location = new System.Drawing.Point(0, 717);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(1243, 109);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 0;
            this.pictureBox_Ground.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = global::FlappyBirdGame.Properties.Resources.pipes;
            this.pictureBox_Bottom.Location = new System.Drawing.Point(432, 515);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(128, 208);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 0;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Enabled = true;
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1080, 825);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Top);
            this.Controls.Add(this.pictureBox_Bird);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Bird;
        private System.Windows.Forms.PictureBox pictureBox_Top;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_GameControl;
    }
}

