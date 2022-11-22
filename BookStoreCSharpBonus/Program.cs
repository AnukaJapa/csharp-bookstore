// See https://aka.ms/new-console-template for more information
//BONUS

Console.WriteLine("inserisci il titolo del libro");
string titolo = Console.ReadLine();

Console.WriteLine("inserisci l'autore del libro");
string autore = Console.ReadLine();

Console.WriteLine("inserisic isbn");
int isbn = int.Parse(Console.ReadLine());

Console.WriteLine("inserisci il numero delle pagine");
int numerodellepagine = int.Parse(Console.ReadLine());

Console.WriteLine("inserisci il peso del libro");
float pesodellibro = float.Parse(Console.ReadLine());

Console.WriteLine("inserisci dimensioni del libro, altezza, lunghezza e profondità");
float larghezza = float.Parse(Console.ReadLine());
float lunghezza = float.Parse(Console.ReadLine());
float profondità = float.Parse(Console.ReadLine());

Console.WriteLine("inserisci adesso informaizoni di amazon, numero di recensioni");
int numerodirecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("inserisci valutazione media");
float valutazionemedia = float.Parse(Console.ReadLine());

Console.WriteLine("è kindle disponibile? inserisci si o no");
string kindle = Console.ReadLine();

Console.WriteLine("è flessibile la copertina? si o no");
string flessibile = Console.ReadLine();


Console.WriteLine(@$"--------------LIBRO DI OGGI:{titolo} di {autore}------------
informazioni generiche:
ISBN: {isbn}
Numero delle pagine: {numerodellepagine}
Peso del libro: {pesodellibro}kg
Dimensioni del libro: {larghezza}cm x {lunghezza}cm x {profondità}cm

Informazioni Amazon:
Numero di recensioni: {numerodirecensioni} recensioni
Valutazione media: {valutazionemedia} stelline
Kindle disponibile: {kindle}
Copertina flessibile disponibile: {flessibile}
");

