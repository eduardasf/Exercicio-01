// See https://aka.ms/new-console-template for more information

using System;
using System.Xml.Schema;
using System.Xml.Serialization;

class atividade
{
    static void Main()
    {

        /**Questão 01--------------------------------------------------------------------------------------------|
        int a = 10;
        int b = 20;

        Console.WriteLine("Antes de trocar:\nO valor do A = " + a);
        Console.WriteLine("O valor do B = " + b);

        int aux;
        aux = a;
        a = b;
        b = aux;

        Console.WriteLine("\nDepois de trocar:\nO valor do A = " + a);
        Console.WriteLine("O valor do B = " + b);**/

        /**Quetão 02--------------------------------------------------------------------------------------------|
        Console.Write("Digite o total de eleitores do município:");
        int eleitores = Int32.Parse(Console.ReadLine());
        Console.Write("Digite o total de votos brancos:");
        int brancos = Int32.Parse(Console.ReadLine());
        Console.Write("Digite o total de votos nulos:");
        int nulos = Int32.Parse(Console.ReadLine());
        Console.Write("Digite o total de votos válidos:");
        int validos = Int32.Parse(Console.ReadLine());

        Console.WriteLine("\nPORCENTAGEM DE VOTOS:");
        int votosB = 100 * brancos / eleitores;
        Console.WriteLine("Percentual de votos brancos: "+  votosB+"%");
        int votosN = 100 * nulos / eleitores;
        Console.WriteLine("Percentual de votos nulos: " + votosN +"%");
        int votosV = 100 * validos / eleitores;
        Console.WriteLine("Percentual de votos válidos: " + votosV +"%");**/

        /**Questão 03--------------------------------------------------------------------------------------------|
        int valor;
        Console.WriteLine("É par ou ímpar?\n");
        Console.Write("Digite um valor:");
        valor = Int32.Parse(Console.ReadLine());

        if(valor >= 0)
        {
            Console.WriteLine("O valor:"+ valor+" é positivo");
        }
        else
        {
            Console.WriteLine("O valor:" + valor + " é negativo");
        }**/

        /**Questão 04---------------------------------------------------------------------------------------------|
        float slaFixo;
        float valorVendas;
        float comissao;

        Console.WriteLine("***CALCULAR SALÁRIO TOTAL***");
        Console.Write("Digite seu salário.......:");
        slaFixo = float.Parse(Console.ReadLine());
        Console.Write("Digite o valor das vendas:");
        valorVendas = float.Parse(Console.ReadLine());

        if (valorVendas <= 1500)
        {
            comissao = (3 * valorVendas) / 100;
            slaFixo += comissao;
            Console.WriteLine("O valor do salário total é:" + slaFixo);
        }
        else
        {
            comissao = (5 * valorVendas) / 100;
            slaFixo += comissao;
            Console.WriteLine("O valor do salário total é:" + slaFixo);
        }**/

        /**Questão 05---------------------------------------------------------------------------------------------|

        string time1;
        string time2;
        int numGols1;
        int numGols2;
        Console.WriteLine("QUE TIME GANHOU?");
        Console.Write("Digite o nome do primeiro time: ");
        time1 = Console.ReadLine();
        Console.Write("Digite o nome do segundo time.: ");
        time2 = Console.ReadLine();

        Console.Write("\nDigite quantos gols o time " + time1 + " fez:");
        numGols1 = int.Parse(Console.ReadLine());
        Console.Write("Digite quantos gols o time " + time2 + "fez:");
        numGols2 = int.Parse(Console.ReadLine());

        if(numGols1 > numGols2)
        {
            Console.WriteLine("\nO time vencedor foi o " + time1);
        }
        else
        {
            Console.WriteLine("O time vencedor foi o " + time2);
        }**/

        /**Questão 06----------------------------------------------------------------------------------------------|
        int valor1;
        int valor2;
        int res;

        Console.WriteLine("Calcular Divisão");
        Console.Write("Digite o primeiro valor:");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segungo valor:");
        valor2 = int.Parse(Console.ReadLine());

        if(valor2 == 0)
        {
            Console.WriteLine("Não é possível realizar divisão por zero! Tente outro valor!");
            Console.Write("Digite o segungo valor:");
            valor2 = int.Parse(Console.ReadLine());
            res = valor1/valor2;
            Console.WriteLine("O valor da divisão é:" + res);
        }
        else
        { 
            res = valor1 / valor2;
            Console.WriteLine("O valor da divisão é:" + res);
        }**/

        /**Questão 07---------------------------------------------------------------------------------------------|

        int tabuada;
        Console.WriteLine("**TABUADA DO 8**");
        
        
        for(int i = 1; i <= 10; i++)
        {
            tabuada = 8 * i;
            Console.WriteLine("8 x " + i +" = "+ tabuada);
        }**/

        /**Questão 08----------------------------------------------------------------------------------------------|
        int valor = 0;
        int soma = 0;
        float media= 0;

        Console.WriteLine("**Média Aritmética**");

        for (int i = 1; i <=10;  i++)
        {
            Console.Write("Digite o " + i + "º número:");
            valor = int.Parse(Console.ReadLine());
            soma += valor;
        }

        media = soma / 10;
        Console.WriteLine("A média aritmética dos valores lidos é:" +  media);**/


        /**Questão 09----------------------------------------------------------------------------------------------|

        double nota1, nota2, nota3;
        string letra;
        double resultado;

        Console.WriteLine("***NOTA DOS ALUNOS***");

        Console.Write("Digite a primeira nota:");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota:");
        nota2 = double.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota:");
        nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nPara cálcular digite:");
        Console.Write("A =  média aritmética\nP = média ponderada\nH = a média harmônica\nResposta:");
        letra = Console.ReadLine();

        resultado = CalcularMedia(nota1, nota2, nota3, letra);



    }

    static double CalcularMedia(double nota1, double nota2, double nota3, string letra)
    {
        double resultado = 0;

        switch (letra)
        {
            case "A":
                resultado = (nota1 + nota2 + nota3) / 3;
                Console.Write($"\nA média arimética é: {resultado:F2}");
                break;
            case "P":
                resultado = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
                Console.Write($"\nA média ponderada é: {resultado:F2}");
                break;
            case "H":
                resultado = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
                Console.WriteLine($"\nA média harmônica é: {resultado:F2}");
                break;

        }
        return resultado;

    }**/


        /**Questão 10-----------------------------------------------------------------------------------------------|

        double altura, pesoIdeal;
        string letra;

        Console.WriteLine("***CALCULAR A ALTURA IDEAL***\n");
        Console.WriteLine("Digite seu sexo:");
        Console.Write("F ou f - feminino\nM ou m - masculino\nResposta:");
        letra = Console.ReadLine();

        Console.Write("\nDigite sua altura:");
        altura = double.Parse(Console.ReadLine());

        pesoIdeal = Peso_Ideal(letra,altura);

    }

    static double Peso_Ideal(string letra, double altura)
    {
        double pesoIdeal = 0;

        if(letra == "F" || letra ==  "f")
        {
            pesoIdeal = 62.1 * altura - 44.7;
            Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal:F2}");

        }
        else if(letra == "M" || letra == "m")
        {
            pesoIdeal = 72.7 * altura - 58;
            Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal:F2}");
        }

        return pesoIdeal;
    }*/
    }
}