namespace Deen_Qaadasho
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
            this.lblsalery = new System.Windows.Forms.Label();
            this.lblye = new System.Windows.Forms.Label();
            this.lbloutpu = new System.Windows.Forms.Label();
            this.txtsalery = new System.Windows.Forms.TextBox();
            this.txtyeaar = new System.Windows.Forms.TextBox();
            this.BTNCLEAR = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsalery
            // 
            this.lblsalery.AutoSize = true;
            this.lblsalery.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalery.Location = new System.Drawing.Point(167, 62);
            this.lblsalery.Name = "lblsalery";
            this.lblsalery.Size = new System.Drawing.Size(157, 23);
            this.lblsalery.TabIndex = 0;
            this.lblsalery.Text = "Enter your salery";
            // 
            // lblye
            // 
            this.lblye.AutoSize = true;
            this.lblye.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblye.Location = new System.Drawing.Point(167, 120);
            this.lblye.Name = "lblye";
            this.lblye.Size = new System.Drawing.Size(136, 23);
            this.lblye.TabIndex = 1;
            this.lblye.Text = "Enter year exp";
            // 
            // lbloutpu
            // 
            this.lbloutpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutpu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutpu.Location = new System.Drawing.Point(12, 253);
            this.lbloutpu.Name = "lbloutpu";
            this.lbloutpu.Size = new System.Drawing.Size(737, 42);
            this.lbloutpu.TabIndex = 2;
            this.lbloutpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsalery
            // 
            this.txtsalery.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalery.Location = new System.Drawing.Point(386, 62);
            this.txtsalery.Name = "txtsalery";
            this.txtsalery.Size = new System.Drawing.Size(302, 30);
            this.txtsalery.TabIndex = 0;
            this.txtsalery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtyeaar
            // 
            this.txtyeaar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyeaar.Location = new System.Drawing.Point(386, 120);
            this.txtyeaar.Name = "txtyeaar";
            this.txtyeaar.Size = new System.Drawing.Size(302, 30);
            this.txtyeaar.TabIndex = 1;
            this.txtyeaar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BTNCLEAR
            // 
            this.BTNCLEAR.Location = new System.Drawing.Point(228, 323);
            this.BTNCLEAR.Name = "BTNCLEAR";
            this.BTNCLEAR.Size = new System.Drawing.Size(75, 76);
            this.BTNCLEAR.TabIndex = 4;
            this.BTNCLEAR.Text = "CLEA&R";
            this.BTNCLEAR.UseVisualStyleBackColor = true;
            this.BTNCLEAR.Click += new System.EventHandler(this.BTNCLEAR_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(115, 323);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 76);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "&CHECK";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.BTNCLEAR);
            this.Controls.Add(this.txtyeaar);
            this.Controls.Add(this.txtsalery);
            this.Controls.Add(this.lbloutpu);
            this.Controls.Add(this.lblye);
            this.Controls.Add(this.lblsalery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsalery;
        private System.Windows.Forms.Label lblye;
        private System.Windows.Forms.Label lbloutpu;
        private System.Windows.Forms.TextBox txtsalery;
        private System.Windows.Forms.TextBox txtyeaar;
        private System.Windows.Forms.Button BTNCLEAR;
        private System.Windows.Forms.Button btncheck;
    }
}

