using _1_Heranca;

Console.WriteLine("### Herança ###\n");

Funcionario func = new Funcionario();
func.Nome = "Paulo";
func.Email = "pcandradeoliveira@gmail.com";
func.Empresa = "Google";
func.Salario = 9000;

Console.WriteLine("Funcionario");
Console.WriteLine(func.Empresa);
Console.WriteLine(func.Salario);
func.Exibir();


Console.ReadKey();