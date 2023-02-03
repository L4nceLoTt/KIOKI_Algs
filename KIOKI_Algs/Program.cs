
using KIOKI_Algs;
using System.Collections.ObjectModel;

internal class Program
{
    private static void Main(string[] args)
    {
        string msg = "";

        string encr = Algs.KeyPhraseEncrypt(msg, "стеганография");
        Console.Write("\n\n" + encr);
        Console.Write("\n" + Algs.KeyPhraseDecrypt(encr, "стеганография"));
    }
}