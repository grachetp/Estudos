using System;

namespace Paramentros_Nomeados
{
    public class Dialogo
    {
        public void Show(DialogoParams parametros)
        {
            // ...
        }
    }

    public class DialogoParams
    {
        public string mensagem;
        public bool mostrarBotaoOK;
        public bool mostrarBotaoNo;
        public bool mostrarBotaoCancel;
        public int delay;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlg = new Dialogo();
            //dlg.Show(mensagem: "Confirmar operação?", mostrarBotaoOK: true, mostrarBotaoNo: true , mostrarBotaoCancel: false, 10);
            //dlg.Show(mostrarBotaoOK: true, mostrarBotaoNo: true, mensagem: "Confirmar operação?", mostrarBotaoCancel: false, delay: 10);

            var paramentros = new DialogoParams()
            {
                mostrarBotaoOK = true,
                mostrarBotaoNo = true,
                mensagem = "Confirmar operação?",
                mostrarBotaoCancel = false,
                delay = 10
            };

            var dlg2 = new Dialogo();
            dlg2.Show(paramentros);


        }
    }
}
