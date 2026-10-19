namespace Hotel_Room_Booking_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_guestname = new System.Windows.Forms.TextBox();
            this.txt_guestage = new System.Windows.Forms.TextBox();
            this.txt_numofnights = new System.Windows.Forms.TextBox();
            this.txt_numofguests = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_standard = new System.Windows.Forms.RadioButton();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_hight = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_breakfast = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.listBox_booking_details = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1233, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number Of Nights :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number Of Guests :";
            // 
            // txt_guestname
            // 
            this.txt_guestname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guestname.Location = new System.Drawing.Point(251, 100);
            this.txt_guestname.Name = "txt_guestname";
            this.txt_guestname.Size = new System.Drawing.Size(234, 28);
            this.txt_guestname.TabIndex = 5;
            // 
            // txt_guestage
            // 
            this.txt_guestage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_guestage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guestage.Location = new System.Drawing.Point(251, 148);
            this.txt_guestage.Name = "txt_guestage";
            this.txt_guestage.Size = new System.Drawing.Size(234, 28);
            this.txt_guestage.TabIndex = 6;
            // 
            // txt_numofnights
            // 
            this.txt_numofnights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numofnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numofnights.Location = new System.Drawing.Point(251, 194);
            this.txt_numofnights.Name = "txt_numofnights";
            this.txt_numofnights.Size = new System.Drawing.Size(234, 28);
            this.txt_numofnights.TabIndex = 7;
            // 
            // txt_numofguests
            // 
            this.txt_numofguests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numofguests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numofguests.Location = new System.Drawing.Point(251, 241);
            this.txt_numofguests.Name = "txt_numofguests";
            this.txt_numofguests.Size = new System.Drawing.Size(234, 28);
            this.txt_numofguests.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 251);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // radioButton_standard
            // 
            this.radioButton_standard.AutoSize = true;
            this.radioButton_standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_standard.Location = new System.Drawing.Point(47, 358);
            this.radioButton_standard.Name = "radioButton_standard";
            this.radioButton_standard.Size = new System.Drawing.Size(125, 29);
            this.radioButton_standard.TabIndex = 10;
            this.radioButton_standard.TabStop = true;
            this.radioButton_standard.Text = "Standard";
            this.radioButton_standard.UseVisualStyleBackColor = true;
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_normal.Location = new System.Drawing.Point(201, 52);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(105, 29);
            this.radioButton_normal.TabIndex = 11;
            this.radioButton_normal.TabStop = true;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_hight
            // 
            this.radioButton_hight.AutoSize = true;
            this.radioButton_hight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_hight.Location = new System.Drawing.Point(374, 52);
            this.radioButton_hight.Name = "radioButton_hight";
            this.radioButton_hight.Size = new System.Drawing.Size(87, 29);
            this.radioButton_hight.TabIndex = 12;
            this.radioButton_hight.TabStop = true;
            this.radioButton_hight.Text = "Hight";
            this.radioButton_hight.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.radioButton_hight);
            this.groupBox2.Controls.Add(this.radioButton_normal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 112);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 115);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Options";
            // 
            // checkBox_breakfast
            // 
            this.checkBox_breakfast.AutoSize = true;
            this.checkBox_breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_breakfast.Location = new System.Drawing.Point(58, 500);
            this.checkBox_breakfast.Name = "checkBox_breakfast";
            this.checkBox_breakfast.Size = new System.Drawing.Size(380, 29);
            this.checkBox_breakfast.TabIndex = 15;
            this.checkBox_breakfast.Text = "BreakFast(10 per Guest per Nights)";
            this.checkBox_breakfast.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(127, 576);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(155, 37);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(328, 576);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(122, 37);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(513, 576);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(114, 37);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "Exit";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // listBox_booking_details
            // 
            this.listBox_booking_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_booking_details.FormattingEnabled = true;
            this.listBox_booking_details.ItemHeight = 25;
            this.listBox_booking_details.Location = new System.Drawing.Point(801, 62);
            this.listBox_booking_details.Name = "listBox_booking_details";
            this.listBox_booking_details.Size = new System.Drawing.Size(368, 454);
            this.listBox_booking_details.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 658);
            this.Controls.Add(this.listBox_booking_details);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.checkBox_breakfast);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioButton_standard);
            this.Controls.Add(this.txt_numofguests);
            this.Controls.Add(this.txt_numofnights);
            this.Controls.Add(this.txt_guestage);
            this.Controls.Add(this.txt_guestname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Hotel Room Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_guestname;
        private System.Windows.Forms.TextBox txt_guestage;
        private System.Windows.Forms.TextBox txt_numofnights;
        private System.Windows.Forms.TextBox txt_numofguests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_standard;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_hight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_breakfast;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ListBox listBox_booking_details;
    }
}

