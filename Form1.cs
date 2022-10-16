using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCompletoCCharp____
{
    public partial class Form1 : Form
    {
        float KmRodada = 0;
        float KmAutonomia = 0;
        float QtdCombustivel = 0;
        double ValorCombustivel, CustoDeCombustivel;



        public Form1()
        {
            InitializeComponent();
        }

        private void txtVeiculo_MouseLeave(object sender, EventArgs e)
        {
            if (txtVeiculo.Text == "carro")
            {
                imgVeiculo.Image = CursoCompletoCCharp____.Properties.Resources.carro_de_entrega_16028855;
            }
            else if (txtVeiculo.Text == "caminhão")
            {
                imgVeiculo.Image = CursoCompletoCCharp____.Properties.Resources.caminhao;
            }
            else if (txtVeiculo.Text == "Moto")
            {
                imgVeiculo.Image = CursoCompletoCCharp____.Properties.Resources.novamoto;
            }
            else
            {
                MessageBox.Show("Alternativa incorreta!!");
                txtVeiculo.Text = "";
                txtVeiculo.Focus();
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            float KmDobrado = 0;
            KmRodada = float.Parse(txtDistancia.Text);
            if (checkBoxIdaVolta.Checked == false)
            {
                KmDobrado = KmRodada * 1;
            }
            else
            {
                KmDobrado = KmRodada * 2; //Ida e volta por conta do false
            }
            //Consumo Combustivel
           QtdCombustivel = KmDobrado / float.Parse(txtAutonomia.Text);

            //Custo de Combustível//Vezes o valor que vem da tabela depois 1, 2 ou 3
            CustoDeCombustivel = double.Parse(txtValorCombustivel.Text) * QtdCombustivel;
            txtDispesaCombustivel.Text = CustoDeCombustivel.ToString();

            txtTotal.Text = Convert.ToString(CustoDeCombustivel * int.Parse(cbTabela.Text));

            txtConsumoCombustivel.Text = CustoDeCombustivel.ToString();
            txtKmRodado.Text = KmDobrado.ToString();
            txtCustoKm.Text = Convert.ToString(float.Parse(txtTotal.Text) / KmDobrado);

        }
    }
}
