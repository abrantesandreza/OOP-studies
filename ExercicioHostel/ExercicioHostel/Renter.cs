﻿

namespace ExercicioHostel
{
    internal class Renter
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public Renter(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;

        }

    }
}
