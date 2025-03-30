Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@"
         💵 Bem vindo 💵         
  Aqui você calcula os juros de  
 um investimento a juros simples 
");
Console.ResetColor(); Thread.Sleep(700);

Console.Write("Capital (R$)      : ");
float capital = Convert.ToSingle(Console.ReadLine()); 

Console.Write("Taxa de juros (%) : ");
float taxa = Convert.ToSingle(Console.ReadLine()); 
float taxaPercentual = taxa/100;

Console.Write("Tempo (meses)     : ");
float tempo = Convert.ToSingle(Console.ReadLine()); 

float juros = capital * taxaPercentual * tempo;
float montante = capital + juros;

Console.WriteLine("Obrigada, aqui estão seus resultados: 💻"); Thread.Sleep(1500);
Console.Clear();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@"➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ 
 |          Resultado Juros simples          | 
➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");
Console.ResetColor();
Console.WriteLine();

Console.WriteLine($@"Capital_______: {capital:C}
Taxa de juros_: {taxa}%
Tempo_________: {tempo} meses

Juros____: {juros:C}
Montante_: {montante:C}
");
