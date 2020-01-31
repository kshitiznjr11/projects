namespace calc
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nholder = new System.Windows.Forms.TextBox();
            this.equalstoBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(379, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "CALCULATOR";
            // 
            // nholder
            // 
            this.nholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nholder.Location = new System.Drawing.Point(32, 110);
            this.nholder.Multiline = true;
            this.nholder.Name = "nholder";
            this.nholder.Size = new System.Drawing.Size(429, 51);
            this.nholder.TabIndex = 40;
            this.nholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equalstoBtn
            // 
            this.equalstoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalstoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalstoBtn.Location = new System.Drawing.Point(386, 307);
            this.equalstoBtn.Name = "equalstoBtn";
            this.equalstoBtn.Size = new System.Drawing.Size(76, 121);
            this.equalstoBtn.TabIndex = 39;
            this.equalstoBtn.Text = "=";
            this.equalstoBtn.UseVisualStyleBackColor = true;
            this.equalstoBtn.Click += new System.EventHandler(this.equalstoBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Location = new System.Drawing.Point(208, 374);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(76, 54);
            this.dotBtn.TabIndex = 38;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(297, 374);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(76, 54);
            this.plusBtn.TabIndex = 37;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(32, 374);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(165, 54);
            this.zeroBtn.TabIndex = 36;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceBtn.Location = new System.Drawing.Point(386, 240);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(76, 54);
            this.backspaceBtn.TabIndex = 35;
            this.backspaceBtn.Text = "C";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(386, 173);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(76, 54);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "CE";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(297, 307);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(76, 54);
            this.subtractBtn.TabIndex = 33;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationBtn.Location = new System.Drawing.Point(297, 240);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(76, 54);
            this.multiplicationBtn.TabIndex = 32;
            this.multiplicationBtn.Text = "*";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(297, 173);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(76, 54);
            this.divideBtn.TabIndex = 31;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(208, 307);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(76, 54);
            this.threeBtn.TabIndex = 30;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(121, 307);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(76, 54);
            this.twoBtn.TabIndex = 29;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(32, 307);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(76, 54);
            this.oneBtn.TabIndex = 28;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(208, 240);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(76, 54);
            this.sixBtn.TabIndex = 27;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(121, 240);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(76, 54);
            this.fiveBtn.TabIndex = 26;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(32, 240);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(76, 54);
            this.fourBtn.TabIndex = 25;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(208, 173);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(76, 54);
            this.nineBtn.TabIndex = 24;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(121, 173);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(76, 54);
            this.eightBtn.TabIndex = 23;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(32, 173);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(76, 54);
            this.sevenBtn.TabIndex = 22;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(495, 457);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nholder);
            this.Controls.Add(this.equalstoBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nholder;
        private System.Windows.Forms.Button equalstoBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
    }
}

