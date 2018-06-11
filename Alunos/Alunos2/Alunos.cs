using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos2
{
    public class Aluno
    {
        public int codigo;
        public string nome;
        public string sobrenome;
        public string sob2;
        public DateTime data;
        public int erro;

        public int Idade()
        { // este método deverá calcular a idade do aluno baseado na sua data de nascimento
            //ano atual subt do ano nascimento
            int idade = Convert.ToInt32(DateTime.Now.Year - data.Year);
            return idade;
        }

        public string NomeCompleto()
        {// Deverá retornar o nome concatenado com o sobrenome,
            string nomeCompleto;
            //espaco antes do sobrenome para quando ficar completo o nome            
            //nome completo concatena o nome e o sobrenome
            nomeCompleto = nome.Trim() + " " + sobrenome + " " + sob2;
            return nomeCompleto;
        }


        public int ValidaNome()
        {//Deverá validar o nome do Aluno com caracteres divergentes                      
            
            if (nome.Trim().Contains("@") || sobrenome.Trim().Contains("@") || sob2.Trim().Contains("@"))
            {
                return erro = 1;
            }
            if (nome.StartsWith("Ç") || sobrenome.StartsWith("Ç") || sob2.Trim().Contains("Ç"))
            {
                return erro = 2;
            }
            if (nome.Contains("III") || sobrenome.Contains("III") || sob2.Trim().Contains("III"))
            {
                return erro = 3;
            }
            
            return ValidaNome();

        }

        public string ErroValidacao()
        {
            if (erro == 1)
            {
                Console.WriteLine("Este nome não pode ser usado contém caracter '@' que é inválido");
            }
            else
            {
                Console.WriteLine("Nome Válido!");
            }
            if (erro == 2)
            {
                Console.WriteLine("Este nome não pode ser usado, contém caracter 'Ç' que é inválido no inicio do nome");
            }
            else
            {
                Console.WriteLine("Nome Válido!");
            }
            if (erro == 3)
            {
                Console.WriteLine("Este nome não pode ser usado, contém caracter 'III' que é inválido como nome");
            }
            else
            {
                Console.WriteLine("Nome Válido!");
            }

            return ErroValidacao(); 
        }
    }

}
