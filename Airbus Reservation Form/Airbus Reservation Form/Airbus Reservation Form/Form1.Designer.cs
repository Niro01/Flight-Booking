namespace Airbus_Reservation_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbSeatRow1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbSeatCol1 = new System.Windows.Forms.MaskedTextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.btnRetrivebooking = new System.Windows.Forms.Button();
            this.btnDeletepassenger = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lstOutput1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome to Air bus Reservation Service";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(84, 93);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(174, 20);
            this.txtName1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(296, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seat No : ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(458, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seat in Place of : ";
            // 
            // mtbSeatRow1
            // 
            this.mtbSeatRow1.Location = new System.Drawing.Point(384, 92);
            this.mtbSeatRow1.Name = "mtbSeatRow1";
            this.mtbSeatRow1.Size = new System.Drawing.Size(52, 20);
            this.mtbSeatRow1.TabIndex = 7;
            // 
            // mtbSeatCol1
            // 
            this.mtbSeatCol1.Location = new System.Drawing.Point(610, 93);
            this.mtbSeatCol1.Name = "mtbSeatCol1";
            this.mtbSeatCol1.Size = new System.Drawing.Size(56, 20);
            this.mtbSeatCol1.TabIndex = 8;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.exitbtn.Location = new System.Drawing.Point(461, 595);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(265, 41);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // btnRetrivebooking
            // 
            this.btnRetrivebooking.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRetrivebooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrivebooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetrivebooking.Location = new System.Drawing.Point(461, 235);
            this.btnRetrivebooking.Name = "btnRetrivebooking";
            this.btnRetrivebooking.Size = new System.Drawing.Size(265, 37);
            this.btnRetrivebooking.TabIndex = 10;
            this.btnRetrivebooking.Text = "Retrive Booking";
            this.btnRetrivebooking.UseVisualStyleBackColor = false;
            this.btnRetrivebooking.Click += new System.EventHandler(this.btnRetrivebooking_Click_1);
            // 
            // btnDeletepassenger
            // 
            this.btnDeletepassenger.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeletepassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeletepassenger.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDeletepassenger.Location = new System.Drawing.Point(461, 436);
            this.btnDeletepassenger.Name = "btnDeletepassenger";
            this.btnDeletepassenger.Size = new System.Drawing.Size(265, 45);
            this.btnDeletepassenger.TabIndex = 11;
            this.btnDeletepassenger.Text = "Delete Passenger";
            this.btnDeletepassenger.UseVisualStyleBackColor = false;
            this.btnDeletepassenger.Click += new System.EventHandler(this.btnDeletepassenger_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(461, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save to File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(18, 169);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(171, 290);
            this.lstOutput.TabIndex = 13;
            // 
            // lstOutput1
            // 
            this.lstOutput1.FormattingEnabled = true;
            this.lstOutput1.Location = new System.Drawing.Point(210, 169);
            this.lstOutput1.Name = "lstOutput1";
            this.lstOutput1.Size = new System.Drawing.Size(226, 290);
            this.lstOutput1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Economy Class";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "First Class";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "First Class Seat Preference\r\n\r\n";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 131);
            this.label8.TabIndex = 18;
            this.label8.Text = "A = Window side(Left).\r\nB = Aisle.\r\nC = Aisle.\r\nD = Window side(Right).\r\n20 Seats" +
    ".\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(461, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sort by Seat No";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Location = new System.Drawing.Point(461, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sort by Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "A    B    C    D    E    F  ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "A    B    C    D";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(210, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 131);
            this.label11.TabIndex = 23;
            this.label11.Text = "A = Window side(Left).\r\nB = Centre.\r\nC = Aisle.\r\nD = Aisle.\r\nE = Centre.\r\nF = Win" +
    "dow Side (Right).\r\n180 Seats.\r\n";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(208, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Economy Seat Preference\r\n\r\n";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(12, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(666, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "This is Flaxible Reservation form. Please Enter valid Name, Seat Number and Seat " +
    "in Place.\r\n\r\n";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label14.Location = new System.Drawing.Point(565, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label15.Location = new System.Drawing.Point(565, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 21);
            this.label15.TabIndex = 27;
            this.label15.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 660);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstOutput1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeletepassenger);
            this.Controls.Add(this.btnRetrivebooking);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.mtbSeatCol1);
            this.Controls.Add(this.mtbSeatRow1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Airbus Reservation Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbSeatRow1;
        private System.Windows.Forms.MaskedTextBox mtbSeatCol1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button btnRetrivebooking;
        private System.Windows.Forms.Button btnDeletepassenger;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.ListBox lstOutput1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
    }
}

