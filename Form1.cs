using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnCalcularNota_Click(object sender, EventArgs e)
        {
            int sumaNota = 0;
            int calculofinal=0;           

            sumaNota = int.Parse(txtPrimerParcial.Text) + int.Parse(txtSegundoParcial.Text) +
                int.Parse(txtPractica.Text) + int.Parse(txtAsistencia.Text) +
                int.Parse(txtExamenFinal.Text);

            calculofinal = sumaNota/5;

            txtNotaFinal.Text = $"{calculofinal}";
        }


        public void validacion (int calculo)
        {

            if (calculofinal => 95)
            {
                txtMensaje.Text = $"Su nota Final es:\n +" +
                    $"";
            }


        }

    }


    }

}
