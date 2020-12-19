using System.Windows.Forms;

namespace Sierpinski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gfxEngine.Initialize(canvas);

            // gfxEngine.drawSierpinskiTriangle_Random(5);

            gfxEngine.drawPolyFractal_Fixed(40,10);
        }
    }
}
