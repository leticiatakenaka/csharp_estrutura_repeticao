// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
// cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma

string[] valores;
int x, y;
do
{
    Console.Write("Escreva o valor de X e Y: ");

    valores = Console.ReadLine().Split(' ');

    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);

    Console.WriteLine(Quadrante(x, y));

} while (x != 0 && y != 0);

string Quadrante(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return "Primeiro Quadrante";
    }
    if (x < 0 && y > 0)
    {
        return "Segundo Quadrante";
    }
    if (x < 0 && y < 0)
    {
        return "Terceiro Quadrante";
    }
    if (x > 0 && y < 0)
    {
        return "Quarto Quadrante";
    }

    return "";
}
