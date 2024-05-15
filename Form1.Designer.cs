namespace WindowsFormsApp1
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnimg = new System.Windows.Forms.Button();
            this.lbtxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(262, 98);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(927, 445);
            this.daycontainer.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1024, 558);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1105, 558);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tuesday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(832, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fridey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(949, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Saturday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1082, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sunday";
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Strawberry Blossom", 47.99999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LBDATE.Location = new System.Drawing.Point(30, 25);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(226, 93);
            this.LBDATE.TabIndex = 10;
            this.LBDATE.Text = "Month year";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(41, 151);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 144);
            this.checkedListBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(41, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnimg
            // 
            this.btnimg.Location = new System.Drawing.Point(95, 558);
            this.btnimg.Name = "btnimg";
            this.btnimg.Size = new System.Drawing.Size(75, 23);
            this.btnimg.TabIndex = 13;
            this.btnimg.Text = "Add Image";
            this.btnimg.UseVisualStyleBackColor = true;
            this.btnimg.Click += new System.EventHandler(this.btnimg_Click);
            // 
            // lbtxt
            // 
            this.lbtxt.AutoSize = true;
            this.lbtxt.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxt.Location = new System.Drawing.Point(41, 118);
            this.lbtxt.Name = "lbtxt";
            this.lbtxt.Size = new System.Drawing.Size(129, 20);
            this.lbtxt.TabIndex = 14;
            this.lbtxt.Text = "To Do List";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 74);
            this.textBox1.TabIndex = 15;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(95, 391);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(75, 23);
            this.btnlist.TabIndex = 16;
            this.btnlist.Text = "Add";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1234, 617);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbtxt);
            this.Controls.Add(this.btnimg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnimg;
        private System.Windows.Forms.Label lbtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnlist;
    }
}

