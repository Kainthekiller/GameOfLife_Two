
namespace GameOfLife_Two
{
    partial class ModalDialog
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
            this.Seed_Up_Down = new System.Windows.Forms.NumericUpDown();
            this.label_Seed = new System.Windows.Forms.Label();
            this.Seed_BTN_Ok = new System.Windows.Forms.Button();
            this.Seed_BTN_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_Up_Down)).BeginInit();
            this.SuspendLayout();
            // 
            // Seed_Up_Down
            // 
            this.Seed_Up_Down.Location = new System.Drawing.Point(356, 97);
            this.Seed_Up_Down.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Seed_Up_Down.Name = "Seed_Up_Down";
            this.Seed_Up_Down.Size = new System.Drawing.Size(120, 26);
            this.Seed_Up_Down.TabIndex = 0;
            // 
            // label_Seed
            // 
            this.label_Seed.AutoSize = true;
            this.label_Seed.Location = new System.Drawing.Point(94, 99);
            this.label_Seed.Name = "label_Seed";
            this.label_Seed.Size = new System.Drawing.Size(230, 20);
            this.label_Seed.TabIndex = 1;
            this.label_Seed.Text = "Please Enter Seed for Random";
            // 
            // Seed_BTN_Ok
            // 
            this.Seed_BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Seed_BTN_Ok.Location = new System.Drawing.Point(163, 311);
            this.Seed_BTN_Ok.Name = "Seed_BTN_Ok";
            this.Seed_BTN_Ok.Size = new System.Drawing.Size(90, 57);
            this.Seed_BTN_Ok.TabIndex = 2;
            this.Seed_BTN_Ok.Text = "OK";
            this.Seed_BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // Seed_BTN_Cancel
            // 
            this.Seed_BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Seed_BTN_Cancel.Location = new System.Drawing.Point(446, 311);
            this.Seed_BTN_Cancel.Name = "Seed_BTN_Cancel";
            this.Seed_BTN_Cancel.Size = new System.Drawing.Size(95, 57);
            this.Seed_BTN_Cancel.TabIndex = 3;
            this.Seed_BTN_Cancel.Text = "Cancel";
            this.Seed_BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // ModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seed_BTN_Cancel);
            this.Controls.Add(this.Seed_BTN_Ok);
            this.Controls.Add(this.label_Seed);
            this.Controls.Add(this.Seed_Up_Down);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialog";
            this.Text = "Random Seed";
            ((System.ComponentModel.ISupportInitialize)(this.Seed_Up_Down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Seed_Up_Down;
        private System.Windows.Forms.Label label_Seed;
        private System.Windows.Forms.Button Seed_BTN_Ok;
        private System.Windows.Forms.Button Seed_BTN_Cancel;
    }
}