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

string titolo = "Clean Code";
string autore = "Robert C. Martin";
string isbn = "9780132350884";

int numerodellepagine = 334;
int pesodellibro = 3;

float larghezza = 12.3f;
float lunghezza = 23.4f;
float profondità = 23.4f;

int numerodirecensioni = 234;

float valutazionemedia = 3.3f;

bool kindle = false;
string kindleDisponibilità;

bool flessibile = true;
string flessibileDisponibilità;
if (kindle)
{
    kindleDisponibilità = "Si";
} else
{
    kindleDisponibilità = "No";
}

if (flessibile)
{
    flessibileDisponibilità = "Si";
} else
{
    flessibileDisponibilità = "No";
}


Console.WriteLine(@$"--------------LIBRO DI OGGI:{titolo} di {autore}------------
informazioni generiche:
ISBN: {isbn}
Numero delle pagine: {numerodellepagine}
Peso del libro: {pesodellibro}kg
Dimensioni del libro: {larghezza}cm x {lunghezza}cm x {profondità
}cm

Informazioni Amazon:
Numero di recensioni: {numerodirecensioni} recensioni
Valutazione media: {valutazionemedia} stelline
Kindle disponibile: {kindleDisponibilità}
Copertina flessibile disponibile: {flessibileDisponibilità}
");
