namespace ColorHexPicker
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
            this.pnColor = new System.Windows.Forms.Panel();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.tG = new System.Windows.Forms.TextBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.tR = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TrackBar();
            this.tApha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyRGB = new System.Windows.Forms.Button();
            this.customContainer1 = new ColorHexPicker.CustomContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnColor
            // 
            this.pnColor.Location = new System.Drawing.Point(20, 71);
            this.pnColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(136, 279);
            this.pnColor.TabIndex = 0;
            // 
            // tbRed
            // 
            this.tbRed.AutoSize = false;
            this.tbRed.LargeChange = 1;
            this.tbRed.Location = new System.Drawing.Point(180, 55);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(412, 39);
            this.tbRed.TabIndex = 1;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRed.Scroll += new System.EventHandler(this.scroll_activity);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(20, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Off";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbG
            // 
            this.tbG.AutoSize = false;
            this.tbG.LargeChange = 1;
            this.tbG.Location = new System.Drawing.Point(180, 114);
            this.tbG.Margin = new System.Windows.Forms.Padding(4);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(412, 39);
            this.tbG.TabIndex = 1;
            this.tbG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbG.Scroll += new System.EventHandler(this.scroll_activity);
            // 
            // tbB
            // 
            this.tbB.AutoSize = false;
            this.tbB.LargeChange = 1;
            this.tbB.Location = new System.Drawing.Point(180, 176);
            this.tbB.Margin = new System.Windows.Forms.Padding(4);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(412, 39);
            this.tbB.TabIndex = 1;
            this.tbB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbB.Scroll += new System.EventHandler(this.scroll_activity);
            // 
            // tG
            // 
            this.tG.Location = new System.Drawing.Point(601, 114);
            this.tG.Margin = new System.Windows.Forms.Padding(4);
            this.tG.Name = "tG";
            this.tG.Size = new System.Drawing.Size(80, 24);
            this.tG.TabIndex = 3;
            this.tG.TextChanged += new System.EventHandler(this.tR_TextChanged);
            this.tG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tApha_KeyPress);
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(601, 176);
            this.tB.Margin = new System.Windows.Forms.Padding(4);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(80, 24);
            this.tB.TabIndex = 3;
            this.tB.TextChanged += new System.EventHandler(this.tR_TextChanged);
            this.tB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tApha_KeyPress);
            // 
            // tR
            // 
            this.tR.Location = new System.Drawing.Point(601, 55);
            this.tR.Margin = new System.Windows.Forms.Padding(4);
            this.tR.Name = "tR";
            this.tR.Size = new System.Drawing.Size(80, 24);
            this.tR.TabIndex = 3;
            this.tR.TextChanged += new System.EventHandler(this.tR_TextChanged);
            this.tR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tApha_KeyPress);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(220, 321);
            this.txtHex.Margin = new System.Windows.Forms.Padding(4);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(208, 24);
            this.txtHex.TabIndex = 4;
            this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            // 
            // tbA
            // 
            this.tbA.AutoSize = false;
            this.tbA.LargeChange = 1;
            this.tbA.Location = new System.Drawing.Point(180, 242);
            this.tbA.Margin = new System.Windows.Forms.Padding(4);
            this.tbA.Maximum = 255;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(412, 39);
            this.tbA.TabIndex = 1;
            this.tbA.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbA.Value = 255;
            this.tbA.Scroll += new System.EventHandler(this.scroll_activity);
            // 
            // tApha
            // 
            this.tApha.Location = new System.Drawing.Point(601, 242);
            this.tApha.Margin = new System.Windows.Forms.Padding(4);
            this.tApha.Name = "tApha";
            this.tApha.Size = new System.Drawing.Size(80, 24);
            this.tApha.TabIndex = 3;
            this.tApha.TextChanged += new System.EventHandler(this.tR_TextChanged);
            this.tApha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tApha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "HEX";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Maroon;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(434, 322);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(33, 28);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.Maroon;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParse.Image = ((System.Drawing.Image)(resources.GetObject("btnParse.Image")));
            this.btnParse.Location = new System.Drawing.Point(472, 323);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(38, 28);
            this.btnParse.TabIndex = 6;
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(220, 289);
            this.txtRGB.Margin = new System.Windows.Forms.Padding(4);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.ReadOnly = true;
            this.txtRGB.Size = new System.Drawing.Size(208, 24);
            this.txtRGB.TabIndex = 4;
            this.txtRGB.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "RGB";
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.BackColor = System.Drawing.Color.Firebrick;
            this.btnCopyRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyRGB.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyRGB.Image")));
            this.btnCopyRGB.Location = new System.Drawing.Point(434, 284);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(33, 33);
            this.btnCopyRGB.TabIndex = 6;
            this.btnCopyRGB.UseVisualStyleBackColor = false;
            this.btnCopyRGB.Click += new System.EventHandler(this.btnCopyRGB_Click);
            // 
            // customContainer1
            // 
            this.customContainer1.CornerRadius = 40;
            this.customContainer1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "RED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "GREEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "BLUE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ALPHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(767, 392);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnCopyRGB);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.tR);
            this.Controls.Add(this.tApha);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.tG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pnColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.TextBox tG;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.TextBox tR;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TrackBar tbA;
        private System.Windows.Forms.TextBox tApha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private CustomContainer customContainer1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Button btnCopyRGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

