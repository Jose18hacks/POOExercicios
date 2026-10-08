using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace POOFundamentos
{
    public class Pessoa2
    {
        public string Nome;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
    }
}
