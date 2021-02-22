
namespace Dolgozat
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
            this.rab_red = new System.Windows.Forms.RadioButton();
            this.rab_yellow = new System.Windows.Forms.RadioButton();
            this.rab_green = new System.Windows.Forms.RadioButton();
            this.rab_blue = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cb_upper = new System.Windows.Forms.CheckBox();
            this.rtb_write = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_asd = new System.Windows.Forms.Label();
            this.b_rogzit = new System.Windows.Forms.Button();
            this.tb_read = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.b_szamol = new System.Windows.Forms.Button();
            this.tb_atfogo = new System.Windows.Forms.TextBox();
            this.tb_kerulet = new System.Windows.Forms.TextBox();
            this.tb_terulet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rab_red
            // 
            this.rab_red.AutoSize = true;
            this.rab_red.Location = new System.Drawing.Point(108, 18);
            this.rab_red.Name = "rab_red";
            this.rab_red.Size = new System.Drawing.Size(48, 17);
            this.rab_red.TabIndex = 0;
            this.rab_red.TabStop = true;
            this.rab_red.Text = "Piros";
            this.rab_red.UseVisualStyleBackColor = true;
            this.rab_red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rab_yellow
            // 
            this.rab_yellow.AutoSize = true;
            this.rab_yellow.Location = new System.Drawing.Point(108, 41);
            this.rab_yellow.Name = "rab_yellow";
            this.rab_yellow.Size = new System.Drawing.Size(53, 17);
            this.rab_yellow.TabIndex = 1;
            this.rab_yellow.TabStop = true;
            this.rab_yellow.Text = "Sárga";
            this.rab_yellow.UseVisualStyleBackColor = true;
            this.rab_yellow.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rab_green
            // 
            this.rab_green.AutoSize = true;
            this.rab_green.Location = new System.Drawing.Point(108, 65);
            this.rab_green.Name = "rab_green";
            this.rab_green.Size = new System.Drawing.Size(46, 17);
            this.rab_green.TabIndex = 2;
            this.rab_green.TabStop = true;
            this.rab_green.Text = "Zöld";
            this.rab_green.UseVisualStyleBackColor = true;
            this.rab_green.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rab_blue
            // 
            this.rab_blue.AutoSize = true;
            this.rab_blue.Location = new System.Drawing.Point(108, 89);
            this.rab_blue.Name = "rab_blue";
            this.rab_blue.Size = new System.Drawing.Size(44, 17);
            this.rab_blue.TabIndex = 3;
            this.rab_blue.TabStop = true;
            this.rab_blue.Text = "Kék";
            this.rab_blue.UseVisualStyleBackColor = true;
            this.rab_blue.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Első";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Második";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Harmadik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // B_negyedik
            // 
            this.button4.Location = new System.Drawing.Point(409, 74);
            this.button4.Name = "B_negyedik";
            this.button4.Size = new System.Drawing.Size(125, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "Negyedik";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_upper
            // 
            this.cb_upper.AutoSize = true;
            this.cb_upper.Location = new System.Drawing.Point(572, 62);
            this.cb_upper.Name = "cb_upper";
            this.cb_upper.Size = new System.Drawing.Size(124, 17);
            this.cb_upper.TabIndex = 8;
            this.cb_upper.Text = "CSUPA NAGYBETŰ";
            this.cb_upper.UseVisualStyleBackColor = true;
            this.cb_upper.CheckedChanged += new System.EventHandler(this.cb_upper_CheckedChanged);
            // 
            // rtb_write
            // 
            this.rtb_write.Location = new System.Drawing.Point(409, 156);
            this.rtb_write.Name = "rtb_write";
            this.rtb_write.Size = new System.Drawing.Size(261, 131);
            this.rtb_write.TabIndex = 9;
            this.rtb_write.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ide írd a rögzíteni kívánt sort";
            // 
            // l_asd
            // 
            this.l_asd.AutoSize = true;
            this.l_asd.Location = new System.Drawing.Point(206, 223);
            this.l_asd.Name = "l_asd";
            this.l_asd.Size = new System.Drawing.Size(42, 13);
            this.l_asd.TabIndex = 11;
            this.l_asd.Text = "#####";
            // 
            // b_rogzit
            // 
            this.b_rogzit.Location = new System.Drawing.Point(192, 249);
            this.b_rogzit.Name = "b_rogzit";
            this.b_rogzit.Size = new System.Drawing.Size(75, 23);
            this.b_rogzit.TabIndex = 12;
            this.b_rogzit.Text = "Rögzít";
            this.b_rogzit.UseVisualStyleBackColor = true;
            this.b_rogzit.Click += new System.EventHandler(this.b_set_Click);
            // 
            // tb_read
            // 
            this.tb_read.Location = new System.Drawing.Point(128, 188);
            this.tb_read.Name = "tb_read";
            this.tb_read.Size = new System.Drawing.Size(208, 20);
            this.tb_read.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Első befogó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Második befogó";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(142, 331);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 16;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(313, 330);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 17;
            // 
            // b_szamol
            // 
            this.b_szamol.Location = new System.Drawing.Point(500, 327);
            this.b_szamol.Name = "b_szamol";
            this.b_szamol.Size = new System.Drawing.Size(75, 23);
            this.b_szamol.TabIndex = 18;
            this.b_szamol.Text = "Számol";
            this.b_szamol.UseVisualStyleBackColor = true;
            this.b_szamol.Click += new System.EventHandler(this.b_count_Click);
            // 
            // tb_atfogo
            // 
            this.tb_atfogo.Enabled = false;
            this.tb_atfogo.Location = new System.Drawing.Point(142, 389);
            this.tb_atfogo.Name = "tb_atfogo";
            this.tb_atfogo.Size = new System.Drawing.Size(100, 20);
            this.tb_atfogo.TabIndex = 19;
            // 
            // tb_kerulet
            // 
            this.tb_kerulet.Enabled = false;
            this.tb_kerulet.Location = new System.Drawing.Point(324, 389);
            this.tb_kerulet.Name = "tb_kerulet";
            this.tb_kerulet.Size = new System.Drawing.Size(100, 20);
            this.tb_kerulet.TabIndex = 20;
            // 
            // tb_terulet
            // 
            this.tb_terulet.Enabled = false;
            this.tb_terulet.Location = new System.Drawing.Point(500, 388);
            this.tb_terulet.Name = "tb_terulet";
            this.tb_terulet.Size = new System.Drawing.Size(100, 20);
            this.tb_terulet.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "átfogó";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "kerület";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "terület";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_terulet);
            this.Controls.Add(this.tb_kerulet);
            this.Controls.Add(this.tb_atfogo);
            this.Controls.Add(this.b_szamol);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_read);
            this.Controls.Add(this.b_rogzit);
            this.Controls.Add(this.l_asd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_write);
            this.Controls.Add(this.cb_upper);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rab_blue);
            this.Controls.Add(this.rab_green);
            this.Controls.Add(this.rab_yellow);
            this.Controls.Add(this.rab_red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rab_red;
        private System.Windows.Forms.RadioButton rab_yellow;
        private System.Windows.Forms.RadioButton rab_green;
        private System.Windows.Forms.RadioButton rab_blue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cb_upper;
        private System.Windows.Forms.RichTextBox rtb_write;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_asd;
        private System.Windows.Forms.Button b_rogzit;
        private System.Windows.Forms.TextBox tb_read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button b_szamol;
        private System.Windows.Forms.TextBox tb_atfogo;
        private System.Windows.Forms.TextBox tb_kerulet;
        private System.Windows.Forms.TextBox tb_terulet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

