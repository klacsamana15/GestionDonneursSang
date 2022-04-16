using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDonneursSang
{
    public partial class DonneurForm : Form
    {

        ComboBox cbGroupeSang;
        String rhesus;

        public DonneurForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGroupeSang = new ComboBox();
            cbGroupeSang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupeSang.Location = new Point(327, 162);
            cbGroupeSang.Size = new Size(133, 21);
            cbGroupeSang.Text = "Groupe sanguin";
            cbGroupeSang.Items.Add("A");
            cbGroupeSang.Items.Add("B");
            cbGroupeSang.Items.Add("O");
            cbGroupeSang.Items.Add("AB");

            cbGroupeSang.Enter += CbGroupeSang_Enter;

            this.Controls.Add(cbGroupeSang);


        }

        private void CbGroupeSang_Enter(object sender, EventArgs e)
        {
      
            cbGroupeSang.Text = "";
            cbGroupeSang.ForeColor = Color.Black;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if ((tbPrenom.Text == "Prénom") || (tbNom.Text == "Nom") || (tbCarteMaladie.Text == "Numéro d'assurance maladie") || (cbGroupeSang.SelectedItem == null) || (!rbRhNegatif.Checked && !rbRhPositif.Checked))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if(tbPrenom.Text == string.Empty)
            {
                MessageBox.Show("Prénom invalide!", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                tbPrenom.Focus();
            }
            else
            {
                //format nom et prénom: n'accepte pas les noms combinés (pas d'espaces) 
                if ((Regex.IsMatch(tbPrenom.Text, @"^[a-zA-Z]+$") == false) || (Regex.IsMatch(tbNom.Text, @"^[a-zA-Z]+$") == false))
                {
                    MessageBox.Show("Veuillez entrez que des lettres.", "Prénom/Nom", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                //format assurance maladie: n'accepte pas d'espaces
                if((Regex.IsMatch(tbCarteMaladie.Text, @"^[a-zA-Z]{4} \d{4} \d{4}") == false))
                {
                    MessageBox.Show("Assurance maladie invalide.", "Numéro d'assurance maladie", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

            }


                if (btnAjouter.Text == "Ajouter")
            {
                string[] infos = new string[] {tbCarteMaladie.Text, tbPrenom.Text, tbNom.Text, cbGroupeSang.SelectedItem.ToString(), rhesus };

                dgvDonneur.Rows.Add(infos);
            }
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            tbPrenom.Text = "";
            tbNom.Text = "";
            tbCarteMaladie.Text = "";
            cbGroupeSang.Text = "";
            cbGroupeSang.SelectedIndex = -1;
            rbRhNegatif.Checked = false;
            rbRhPositif.Checked = false;
        }

        private void tbPrenom_Enter(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "Prénom")
            {
                tbPrenom.Text = "";
                tbPrenom.ForeColor = Color.Black;
            }
        }

        private void tbPrenom_Leave(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "")
            {
                tbPrenom.ForeColor = Color.LightPink;
                tbPrenom.Text = "Prénom";
            }
        }

        private void tbNom_Enter(object sender, EventArgs e)
        {
            if (tbNom.Text == "Nom")
            {
                tbNom.Text = "";
                tbNom.ForeColor = Color.Black;
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.LightPink;
                tbNom.Text = "Nom";
            }
        }

        private void tbCarteMaladie_Enter(object sender, EventArgs e)
        {
            if (tbCarteMaladie.Text == "AAAA #### ####")
            {
                tbCarteMaladie.Text = "";
                tbCarteMaladie.ForeColor = Color.Black;
            }
        }

        private void tbCarteMaladie_Leave(object sender, EventArgs e)
        {
            if (tbCarteMaladie.Text == "")
            {
                tbCarteMaladie.ForeColor = Color.LightPink;
                tbCarteMaladie.Text = "AAAA #### ####";
            }
        }

        private void dgvDonneur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
  
        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            while (dgvDonneur.Rows.Count > 1)
            {
                if (MessageBox.Show("Êtes-vous certain de vouloir supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDonneur.SelectedRows)
                    {
                        dgvDonneur.Rows.Remove(row);

          
                    }
                }
                return;
            }

            if(dgvDonneur.Rows.Count == 1)
            {
                MessageBox.Show("Aucune donnée à supprimer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void rbRhNegatif_CheckedChanged(object sender, EventArgs e)
        {
            rhesus = "Rh-";
        }

        private void rbRhPositif_CheckedChanged(object sender, EventArgs e)
        {
            rhesus = "Rh+";
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (dgvDonneur.Rows.Count > 1)
            {
                if (MessageBox.Show("Êtes-vous certain de vouloir supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDonneur.SelectedRows)
                    {
                        dgvDonneur.Rows.Remove(row);
                    }
                }
                return;
            }

            if (dgvDonneur.Rows.Count == 1)
            {
                MessageBox.Show("Aucune donnée à supprimer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter saveList = new StreamWriter("Donneurs.txt", false);
            try
            {
                string line = "";
                //This for loop loops through each row in the table
                for (int r = 0; r <= dgvDonneur.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                     //is passed from the for loop above.
                    for (int c = 0; c <= dgvDonneur.Columns.Count - 1; c++)
                    {
                        line = line + dgvDonneur.Rows[r].Cells[c].Value;
                        if (c != dgvDonneur.Columns.Count - 1)
                        {
                            //seperate each field in the text file with a space
                            line = line + "    ";
                        }
                    }
                    saveList.WriteLine(line);
                    line = "";
                }


                saveList.Close();
                MessageBox.Show("Sauvegarde complété!", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Sauvegarder n'a pas été complété", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveList.Close();
            }
        }

           
}
}
