using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase1
            //Poso el meu nom com a 'Ericc2' per comprovar totes les funcionalitats
            char [] nom = new[] { 'E', 'r', 'i', 'c', 'c','2'};

            for (int i = 0; i<nom.Length; i++)
            {
                Console.WriteLine($"Lletra en la posició {i + 1}: {nom[i]}.");

            }

            //Fase2
         
            list<char> lletresNom = new list<char>();
           
            for (int i=0; i<nom.Length; i++)
            {
                lletresNom.Add(nom[i]);
            }
            string vocals = "aeiouAEIOU";

            for(int i=0; i<lletresNom.Count;i++)
            {
                
                if (char.IsNumber((char)lletresNom[i])) Console.WriteLine($"El caràcter en posició {i + 1} és un número");
                else if (vocals.Contains((char)lletresNom[i])) Console.WriteLine($"El caràcter en la posició {i + 1} és una VOCAL");
                else Console.WriteLine($"El caràcter en la posició {i + 1} és una CONSONANT");

            }

            //Fase3
            Dictionary<char, int> repeticioLletres= new Dictionary<char, int>();
            int repeticions;
            foreach(char lletra in lletresNom)
            {
                repeticions = 0;
                foreach(char lletra2 in lletresNom)
                {
                    if (lletra2==lletra) repeticions++;
                }
                repeticioLletres[lletra] = repeticions;
                
            }
            foreach (KeyValuePair<char,int> valor in repeticioLletres)
            {
                Console.WriteLine("El caràcter {0} es repeteix {1} vegada/es", valor.Key, valor.Value);
            }

            //Fase4

            list<char> lletresCognom = new list<char>();
            lletresCognom.Add('A');
            lletresCognom.Add('l');
            lletresCognom.Add('o');
            lletresCognom.Add('n');
            lletresCognom.Add('s');
            lletresCognom.Add('o');

            list<char> fullName = new list<char>();
            fullName = lletresNom;
            fullName.Add(' ');
            fullName.AddRange(lletresCognom);

            Console.WriteLine("Contingut del fullName:");
            foreach (char lletra in fullName)
            {
                Console.Write(lletra);
                Console.Write("-");
            }
            

        }
    } 
}
