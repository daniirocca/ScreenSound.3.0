namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }
    public int Nota { get; }

    //Método estático- autocontida, não precisamos colocar new para chamar 
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
