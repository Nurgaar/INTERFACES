using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trival
{
    public partial class FrmTrivial : Form
    {
        int paisaleatorio;
        int respuestacorrecta=0;
        int acertadas = 0;
        int falladas = 0;
        int i = 0;
        int j = 0;
        int modo;
      
        Random rnd = new Random();
        
        int aleatorio2;
        int aleatorio3;

        String[] paises = { "España", "Dinamarca", "Japón", "Francia", "Moldavia", "Atenas" };
        String[] capitales = { "Madrid", "Copenhague", "Tokio", "París", "Chisinau", "Grecia" };
        public FrmTrivial()
        {
            InitializeComponent();

           
            txtRespuesta1.Text = capitales[1];
            txtRespuesta2.Text = capitales[2];
            txtRespuesta3.Text = capitales[0];
            txtRespuesta4.Text = capitales[4];

            txtPregunta.Text = paises[paisaleatorio];
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmTrivial_Load(object sender, EventArgs e)
        {
            
        }

        private void MnuPartidaNueva_Click(object sender, EventArgs e)
        {

            acertadas = 0;
            falladas = 0;

            TxtPorcentaje.Text = "";
            TxtResultado.Text = "";
        
            if(modo==0)
            {
                txtPregunta.Text = paises[0];
                txtRespuesta1.Text = capitales[0];
                txtRespuesta2.Text = capitales[1];
                txtRespuesta3.Text = capitales[2];
                txtRespuesta4.Text = capitales[3];
            }
            else
            {
                txtPregunta.Text = capitales[0];
                txtRespuesta1.Text = paises[0];
                txtRespuesta2.Text = paises[1];
                txtRespuesta3.Text = paises[2];
                txtRespuesta4.Text = paises[3];
            }
          
        }

        private void txtRespuesta1_TextClick(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;

            switch(txtPregunta.Text)
            {
                case "España":
                    {
                        if(tx.Text.Equals("Madrid"))
                        {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                            falladas++;
                        }
                    }
                    break;
                case "Francia":
                    {
                        if (tx.Text.Equals("París"))
                        {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                            
                            falladas++;
                        }
                    }
                    break;
                case "Moldavia":
                    {
                        if (tx.Text.Equals("Chisinau"))
                        {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                            falladas++;
                        }
                    }
                    break;

                case "Dinamarca":
                    {
                        if (tx.Text.Equals("Copenhague"))
                        {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                           
                            falladas++;
                        }
                    }
                    break;
                case "Atenas":
                    {
                        if (tx.Text.Equals("Grecia"))
                        {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                           
                            falladas++;
                        }
                    }
                    break;
                case "Japón":
                    {
                        if (tx.Text.Equals("Tokio"))
                            {
                            TxtResultado.Text = "Acertado";
                            acertadas++;
                            falladas++;
                        }
                        else
                        {
                            TxtResultado.Text = "ERROR";
                         
                            falladas++;
                        }
                       
                        break;
                    }


                   


            }

      
           

            TxtPorcentaje.Text = Convert.ToDouble((acertadas * 100 / falladas)).ToString() + "%";

        }
        public int[] Aleatorias()
        {
            int[] array = new int[4];
            
            for(int i = 0; i< array.Length;i++)
            {

                array[i] = rnd.Next(6);
                
                for(int j =0; j< i; j++)
                {
                    if(array[i] == array[j])
                    {
                        i--;
                    }
                }
            }
            return array;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
           
            
            paisaleatorio = rnd.Next(5);

            txtPregunta.Text = paises[paisaleatorio];

            
            int[] capitalesaleatorio = new int[4];
            capitalesaleatorio = Aleatorias();
            int numero = rnd.Next(6);
            if(modo==0)
            {
                txtPregunta.Text = paises[numero];
                txtRespuesta1.Text = capitales[capitalesaleatorio[0]];
                txtRespuesta2.Text = capitales[capitalesaleatorio[1]];
                txtRespuesta3.Text = capitales[capitalesaleatorio[2]];
                txtRespuesta4.Text = capitales[capitalesaleatorio[3]];

                switch(numero)
                {
                    case 0:
                        {
                            if(txtRespuesta1.Text.Equals(capitales[0]))
                                {
                                txtRespuesta1.Text = capitales[0];
                                }
                            else if (txtRespuesta2.Text.Equals(capitales[0]))
                                {
                                txtRespuesta2.Text = capitales[0];
                                }
                            else if(txtRespuesta3.Text.Equals(capitales[0]))
                                {
                                txtRespuesta3.Text = capitales[0];
                            }
                            else if(txtRespuesta4.Text.Equals(capitales[0]))
                                {
                                txtRespuesta4.Text = capitales[0];
                            }
                            else
                            {
                                txtRespuesta4.Text = capitales[0];
                            }
                            break;

                        }
                    case 1:
                        {
                            if (txtRespuesta1.Text.Equals(capitales[1]))
                            {
                                txtRespuesta1.Text = capitales[1];
                            }
                            else if (txtRespuesta2.Text.Equals(capitales[1]))
                            {
                                txtRespuesta2.Text = capitales[1];
                            }
                            else if (txtRespuesta3.Text.Equals(capitales[1]))
                            {
                                txtRespuesta3.Text = capitales[1];
                            }
                            else if (txtRespuesta4.Text.Equals(capitales[1]))
                            {
                                txtRespuesta4.Text = capitales[1];
                            }
                            else
                            {
                                txtRespuesta4.Text = capitales[1];
                            }
                            break;

                        }
                    case 3:
                        {
                            if (txtRespuesta1.Text.Equals(capitales[3]))
                            {
                                txtRespuesta1.Text = capitales[3];
                            }
                            else if (txtRespuesta2.Text.Equals(capitales[3]))
                            {
                                txtRespuesta2.Text = capitales[3];
                            }
                            else if (txtRespuesta3.Text.Equals(capitales[3]))
                            {
                                txtRespuesta3.Text = capitales[3];
                            }
                            else if (txtRespuesta4.Text.Equals(capitales[3]))
                            {
                                txtRespuesta4.Text = capitales[3];
                            }
                            else
                            {
                                txtRespuesta4.Text = capitales[3];
                            }
                            break;

                        }
                    case 4:
                        {
                            if (txtRespuesta1.Text.Equals(capitales[4]))
                            {
                                txtRespuesta1.Text = capitales[4];
                            }
                            else if (txtRespuesta2.Text.Equals(capitales[4]))
                            {
                                txtRespuesta2.Text = capitales[4];
                            }
                            else if (txtRespuesta3.Text.Equals(capitales[4]))
                            {
                                txtRespuesta3.Text = capitales[4];
                            }
                            else if (txtRespuesta4.Text.Equals(capitales[4]))
                            {
                                txtRespuesta4.Text = capitales[4];
                            }
                            else
                            {
                                txtRespuesta4.Text = capitales[4];
                            }
                            break;

                        }

                   
                }
                 
            }
            else
            {
                txtPregunta.Text = capitales[numero];
                txtRespuesta1.Text = paises[capitalesaleatorio[0]];
                txtRespuesta2.Text = paises[capitalesaleatorio[1]];
                txtRespuesta3.Text = paises[capitalesaleatorio[2]];
                txtRespuesta4.Text = paises[capitalesaleatorio[3]];
                switch(numero)
                {
                    case 0:
                        {
                            if (txtRespuesta1.Text.Equals(paises[0]))
                            {
                                txtRespuesta1.Text = paises[0];
                            }
                            else if (txtRespuesta2.Text.Equals(paises[0]))
                            {
                                txtRespuesta2.Text = paises[0];
                            }
                            else if (txtRespuesta3.Text.Equals(paises[0]))
                            {
                                txtRespuesta3.Text = paises[0];
                            }
                            else if (txtRespuesta4.Text.Equals(paises[0]))
                            {
                                txtRespuesta4.Text = paises[0];
                            }
                            else
                            {
                                txtRespuesta4.Text = paises[0];
                            }
                            break;

                        }
                    case 1:
                        {
                            if (txtRespuesta1.Text.Equals(paises[1]))
                            {
                                txtRespuesta1.Text = paises[1];
                            }
                            else if (txtRespuesta2.Text.Equals(paises[1]))
                            {
                                txtRespuesta2.Text = paises[1];
                            }
                            else if (txtRespuesta3.Text.Equals(paises[1]))
                            {
                                txtRespuesta3.Text = paises[1];
                            }
                            else if (txtRespuesta4.Text.Equals(paises[1]))
                            {
                                txtRespuesta4.Text = paises[1];
                            }
                            else
                            {
                                txtRespuesta4.Text = paises[1];
                            }
                            break;

                        }
                    case 3:
                        {
                            if (txtRespuesta1.Text.Equals(paises[3]))
                            {
                                txtRespuesta1.Text = paises[3];
                            }
                            else if (txtRespuesta2.Text.Equals(paises[3]))
                            {
                                txtRespuesta2.Text = paises[3];
                            }
                            else if (txtRespuesta3.Text.Equals(paises[3]))
                            {
                                txtRespuesta3.Text = paises[3];
                            }
                            else if (txtRespuesta4.Text.Equals(paises[3]))
                            {
                                txtRespuesta4.Text = paises[3];
                            }
                            else
                            {
                                txtRespuesta4.Text = paises[3];
                            }
                            break;

                        }
                    case 4:
                        {
                            if (txtRespuesta1.Text.Equals(paises[4]))
                            {
                                txtRespuesta1.Text = paises[4];
                            }
                            else if (txtRespuesta2.Text.Equals(paises[4]))
                            {
                                txtRespuesta2.Text = paises[4];
                            }
                            else if (txtRespuesta3.Text.Equals(paises[4]))
                            {
                                txtRespuesta3.Text = paises[4];
                            }
                            else if (txtRespuesta4.Text.Equals(paises[4]))
                            {
                                txtRespuesta4.Text = paises[4];
                            }
                            else
                            {
                                txtRespuesta4.Text = paises[4];
                            }
                            break;

                        }
                }
            }
        }

        private void TxtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRespuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIÓS");
            Application.Exit();
            
        }

        private void MnuPartidaSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIÓS");
            Application.Exit();
        }

        private void MnuOpciones_Click(object sender, EventArgs e)
        {

        }

        private void MnuOpcionesNombrePaises_Click(object sender, EventArgs e)
        {
            modo = 1;
            LblPais.Text = "Capital";
            LblCapital.Text = "País";
        }

        private void txtRespuesta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRespuesta3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRespuesta4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MnuOpcionesNombreCapital_Click(object sender, EventArgs e)
        {
            modo = 0;
            LblPais.Text = "País";
            LblCapital.Text = "Capital";
        }
    }
    }