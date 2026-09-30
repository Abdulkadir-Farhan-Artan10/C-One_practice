namespace assignment2
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblfoodoneprice = new System.Windows.Forms.Label();
            this.lblfoodtwo = new System.Windows.Forms.Label();
            this.lblfoodtwoprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltaxt = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(278, 15);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(191, 26);
            this.txtfood1.TabIndex = 0;
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(278, 77);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(191, 26);
            this.txtprice1.TabIndex = 1;
            this.txtprice1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(268, 141);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(191, 26);
            this.txtfood2.TabIndex = 2;
            // 
            // txtprice2
            // 
            this.txtprice2.Location = new System.Drawing.Point(268, 217);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(191, 26);
            this.txtprice2.TabIndex = 3;
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Location = new System.Drawing.Point(79, 18);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(119, 20);
            this.lblfood1.TabIndex = 4;
            this.lblfood1.Text = "Enter  food one";
            // 
            // lblfoodoneprice
            // 
            this.lblfoodoneprice.AutoSize = true;
            this.lblfoodoneprice.Location = new System.Drawing.Point(79, 67);
            this.lblfoodoneprice.Name = "lblfoodoneprice";
            this.lblfoodoneprice.Size = new System.Drawing.Size(153, 20);
            this.lblfoodoneprice.TabIndex = 5;
            this.lblfoodoneprice.Text = "Enter food one price";
            // 
            // lblfoodtwo
            // 
            this.lblfoodtwo.AutoSize = true;
            this.lblfoodtwo.Location = new System.Drawing.Point(79, 141);
            this.lblfoodtwo.Name = "lblfoodtwo";
            this.lblfoodtwo.Size = new System.Drawing.Size(115, 20);
            this.lblfoodtwo.TabIndex = 6;
            this.lblfoodtwo.Text = "enter  food two";
            // 
            // lblfoodtwoprice
            // 
            this.lblfoodtwoprice.AutoSize = true;
            this.lblfoodtwoprice.Location = new System.Drawing.Point(79, 223);
            this.lblfoodtwoprice.Name = "lblfoodtwoprice";
            this.lblfoodtwoprice.Size = new System.Drawing.Size(151, 20);
            this.lblfoodtwoprice.TabIndex = 7;
            this.lblfoodtwoprice.Text = "Enter food two price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltaxt
            // 
            this.lbltaxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltaxt.Location = new System.Drawing.Point(241, 327);
            this.lbltaxt.Name = "lbltaxt";
            this.lbltaxt.Size = new System.Drawing.Size(277, 54);
            this.lbltaxt.TabIndex = 9;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalamount.Location = new System.Drawing.Point(241, 397);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(277, 54);
            this.lbltotalamount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "salex taxt is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "total_amount is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltaxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblfoodtwoprice);
            this.Controls.Add(this.lblfoodtwo);
            this.Controls.Add(this.lblfoodoneprice);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblfoodoneprice;
        private System.Windows.Forms.Label lblfoodtwo;
        private System.Windows.Forms.Label lblfoodtwoprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltaxt;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

