namespace The_birthday_problem
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
            this.storyoutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choise1 = new System.Windows.Forms.Button();
            this.choise2 = new System.Windows.Forms.Button();
            this.choise1output = new System.Windows.Forms.Label();
            this.choise2output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // storyoutput
            // 
            this.storyoutput.BackColor = System.Drawing.Color.Black;
            this.storyoutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyoutput.Location = new System.Drawing.Point(83, 9);
            this.storyoutput.Name = "storyoutput";
            this.storyoutput.Size = new System.Drawing.Size(557, 121);
            this.storyoutput.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 220);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // choise1
            // 
            this.choise1.Location = new System.Drawing.Point(101, 388);
            this.choise1.Name = "choise1";
            this.choise1.Size = new System.Drawing.Size(75, 23);
            this.choise1.TabIndex = 2;
            this.choise1.Text = "1";
            this.choise1.UseVisualStyleBackColor = true;
            this.choise1.Click += new System.EventHandler(this.choise1_Click);
            // 
            // choise2
            // 
            this.choise2.Location = new System.Drawing.Point(492, 388);
            this.choise2.Name = "choise2";
            this.choise2.Size = new System.Drawing.Size(75, 23);
            this.choise2.TabIndex = 3;
            this.choise2.Text = "2";
            this.choise2.UseVisualStyleBackColor = true;
            this.choise2.Click += new System.EventHandler(this.choise2_Click);
            // 
            // choise1output
            // 
            this.choise1output.Location = new System.Drawing.Point(182, 391);
            this.choise1output.Name = "choise1output";
            this.choise1output.Size = new System.Drawing.Size(227, 20);
            this.choise1output.TabIndex = 4;
            this.choise1output.Click += new System.EventHandler(this.choise1output_Click);
            // 
            // choise2output
            // 
            this.choise2output.Location = new System.Drawing.Point(589, 391);
            this.choise2output.Name = "choise2output";
            this.choise2output.Size = new System.Drawing.Size(180, 18);
            this.choise2output.TabIndex = 5;
            this.choise2output.Click += new System.EventHandler(this.choise2output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choise2output);
            this.Controls.Add(this.choise1output);
            this.Controls.Add(this.choise2);
            this.Controls.Add(this.choise1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.storyoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storyoutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choise1;
        private System.Windows.Forms.Button choise2;
        private System.Windows.Forms.Label choise1output;
        private System.Windows.Forms.Label choise2output;
    }
}

