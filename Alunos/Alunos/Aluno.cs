using System;
using System.Collections.Generic;
using System.Text;

namespace Alunos
{
    public class Aluno
    {
        public int codigo;
        public string nome;
        public string sobrenome;
        public string sob2;
        public DateTime data;

        public int idade()
        { // este método deverá calcular a idade do aluno baseado na sua data de nascimento
            //ano atual subt do ano nascimento
            int idade = DateTime.Now.Year - this.data.Year;            
            return idade;
        }

        public string nomeCompleto()
        {// Deverá retornar o nome concatenado com o sobrenome,
            string nomeCompleto;
            //espaco antes do sobrenome para quando ficar completo o nome            
            //nome completo concatena o nome e o sobrenome
            nomeCompleto = nome.Trim() + " " + sobrenome + " " + sob2; 
            return nomeCompleto;
        }


         public int validaNome(int erro)
        {//Deverá validar o nome do Aluno com caracteres divergentes                      
            erro = 0;
            if (nome.Trim().Contains("@") || sobrenome.Trim().Contains("@") || sob2.Trim().Contains("@"))
            {
                return erro = erro++;
            }
            if(nome.StartsWith("Ç") || sobrenome.StartsWith("Ç") || sob2.Trim().Contains("Ç"))
            {
                return erro = erro ++;
            }
            return validaNome(erro);
                        
        }

        public string erroValidacao(int erro)
        {
            if(erro == 1)
            {
                Console.WriteLine("Este nome não pode ser usado contém caracter '@' que é inválido");
            }
            if (erro == 2)
            {
                Console.WriteLine("Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome");
            }

            return erroValidacao(erro);
        }
    }
}
