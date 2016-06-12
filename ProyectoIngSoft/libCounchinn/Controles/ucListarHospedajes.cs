﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCounchinn.Clases;
using libCounchinn.Modelo;

namespace libCounchinn.Controles
{
    public partial class ucListarHospedajes : UserControl
    {
        private ModeloLibCouchin VarModelo;
        private bool log;
        public event DelegadoVerDetalle VerDetalle;

        public ucListarHospedajes()
        {
            InitializeComponent();

        }

        public void Inicializar()
        {
            if (ElUsuarioLogeado.UsuarioLogeado != null)
            {
                log = true;
            }
            else
            {
                log = false;
            }
            try
            {
                this.VarModelo = new ModeloLibCouchin(ClaseDeConfiguracion.EFConnectionString);
                this.bindingSourceListarHospedajes.DataSource = this.VarModelo.SEL_IMAGENESPUBLICACION();
            }
            catch 
            {

            }

        }

        private void dataRepeater1_ItemTemplate_Click(object sender, EventArgs e)
        {
           int idPub =  Convert.ToInt32(dataRepeater1.CurrentItem.Controls["mlbIdPublicacion"].Text);
            if (this.VerDetalle !=  null)
            {
                this.SendToBack();
                this.VerDetalle(idPub);
            }
        }

        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
            if (log)
            {
                MetroFramework.Controls.MetroLink lin = (e.DataRepeaterItem.Controls["metroLink1"] as MetroFramework.Controls.MetroLink);
                lin.Visible = true;
                e.DataRepeaterItem.Controls.Add(lin);
            }
            else
            {
                MetroFramework.Controls.MetroLink lin = (e.DataRepeaterItem.Controls["metroLink1"] as MetroFramework.Controls.MetroLink);
                lin.Visible = false;
                e.DataRepeaterItem.Controls.Add(lin);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.dataRepeater1.Focus();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.dataRepeater1.Focus();
        }
    }
}
