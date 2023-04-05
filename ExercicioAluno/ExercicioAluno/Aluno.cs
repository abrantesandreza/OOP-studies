using System.Globalization

namespace ExercicioAluno
{
    class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTri;
        public double NotaSegundoTri;
        public double NotaTerceiroTri;


        public double NotaFinal() {
            return NotaPrimeiroTri + NotaSegundoTri + NotaTerceiroTri
        }

        public string AprovadoOuReprovado() {
            if (NotaFinal() > 60.0) {
                return "APROVADO"
            } else {
                return "REPROVADO"
            }
        }

        public double SeReprovado() {
            if (AprovadoOuReprovado() == "REPROVADO") {
                return 100 - NotaFinal()
            }
        }

    }
}
