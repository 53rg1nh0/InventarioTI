using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Extencions
{
    static class ControlExtencion
    {
        static int intMouse_x, intMouse_y;
        static Point pointNovo;
        static bool booMouseDown = false;
        private static void MouseDown(Object sender, MouseEventArgs e)
        {

            booMouseDown = true;
            intMouse_x = Control.MousePosition.X - FormInventario.ActiveForm.Location.X;
            intMouse_y = Control.MousePosition.Y - FormInventario.ActiveForm.Location.Y;
        }

        private static void MouseUp(Object sender, MouseEventArgs e)
        {
            booMouseDown = false;
        }

        private static void MouseMove(Object sender, MouseEventArgs e)
        {

            if (booMouseDown)
            {
                pointNovo = Control.MousePosition;
                pointNovo.X -= intMouse_x;
                pointNovo.Y -= intMouse_y;
                FormInventario.ActiveForm.Location = pointNovo;
                Application.DoEvents();
            }
        }

        public static void Arrastar(this Control conteiner)
        {
            foreach (Control c in conteiner.Controls)
            {
                Type tipo = c.GetType();
                if (tipo != typeof(Button) && tipo != typeof(TextBox) && tipo != typeof(ComboBox) &&  tipo != typeof(PictureBox)
                    && c.Name != "dgvCliente" && c.Name != "dgvEquipamento")
                {
                    c.MouseDown += MouseDown;
                    c.MouseUp += MouseUp;
                    c.MouseMove += MouseMove;
                }
                if(c.Name=="ptbSobre" || c.Name == "ptbSobreSolar" || c.Name == "ptbPrograma")
                {
                    c.MouseDown += MouseDown;
                    c.MouseUp += MouseUp;
                    c.MouseMove += MouseMove;
                }
                if (c.Controls.Count != 0)
                {
                    Arrastar(c);
                }

            }
        }       
    }
}
