namespace first_example_of_ca242
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.lpldisplay = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.txtthirdname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(484, 34);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(222, 26);
            this.txtfname.TabIndex = 0;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(484, 88);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(222, 26);
            this.txtsname.TabIndex = 1;
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay.Location = new System.Drawing.Point(160, 227);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(0, 46);
            this.lbldisplay.TabIndex = 2;
            // 
            // lpldisplay
            // 
            this.lpldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpldisplay.Location = new System.Drawing.Point(333, 203);
            this.lpldisplay.Name = "lpldisplay";
            this.lpldisplay.Size = new System.Drawing.Size(519, 56);
            this.lpldisplay.TabIndex = 3;
            this.lpldisplay.Click += new System.EventHandler(this.lpldisplay_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.AutoSize = true;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.Color.Red;
            this.btndisplay.Location = new System.Drawing.Point(30, 370);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(285, 56);
            this.btndisplay.TabIndex = 4;
            this.btndisplay.Text = "show fullname";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // txtthirdname
            // 
            this.txtthirdname.Location = new System.Drawing.Point(484, 136);
            this.txtthirdname.Name = "txtthirdname";
            this.txtthirdname.Size = new System.Drawing.Size(222, 26);
            this.txtthirdname.TabIndex = 5;
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(368, 370);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(117, 56);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblfname
            // 
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(127, 34);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(358, 40);
            this.lblfname.TabIndex = 8;
            this.lblfname.Text = "Enter Your First Name :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Your Third Name :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Your Second Name :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Full Name is :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(604, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtthirdname);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.lpldisplay);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtfname);
            this.Name = "Form1";
            this.Text = "home page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label lpldisplay;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.TextBox txtthirdname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

