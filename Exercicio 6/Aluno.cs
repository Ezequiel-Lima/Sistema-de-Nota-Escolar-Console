namespace Exercicio_6
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }

        public Aluno(string nome, double primeiraNota, double segundaNota, double terceiraNota)
        {
            Nome = nome;
            PrimeiraNota = primeiraNota;
            SegundaNota = segundaNota;
            TerceiraNota = terceiraNota;
        }

        public double CalcularNota()
        {
            return (PrimeiraNota + SegundaNota + TerceiraNota) / 3;
        }

        public double VerificarQuantosFaltam()
        {
            return 100 - CalcularNota();
        }
    }
}
