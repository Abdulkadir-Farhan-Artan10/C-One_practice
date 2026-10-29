namespace STUDENT_Course_Registration_System
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_coursename = new System.Windows.Forms.TextBox();
            this.txt_courseprice = new System.Windows.Forms.TextBox();
            this.btn_addcourse = new System.Windows.Forms.Button();
            this.btn_removecourse = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.listBox_coursename_courseprice = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_registeredcourse = new System.Windows.Forms.TextBox();
            this.listBox_registration_result = new System.Windows.Forms.ListBox();
            this.txt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter student ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter student Age: ";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(271, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(260, 28);
            this.txt_id.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(271, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(260, 28);
            this.txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(271, 126);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(260, 28);
            this.txt_age.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course Price : ";
            // 
            // txt_coursename
            // 
            this.txt_coursename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursename.Location = new System.Drawing.Point(375, 206);
            this.txt_coursename.Name = "txt_coursename";
            this.txt_coursename.Size = new System.Drawing.Size(260, 28);
            this.txt_coursename.TabIndex = 3;
            // 
            // txt_courseprice
            // 
            this.txt_courseprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_courseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courseprice.Location = new System.Drawing.Point(375, 315);
            this.txt_courseprice.Name = "txt_courseprice";
            this.txt_courseprice.Size = new System.Drawing.Size(260, 28);
            this.txt_courseprice.TabIndex = 5;
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Location = new System.Drawing.Point(81, 509);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(158, 59);
            this.btn_addcourse.TabIndex = 6;
            this.btn_addcourse.Text = "Add Course";
            this.btn_addcourse.UseVisualStyleBackColor = true;
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // btn_removecourse
            // 
            this.btn_removecourse.Location = new System.Drawing.Point(297, 509);
            this.btn_removecourse.Name = "btn_removecourse";
            this.btn_removecourse.Size = new System.Drawing.Size(158, 59);
            this.btn_removecourse.TabIndex = 8;
            this.btn_removecourse.Text = "Remove Course";
            this.btn_removecourse.UseVisualStyleBackColor = true;
            this.btn_removecourse.Click += new System.EventHandler(this.btn_removecourse_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(531, 497);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(158, 59);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // listBox_coursename_courseprice
            // 
            this.listBox_coursename_courseprice.FormattingEnabled = true;
            this.listBox_coursename_courseprice.ItemHeight = 20;
            this.listBox_coursename_courseprice.Location = new System.Drawing.Point(695, 12);
            this.listBox_coursename_courseprice.Name = "listBox_coursename_courseprice";
            this.listBox_coursename_courseprice.Size = new System.Drawing.Size(234, 404);
            this.listBox_coursename_courseprice.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Of Registered Course: ";
            // 
            // txt_registeredcourse
            // 
            this.txt_registeredcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_registeredcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registeredcourse.Location = new System.Drawing.Point(375, 255);
            this.txt_registeredcourse.Name = "txt_registeredcourse";
            this.txt_registeredcourse.Size = new System.Drawing.Size(260, 28);
            this.txt_registeredcourse.TabIndex = 4;
            // 
            // listBox_registration_result
            // 
            this.listBox_registration_result.FormattingEnabled = true;
            this.listBox_registration_result.ItemHeight = 20;
            this.listBox_registration_result.Location = new System.Drawing.Point(1017, 12);
            this.listBox_registration_result.Name = "listBox_registration_result";
            this.listBox_registration_result.Size = new System.Drawing.Size(375, 544);
            this.listBox_registration_result.TabIndex = 16;
            // 
            // txt_close
            // 
            this.txt_close.Location = new System.Drawing.Point(782, 497);
            this.txt_close.Name = "txt_close";
            this.txt_close.Size = new System.Drawing.Size(158, 59);
            this.txt_close.TabIndex = 9;
            this.txt_close.Text = "exit";
            this.txt_close.UseVisualStyleBackColor = true;
            this.txt_close.Click += new System.EventHandler(this.txt_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 636);
            this.Controls.Add(this.txt_close);
            this.Controls.Add(this.listBox_registration_result);
            this.Controls.Add(this.txt_registeredcourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_coursename_courseprice);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_removecourse);
            this.Controls.Add(this.btn_addcourse);
            this.Controls.Add(this.txt_courseprice);
            this.Controls.Add(this.txt_coursename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_coursename;
        private System.Windows.Forms.TextBox txt_courseprice;
        private System.Windows.Forms.Button btn_addcourse;
        private System.Windows.Forms.Button btn_removecourse;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ListBox listBox_coursename_courseprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_registeredcourse;
        private System.Windows.Forms.ListBox listBox_registration_result;
        private System.Windows.Forms.Button txt_close;
    }
}

