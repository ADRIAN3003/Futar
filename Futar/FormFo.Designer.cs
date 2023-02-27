
namespace Futar
{
    partial class frmFo
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
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnKuldemenyek = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPartnerek = new System.Windows.Forms.Button();
            this.btnFutarok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(12, 289);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(331, 48);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnKuldemenyek
            // 
            this.btnKuldemenyek.Location = new System.Drawing.Point(12, 12);
            this.btnKuldemenyek.Name = "btnKuldemenyek";
            this.btnKuldemenyek.Size = new System.Drawing.Size(331, 48);
            this.btnKuldemenyek.TabIndex = 0;
            this.btnKuldemenyek.Text = "Küldemények listája";
            this.btnKuldemenyek.UseVisualStyleBackColor = true;
            this.btnKuldemenyek.Click += new System.EventHandler(this.btnKuldemenyek_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 66);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(331, 48);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Küldemények adminisztrációja";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPartnerek
            // 
            this.btnPartnerek.Location = new System.Drawing.Point(12, 120);
            this.btnPartnerek.Name = "btnPartnerek";
            this.btnPartnerek.Size = new System.Drawing.Size(331, 48);
            this.btnPartnerek.TabIndex = 2;
            this.btnPartnerek.Text = "Partnerek";
            this.btnPartnerek.UseVisualStyleBackColor = true;
            // 
            // btnFutarok
            // 
            this.btnFutarok.Location = new System.Drawing.Point(12, 174);
            this.btnFutarok.Name = "btnFutarok";
            this.btnFutarok.Size = new System.Drawing.Size(331, 48);
            this.btnFutarok.TabIndex = 3;
            this.btnFutarok.Text = "Futárok";
            this.btnFutarok.UseVisualStyleBackColor = true;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(355, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btnFutarok);
            this.Controls.Add(this.btnPartnerek);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnKuldemenyek);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFo_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnKuldemenyek;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPartnerek;
        private System.Windows.Forms.Button btnFutarok;
    }
}