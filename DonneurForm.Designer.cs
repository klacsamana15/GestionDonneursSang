
namespace GestionDonneursSang
{
    partial class DonneurForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonneurForm));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumCarteMaladie = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblGroupeSang = new System.Windows.Forms.Label();
            this.lblRhesus = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbCarteMaladie = new System.Windows.Forms.TextBox();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDonneur = new System.Windows.Forms.DataGridView();
            this.colNAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupeSanguin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRhesus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSupprimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHeartBlood = new System.Windows.Forms.PictureBox();
            this.rbRhPositif = new System.Windows.Forms.RadioButton();
            this.rbRhNegatif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonneur)).BeginInit();
            this.cmsSupprimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(942, 75);
            this.lblNom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblNumCarteMaladie
            // 
            this.lblNumCarteMaladie.AutoSize = true;
            this.lblNumCarteMaladie.Location = new System.Drawing.Point(650, 181);
            this.lblNumCarteMaladie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumCarteMaladie.Name = "lblNumCarteMaladie";
            this.lblNumCarteMaladie.Size = new System.Drawing.Size(290, 25);
            this.lblNumCarteMaladie.TabIndex = 1;
            this.lblNumCarteMaladie.Text = "Numéro d\'assurance maladie";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(650, 75);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(86, 25);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblGroupeSang
            // 
            this.lblGroupeSang.AutoSize = true;
            this.lblGroupeSang.Location = new System.Drawing.Point(650, 279);
            this.lblGroupeSang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGroupeSang.Name = "lblGroupeSang";
            this.lblGroupeSang.Size = new System.Drawing.Size(165, 25);
            this.lblGroupeSang.TabIndex = 3;
            this.lblGroupeSang.Text = "Groupe sanguin";
            // 
            // lblRhesus
            // 
            this.lblRhesus.AutoSize = true;
            this.lblRhesus.Location = new System.Drawing.Point(942, 283);
            this.lblRhesus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRhesus.Name = "lblRhesus";
            this.lblRhesus.Size = new System.Drawing.Size(85, 25);
            this.lblRhesus.TabIndex = 4;
            this.lblRhesus.Text = "Rhesus";
            // 
            // tbPrenom
            // 
            this.tbPrenom.ForeColor = System.Drawing.Color.LightPink;
            this.tbPrenom.Location = new System.Drawing.Point(654, 106);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(262, 31);
            this.tbPrenom.TabIndex = 2;
            this.tbPrenom.Text = "Prénom";
            this.tbPrenom.Enter += new System.EventHandler(this.tbPrenom_Enter);
            this.tbPrenom.Leave += new System.EventHandler(this.tbPrenom_Leave);
            // 
            // tbNom
            // 
            this.tbNom.ForeColor = System.Drawing.Color.LightPink;
            this.tbNom.Location = new System.Drawing.Point(948, 106);
            this.tbNom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(262, 31);
            this.tbNom.TabIndex = 6;
            this.tbNom.Text = "Nom";
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // tbCarteMaladie
            // 
            this.tbCarteMaladie.ForeColor = System.Drawing.Color.LightPink;
            this.tbCarteMaladie.Location = new System.Drawing.Point(654, 210);
            this.tbCarteMaladie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCarteMaladie.Name = "tbCarteMaladie";
            this.tbCarteMaladie.Size = new System.Drawing.Size(556, 31);
            this.tbCarteMaladie.TabIndex = 7;
            this.tbCarteMaladie.Text = "AAAA #### ####";
            this.tbCarteMaladie.Enter += new System.EventHandler(this.tbCarteMaladie_Enter);
            this.tbCarteMaladie.Leave += new System.EventHandler(this.tbCarteMaladie_Leave);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.btnInitialiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(197)))), ((int)(((byte)(176)))));
            this.btnInitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialiser.Location = new System.Drawing.Point(708, 398);
            this.btnInitialiser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(178, 48);
            this.btnInitialiser.TabIndex = 0;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = false;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(197)))), ((int)(((byte)(176)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Location = new System.Drawing.Point(952, 398);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(178, 48);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(197)))), ((int)(((byte)(176)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Location = new System.Drawing.Point(674, 904);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(178, 48);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(197)))), ((int)(((byte)(176)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(420, 904);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDonneur
            // 
            this.dgvDonneur.AllowUserToResizeColumns = false;
            this.dgvDonneur.AllowUserToResizeRows = false;
            this.dgvDonneur.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvDonneur.ColumnHeadersHeight = 40;
            this.dgvDonneur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDonneur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNAM,
            this.colPrenom,
            this.colNom,
            this.colGroupeSanguin,
            this.colRhesus});
            this.dgvDonneur.ContextMenuStrip = this.cmsSupprimer;
            this.dgvDonneur.GridColor = System.Drawing.Color.DarkGray;
            this.dgvDonneur.Location = new System.Drawing.Point(46, 508);
            this.dgvDonneur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDonneur.Name = "dgvDonneur";
            this.dgvDonneur.RowHeadersWidth = 82;
            this.dgvDonneur.RowTemplate.Height = 33;
            this.dgvDonneur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonneur.Size = new System.Drawing.Size(1168, 337);
            this.dgvDonneur.TabIndex = 0;
            this.dgvDonneur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonneur_CellContentClick);
            // 
            // colNAM
            // 
            this.colNAM.HeaderText = "Numéro d\'assurance maladie";
            this.colNAM.MinimumWidth = 10;
            this.colNAM.Name = "colNAM";
            this.colNAM.Width = 200;
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.MinimumWidth = 10;
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Width = 200;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.MinimumWidth = 10;
            this.colNom.Name = "colNom";
            this.colNom.Width = 200;
            // 
            // colGroupeSanguin
            // 
            this.colGroupeSanguin.HeaderText = "Groupe sanguin";
            this.colGroupeSanguin.MinimumWidth = 10;
            this.colGroupeSanguin.Name = "colGroupeSanguin";
            this.colGroupeSanguin.Width = 50;
            // 
            // colRhesus
            // 
            this.colRhesus.HeaderText = "Rhesus";
            this.colRhesus.MinimumWidth = 10;
            this.colRhesus.Name = "colRhesus";
            this.colRhesus.Width = 50;
            // 
            // cmsSupprimer
            // 
            this.cmsSupprimer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsSupprimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.cmsSupprimer.Name = "cmsSupprimer";
            this.cmsSupprimer.Size = new System.Drawing.Size(202, 42);
            this.cmsSupprimer.Text = "Supprimer";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // pbHeartBlood
            // 
            this.pbHeartBlood.Image = global::GestionDonneursSang.Properties.Resources.blooddonor;
            this.pbHeartBlood.Location = new System.Drawing.Point(46, 23);
            this.pbHeartBlood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbHeartBlood.Name = "pbHeartBlood";
            this.pbHeartBlood.Size = new System.Drawing.Size(552, 415);
            this.pbHeartBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeartBlood.TabIndex = 20;
            this.pbHeartBlood.TabStop = false;
            // 
            // rbRhPositif
            // 
            this.rbRhPositif.AutoSize = true;
            this.rbRhPositif.Location = new System.Drawing.Point(948, 312);
            this.rbRhPositif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRhPositif.Name = "rbRhPositif";
            this.rbRhPositif.Size = new System.Drawing.Size(82, 29);
            this.rbRhPositif.TabIndex = 21;
            this.rbRhPositif.TabStop = true;
            this.rbRhPositif.Text = "Rh+";
            this.rbRhPositif.UseVisualStyleBackColor = true;
            this.rbRhPositif.CheckedChanged += new System.EventHandler(this.rbRhPositif_CheckedChanged);
            // 
            // rbRhNegatif
            // 
            this.rbRhNegatif.AutoSize = true;
            this.rbRhNegatif.Location = new System.Drawing.Point(1060, 312);
            this.rbRhNegatif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRhNegatif.Name = "rbRhNegatif";
            this.rbRhNegatif.Size = new System.Drawing.Size(77, 29);
            this.rbRhNegatif.TabIndex = 22;
            this.rbRhNegatif.TabStop = true;
            this.rbRhNegatif.Text = "Rh-";
            this.rbRhNegatif.UseVisualStyleBackColor = true;
            this.rbRhNegatif.CheckedChanged += new System.EventHandler(this.rbRhNegatif_CheckedChanged);
            // 
            // DonneurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1258, 985);
            this.Controls.Add(this.rbRhNegatif);
            this.Controls.Add(this.rbRhPositif);
            this.Controls.Add(this.pbHeartBlood);
            this.Controls.Add(this.dgvDonneur);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.tbCarteMaladie);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblRhesus);
            this.Controls.Add(this.lblGroupeSang);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNumCarteMaladie);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonneurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des donneurs de sang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonneur)).EndInit();
            this.cmsSupprimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartBlood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumCarteMaladie;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblGroupeSang;
        private System.Windows.Forms.Label lblRhesus;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbCarteMaladie;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDonneur;
        private System.Windows.Forms.PictureBox pbHeartBlood;
        private System.Windows.Forms.RadioButton rbRhPositif;
        private System.Windows.Forms.RadioButton rbRhNegatif;
        private System.Windows.Forms.ContextMenuStrip cmsSupprimer;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupeSanguin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRhesus;
    }
}

