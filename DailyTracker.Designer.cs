namespace WindowsFormsApp1
{
    partial class DailyTracker
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
            this.txdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txevent = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(90, 71);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(343, 34);
            this.txdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(358, 269);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Event";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(90, 148);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(343, 34);
            this.txevent.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Event";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(273, 223);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete Event";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // DailyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txdate);
            this.Name = "DailyTracker";
            this.Text = "DailyTracker";
            this.Load += new System.EventHandler(this.DailyTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
    }
}