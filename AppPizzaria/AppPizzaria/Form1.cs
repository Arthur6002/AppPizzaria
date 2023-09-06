using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            string Pizza, Borda,Bebida, Mensagem = $"{txtCliente.Text}\n";
            double ValorPizza, ValorBorda, ValorBebida;

            if(rdbModa.Checked)
            {
                Pizza = rdbModa.Text;
                ValorPizza = double.Parse(lblModa.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbAtum.Checked)
            {
                Pizza = rdbAtum.Text;
                ValorPizza = double.Parse(lblAtum.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbBaiana.Checked)
            {
                Pizza = rdbBaiana.Text;
                ValorPizza = double.Parse(lblBaiana.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbBrocolis.Checked)
            {
                Pizza = rdbAtum.Text;
                ValorPizza = double.Parse(lblBrocolis.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbCalabresa.Checked)
            {
                Pizza = rdbCalabresa.Text;
                ValorPizza = double.Parse(lblCalabresa.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbMussarela.Checked)
            {
                Pizza = rdbMussarela.Text;
                ValorPizza = double.Parse(lblMussarela.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbQuatro.Checked)
            {
                Pizza = rdbQuatro.Text;
                ValorPizza = double.Parse(lblQuatro.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }
            else if (rdbStrogonoff.Checked)
            {
                Pizza = rdbStrogonoff.Text;
                ValorPizza = double.Parse(lblStrogonof.Text);
                Mensagem += $"Pizza:{Pizza}=R${ValorPizza}";
            }

            if(rdbCatupiry.Checked)
            {
                Borda = rdbCatupiry.Text;
                ValorBorda = double.Parse(lblCatupiry.Text);
                Mensagem += $"\nBorda: {Borda}= R${ValorBorda}";
            }
            else if (rdbCheddar.Checked)
            {
                Borda = rdbCheddar.Text;
                ValorBorda = double.Parse(lblCheddar.Text);
                Mensagem += $"\nBorda: {Borda}= R${ValorBorda}";
            }

            if (ckbCervejaG.Checked)
            {
                Bebida = ckbCervejaG.Text;
                ValorBebida = double.Parse(lblCervejaG.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbCervejaL.Checked)
            {
                Bebida = ckbCervejaL.Text;
                ValorBebida = double.Parse(lblCervejaL.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbCocaLa.Checked)
            {
                Bebida = ckbCocaLa.Text;
                ValorBebida = double.Parse(lblCocaLa.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbCocaLi.Checked)
            {
                Bebida = ckbCocaLi.Text;
                ValorBebida = double.Parse(lblCocaLi.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbGuaranaLa.Checked)
            {
                Bebida = ckbGuaranaLa.Text;
                ValorBebida = double.Parse(lblGuaranaLa.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbGuaranaLi.Checked)
            {
                Bebida = ckbGuaranaLi.Text;
                ValorBebida = double.Parse(lblGuaranaLi.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbAbacaxiC.Checked)
            {
                Bebida = ckbAbacaxiC.Text;
                ValorBebida = double.Parse(lblAbacaxiC.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbAbacaxiJ.Checked)
            {
                Bebida = ckbAbacaxiJ.Text;
                ValorBebida = double.Parse(lblAbacaxiJ.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbLaranjaJ.Checked)
            {
                Bebida = ckbLaranjaJ.Text;
                ValorBebida = double.Parse(lblLaranjaJ.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbLaranjaC.Checked)
            {
                Bebida = ckbLaranjaC.Text;
                ValorBebida = double.Parse(lblLaranjaC.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbMaracujaC.Checked)
            {
                Bebida = ckbMaracujaC.Text;
                ValorBebida = double.Parse(lblMaracujaC.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            if (ckbMaracujaJ.Checked)
            {
                Bebida = ckbMaracujaJ.Text;
                ValorBebida = double.Parse(lblMaracujaJ.Text);
                Mensagem += $"\nBebida: {Bebida}= R${ValorBebida}";
            }
            MessageBox.Show(Mensagem);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbModa.Checked = false;
            rdbAtum.Checked = false;
            rdbBaiana.Checked = false;
            rdbBrocolis.Checked = false;
            rdbCalabresa.Checked = false;
            rdbMussarela.Checked = false;
            rdbQuatro.Checked = false;
            rdbStrogonoff.Checked = false;
            rdbCatupiry.Checked = false;
            rdbCheddar.Checked = false;
            ckbCervejaG.Checked = false;
            ckbCervejaL.Checked = false;
            ckbCocaLi.Checked = false;
            ckbCocaLa.Checked = false;
            ckbGuaranaLi.Checked = false;
            ckbGuaranaLa.Checked = false;
            ckbAbacaxiC.Checked = false;
            ckbAbacaxiJ.Checked = false;
            ckbLaranjaC.Checked = false;
            ckbLaranjaJ.Checked = false;
            ckbMaracujaC.Checked = false;
            ckbMaracujaJ.Checked = false;
        }
    }
}
