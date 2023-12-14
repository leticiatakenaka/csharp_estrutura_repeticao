//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
// um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
// 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
// que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
// mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
// exemplo.

int tipo;

do
{
    Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
    Console.Write("Escreva o tipo de combustível abastecido: ");
    tipo = int.Parse(Console.ReadLine());

    switch (tipo)
    {
        case 1:
            Console.WriteLine("Álcool");
            break;
        case 2:
            Console.WriteLine("Gasolina");
            break;
        case 3:
            Console.WriteLine("Diesel");
            break;
        case 4:
            Console.WriteLine("MUITO OBRIGADO");
            break;
        default:
            Console.WriteLine("Código inválido");
            break;
    }

} while (tipo != 4);