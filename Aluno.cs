namespace aula_4
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Escola { get; set; }

        public Aluno(string nome, string matricula, string escola) : base(nome)
        {
            Matricula = matricula;
            Escola = escola;
        }
        
        public static void Main(string[] args)
        {
            var aluno = new Aluno("Joao Rodrigo", "113412", "Faccat");

            aluno.DizerAlgo("Olá");
            aluno.Multiplicar(5, 26);
            aluno.Somar(7, 14);
            aluno.Subtrair(90, 55);
            aluno.Dividir(9, 3);
            aluno.CalcularRestoDivisao(9, 4);
        }
    }
}