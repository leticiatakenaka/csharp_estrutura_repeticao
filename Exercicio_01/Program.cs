//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002
string senha;

do
{
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();

    Console.WriteLine(senha != "2002" ? "Senha Invalida" : "Acesso Permitido");
} while (senha != "2002");