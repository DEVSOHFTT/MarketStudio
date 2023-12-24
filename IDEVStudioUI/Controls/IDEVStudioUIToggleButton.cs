using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias de windows forms
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace IDEVStudioUI.Controls
{
    public class IDEVStudioUIToggleButton : CheckBox
    {
        #region PROPIEDADES
        //ON
        Color onBackColor;
        Color onToggleColor;
        //OFF
        Color offBackColor;
        Color offToggleColor;

        bool solidStyle;

        //ENCAPSULAMIENTO
        [Category("IDEV Studio Properties")]
        public Color OnBackColor { get { return onBackColor; } set { onBackColor = value; this.Invalidate(); } }
        [Category("IDEV Studio Properties")]
        public Color OnToggleColor { get { return onToggleColor; } set { onToggleColor = value; this.Invalidate(); } }
        [Category("IDEV Studio Properties")]
        public Color OffBackColor { get { return offBackColor; } set { offBackColor = value; this.Invalidate(); } }
        [Category("IDEV Studio Properties")]
        public Color OffToggleColor { get { return offToggleColor; } set { offToggleColor = value; this.Invalidate(); } }
        [Category("IDEV Studio Properties")]
        public bool SolidStyle { get { return solidStyle; } set { solidStyle = value; this.Invalidate(); } }
        #endregion

        #region METODOS
        public IDEVStudioUIToggleButton()
        {
            this.onBackColor = Color.MediumSlateBlue;
            this.onToggleColor = Color.WhiteSmoke;
            this.offBackColor = Color.Gray;
            this.offToggleColor = Color.Gainsboro;
            this.solidStyle = false;

            this.AutoSize = false;
            this.MinimumSize = new Size(45, 22);
            this.MaximumSize = new Size(45, 22);
            this.Size = new Size(45, 22);
        }

        //Ruta de graficos para la superficie del control
        GraphicsPath GetFiguePath()
        {
            int arcSize = this.Height -1;
            Rectangle leftArc = new Rectangle(0,0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2,0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }
        #endregion

        #region EVENTOS
        //Pintar el control desde el comienzo
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            //Estados del control
            if (this.Checked)
            {
                //ON
                //Dibujar la superficie del control
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFiguePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFiguePath());
                //Dibujar la palanca del control
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height +1, 2, toggleSize, toggleSize));
            }
            else
            {
                //OFF
                //Dibujar la superficie del control
                if(solidStyle)
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFiguePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFiguePath());
                //Dibujar la palanca del control
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
        #endregion
    }
}
