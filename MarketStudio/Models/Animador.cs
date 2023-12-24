using IDEVStudioUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    public static class Animador
    {
        public static void ExaltarBotonLayout_MouseEnter(Control ctrl)
        {
            Control parent = ctrl.Parent;
            parent.Padding = new Padding(4, 4, 4, 4);
            Reproductor.Play(TypeSound.Enter);
        }
        public static void ExaltarBotonLayout_MouseLeave(Control ctrl)
        {
            Control parent = ctrl.Parent;
            parent.Padding = new Padding(6, 6, 6, 6);
        }

        public static void ExaltarLabelLayout_MouseEnter(Control ctrl, Control pic)
        {
            ExaltarBotonLayout_MouseEnter(pic);
            ctrl.ForeColor = Color.FromArgb(90,215,255);
            Reproductor.Play(TypeSound.Enter);
        }
        public static void ExaltarLabelLayout_MouseLeave(Control ctrl, Control pic)
        {
            ExaltarBotonLayout_MouseLeave(pic);
            ctrl.ForeColor = Color.White;
        }
    }
}
