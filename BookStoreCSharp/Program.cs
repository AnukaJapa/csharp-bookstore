// See https://aka.ms/new-console-template for more information
//In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
//Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
//Titolo
//Autore
//ISBN
//Numero pagine
//Peso del libro
//Larghezza, Altezza e Profondità del libro
//Valutazione media
//Numero di recensioni
//se è disponibile in versione Kindle
//se la copertina flessibile è disponibile
//Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
//A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
//Un esempio è il seguente:
//---------------IL LIBRO DI OGGI: << titolo >> di << autore >> ----------------
//Informazioni generiche:
//ISBN: << isbn >>
//Numero delle pagine: << numeroPagine >> pagine
//Peso del libro: << pesoLibro >> kg
//Dimensioni del libro: << larghezza >> cm x << lunghezza >> cm x << profondita >> cm
//Informazioni Amazon:
//Numero di recensioni: << numeroRecensioni >> recensioni
//Valutazione media: << valutazioneMedia >> stelline
//Kindle disponibile: Si o No
//Copertina flessibile disponibile: Si o No

//chiedi all'utente informazioni

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
Dimensioni del libro: {larghezza}cm x {lunghezza}cm x {profont
}cm

Informazioni Amazon:
Numero di recensioni: {numerodirecensioni} recensioni
Valutazione media: {valutazionemedia} stelline
Kindle disponibile: {kindle}
Copertina flessibile disponibile: {flessibile}
");
