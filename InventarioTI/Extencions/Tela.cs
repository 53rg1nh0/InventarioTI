namespace InventarioTI.Extencions
{
    public static class Tela
    {
        private static float _dpiX, _dpiY;

        public static float Fator { get; set; }

        static Tela()
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                //_dpiX = graphics.DpiX;
                //_dpiY = graphics.DpiY;
                //Fator = 96 / _dpiX;

                _dpiX = Properties.Settings.Default.Resolucao;
                _dpiY = graphics.DpiY;
                Fator = 96 / _dpiX*(Properties.Settings.Default.Resolucao == 144f ? 1.2f : 1);
            }
        }

        //public static void Escala(this Control fr)
        //{
        //    fr.Scale(new SizeF(_dpiX / 96, _dpiY / 96));
        //foreach (Control c in fr.Controls)
        //{
        //    Type tipo = c.GetType();
        //    if (tipo == typeof(Label) || tipo == typeof(TextBox) || tipo == typeof(ComboBox) || tipo == typeof(CheckBox))
        //    {
        //        c.Font = new(c.Font.FontFamily, c.Font.Size * (Fator), c.Font.Style);
        //    }

        //    if (c.Controls.Count != 0)
        //    {
        //        Escala(c);
        //    }

        //}
        //}

        public static void Escala(this Control fr)
        {
            if (Properties.Settings.Default.Resolucao == 144f && fr is Form) fr.Scale(1.2f);
           
            foreach (Control c in fr.Controls)
            {
                Type tipo = c.GetType();
                if (tipo == typeof(Label) ||/* tipo == typeof(TextBox) || tipo == typeof(ComboBox) ||*/ tipo == typeof(CheckBox))
                {
                    c.Font = new(c.Font.FontFamily, c.Font.Size * (Fator), c.Font.Style);
                }
                if (_dpiX == 144f && (tipo == typeof(TextBox) || tipo == typeof(ComboBox)))
                {
                    c.Font = new(c.Font.FontFamily, c.Font.Size * (Fator * 1.6f), c.Font.Style);
                }
                if (!(tipo.Name == "ptbHome" || tipo.Name == "ptbAjustes" || tipo.Name == "ptbSobre") || tipo.Name == "FormInventario")
                {
                    c.Margin = new Padding((int)(c.Margin.Left * Fator), (int)(c.Margin.Top * Fator), (int)(c.Margin.Right * Fator), (int)(c.Margin.Bottom * Fator));
                    c.Padding = new Padding((int)(c.Padding.Left * Fator), (int)(c.Padding.Top * Fator), (int)(c.Padding.Right * Fator), (int)(c.Padding.Bottom * Fator));
                }

                if (c.Controls.Count != 0)
                {
                    Escala(c);
                }
            }

        }
    }
}
