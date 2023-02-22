
namespace Futar
{
    partial class frmBejelentkezes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFelhasznalo = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Felhasználó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó:";
            // 
            // tbFelhasznalo
            // 
            this.tbFelhasznalo.Location = new System.Drawing.Point(117, 27);
            this.tbFelhasznalo.Name = "tbFelhasznalo";
            this.tbFelhasznalo.Size = new System.Drawing.Size(173, 26);
            this.tbFelhasznalo.TabIndex = 0;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(117, 74);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '•';
            this.tbJelszo.Size = new System.Drawing.Size(173, 26);
            this.tbJelszo.TabIndex = 1;
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(12, 127);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(130, 33);
            this.btnMegsem.TabIndex = 3;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Location = new System.Drawing.Point(160, 127);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(130, 33);
            this.btnBejelentkezes.TabIndex = 2;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = true;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // frmBejelentkezes
            // 
            this.AcceptButton = this.btnBejelentkezes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMegsem;
            this.ClientSize = new System.Drawing.Size(302, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btnBejelentkezes);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFelhasznalo;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnBejelentkezes;
    }
}

