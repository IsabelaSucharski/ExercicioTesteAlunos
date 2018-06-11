using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alunos2;

namespace TesteAlunos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Aluno aluno = new Aluno();
            aluno.codigo = 1;
            aluno.nome = "Felipe Vozgeral Canca";
            aluno.data = new DateTime(1990,04,01);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Aluno aluno = new Aluno();
            aluno.codigo = 2;
            aluno.nome = "Aline  Branca";
            aluno.data = new DateTime(2020, 01, 01);
            Assert.IsFalse(false); 
        }

        [TestMethod]
        public void TestMethod3()
        {
            Aluno aluno = new Aluno();
            aluno.codigo = 3;
            aluno.nome = "Alfredo Sella";
            aluno.data = new DateTime(1986, 03, 12);
            Assert.IsFalse(false);
        }
    }
}
