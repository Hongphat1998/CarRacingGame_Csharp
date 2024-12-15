
namespace Car_Racing
{
    partial class CarRacingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacingForm));
            timerLine = new System.Windows.Forms.Timer(components);
            ptrLine1 = new System.Windows.Forms.PictureBox();
            ptrLine2 = new System.Windows.Forms.PictureBox();
            ptrLine3 = new System.Windows.Forms.PictureBox();
            ptrMyCar = new System.Windows.Forms.PictureBox();
            ptrEnemyCar4 = new System.Windows.Forms.PictureBox();
            ptrEnemyCar2 = new System.Windows.Forms.PictureBox();
            ptrEnemyCar1 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            lblScore = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ptrCoin1 = new System.Windows.Forms.PictureBox();
            ptrCoin2 = new System.Windows.Forms.PictureBox();
            lblCoin = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptrLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrLine3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrMyCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrCoin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrCoin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // timerLine
            // 
            timerLine.Interval = 25;
            timerLine.Tick += timerLine_Tick;
            // 
            // ptrLine1
            // 
            ptrLine1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ptrLine1.Location = new System.Drawing.Point(521, 1);
            ptrLine1.Name = "ptrLine1";
            ptrLine1.Size = new System.Drawing.Size(10, 180);
            ptrLine1.TabIndex = 6;
            ptrLine1.TabStop = false;
            // 
            // ptrLine2
            // 
            ptrLine2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ptrLine2.Location = new System.Drawing.Point(521, 223);
            ptrLine2.Name = "ptrLine2";
            ptrLine2.Size = new System.Drawing.Size(10, 180);
            ptrLine2.TabIndex = 7;
            ptrLine2.TabStop = false;
            // 
            // ptrLine3
            // 
            ptrLine3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ptrLine3.Location = new System.Drawing.Point(521, 430);
            ptrLine3.Name = "ptrLine3";
            ptrLine3.Size = new System.Drawing.Size(10, 180);
            ptrLine3.TabIndex = 8;
            ptrLine3.TabStop = false;
            // 
            // ptrMyCar
            // 
            ptrMyCar.Image = (System.Drawing.Image)resources.GetObject("ptrMyCar.Image");
            ptrMyCar.Location = new System.Drawing.Point(510, 520);
            ptrMyCar.Name = "ptrMyCar";
            ptrMyCar.Size = new System.Drawing.Size(40, 90);
            ptrMyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrMyCar.TabIndex = 9;
            ptrMyCar.TabStop = false;
            // 
            // ptrEnemyCar4
            // 
            ptrEnemyCar4.Image = (System.Drawing.Image)resources.GetObject("ptrEnemyCar4.Image");
            ptrEnemyCar4.Location = new System.Drawing.Point(750, 50);
            ptrEnemyCar4.Name = "ptrEnemyCar4";
            ptrEnemyCar4.Size = new System.Drawing.Size(40, 90);
            ptrEnemyCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrEnemyCar4.TabIndex = 10;
            ptrEnemyCar4.TabStop = false;
            // 
            // ptrEnemyCar2
            // 
            ptrEnemyCar2.Image = (System.Drawing.Image)resources.GetObject("ptrEnemyCar2.Image");
            ptrEnemyCar2.Location = new System.Drawing.Point(250, 350);
            ptrEnemyCar2.Name = "ptrEnemyCar2";
            ptrEnemyCar2.Size = new System.Drawing.Size(40, 90);
            ptrEnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrEnemyCar2.TabIndex = 12;
            ptrEnemyCar2.TabStop = false;
            // 
            // ptrEnemyCar1
            // 
            ptrEnemyCar1.Image = (System.Drawing.Image)resources.GetObject("ptrEnemyCar1.Image");
            ptrEnemyCar1.Location = new System.Drawing.Point(610, 200);
            ptrEnemyCar1.Name = "ptrEnemyCar1";
            ptrEnemyCar1.Size = new System.Drawing.Size(40, 90);
            ptrEnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrEnemyCar1.TabIndex = 13;
            ptrEnemyCar1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pictureBox1.Location = new System.Drawing.Point(186, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(10, 662);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(630, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 21);
            label1.TabIndex = 16;
            label1.Text = "YOUR SCORE: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.Color.Red;
            lblScore.Location = new System.Drawing.Point(761, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(19, 21);
            lblScore.TabIndex = 17;
            lblScore.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(-6, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(190, 663);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(843, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(190, 661);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // ptrCoin1
            // 
            ptrCoin1.Image = (System.Drawing.Image)resources.GetObject("ptrCoin1.Image");
            ptrCoin1.Location = new System.Drawing.Point(403, 174);
            ptrCoin1.Name = "ptrCoin1";
            ptrCoin1.Size = new System.Drawing.Size(40, 40);
            ptrCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrCoin1.TabIndex = 20;
            ptrCoin1.TabStop = false;
            // 
            // ptrCoin2
            // 
            ptrCoin2.Image = (System.Drawing.Image)resources.GetObject("ptrCoin2.Image");
            ptrCoin2.Location = new System.Drawing.Point(538, 302);
            ptrCoin2.Name = "ptrCoin2";
            ptrCoin2.Size = new System.Drawing.Size(40, 40);
            ptrCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptrCoin2.TabIndex = 21;
            ptrCoin2.TabStop = false;
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCoin.ForeColor = System.Drawing.Color.Gold;
            lblCoin.Location = new System.Drawing.Point(342, 9);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new System.Drawing.Size(19, 21);
            lblCoin.TabIndex = 23;
            lblCoin.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Gold;
            label3.Location = new System.Drawing.Point(211, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 21);
            label3.TabIndex = 22;
            label3.Text = "YOUR COIN: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pictureBox2.Location = new System.Drawing.Point(833, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(10, 662);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(682, 328);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(40, 90);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // CarRacingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonShadow;
            ClientSize = new System.Drawing.Size(1034, 661);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(lblCoin);
            Controls.Add(label3);
            Controls.Add(ptrCoin2);
            Controls.Add(ptrCoin1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ptrEnemyCar1);
            Controls.Add(ptrEnemyCar2);
            Controls.Add(ptrEnemyCar4);
            Controls.Add(ptrMyCar);
            Controls.Add(ptrLine3);
            Controls.Add(ptrLine2);
            Controls.Add(ptrLine1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarRacingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Racing Game";
            KeyUp += CarRacingForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)ptrLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrLine3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrMyCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrEnemyCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrCoin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrCoin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timerLine;
        private System.Windows.Forms.PictureBox ptrLine1;
        private System.Windows.Forms.PictureBox ptrLine2;
        private System.Windows.Forms.PictureBox ptrLine3;
        private System.Windows.Forms.PictureBox ptrMyCar;
        private System.Windows.Forms.PictureBox ptrEnemyCar4;
        private System.Windows.Forms.PictureBox ptrEnemyCar2;
        private System.Windows.Forms.PictureBox ptrEnemyCar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox ptrCoin1;
        private System.Windows.Forms.PictureBox ptrCoin2;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

