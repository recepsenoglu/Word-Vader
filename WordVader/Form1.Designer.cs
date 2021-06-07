namespace WordVader
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
            this.txtgiris = new System.Windows.Forms.RichTextBox();
            this.txtcikis = new System.Windows.Forms.RichTextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtgiris
            // 
            this.txtgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgiris.Location = new System.Drawing.Point(24, 12);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Size = new System.Drawing.Size(404, 291);
            this.txtgiris.TabIndex = 0;
            this.txtgiris.Text = "";
            this.txtgiris.TextChanged += new System.EventHandler(this.txtgiris_TextChanged);
            // 
            // txtcikis
            // 
            this.txtcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcikis.Location = new System.Drawing.Point(548, 12);
            this.txtcikis.Name = "txtcikis";
            this.txtcikis.ReadOnly = true;
            this.txtcikis.Size = new System.Drawing.Size(404, 291);
            this.txtcikis.TabIndex = 2;
            this.txtcikis.Text = "";
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(447, 12);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 291);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 324);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtcikis);
            this.Controls.Add(this.txtgiris);
            this.Name = "Form1";
            this.Text = "it\'s over anakin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtgiris;
        private System.Windows.Forms.RichTextBox txtcikis;
        private System.Windows.Forms.Button btnok;
    }
}

