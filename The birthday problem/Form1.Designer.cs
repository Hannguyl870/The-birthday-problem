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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option1Lable = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storyoutput
            // 
            this.storyoutput.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.storyoutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyoutput.Location = new System.Drawing.Point(87, 9);
            this.storyoutput.Name = "storyoutput";
            this.storyoutput.Size = new System.Drawing.Size(510, 121);
            this.storyoutput.TabIndex = 0;
            this.storyoutput.Click += new System.EventHandler(this.storyoutput_Click);
            // 
            // imageBox
            // 
            this.imageBox.ErrorImage = null;
            this.imageBox.Image = global::The_birthday_problem.Properties.Resources.happy_birthday;
            this.imageBox.InitialImage = null;
            this.imageBox.Location = new System.Drawing.Point(87, 68);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(562, 264);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(101, 388);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(75, 23);
            this.option1.TabIndex = 2;
            this.option1.Text = "1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.choise1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(492, 388);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(75, 23);
            this.option2.TabIndex = 3;
            this.option2.Text = "2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.choise2_Click);
            // 
            // option1Lable
            // 
            this.option1Lable.Location = new System.Drawing.Point(182, 391);
            this.option1Lable.Name = "option1Lable";
            this.option1Lable.Size = new System.Drawing.Size(227, 20);
            this.option1Lable.TabIndex = 4;
            this.option1Lable.Click += new System.EventHandler(this.choise1output_Click);
            // 
            // option2Label
            // 
            this.option2Label.Location = new System.Drawing.Point(589, 391);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(180, 18);
            this.option2Label.TabIndex = 5;
            this.option2Label.Click += new System.EventHandler(this.choise2output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Lable);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.storyoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storyoutput;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Label option1Lable;
        private System.Windows.Forms.Label option2Label;
    }
}

