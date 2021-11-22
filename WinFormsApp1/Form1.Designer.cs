namespace WinFormsApp1
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
            this.mainDisplay = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDoStuff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.Location = new System.Drawing.Point(96, 12);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(692, 340);
            this.mainDisplay.TabIndex = 0;
            this.mainDisplay.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDoStuff
            // 
            this.btnDoStuff.Location = new System.Drawing.Point(12, 41);
            this.btnDoStuff.Name = "btnDoStuff";
            this.btnDoStuff.Size = new System.Drawing.Size(75, 23);
            this.btnDoStuff.TabIndex = 2;
            this.btnDoStuff.Text = "Do Stuff";
            this.btnDoStuff.UseVisualStyleBackColor = true;
            this.btnDoStuff.Click += new System.EventHandler(this.btnDoStuff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoStuff);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mainDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox mainDisplay;
        private Button btnStart;
        private Button btnDoStuff;
    }
}