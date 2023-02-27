
namespace Futar
{
    partial class frmAdmin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPartner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFutar = new System.Windows.Forms.ComboBox();
            this.btnVissza = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partner_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.datum,
            this.partner,
            this.futar,
            this.partner_id,
            this.futar_id});
            this.dgvAdmin.Location = new System.Drawing.Point(12, 12);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(586, 185);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.SelectionChanged += new System.EventHandler(this.dgvAdmin_SelectionChanged);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(620, 12);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(134, 44);
            this.btnUj.TabIndex = 1;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(620, 84);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(134, 44);
            this.btnModositas.TabIndex = 1;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(620, 153);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(134, 44);
            this.btnTorles.TabIndex = 1;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Partner";
            // 
            // cbPartner
            // 
            this.cbPartner.FormattingEnabled = true;
            this.cbPartner.Location = new System.Drawing.Point(12, 243);
            this.cbPartner.Name = "cbPartner";
            this.cbPartner.Size = new System.Drawing.Size(586, 28);
            this.cbPartner.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Futár";
            // 
            // cbFutar
            // 
            this.cbFutar.FormattingEnabled = true;
            this.cbFutar.Location = new System.Drawing.Point(12, 313);
            this.cbFutar.Name = "cbFutar";
            this.cbFutar.Size = new System.Drawing.Size(586, 28);
            this.cbFutar.TabIndex = 3;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(219, 356);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(134, 44);
            this.btnVissza.TabIndex = 1;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(620, 356);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(134, 44);
            this.btnMentes.TabIndex = 1;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Location = new System.Drawing.Point(620, 297);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(134, 44);
            this.btnMegsem.TabIndex = 1;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // futar
            // 
            this.futar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.futar.DataPropertyName = "futar";
            this.futar.HeaderText = "Futár";
            this.futar.Name = "futar";
            this.futar.ReadOnly = true;
            this.futar.Width = 72;
            // 
            // partner_id
            // 
            this.partner_id.DataPropertyName = "partner_id";
            this.partner_id.HeaderText = "Partner ID";
            this.partner_id.Name = "partner_id";
            this.partner_id.ReadOnly = true;
            this.partner_id.Visible = false;
            // 
            // futar_id
            // 
            this.futar_id.DataPropertyName = "futar_id";
            this.futar_id.HeaderText = "Futár ID";
            this.futar_id.Name = "futar_id";
            this.futar_id.ReadOnly = true;
            this.futar_id.Visible = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVissza;
            this.ClientSize = new System.Drawing.Size(775, 412);
            this.ControlBox = false;
            this.Controls.Add(this.cbFutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPartner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.dgvAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Küldemények adminisztrációja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFutar;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar;
        private System.Windows.Forms.DataGridViewTextBoxColumn partner_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar_id;
    }
}