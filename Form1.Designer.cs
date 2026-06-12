namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bebida = new Label();
            TxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            B_agregar = new Button();
            CmTamanio = new ComboBox();
            lb_Extra = new Label();
            rb_caliente = new RadioButton();
            rb_fria = new RadioButton();
            rb_alcoholica = new RadioButton();
            TxPrecio = new TextBox();
            TxExtra = new TextBox();
            T_bebidas = new Label();
            lis_Bebidas = new ListBox();
            Descripcion = new Label();
            _ = new ListBox();
            SuspendLayout();
            // 
            // Bebida
            // 
            Bebida.AutoSize = true;
            Bebida.Location = new Point(25, 132);
            Bebida.Name = "Bebida";
            Bebida.Size = new Size(137, 25);
            Bebida.TabIndex = 0;
            Bebida.Text = "Nombre Bebida";
            // 
            // TxNombre
            // 
            TxNombre.Location = new Point(25, 170);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(270, 31);
            TxNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(704, 60);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO AL MENU DE PEDIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 216);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Tamanio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 313);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // B_agregar
            // 
            B_agregar.BackColor = Color.FromArgb(255, 128, 0);
            B_agregar.Cursor = Cursors.Hand;
            B_agregar.Location = new Point(25, 508);
            B_agregar.Name = "B_agregar";
            B_agregar.Size = new Size(112, 34);
            B_agregar.TabIndex = 5;
            B_agregar.Text = "Agregar";
            B_agregar.UseVisualStyleBackColor = false;
            B_agregar.Click += B_agregar_Click_1;
            // 
            // CmTamanio
            // 
            CmTamanio.Cursor = Cursors.Hand;
            CmTamanio.FormattingEnabled = true;
            CmTamanio.Items.AddRange(new object[] { "Chico", "Mediano", "Grande", "Extra Grande" });
            CmTamanio.Location = new Point(25, 256);
            CmTamanio.Name = "CmTamanio";
            CmTamanio.Size = new Size(182, 33);
            CmTamanio.TabIndex = 6;
            // 
            // lb_Extra
            // 
            lb_Extra.AutoSize = true;
            lb_Extra.Location = new Point(25, 401);
            lb_Extra.Name = "lb_Extra";
            lb_Extra.Size = new Size(110, 25);
            lb_Extra.TabIndex = 7;
            lb_Extra.Text = "Temperatura";
            // 
            // rb_caliente
            // 
            rb_caliente.AutoSize = true;
            rb_caliente.BackColor = Color.Red;
            rb_caliente.Cursor = Cursors.Hand;
            rb_caliente.Location = new Point(25, 84);
            rb_caliente.Name = "rb_caliente";
            rb_caliente.Size = new Size(155, 29);
            rb_caliente.TabIndex = 8;
            rb_caliente.TabStop = true;
            rb_caliente.Text = "Bebida caliente";
            rb_caliente.UseVisualStyleBackColor = false;
            rb_caliente.CheckedChanged += rb_caliente_CheckedChanged;
            // 
            // rb_fria
            // 
            rb_fria.AutoSize = true;
            rb_fria.BackColor = Color.FromArgb(128, 255, 255);
            rb_fria.Cursor = Cursors.Hand;
            rb_fria.Location = new Point(195, 84);
            rb_fria.Name = "rb_fria";
            rb_fria.Size = new Size(121, 29);
            rb_fria.TabIndex = 9;
            rb_fria.TabStop = true;
            rb_fria.Text = "Bebida fria";
            rb_fria.UseVisualStyleBackColor = false;
            // 
            // rb_alcoholica
            // 
            rb_alcoholica.AutoSize = true;
            rb_alcoholica.BackColor = Color.Fuchsia;
            rb_alcoholica.Cursor = Cursors.Hand;
            rb_alcoholica.Location = new Point(322, 84);
            rb_alcoholica.Name = "rb_alcoholica";
            rb_alcoholica.Size = new Size(174, 29);
            rb_alcoholica.TabIndex = 10;
            rb_alcoholica.TabStop = true;
            rb_alcoholica.Text = "Bebida alcoholica";
            rb_alcoholica.UseVisualStyleBackColor = false;
            // 
            // TxPrecio
            // 
            TxPrecio.Location = new Point(25, 352);
            TxPrecio.Name = "TxPrecio";
            TxPrecio.Size = new Size(270, 31);
            TxPrecio.TabIndex = 11;
            // 
            // TxExtra
            // 
            TxExtra.Location = new Point(25, 446);
            TxExtra.Name = "TxExtra";
            TxExtra.Size = new Size(270, 31);
            TxExtra.TabIndex = 12;
            // 
            // T_bebidas
            // 
            T_bebidas.AutoSize = true;
            T_bebidas.BackColor = SystemColors.ActiveBorder;
            T_bebidas.Location = new Point(892, 392);
            T_bebidas.Name = "T_bebidas";
            T_bebidas.Size = new Size(182, 25);
            T_bebidas.TabIndex = 14;
            T_bebidas.Text = "0 bebidas registradas";
            // 
            // lis_Bebidas
            // 
            lis_Bebidas.BackColor = SystemColors.InfoText;
            lis_Bebidas.ForeColor = SystemColors.Window;
            lis_Bebidas.FormattingEnabled = true;
            lis_Bebidas.ItemHeight = 25;
            lis_Bebidas.Location = new Point(840, 50);
            lis_Bebidas.Name = "lis_Bebidas";
            lis_Bebidas.Size = new Size(405, 204);
            lis_Bebidas.TabIndex = 15;
            lis_Bebidas.SelectedIndexChanged += lis_Bebidas_SelectedIndexChanged_1;
            // 
            // Descripcion
            // 
            Descripcion.BackColor = SystemColors.ScrollBar;
            Descripcion.Location = new Point(779, 270);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(477, 52);
            Descripcion.TabIndex = 16;
            // 
            // _
            // 
            _.BackColor = Color.GreenYellow;
            _.ForeColor = Color.GreenYellow;
            _.FormattingEnabled = true;
            _.ItemHeight = 25;
            _.Location = new Point(0, 550);
            _.Name = "_";
            _.Size = new Size(1271, 154);
            _.TabIndex = 18;
            _.UseTabStops = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1268, 604);
            Controls.Add(_);
            Controls.Add(Descripcion);
            Controls.Add(lis_Bebidas);
            Controls.Add(T_bebidas);
            Controls.Add(TxExtra);
            Controls.Add(TxPrecio);
            Controls.Add(rb_alcoholica);
            Controls.Add(rb_fria);
            Controls.Add(rb_caliente);
            Controls.Add(lb_Extra);
            Controls.Add(CmTamanio);
            Controls.Add(B_agregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxNombre);
            Controls.Add(Bebida);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Bebida;
        private TextBox TxNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button B_agregar;
        private ComboBox CmTamanio;
        private Label lb_Extra;
        private RadioButton rb_caliente;
        private RadioButton rb_fria;
        private RadioButton rb_alcoholica;
        private TextBox TxPrecio;
        private TextBox TxExtra;
        private Label T_bebidas;
        private ListBox lis_Bebidas;
        private Label Descripcion;
        private ListBox _;
    }
}
