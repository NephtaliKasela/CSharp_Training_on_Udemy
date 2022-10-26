using System;

namespace First_project
{
    class Program
    {
        static void AfficherInfosPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("bient�t vous aurez " + (age + 1) + " ans");

            // si l'age >= 18 -> majeur sinon mineur
            // age == 17 -> Vous serez bient�t majeur
            // age == 18 -> Vous �tes tout juste majeur

            // age >= 60 -> Vous �tes s�nior
            // age < 10 -> Vous �tes un enfant.

            // ET OU  (and &&  or ||)
            // age >= 12 ET age < 18 -> adolescent
            // age == 1 OU age == 2 -> b�b�


            if (age == 18)
            {
                Console.WriteLine("Vous �tes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bient�t majeur");
            }
            else if ((age >= 12) && (age < 18))
            {
                Console.WriteLine("Vous �tes adolescent");
            }
            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("Vous �tes un b�b�");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous �tes s�nior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous �tes majeur");
            }
            else if (age < 10)
            {
                Console.WriteLine("Vous �tes un enfant");
            }
            else
            {
                Console.WriteLine("Vous �tes mineur");
            }


        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne num�ro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas �tre vide");
                }
            }
            return nom;
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write(nom + ", quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas �tre n�gatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'age ne doit pas �tre �gal � 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur :  Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // DEMANDE LE NOM
            //string nom1 = DemanderNom(1);
            //string nom2 = DemanderNom(2);
            string nom1 = "Jean";
            string nom2 = "Paul";

            // DEMANDE L'AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // AFFICHE LES RESULTATS
            AfficherInfosPersonne(nom1, age1);
            AfficherInfosPersonne(nom2, age2);

        }
    }
}
