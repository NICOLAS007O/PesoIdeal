double altura, conta1, conta2;

string sexo;

Console.Clear();

Console.WriteLine("--- Descubra seu peso ideal ---");

Console.WriteLine("Digite sua altura em m..........:");
altura = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Sexo [M]asculino / [F]eminino...:");
sexo = Console.ReadLine();

conta1 = altura * 72.7 - 58;

conta2 = altura * 62.1 - 44.7;

if ( sexo == "m" )
{
    Console.WriteLine($"Seu peso ideal é {conta1:N2}Kg");
}
else if ( sexo == "f" )
{
    Console.WriteLine($"Seu peso ideal é {conta2:N2}Kg");
}