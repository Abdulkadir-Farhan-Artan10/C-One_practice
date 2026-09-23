namespace home_assignment
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
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtnumericofthemonth = new System.Windows.Forms.TextBox();
            this.txtnameofthemonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbldayOfTheWeek = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblnumericmonth = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(52, 241);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(822, 59);
            this.lbloutput.TabIndex = 4;
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(380, 23);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(352, 35);
            this.txtdayoftheweek.TabIndex = 5;
            // 
            // txtnumericofthemonth
            // 
            this.txtnumericofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumericofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumericofthemonth.Location = new System.Drawing.Point(380, 123);
            this.txtnumericofthemonth.Name = "txtnumericofthemonth";
            this.txtnumericofthemonth.Size = new System.Drawing.Size(352, 35);
            this.txtnumericofthemonth.TabIndex = 6;
            // 
            // txtnameofthemonth
            // 
            this.txtnameofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnameofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameofthemonth.Location = new System.Drawing.Point(380, 68);
            this.txtnameofthemonth.Name = "txtnameofthemonth";
            this.txtnameofthemonth.Size = new System.Drawing.Size(352, 35);
            this.txtnameofthemonth.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(380, 175);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(352, 35);
            this.txtyear.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.ForeColor = System.Drawing.Color.Red;
            this.btnshowdate.Location = new System.Drawing.Point(139, 351);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(158, 48);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(363, 351);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(180, 46);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(625, 351);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(157, 46);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbldayOfTheWeek
            // 
            this.lbldayOfTheWeek.AutoSize = true;
            this.lbldayOfTheWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayOfTheWeek.Location = new System.Drawing.Point(125, 23);
            this.lbldayOfTheWeek.Name = "lbldayOfTheWeek";
            this.lbldayOfTheWeek.Size = new System.Drawing.Size(211, 22);
            this.lbldayOfTheWeek.TabIndex = 0;
            this.lbldayOfTheWeek.Text = "Enter day of the week:";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(193, 175);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(143, 22);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter the year:";
            // 
            // lblnumericmonth
            // 
            this.lblnumericmonth.AutoSize = true;
            this.lblnumericmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumericmonth.Location = new System.Drawing.Point(45, 131);
            this.lblnumericmonth.Name = "lblnumericmonth";
            this.lblnumericmonth.Size = new System.Drawing.Size(291, 22);
            this.lblnumericmonth.TabIndex = 2;
            this.lblnumericmonth.Text = "Enter the numeric of the Month:";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(94, 68);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(242, 22);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter name of The Month:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 528);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnameofthemonth);
            this.Controls.Add(this.txtnumericofthemonth);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumericmonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldayOfTheWeek);
            this.Name = "Form1";
            this.Text = "Birrth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtnumericofthemonth;
        private System.Windows.Forms.TextBox txtnameofthemonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbldayOfTheWeek;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblnumericmonth;
        private System.Windows.Forms.Label lblnameofthemonth;
    }
}

