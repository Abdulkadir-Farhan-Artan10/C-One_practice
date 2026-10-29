namespace Example_chapter2
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
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.btnshowInfo = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(264, 44);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(192, 26);
            this.txtage.TabIndex = 0;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(264, 101);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(192, 26);
            this.txtsalary.TabIndex = 1;
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(264, 160);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(192, 26);
            this.txtgrade.TabIndex = 2;
            // 
            // btnshowInfo
            // 
            this.btnshowInfo.Location = new System.Drawing.Point(169, 284);
            this.btnshowInfo.Name = "btnshowInfo";
            this.btnshowInfo.Size = new System.Drawing.Size(129, 68);
            this.btnshowInfo.TabIndex = 3;
            this.btnshowInfo.Text = "showInfo";
            this.btnshowInfo.UseVisualStyleBackColor = true;
            this.btnshowInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(32, 211);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(251, 51);
            this.lbloutput.TabIndex = 4;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(586, 294);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 48);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(342, 294);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 48);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnshowInfo);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Button btnshowInfo;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

