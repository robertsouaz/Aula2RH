using System;
using Aula02RH.Models;

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Funcionarios func = new Funcionarios();
            func.Id = 10;
            func.Nome = "Neymar";
            func.CPF = "123458678910";
            func.DataAdimissao = DateTime.Parse("10/10/2024");
            func.Salario = 1000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnuns.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.WriteLine(mensagem);
            Console.WriteLine("============================================");*/


            Funcionario func new Funcionario(); 
            Console.WriteLine("Digite o Id do funcionário: "); 
            func. Id int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o nome do funcionário: "); 
            func. Nome Console.ReadLine(); 
            Console.WriteLine("Digite o CPF: "); 
            func.Cpf Console.ReadLine(); 
            Console.WriteLine("Digite a data de Admissão: "); 
            func.DataAdmissao DateTime.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o Salário: "); 
            func.Salario decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("Escolha o tipo de Funcionário (1 CLT/2 Aprendiz): "); 
            int opcao int.Parse(Console.ReadLine()); 

            //Operador Ternário Interpretação: Se a condição do parenteses for verdadeira, 
            //escolhe o que está depois da "?", Caso contrário, escolhe o que está de pois dos ":"

            func.TipoFuncionario (opcao 1)? TipoFuncionarioEnum.CLT: TipoFuncionarioEnum.Aprendiz; 
            func.ReajustarSalario(); 
            decimal valorDescontoVT func.CalcularDescontoVT (6); 
            Console.WriteLine(" "); 
            Console.WriteLine($"0 salário reajusta do é (func.Salario}.\n"); 
            Console.WriteLine($"O Desconto do VT é (valorDescontoVT).\n"); 
            Console.WriteLine(" ")
        }
    }
}