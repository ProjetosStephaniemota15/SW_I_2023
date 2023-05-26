﻿namespace exe1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desenvolvido por Stephanie Mota");

        Cao c = new Cao();
        Gato g = new Gato();
        Homem h = new Homem();

        Console.WriteLine("O cachorro emite o " + c.fala());
        Console.WriteLine("O cachorro emite o " + g.fala());
        Console.WriteLine("O cachorro emite o " + h.fala());

    }
}