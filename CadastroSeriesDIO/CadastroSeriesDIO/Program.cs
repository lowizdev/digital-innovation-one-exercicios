using CadastroSeriesDIO.Entidades;
using System;

namespace CadastroSeriesDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioSeries r1 = new RepositorioSeries();

            Serie s1 = new Serie(0, Enums.Genero.Acao, "teste 1", "desc 1", 1990);
            Serie s2 = new Serie(1, Enums.Genero.Comedia, "teste 2", "desc 2", 1999);

            r1.Create(s1);
            Console.WriteLine(r1.Read(0));
            r1.Create(s2);
            Console.WriteLine(r1.Read(0));
            Console.WriteLine(r1.Read(1));

            s2 = new Serie(1, Enums.Genero.Comedia, "teste 2 updated", "desc 2", 1999);
            r1.Update(1, s2);

            Console.WriteLine(r1.Read(0));
            Console.WriteLine(r1.Read(1));
            Console.WriteLine(r1.Read(2));

            Console.WriteLine(r1.Delete(0));
            Console.WriteLine(r1.Read(0));
            Console.WriteLine(r1.Read(1));

        }
    }
}
