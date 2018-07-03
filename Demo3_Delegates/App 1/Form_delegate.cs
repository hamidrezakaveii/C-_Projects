using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    //delegate creation 
    delegate void MonDelegateRecherche(); 
    public partial class Form_delegate : Form
    {

        List<MonDelegateRecherche> listDelegates;

        public Form_delegate()
        {
            InitializeComponent();
            listDelegates = new List<MonDelegateRecherche>();
            ajouterDelegate();
        }

        private void ajouterDelegate()
        {
            //ajoute au combobox
            cb_recherche.Items.Add("Recherche par nom");
            cb_recherche.Items.Add("Recherche par prenom");
            cb_recherche.Items.Add("Recherche par nom et prenom");
            //ajoute a la liste des delegates
            listDelegates.Add(rechercheParNom);
            listDelegates.Add(rechercheParPrenom);
            listDelegates.Add(rechercheParNomPrenom);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_resultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void rechercheParNom()
        {
            tb_resultat.AppendText("recherche par nom est lancee");
        }

        private void rechercheParPrenom()
        {
            tb_resultat.AppendText("recherche par prenom est lancee");
        }
        private void rechercheParNomPrenom()
        {
            tb_resultat.AppendText("recherche par nom et prenom est lancee");
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            if(cb_recherche.SelectedIndex != -1)
            {
                tb_resultat.Clear();
                listDelegates[cb_recherche.SelectedIndex]();
            }
        }
    }
}
