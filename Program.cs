Console.Clear();
/*Juros simples (j)

Capital [c] (R$).......: 1200,00
Taxa de juros [i] (%)..: 2
Tempo [t] (meses)......: 15

Juros (R$).....: 360,00
Montante (R$)..: 1560,00

j = c . i . t

m = c + j
*/

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@"
       --- Bem vindo ---      
 Aqui você calcula seus juros 
");
Console.ResetColor(); Thread.Sleep(700);

Console.Write("Capital (R$)      : ");
float capital = Convert.ToSingle(Console.ReadLine()); 

Console.Write("Taxa de juros (%) : ");
float taxa = Convert.ToSingle(Console.ReadLine()); 
float taxaPercentual = taxa /100;

Console.Write("Tempo (meses)     : ");
float tempo = Convert.ToSingle(Console.ReadLine()); 

float juros = capital * taxaPercentual * tempo;
float montante = capital + juros;

Console.WriteLine("Obrigada, aqui estão seus resultados:"); Thread.Sleep(1000);
Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Capital_______:{capital:C}");
Console.WriteLine($"Taxa de juros_:{taxa}%");
Console.WriteLine($"Tempo_________:{tempo} meses");
Console.ResetColor();

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Juros_____:{juros:C}");
Console.WriteLine($"Montante_:{montante:C}");
Console.ResetColor();
