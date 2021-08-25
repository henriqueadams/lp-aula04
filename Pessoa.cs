using System;

namespace aula_4
{
    public abstract class Pessoa
    {
        
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        
        public void DizerAlgo(string fala)
            => Console.WriteLine(fala);

        public void Multiplicar(int valorA, int valorB)
            => FalarResultado(valorA * valorB);

        public void Somar(int valorA, int valorB)
            => FalarResultado(valorA + valorB);

        public void Subtrair(int valorA, int valorB)
            => FalarResultado(valorA - valorB);

        public void Dividir(int valorA, int valorB)
            => FalarResultado(valorA / valorB);    

        public void CalcularRestoDivisao(int valorA, int valorB)
            => FalarResultado(valorA % valorB);

        private void FalarResultado(int resultado)
            => Console.WriteLine("O resultado é " + resultado);

    }   
}