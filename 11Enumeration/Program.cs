Console.WriteLine("## Enumerations ##\n");

Console.WriteLine("## Dias da Semana ##");
Console.WriteLine($"{DiasDaSemana.Domingo}");
Console.WriteLine($"{DiasDaSemana.Segunda}");
Console.WriteLine($"{DiasDaSemana.Terca}");
Console.WriteLine($"{DiasDaSemana.Quarta}");
Console.WriteLine($"{DiasDaSemana.Quinta}");
Console.WriteLine($"{DiasDaSemana.Sexta}");
Console.WriteLine($"{DiasDaSemana.Sabado}");

Console.WriteLine("\n-----------------------\n");

Console.WriteLine("## Valores Inteiros dos Dias da Semana ##");
int domingo = (int)DiasDaSemana.Domingo;
int segunda = (int)DiasDaSemana.Terca;
int terca = (int)DiasDaSemana.Terca;    
int quarta = (int)DiasDaSemana.Quarta;
int quinta = (int)DiasDaSemana.Quinta;
int sexta = (int)DiasDaSemana.Sexta;
int sabado = (int)DiasDaSemana.Sabado;

Console.WriteLine($"\n{domingo}");
Console.WriteLine($"{segunda}");
Console.WriteLine($"{terca}");
Console.WriteLine($"{quarta}");
Console.WriteLine($"{quinta}");
Console.WriteLine($"{sexta}");
Console.WriteLine($"{sabado}");

Console.WriteLine("\n-----------------------\n");
Console.WriteLine("## Obtendo o Nome através do valor ##");


Console.ReadKey();

enum DiasDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

