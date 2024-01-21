using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Joáo Silva", EEstadoCivil.Casado);

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.EstadoCivil);
            Console.WriteLine((int)cliente.EstadoCivil);
        }
    }

    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

    struct Cliente
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;

        public Cliente(string nome, EEstadoCivil estadoCivil)
        {
            Nome = nome;
            EstadoCivil = estadoCivil;
        }
    }
}
