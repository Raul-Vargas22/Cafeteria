namespace Cafeteria
{
    public partial class Form1 : Form
    {
        private List<Bebida> bebidas;
        public Form1()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }

        private void rb_caliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_caliente.Checked == true)
            {
                lb_Extra.Text = "Temperatura";
            }
            else if (rb_fria.Checked == true)
            {
                lb_Extra.Text = "Hielos";
            }
            else
            {
                lb_Extra.Text = "Porcentaje de alcohol";
            }
        }

        private void Limpiarcomponentes()
        {
            TxNombre.Clear();
            TxPrecio.Clear();
            TxExtra.Clear();
            CmTamanio.SelectedIndex = -1;
        }

        private void lis_Bebidas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Descripcion.Text = bebidas[lis_Bebidas.SelectedIndex].Preparar();
        }

        private void B_agregar_Click_1(object sender, EventArgs e)
        {
            string nombre = TxNombre.Text.Trim();
            string tamano = CmTamanio.Text.Trim();
            float precio = float.Parse(TxPrecio.Text.Trim());
            int extra = int.Parse(TxExtra.Text.Trim());

            if (rb_caliente.Checked)
            {
                bebidas.Add(new Bebida_caliente(nombre, tamano, precio, extra));
            }
            else if (rb_fria.Checked)
            {
                bebidas.Add(new Bebida_fria(nombre, tamano, precio, extra));
            }
            else
            {
                bebidas.Add(new Bebida_alcoholica(nombre, tamano, precio, extra));
            }


            if (bebidas[bebidas.Count - 1] is Bebida_fria fria)
            {
                lis_Bebidas.Items.Add(fria.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is Bebida_caliente caliente)
            {
                lis_Bebidas.Items.Add(caliente.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is Bebida_alcoholica alcoholica)
            {
                lis_Bebidas.Items.Add(alcoholica.Mensaje());
            }

            T_bebidas.Text = bebidas.Count + " Bebidas Registradas";
            Limpiarcomponentes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
