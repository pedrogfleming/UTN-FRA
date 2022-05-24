using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormFabricaTroopers
{
    public partial class frmPpal : Form
    {
        private EjercitoImperial ejercitoImperial;
        public frmPpal()
        {
            ejercitoImperial = new EjercitoImperial(10);
            Troopper auxTrooperAsalto = new TrooperAsalto(Blaster.EC17);            
            ejercitoImperial += auxTrooperAsalto;
            InitializeComponent();
        }
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            foreach (Troopper item in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(item.InfoTrooper());
            }            
        }
        private void FormEjercitoTroopers_Load(object sender, EventArgs e)
        {
            cmbBlaster.DataSource = Enum.GetValues(typeof(Blaster));
            RefrescarEjercito();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedItem is not null && !string.IsNullOrWhiteSpace(cmbTipo.SelectedItem.ToString()))
            {
                Troopper auxTrooper = null;
                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Tropper Arena":
                        if(cmbBlaster.SelectedItem is not null && (Blaster)cmbBlaster.SelectedItem != Blaster.EC17)
                        {
                            auxTrooper = new TrooperArena((Blaster)cmbBlaster.SelectedItem);
                        }
                        else
                        {
                            auxTrooper = new TrooperArena(Blaster.EC17);
                        }
                        break;
                    case "Tropper Asalto":
                        if (cmbBlaster.SelectedItem is not null && (Blaster)cmbBlaster.SelectedItem != Blaster.E11)
                        {
                            auxTrooper = new TrooperAsalto((Blaster)cmbBlaster.SelectedItem);
                        }
                        else
                        {
                            auxTrooper = new TrooperAsalto(Blaster.E11);
                        }
                        break;
                    case "Tropper Explorador":
                        auxTrooper = new TrooperExplorador("Moto");                        
                        break;
                }
                if(auxTrooper != null)
                {                    
                    if(auxTrooper.GetType() != typeof(TrooperAsalto))
                    {
                        auxTrooper.EsClon = chkEsClon.Checked;
                    }                    
                    this.ejercitoImperial += auxTrooper;
                    RefrescarEjercito();
                }                
            }    
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedItem is not null)
            {
                string auxTipo = cmbTipo.SelectedItem.ToString();
                Troopper auxNuevoTrooper = null;
                switch (auxTipo)
                {
                    case "Tropper Arena":
                        auxNuevoTrooper = new TrooperArena(Blaster.EC17);                    
                        break;
                    case "Tropper Asalto":
                        auxNuevoTrooper = new TrooperAsalto(Blaster.E11);
                        break;
                    case "Tropper Explorador":
                        auxNuevoTrooper = new TrooperExplorador("Moto");
                        break;
                }                
                this.ejercitoImperial -= auxNuevoTrooper;
                RefrescarEjercito();
            }
        }
    }
}
