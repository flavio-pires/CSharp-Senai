using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc;
            do {
            string nome;
            double peso;
            double altura;
            Console.WriteLine("===== Calcule seu IMC =====");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());            
            System.Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Clear();
            
            Paciente paciente1 = new Paciente(nome,peso,altura);

            System.Console.WriteLine($"Bem Vindo - {paciente1.Nome}");
            imc = peso / (altura*altura);
            if(imc < 20){
                System.Console.WriteLine($"Seu IMC é de {imc} e você está abaixo do peso!");
            } else if ((imc >= 20) && (imc <= 25)){      
                System.Console.WriteLine($"Seu IMC é de {imc} e você está no peso ideal!");
            } else if ((imc > 25) && (imc <= 30)){
                System.Console.WriteLine($"Seu IMC é de {imc} e você está com excesso de peso!");
            } else if ((imc > 30) && (imc <= 35)){
                System.Console.WriteLine($"Seu IMC é de {imc} e você está com obesidade!");
            } else if (imc > 35){
                System.Console.WriteLine($"Seu IMC é de {imc} e você está com obesidade mórbida!");
            }
            } while(imc == 0);
        }
    }
}
