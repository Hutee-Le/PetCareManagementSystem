using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareManagementSystem.GUI.CustomControls
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 20;

        public int Radius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            SetRoundedShape();
        }

        private void SetRoundedShape()
        {
            Rectangle bounds = new Rectangle(0, 0, Width, Height);
            float r2 = Radius / 2f;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, Radius, Radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - Radius, bounds.Y, Radius, Radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - Radius, bounds.Y + bounds.Height - Radius, Radius, Radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - Radius, Radius, Radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
