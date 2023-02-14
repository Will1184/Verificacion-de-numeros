using System.Data;

namespace GM21057Guia4Ejerecicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Numero numeros = new Numero();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresarNum_Click(object sender, EventArgs e)
        {
            int c = 0;
            int n = datos.Rows.Add();
            int[] num=new int[10];
            int numNegativos=0, numPositivos=0, numMultiplosQuince=0,sumaPares=0;
            for (int i = 0; i < 10; i++)
            {
                c++;
                num[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero: " + c));

            }
            for (int i = 0; i < num.Length; i++)
            {
                
                if (num[i] < 0)
                {
                    numNegativos++;
                }
                if (num[i] > 0)
                {
                    numPositivos++;
                }
                if (num[i] %15==0)
                {
                    numMultiplosQuince++;
                }
                if (num[i] %2==0)
                {
                    sumaPares = sumaPares + num[i];
                }
            }
            datos.Rows[n].Cells[0].Value = numNegativos.ToString();
            datos.Rows[n].Cells[1].Value = numPositivos.ToString();
            datos.Rows[n].Cells[2].Value = numMultiplosQuince .ToString();
            datos.Rows[n].Cells[3].Value = sumaPares.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}