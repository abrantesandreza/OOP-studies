using ExercicioHostel;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Renter[] rooms = new Renter[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qntdQuarto = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qntdQuarto; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string renterName = Console.ReadLine();

                Console.Write("Email: ");
                string renterEmail = Console.ReadLine();

                Console.Write("Quarto: ");
                int renterRoom = int.Parse(Console.ReadLine());

                //A entrada do usuário será o "ponteiro" para as informações do inquilino
                rooms[renterRoom] = new Renter(renterName, renterEmail);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            
            //Itera sobre o vector de Rooms para encontrar os ocupados
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(i + ": " + rooms[i]);
                }
            }

        }

    }

}
