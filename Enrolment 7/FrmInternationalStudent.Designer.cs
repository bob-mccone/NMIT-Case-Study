﻿namespace Enrolment_7
{
    partial class FrmInternationalStudent
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblIELTS = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtIELTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(52, 125);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Country";
            // 
            // lblIELTS
            // 
            this.lblIELTS.AutoSize = true;
            this.lblIELTS.Location = new System.Drawing.Point(58, 151);
            this.lblIELTS.Name = "lblIELTS";
            this.lblIELTS.Size = new System.Drawing.Size(37, 13);
            this.lblIELTS.TabIndex = 14;
            this.lblIELTS.Text = "IELTS";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(101, 122);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 15;
            // 
            // txtIELTS
            // 
            this.txtIELTS.Location = new System.Drawing.Point(101, 148);
            this.txtIELTS.Name = "txtIELTS";
            this.txtIELTS.Size = new System.Drawing.Size(100, 20);
            this.txtIELTS.TabIndex = 16;
            // 
            // FrmInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.txtIELTS);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblIELTS);
            this.Controls.Add(this.lblCountry);
            this.Name = "FrmInternationalStudent";
            this.Text = "International Student";
            this.Controls.SetChildIndex(this.lblCountry, 0);
            this.Controls.SetChildIndex(this.lblIELTS, 0);
            this.Controls.SetChildIndex(this.txtCountry, 0);
            this.Controls.SetChildIndex(this.txtIELTS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblIELTS;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtIELTS;
    }
}
