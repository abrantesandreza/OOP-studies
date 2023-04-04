
namespace ExercicioRetangulo
{
    class Retangulo
    {

        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura); 
        }

        public double Diagonal()
        {
            double diagon = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(diagon);
        }

    }
}
