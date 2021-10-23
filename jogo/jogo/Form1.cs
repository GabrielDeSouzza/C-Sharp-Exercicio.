using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form1 : Form
    {
        int vlr_aleatorio = Aleatorio();
        int tentativa = 2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Vlr_digi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convert_vlr_digi = Convert.ToInt32(vlr_digi.Text);

                
                label1.Text = $"Eu pensei em um número entre 1 e 1000. Você consegue adivinhar qual é? Digite sua {tentativa++}° tentativa de adivinhar.";

                if (convert_vlr_digi == vlr_aleatorio)
                {
                    label2.Visible = true;
                    label2.Text = "Correto!";
                    vlr_digi.BackColor = Color.Green;
                    BackColor = Color.Red;
                }
                else
                {

                    label2.Text = "";
                    label2.Visible = true;
                    if (convert_vlr_digi >= (vlr_aleatorio - vlr_aleatorio * 0.02) && convert_vlr_digi <= (vlr_aleatorio + vlr_aleatorio * 0.2))
                    {
                        vlr_digi.BackColor = Color.Red;

                        label2.Text = "Muito PERTO!!!";
                    }
                    else if (convert_vlr_digi >= (vlr_aleatorio - vlr_aleatorio * 0.05) && convert_vlr_digi <= (vlr_aleatorio + vlr_aleatorio * 0.05))
                    {
                        vlr_digi.BackColor = Color.Crimson;

                        label2.Text = "Quase lá!";
                    }
                    

                    else if (convert_vlr_digi >= (vlr_aleatorio - vlr_aleatorio * 0.10) && convert_vlr_digi <= (vlr_aleatorio + vlr_aleatorio * 0.10))
                    {
                        vlr_digi.BackColor = Color.OrangeRed;

                        label2.Text = "Ta ficando perto em!";
                    }
                    else if (convert_vlr_digi >= (vlr_aleatorio - vlr_aleatorio * 0.20) && convert_vlr_digi <= (vlr_aleatorio + vlr_aleatorio * 0.20))
                    {
                        vlr_digi.BackColor = Color.RoyalBlue;

                        label2.Text = "Um pouco mais de paciência e você consegue!";
                    }
                    else
                    {
                        vlr_digi.BackColor = Color.Blue;
                        label2.Text = "Tá longe!";
                    }
                }
            }
            catch
            {

            }
            }

        private void Label1_Click(object sender, EventArgs e)
        {
            // para ver qual o numero aleatorio click na label que faz a pergunta
            label1.Text =Convert.ToString( vlr_aleatorio);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vlr_aleatorio = Aleatorio();
        }
        public static int Aleatorio()
        {
            Random num_ale = new Random();
            return num_ale.Next(0, 1000);

        }

    
    }
  
        
   }
