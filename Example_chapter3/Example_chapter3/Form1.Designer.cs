namespace Example_chapter3
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_computer = new System.Windows.Forms.CheckBox();
            this.checkBox_it = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnremoveat = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtremoveditems = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Age :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(256, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 30);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(256, 75);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(234, 30);
            this.txtage.TabIndex = 5;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(97, 204);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(68, 24);
            this.radioButton_male.TabIndex = 6;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(199, 204);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(87, 24);
            this.radioButton_female.TabIndex = 7;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Location = new System.Drawing.Point(85, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 136);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Faculty";
            // 
            // checkBox_computer
            // 
            this.checkBox_computer.AutoSize = true;
            this.checkBox_computer.Location = new System.Drawing.Point(87, 370);
            this.checkBox_computer.Name = "checkBox_computer";
            this.checkBox_computer.Size = new System.Drawing.Size(105, 24);
            this.checkBox_computer.TabIndex = 11;
            this.checkBox_computer.Text = "Computer";
            this.checkBox_computer.UseVisualStyleBackColor = true;
            // 
            // checkBox_it
            // 
            this.checkBox_it.AutoSize = true;
            this.checkBox_it.Location = new System.Drawing.Point(226, 370);
            this.checkBox_it.Name = "checkBox_it";
            this.checkBox_it.Size = new System.Drawing.Size(49, 24);
            this.checkBox_it.TabIndex = 12;
            this.checkBox_it.Text = "IT";
            this.checkBox_it.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Location = new System.Drawing.Point(73, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 146);
            this.panel2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(776, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 284);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(511, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 63);
            this.button2.TabIndex = 16;
            this.button2.Text = "Select Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(427, 310);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(124, 64);
            this.btnremove.TabIndex = 18;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnremoveat
            // 
            this.btnremoveat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveat.Location = new System.Drawing.Point(591, 310);
            this.btnremoveat.Name = "btnremoveat";
            this.btnremoveat.Size = new System.Drawing.Size(162, 64);
            this.btnremoveat.TabIndex = 19;
            this.btnremoveat.Text = "Remove At";
            this.btnremoveat.UseVisualStyleBackColor = true;
            this.btnremoveat.Click += new System.EventHandler(this.btnremoveat_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(702, 402);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(124, 64);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "REmoved Items : ";
            // 
            // txtremoveditems
            // 
            this.txtremoveditems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtremoveditems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremoveditems.Location = new System.Drawing.Point(328, 198);
            this.txtremoveditems.Name = "txtremoveditems";
            this.txtremoveditems.Size = new System.Drawing.Size(350, 30);
            this.txtremoveditems.TabIndex = 22;
            // 
            // btncount
            // 
            this.btncount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncount.Location = new System.Drawing.Point(702, 493);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(124, 64);
            this.btncount.TabIndex = 23;
            this.btncount.Text = "count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // lblcount
            // 
            this.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(276, 537);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(343, 37);
            this.lblcount.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 649);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.txtremoveditems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremoveat);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox_it);
            this.Controls.Add(this.checkBox_computer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_computer;
        private System.Windows.Forms.CheckBox checkBox_it;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnremoveat;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtremoveditems;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Label lblcount;
    }
}

