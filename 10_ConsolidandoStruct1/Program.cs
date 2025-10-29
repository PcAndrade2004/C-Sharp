using System.Globalization;

Console.WriteLine("## Consolidando Structs ##\n");

Cliente c1 = new Cliente("Paulo Cesar", "pcandradeoliveira@gmail.com", 21);
Cliente.ExibirInfo(c1.Nome!, c1.Email!, c1.Idade);

Console.ReadKey();  
