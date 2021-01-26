namespace CatsAndDogs
{
    partial class Form1
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.getADog = new System.Windows.Forms.Button();
            this.catPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(702, 12);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(390, 252);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            // 
            // getADog
            // 
            this.getADog.Location = new System.Drawing.Point(873, 291);
            this.getADog.Name = "getADog";
            this.getADog.Size = new System.Drawing.Size(150, 29);
            this.getADog.TabIndex = 1;
            this.getADog.Text = "Get Dog Image";
            this.getADog.UseVisualStyleBackColor = true;
            this.getADog.Click += new System.EventHandler(this.getADog_Click);
            // 
            // catPicture
            // 
            this.catPicture.Location = new System.Drawing.Point(63, 12);
            this.catPicture.Name = "catPicture";
            this.catPicture.Size = new System.Drawing.Size(391, 252);
            this.catPicture.TabIndex = 2;
            this.catPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Cat Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catPicture);
            this.Controls.Add(this.getADog);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button getADog;
        private System.Windows.Forms.PictureBox catPicture;
        private System.Windows.Forms.Button button1;
    }
}

