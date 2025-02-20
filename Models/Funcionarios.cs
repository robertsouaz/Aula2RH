using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Aula02RH.Models.Enuns;

namespace Aula02RH.Models
{

    public class Funcionarios
    {
        // prop + TAB --> cria propriedade
        // Avaixo siga com a Class

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = "";
        public DateTime DataAdimissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnuns TipoFuncionario { get; set; }

        // Abaixo siga com o Método
        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100);
        }
        public decimal CalcularDescontoVT( decimal percentual)
        {
            decimal desconto = this.Salario * percentual / 100;
            return desconto;
        }
        private int ContarCaracteres (string dado)
        {
            return dado.Length;
        }
        //identar o codigo SHIF + ALT + F
        public bool ValidarCPF ()
        {
            if (ContarCaracteres(CPF) == 11)
                return true;
            else
                return false;
        }
        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
                string.Format("Periodo de Experiencia: {0} até {1}", DataAdimissao, DataAdimissao.AddMonths(3));
            return periodoExperiencia;
        }






    }
}