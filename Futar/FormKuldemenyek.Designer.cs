
namespace Futar
{
    partial class frmKuldemenyek
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
            this.dgvKuldemenyek = new System.Windows.Forms.DataGridView();
            this.btnVissza = new System.Windows.Forms.Button();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerulet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuldemenyek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKuldemenyek
            // 
            this.dgvKuldemenyek.AllowUserToAddRows = false;
            this.dgvKuldemenyek.AllowUserToDeleteRows = false;
            this.dgvKuldemenyek.AllowUserToOrderColumns = true;
            this.dgvKuldemenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuldemenyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datum,
            this.partner,
            this.kerulet,
            this.utca,
            this.hazszam,
            this.futar});
            this.dgvKuldemenyek.Location = new System.Drawing.Point(12, 12);
            this.dgvKuldemenyek.Name = "dgvKuldemenyek";
            this.dgvKuldemenyek.RowHeadersVisible = false;
            this.dgvKuldemenyek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKuldemenyek.Size = new System.Drawing.Size(772, 304);
            this.dgvKuldemenyek.TabIndex = 0;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(349, 322);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(99, 33);
            this.btnVissza.TabIndex = 1;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // datum
            // 
            this.datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.Width = 82;
            // 
            // partner
            // 
            this.partner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partner.DataPropertyName = "partner";
            this.partner.HeaderText = "Partner";
            this.partner.Name = "partner";
            this.partner.ReadOnly = true;
            // 
            // kerulet
            // 
            this.kerulet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kerulet.DataPropertyName = "kerulet";
            this.kerulet.HeaderText = "Kerület";
            this.kerulet.Name = "kerulet";
            this.kerulet.ReadOnly = true;
            this.kerulet.Width = 84;
            // 
            // utca
            // 
            this.utca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.utca.DataPropertyName = "utca";
            this.utca.HeaderText = "Utca";
            this.utca.Name = "utca";
            this.utca.ReadOnly = true;
            this.utca.Width = 68;
            // 
            // hazszam
            // 
            this.hazszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hazszam.DataPropertyName = "hazszam";
            this.hazszam.HeaderText = "Házszám";
            this.hazszam.Name = "hazszam";
            this.hazszam.ReadOnly = true;
            this.hazszam.Width = 101;
            // 
            // futar
            // 
            this.futar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.futar.DataPropertyName = "futar";
            this.futar.HeaderText = "Futár";
            this.futar.Name = "futar";
            this.futar.ReadOnly = true;
            this.futar.Width = 72;
            // 
            // frmKuldemenyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVissza;
            this.ClientSize = new System.Drawing.Size(796, 367);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKuldemenyek);
            this.Controls.Add(this.btnVissza);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKuldemenyek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Küldemények listája";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuldemenyek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKuldemenyek;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerulet;
        private System.Windows.Forms.DataGridViewTextBoxColumn utca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar;
    }
}