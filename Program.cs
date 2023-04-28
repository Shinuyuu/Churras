void Shin (int fun)
{
     if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
}
void barra()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("<=============================>");
}
int qtdAdultos,adultoAlcolic,AdultoNoAlcolic, AsCrias;
void frase(string frase)

{
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}
void calculadora(double quantiAdulto, double quantiaDeCrias, string produto, string tipo)
{
    double calculo =0;
if (produto != "Cerveja" && produto != "Refrigerante")
{
calculo = quantiAdulto*qtdAdultos + quantiaDeCrias*AsCrias;
}
else if (produto == "Cerveja" && produto != "Refrigerante")
{
calculo = quantiAdulto*adultoAlcolic; 
}
else if (produto != "Cerveja" && produto == "Refrigerante")
{
calculo = quantiAdulto*AdultoNoAlcolic + quantiaDeCrias*AsCrias; 
}
Console.ForegroundColor = ConsoleColor.White;
if (tipo == "kg")
{
if (calculo/1000 >= 1)
{
frase($"{produto}: {calculo/1000}kg\n");
}
else
{
frase($"{produto}: {calculo}g\n");
}
}
else if (tipo == "l")
{
if (calculo/1000 >= 1)
{
frase($"{produto}: {calculo/1000}l\n");
}
else
{
frase($"{produto}: {calculo}ml\n");
} 
}

}
Console.Clear();

Shin(02);
frase("Digite quantidade de adultos que consomem bebidas alcoólicas: ");
Shin(00);
adultoAlcolic = int.Parse(Console.ReadLine()!);
Shin(02);
Console.Clear();
frase("Digite quantidade de adultos que não consomem bebidas alcoólicas: ");

Shin(00);
AdultoNoAlcolic = int.Parse(Console.ReadLine()!);
qtdAdultos = adultoAlcolic + AdultoNoAlcolic;
Console.Clear();
Shin(02);
frase("Digite quantidade de crianças: ");

Shin(00);
AsCrias = int.Parse(Console.ReadLine()!);
Console.Clear();
barra();
calculadora(400,200,"Carne","kg");
barra();
calculadora(200,200,"Acompanhamentos","kg");
barra();
calculadora(2000,0,"Cerveja","l");
barra();
calculadora(500,500,"Refrigerante","l");
barra();
calculadora(400,400,"Água","l");
barra();
Console.ResetColor();

Thread.Sleep(6500);
Console.Clear();