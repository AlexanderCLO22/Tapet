float vägghöjd = 0;
float väggbredd = 0;


float tapetlängd = 10.05f;
float tapetbredd = 0.53f;

float tapetrulle = tapetlängd * tapetbredd;

Console.WriteLine("-------------------Forza Juve------------------------------------------");
Console.WriteLine("Skriv in hur hög väggen är i meter");
vägghöjd = float.Parse(Console.ReadLine());

Console.WriteLine("Skriv in hur bred väggen är i meter");
väggbredd = float.Parse(Console.ReadLine());

float väggstorlek = vägghöjd * väggbredd;
//float tapetremsor = tapetlängd / vägghöjd;

Console.WriteLine("Du behöver " + väggstorlek / tapetrulle + " tapetrullar");

Console.WriteLine("--------------------Juve Forever-----------------------------------------");
