Console.WriteLine("SEJA BEM-VINDO AO MENU DE OPÇÕES");
Console.WriteLine("Exercicio 1 - 1 ");
Console.WriteLine("Exercicio 2 - 2 ");
Console.WriteLine("Exercicio 3 - 3 ");
Console.WriteLine("Exercicio 4 - 4 ");
Console.WriteLine("Exercicio 5 - 5 ");
Console.WriteLine("Exercicio 6 - 6 ");
Console.WriteLine("Exercicio 7 - 7 ");
Console.WriteLine("Exercicio 8 - 8 ");
Console.WriteLine("Exercicio 9 - 9 ");
Console.WriteLine("Exercicio 10 - 10 ");
string op = Console.ReadLine();

switch (op)
{
	case "1":
        Console.WriteLine("CÁLCULO DE MÉDIA");
        Console.WriteLine("Digite a primeira nota");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 7)
        {
            Console.WriteLine("Meus parabéns, você passou");
        }
        else if (media >= 4 && media <= 6.9 )
        {
            Console.WriteLine("Você ficou de exame final");
        }
        else
        {
            Console.WriteLine("REPROVADO");
        }
        break;

    case "2":

        Console.WriteLine("VERIFICAÇÃO DE NÚMERO PAR E ÍMPAR");
        Console.WriteLine("Digite um número para a verificação");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if(num % 2 == 0)
        {
            Console.WriteLine("O seu número é par");
        }
        else
        {
            Console.WriteLine("O seu número é ímpar");
        }
        break;

    case "3":
        Console.WriteLine("TABUADA");
        Console.WriteLine("Digite um número para que o programa calcule a tabuada");
        int num_Tab = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num_Tab} X {i} = {num_Tab * i}");
        }
        break;

    case "4":
        Console.WriteLine("FATORIAL DE UM NÚMERO");
        Console.WriteLine("Digite um número para calcularmos o fatorial desse número");
        int num_Fatorial = Convert.ToInt32(Console.ReadLine());
        int fatorial = 1;

        for (int i = num_Fatorial; i >= 1; i--)
        {
            fatorial = fatorial * i;
        }
        Console.WriteLine("O fatorial desse número é " +fatorial);
        break;

    case "5":
        Console.WriteLine("VERIFICAÇÃO DE IDADE PARA VOTAÇÃO");
        Console.WriteLine("Digite a sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if(idade >= 16)
        {
            Console.WriteLine("Você está apto para votar");
        }
        else
        {
            Console.WriteLine("Você não está apto para votar");
        }
        break;

    case "6":
        Console.WriteLine("CÁLCULO DE IMPOSTO DE RENDA");
        Console.WriteLine("Digite a sua renda mensal");
        double renda = Convert.ToDouble(Console.ReadLine());

        if(renda > 69517.45)
        {
            double imposto_Maior = renda * 0.275;
            Console.WriteLine("O seu imposto é " +imposto_Maior);
        }
        else if(renda >= 28559.71 && renda <= 69517.45)
        {
            double imposto_Menor = renda * 0.15;
            Console.WriteLine("O seu imposto é " +imposto_Menor);
        }
        else if(renda <= 28559.70)
        {
            Console.WriteLine("Você está isento dos impostos");
        }
        break;

    case "7":
        Console.WriteLine("NÚMEROS PRIMOS");

        break;
}