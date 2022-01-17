using System;
using System.Runtime.InteropServices;

namespace LabAPP.Util
{
    public class Util
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }

    public class Mensagem
    {
        private Mensagem(string value) { Value = value; }

        public string Value { get; private set; }

        public static Mensagem NDeuCerto { get { return new Mensagem("Algo não deu certo!"); } }

        public static Mensagem AnaliseCamposVazios { get { return new Mensagem("Existe campos vazios!"); } }

        public static Mensagem ErroThread { get { return new Mensagem("Houve erro em algum fluxo, alguma thread quebrou!"); } }

    }
}
