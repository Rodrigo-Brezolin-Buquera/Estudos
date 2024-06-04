using System;


// "1. Maior e menor em 10 inputs"
// class Program

// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com dez números inteiros:");

//         int maior = 0;
//         int menor = 10000000;

//         for (int i = 0; i < 10; i++)
//         {
//             int input = int.Parse(Console.ReadLine());
//             if (input > maior) maior = input;
//             if (input < menor) menor = input;
//         }

//         Console.WriteLine($"Maior: {maior}, menor: {menor}");
//     }
// }



//

// "2. Contagem de votos)
// class Program {
//     static void Main()
//     {

//     Console.WriteLine("Entre com votos do candidato 1");
//     int votosCandidato1 = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("Entre com votos do candidato 2");
//     int votosCandidato2 = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("Entre com votos do candidato 3");
//     int votosCandidato3 = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("Entre com votos brancos");
//     int votosBrancos = int.Parse(Console.ReadLine()!);

//     Console.WriteLine("Entre com votos nulos");
//     int votosNulos = int.Parse(Console.ReadLine()!);

//     int totalVotos = votosCandidato1 + votosCandidato2 + votosCandidato3 +votosBrancos + votosNulos;

//     double candidato1Porcentagem = ((double)votosCandidato1 / totalVotos) * 100;
//     double candidato2Porcentagem = ((double)votosCandidato2 / totalVotos) * 100;
//     double candidato3Porcentagem = ((double)votosCandidato3 / totalVotos) * 100;
//     double candidatoBrancoPorcentagem = ((double)votosBrancos / totalVotos) * 100;
//     double candidatoNulosPorcentagem = ((double)votosNulos / totalVotos) * 100;


//     string mensagem1 = $"Candidato1 - Total: {votosCandidato1} - {candidato1Porcentagem:F2}%";
//     string mensagem2 = $"Candidato2 - Total: {votosCandidato2} - {candidato2Porcentagem:F2}%";
//     string mensagem3 = $"Candidato3 - Total: {votosCandidato3} - {candidato3Porcentagem:F2}%";
//     string mensagemBranco = $"Brancos - Total: {votosBrancos} - {candidatoBrancoPorcentagem:F2}%";
//     string mensagemNulo = $"Nulos - Total: {votosNulos} - {candidatoNulosPorcentagem:F2}%";

//     Console.WriteLine(mensagem1);
//     Console.WriteLine(mensagem2);
//     Console.WriteLine(mensagem3);
//     Console.WriteLine(mensagemBranco);
//     Console.WriteLine(mensagemNulo);

//     }
// }

// 3. Aluno aprovado ou não
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com a nota do aluno");

//         float nota = float.Parse(Console.ReadLine()!);

//         if (nota < 0 || nota > 10)
//         {
//             Console.WriteLine("Entre com um valor entre 0 e 10");
//         }
//         else
//         {
//             if (nota >= 6) Console.WriteLine("Aprovado");
//             else Console.WriteLine("Reprovado");
//         }
//     }
// }

// 4. Calcula cédulas 

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com o valor");

//         int valor = int.Parse(Console.ReadLine()!);
//         int resto = 0;
//         int quantidade = 0;

//         if (valor > 100)
//         {
//             quantidade = valor / 100;
//             resto = valor % 100;
//             valor = resto;
//             Console.WriteLine("Notas de cem: " + quantidade);
//         }

//         if (valor > 50)
//         {
//             quantidade = valor / 50;
//             resto = valor % 50;
//             valor = resto;
//             Console.WriteLine("Notas de cinquenta: " + quantidade);
//         }

//         if (valor > 20)
//         {
//             quantidade = valor / 20;
//             resto = valor % 20;
//             valor = resto;
//             Console.WriteLine("Notas de vinte: " + quantidade);
//         }

//         if (valor > 10)
//         {
//             quantidade = valor / 10;
//             resto = valor % 10;
//             valor = resto;
//             Console.WriteLine("Notas de dez: " + quantidade);
//         }

//         if (valor > 5)
//         {
//             quantidade = valor / 5;
//             resto = valor % 5;
//             valor = resto;
//             Console.WriteLine("Notas de cinco: " + quantidade);
//         }

//         if (valor > 2)
//         {
//             quantidade = valor / 2;
//             resto = valor % 2;
//             valor = resto;
//             Console.WriteLine("Notas de dois: " + quantidade);
//         }

//         if (valor > 1)
//         {
//             quantidade = valor / 1;
//             resto = valor % 1;
//             valor = resto;
//             Console.WriteLine("Notas de um: " + quantidade);
//         }
//     }
// }


// 5.Fahrenheit para celsius
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com a temperatura em fahrenheit ");
//         float temperatura = float.Parse(Console.ReadLine()!);

//         float tempEmCelsius = (temperatura - 32) * 5/9;

//         Console.WriteLine($"Temperatura em celsius: {tempEmCelsius:F1} C"  );

//     }
// }


// 6. Ver se pode votar

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com o ano atual ");
//         int anoAtual = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Entre com o ano de nascimento ");
//         int anoNascimento = int.Parse(Console.ReadLine()!);

//         if (anoAtual - anoNascimento >= 18) Console.WriteLine("Pode Votar");
//         else Console.WriteLine("Não pode Votar");
//     }
// }


// 7. Verifica ano bisexto

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Entre com um ano ");
//         int ano = int.Parse(Console.ReadLine()!);

//         if (ano % 4 == 0)
//         {
//             if (ano % 100 == 0)
//             {
//                 if (ano % 400 == 0)  Console.WriteLine("É bisesto");
//                 else Console.WriteLine("Não é bisesto");

//             }
//             else Console.WriteLine("É bisesto");
//         }
//         else  Console.WriteLine("Não é bisesto");

//     }
// }


// 8. Calculo IMC

class Program
{
    static void Main()
    {
        Console.WriteLine("Entre com o seu peso  ");
        float peso = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Entre com o seu altura  ");
        float altura = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Você é M ou F  ");
        string genero = Console.ReadLine()!;

        float imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc:F1}");



    }
}