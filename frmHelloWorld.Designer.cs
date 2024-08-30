namespace Hello_World
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.pbHelloWorld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelloWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(368, 431);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(75, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Hello World!";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.SystemColors.Window;
            this.lblHelloWorld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHelloWorld.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(426, 348);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(152, 27);
            this.lblHelloWorld.TabIndex = 2;
            this.lblHelloWorld.Text = "Hello World!!!";
            // 
            // pbHelloWorld
            // 
            this.pbHelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("pbHelloWorld.Image")));
            this.pbHelloWorld.Location = new System.Drawing.Point(409, 504);
            this.pbHelloWorld.Name = "pbHelloWorld";
            this.pbHelloWorld.Size = new System.Drawing.Size(169, 95);
            this.pbHelloWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelloWorld.TabIndex = 3;
            this.pbHelloWorld.TabStop = false;
            this.pbHelloWorld.Click += new System.EventHandler(this.pbHelloWorld_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 680);
            this.Controls.Add(this.pbHelloWorld);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "frmHelloWorld";
            ((System.ComponentModel.ISupportInitialize)(this.pbHelloWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox pbHelloWorld;
    }
}

