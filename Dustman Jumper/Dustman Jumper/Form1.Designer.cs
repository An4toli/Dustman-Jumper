﻿
namespace Dustman_Jumper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.paper1 = new System.Windows.Forms.PictureBox();
            this.butelkaKosz = new System.Windows.Forms.PictureBox();
            this.jar1 = new System.Windows.Forms.PictureBox();
            this.EQ3 = new System.Windows.Forms.PictureBox();
            this.EQ2 = new System.Windows.Forms.PictureBox();
            this.EQ1 = new System.Windows.Forms.PictureBox();
            this.StanEnergi3 = new System.Windows.Forms.PictureBox();
            this.StanEnergi2 = new System.Windows.Forms.PictureBox();
            this.StanEnergi1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butelkaKosz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.Location = new System.Drawing.Point(396, 11);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(271, 31);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Punkty: ";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // paper1
            // 
            this.paper1.BackColor = System.Drawing.Color.Transparent;
            this.paper1.BackgroundImage = global::Dustman_Jumper.Properties.Resources.kartka;
            this.paper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paper1.Location = new System.Drawing.Point(184, 166);
            this.paper1.Name = "paper1";
            this.paper1.Size = new System.Drawing.Size(55, 52);
            this.paper1.TabIndex = 25;
            this.paper1.TabStop = false;
            this.paper1.Tag = "paper";
            // 
            // butelkaKosz
            // 
            this.butelkaKosz.BackColor = System.Drawing.Color.Transparent;
            this.butelkaKosz.BackgroundImage = global::Dustman_Jumper.Properties.Resources.szklokosz;
            this.butelkaKosz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butelkaKosz.Location = new System.Drawing.Point(975, 298);
            this.butelkaKosz.Name = "butelkaKosz";
            this.butelkaKosz.Size = new System.Drawing.Size(58, 74);
            this.butelkaKosz.TabIndex = 23;
            this.butelkaKosz.TabStop = false;
            this.butelkaKosz.Tag = "glassdumpster";
            // 
            // jar1
            // 
            this.jar1.BackColor = System.Drawing.Color.Transparent;
            this.jar1.BackgroundImage = global::Dustman_Jumper.Properties.Resources.sloik;
            this.jar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jar1.Location = new System.Drawing.Point(381, 533);
            this.jar1.Name = "jar1";
            this.jar1.Size = new System.Drawing.Size(55, 52);
            this.jar1.TabIndex = 21;
            this.jar1.TabStop = false;
            this.jar1.Tag = "jar";
            // 
            // EQ3
            // 
            this.EQ3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EQ3.Location = new System.Drawing.Point(975, 613);
            this.EQ3.Name = "EQ3";
            this.EQ3.Size = new System.Drawing.Size(58, 51);
            this.EQ3.TabIndex = 17;
            this.EQ3.TabStop = false;
            this.EQ3.Tag = "EQ";
            // 
            // EQ2
            // 
            this.EQ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EQ2.Location = new System.Drawing.Point(895, 613);
            this.EQ2.Name = "EQ2";
            this.EQ2.Size = new System.Drawing.Size(58, 51);
            this.EQ2.TabIndex = 16;
            this.EQ2.TabStop = false;
            this.EQ2.Tag = "EQ";
            // 
            // EQ1
            // 
            this.EQ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EQ1.Location = new System.Drawing.Point(804, 613);
            this.EQ1.Name = "EQ1";
            this.EQ1.Size = new System.Drawing.Size(58, 51);
            this.EQ1.TabIndex = 15;
            this.EQ1.TabStop = false;
            this.EQ1.Tag = "EQ";
            // 
            // StanEnergi3
            // 
            this.StanEnergi3.BackgroundImage = global::Dustman_Jumper.Properties.Resources.pelnaenergia;
            this.StanEnergi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StanEnergi3.Location = new System.Drawing.Point(985, 12);
            this.StanEnergi3.Name = "StanEnergi3";
            this.StanEnergi3.Size = new System.Drawing.Size(48, 46);
            this.StanEnergi3.TabIndex = 11;
            this.StanEnergi3.TabStop = false;
            // 
            // StanEnergi2
            // 
            this.StanEnergi2.BackgroundImage = global::Dustman_Jumper.Properties.Resources.pelnaenergia;
            this.StanEnergi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StanEnergi2.Location = new System.Drawing.Point(931, 11);
            this.StanEnergi2.Name = "StanEnergi2";
            this.StanEnergi2.Size = new System.Drawing.Size(48, 46);
            this.StanEnergi2.TabIndex = 10;
            this.StanEnergi2.TabStop = false;
            // 
            // StanEnergi1
            // 
            this.StanEnergi1.BackgroundImage = global::Dustman_Jumper.Properties.Resources.pelnaenergia;
            this.StanEnergi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StanEnergi1.Location = new System.Drawing.Point(877, 11);
            this.StanEnergi1.Name = "StanEnergi1";
            this.StanEnergi1.Size = new System.Drawing.Size(48, 46);
            this.StanEnergi1.TabIndex = 9;
            this.StanEnergi1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.LightCoral;
            this.player.Location = new System.Drawing.Point(33, 600);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 41);
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox7.Location = new System.Drawing.Point(151, 225);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(216, 37);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox6.Location = new System.Drawing.Point(400, 289);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(336, 37);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox5.Location = new System.Drawing.Point(833, 370);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(213, 37);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.Location = new System.Drawing.Point(694, 456);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 37);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox3.Location = new System.Drawing.Point(534, 523);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 37);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.Location = new System.Drawing.Point(151, 592);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 37);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 652);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Dustman_Jumper.Properties.Resources.butelka;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(722, 397);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(55, 52);
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "botle";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::Dustman_Jumper.Properties.Resources.papierkosz;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(245, 523);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 74);
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "paperdumpster";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::Dustman_Jumper.Properties.Resources.plastikkosz;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(309, 153);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 74);
            this.pictureBox9.TabIndex = 29;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "plasticdumpster";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::Dustman_Jumper.Properties.Resources.kartka;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(519, 230);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(55, 52);
            this.pictureBox11.TabIndex = 30;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "paper";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::Dustman_Jumper.Properties.Resources.country_platform_preview;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(0, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(1046, 689);
            this.pictureBox12.TabIndex = 31;
            this.pictureBox12.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Dustman_Jumper.Properties.Resources.country_platform_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.paper1);
            this.Controls.Add(this.butelkaKosz);
            this.Controls.Add(this.jar1);
            this.Controls.Add(this.EQ3);
            this.Controls.Add(this.EQ2);
            this.Controls.Add(this.EQ1);
            this.Controls.Add(this.StanEnergi3);
            this.Controls.Add(this.StanEnergi2);
            this.Controls.Add(this.StanEnergi1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox12);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 1249);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Form1";
            this.Text = "Dustman Jumper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.paper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butelkaKosz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanEnergi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox StanEnergi1;
        private System.Windows.Forms.PictureBox StanEnergi2;
        private System.Windows.Forms.PictureBox StanEnergi3;
        public System.Windows.Forms.PictureBox EQ1;
        public System.Windows.Forms.PictureBox EQ2;
        public System.Windows.Forms.PictureBox EQ3;
        private System.Windows.Forms.PictureBox jar1;
        private System.Windows.Forms.PictureBox butelkaKosz;
        private System.Windows.Forms.PictureBox paper1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

