using System;
using System.Text;

namespace BaltaStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guids
            // var id = Guid.NewGuid();
            // id.ToString();
            // id = new Guid("574cccce-28d6-4cb9-b448-5dfdafe514dc");
            // Console.WriteLine(id.ToString().Substring(0, 8));

            // Interpolação de string
            // var price = 10.2;
            // var text = "O preço do produto é " + price;
            // var text2 = string.Format("O preço do produto é {0}", price);
            // var text3 = $"O preço do produto é {price}";
            // System.Console.WriteLine(text2);

            // Comparação de strings
            // var texto = "Testando";
            // System.Console.WriteLine(texto.CompareTo("Testando"));
            // System.Console.WriteLine(texto.CompareTo("testando"));
            // System.Console.WriteLine(texto.Contains("Test"));
            // System.Console.WriteLine(texto.Contains("test"));
            // System.Console.WriteLine(texto.Contains("test", StringComparison.CurrentCultureIgnoreCase));

            // StartsWith/EndsWith
            // var texto = "Esse é um texto de teste";
            // System.Console.WriteLine(texto.StartsWith("Esse"));
            // System.Console.WriteLine(texto.StartsWith("esse"));
            // System.Console.WriteLine(texto.EndsWith("teste"));

            // Equals
            // var texto = "Esse é um texto de teste";
            // System.Console.WriteLine(texto.Equals("Esse é um texto de teste"));

            // Indices
            // var texto = "Esse é um texto de teste";
            // System.Console.WriteLine(texto.IndexOf("é"));
            // System.Console.WriteLine(texto.LastIndexOf("de"));

            // Métodos adicionais
            // var texto = "Esse é um texto de teste";
            // System.Console.WriteLine(texto.ToUpper());
            // System.Console.WriteLine(texto.ToLower());
            // System.Console.WriteLine(texto.Insert(5, "aqui "));
            // System.Console.WriteLine(texto.Remove(0, 5));
            // System.Console.WriteLine(texto.Length);

            // Manipulando strings
            // var texto = "Esse é um texto de teste";
            // System.Console.WriteLine(texto.Replace("Esse", "Isto"));
            // var divisao = texto.Split(" ");
            // System.Console.WriteLine(divisao[0]);
            // System.Console.WriteLine(texto.Substring(5, 5));
            // System.Console.WriteLine(texto.Substring(1, texto.LastIndexOf("é")));
            // var texto2 = " teste ";
            // System.Console.WriteLine(texto2.Trim());

            // StringBuilder
            var texto = new StringBuilder();
            texto.Append("Esse é um texto de teste");
            texto.Append(", esse é um texto de teste");
            texto.ToString();
            System.Console.WriteLine(texto);
        }
    }
}
