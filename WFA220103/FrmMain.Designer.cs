namespace WFA220103
{
    partial class FrmMain
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
            this.rtbAdatok = new System.Windows.Forms.RichTextBox();
            this.btnLekerdezes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAdatok
            // 
            this.rtbAdatok.Location = new System.Drawing.Point(12, 12);
            this.rtbAdatok.Name = "rtbAdatok";
            this.rtbAdatok.Size = new System.Drawing.Size(477, 253);
            this.rtbAdatok.TabIndex = 0;
            this.rtbAdatok.Text = "";
            // 
            // btnLekerdezes
            // 
            this.btnLekerdezes.Location = new System.Drawing.Point(12, 271);
            this.btnLekerdezes.Name = "btnLekerdezes";
            this.btnLekerdezes.Size = new System.Drawing.Size(477, 69);
            this.btnLekerdezes.TabIndex = 1;
            this.btnLekerdezes.Text = "Csináld!";
            this.btnLekerdezes.UseVisualStyleBackColor = true;
            this.btnLekerdezes.Click += new System.EventHandler(this.BtnLekerdezes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.btnLekerdezes);
            this.Controls.Add(this.rtbAdatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAdatok;
        private System.Windows.Forms.Button btnLekerdezes;
    }
}

