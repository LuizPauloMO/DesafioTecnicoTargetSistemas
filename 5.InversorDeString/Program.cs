String texto = "Fernanda Montenegro";

Console.WriteLine("Digite um texto e eu vou invertê-lo, ou enter para sair: ");
texto=Console.ReadLine()??String.Empty;

if (!String.IsNullOrEmpty(texto))
{
    String TextoInvertido = InverteString(texto);
    Console.WriteLine("Seu texto invertido: "+TextoInvertido.ToUpper());
    Console.ReadKey();
}
else
{
    Console.WriteLine("Tchauuuu......");
    Console.ReadKey();
}

String InverteString(String texto)
{
   int len=texto.Length;
    char[] ch=new char[len];
    for(int i=0; i<len; i++)
    {
        ch[i] = texto[len - 1 - i];
    }
    return new string(ch);
}