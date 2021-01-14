using System;
using System.Data;

namespace _11___Metodos_de_Extensao
{

    public static class MyExtension //Deve ser static
    {
        public static void WriteJSON(this DataSet ds, string fileName) //Injeção ocorre aqui
        {
            //...
        }

        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataSet();
            ds.WriteJSON("dados.xml");
            string url = "pedrograchet";
            MyExtension.ToUrl(url);
        }
    }
}
