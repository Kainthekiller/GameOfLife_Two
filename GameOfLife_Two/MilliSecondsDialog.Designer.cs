
namespace GameOfLife_Two
{
    partial class MilliSecondsDialog
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
            this.MillSecUpnDwn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MillSec_BTN_OK = new System.Windows.Forms.Button();
            this.MillSec_BTN_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MillSecUpnDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // MillSecUpnDwn
            // 
            this.MillSecUpnDwn.Location = new System.Drawing.Point(506, 67);
            this.MillSecUpnDwn.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MillSecUpnDwn.Name = "MillSecUpnDwn";
            this.MillSecUpnDwn.Size = new System.Drawing.Size(120, 26);
            this.MillSecUpnDwn.TabIndex = 0;
            this.MillSecUpnDwn.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change MilliSeconds";
            // 
            // MillSec_BTN_OK
            // 
            this.MillSec_BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MillSec_BTN_OK.Location = new System.Drawing.Point(193, 352);
            this.MillSec_BTN_OK.Name = "MillSec_BTN_OK";
            this.MillSec_BTN_OK.Size = new System.Drawing.Size(103, 46);
            this.MillSec_BTN_OK.TabIndex = 2;
            this.MillSec_BTN_OK.Text = "OK";
            this.MillSec_BTN_OK.UseVisualStyleBackColor = true;
            // 
            // MillSec_BTN_Cancel
            // 
            this.MillSec_BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MillSec_BTN_Cancel.Location = new System.Drawing.Point(466, 352);
            this.MillSec_BTN_Cancel.Name = "MillSec_BTN_Cancel";
            this.MillSec_BTN_Cancel.Size = new System.Drawing.Size(111, 46);
            this.MillSec_BTN_Cancel.TabIndex = 3;
            this.MillSec_BTN_Cancel.Text = "Cancel\r\n";
            this.MillSec_BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // MilliSecondsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MillSec_BTN_Cancel);
            this.Controls.Add(this.MillSec_BTN_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MillSecUpnDwn);
            this.Name = "MilliSecondsDialog";
            this.Text = "MilliSecondsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.MillSecUpnDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MillSecUpnDwn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MillSec_BTN_OK;
        private System.Windows.Forms.Button MillSec_BTN_Cancel;
    }
}