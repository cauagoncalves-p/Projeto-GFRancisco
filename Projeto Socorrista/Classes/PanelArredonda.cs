using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista.Classes
{
    public class PanelArredonda
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect, int nTopRect,
          int nRightRect, int nBottomRect,
          int nWidthEllipse, int nHeightEllipse);

        /// <summary>
        /// Aplica bordas arredondadas a um Panel específico.
        /// </summary>
        /// <param name="panel">O Panel que você quer arredondar</param>
        /// <param name="radius">O raio do arredondamento</param>
        public void ArredondarPanel(Panel panel, int radius)
        {
            if (panel == null) return;

            panel.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, panel.Width, panel.Height, radius, radius));

            // Atualiza se o tamanho mudar
            panel.SizeChanged += (s, e) =>
            {
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(
                    0, 0, panel.Width, panel.Height, radius, radius));
            };
        }
    }
}
