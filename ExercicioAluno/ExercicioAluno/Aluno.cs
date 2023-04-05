using System.Globalization;

namespace ExercicioAluno
{
    class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTri;
        public double NotaSegundoTri;
        public double NotaTerceiroTri;


        public double NotaFinal() {
            return NotaPrimeiroTri + NotaSegundoTri + NotaTerceiroTri;
        }

        public string AprovadoOuReprovado() {
            if (NotaFinal() >= 60.0) {
                return "APROVADO";
            } else {
                double faltaParaPassar = 60 - NotaFinal();
                Console.WriteLine($"FALTARAM: {faltaParaPassar.ToString("F2", CultureInfo.InvariantCulture)} PONTO(S)");
                return "REPROVADO";
            }
        }

        

    }
}
