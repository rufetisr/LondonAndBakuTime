namespace LondonAndBakuTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.londonpictureBox = new System.Windows.Forms.PictureBox();
            this.bakupictureBox = new System.Windows.Forms.PictureBox();
            this.bakubutton = new System.Windows.Forms.Button();
            this.londonbutton = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.londonpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakupictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // londonpictureBox
            // 
            this.londonpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.londonpictureBox.Image = global::LondonAndBakuTime.Properties.Resources.london;
            this.londonpictureBox.Location = new System.Drawing.Point(0, 0);
            this.londonpictureBox.Name = "londonpictureBox";
            this.londonpictureBox.Size = new System.Drawing.Size(623, 450);
            this.londonpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.londonpictureBox.TabIndex = 1;
            this.londonpictureBox.TabStop = false;
            this.londonpictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonpictureBox_MouseClick);
            // 
            // bakupictureBox
            // 
            this.bakupictureBox.BackgroundImage = global::LondonAndBakuTime.Properties.Resources.baku;
            this.bakupictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakupictureBox.Location = new System.Drawing.Point(0, 0);
            this.bakupictureBox.Name = "bakupictureBox";
            this.bakupictureBox.Size = new System.Drawing.Size(623, 450);
            this.bakupictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bakupictureBox.TabIndex = 0;
            this.bakupictureBox.TabStop = false;
            this.bakupictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakupictureBox_MouseClick);
            // 
            // bakubutton
            // 
            this.bakubutton.AutoSize = true;
            this.bakubutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.bakubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bakubutton.Location = new System.Drawing.Point(185, 354);
            this.bakubutton.Name = "bakubutton";
            this.bakubutton.Size = new System.Drawing.Size(100, 35);
            this.bakubutton.TabIndex = 2;
            this.bakubutton.Text = "Baku";
            this.bakubutton.UseVisualStyleBackColor = false;
            this.bakubutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakubutton_MouseClick);
            // 
            // londonbutton
            // 
            this.londonbutton.AutoSize = true;
            this.londonbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.londonbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.londonbutton.Location = new System.Drawing.Point(331, 354);
            this.londonbutton.Name = "londonbutton";
            this.londonbutton.Size = new System.Drawing.Size(100, 35);
            this.londonbutton.TabIndex = 2;
            this.londonbutton.Text = "London";
            this.londonbutton.UseVisualStyleBackColor = false;
            this.londonbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonbutton_MouseClick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timelabel.Location = new System.Drawing.Point(110, 66);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(63, 25);
            this.timelabel.TabIndex = 3;
            this.timelabel.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.londonbutton);
            this.Controls.Add(this.bakubutton);
            this.Controls.Add(this.londonpictureBox);
            this.Controls.Add(this.bakupictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.londonpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakupictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bakupictureBox;
        private System.Windows.Forms.PictureBox londonpictureBox;
        private System.Windows.Forms.Button bakubutton;
        private System.Windows.Forms.Button londonbutton;
        private System.Windows.Forms.Label timelabel;
    }
}

