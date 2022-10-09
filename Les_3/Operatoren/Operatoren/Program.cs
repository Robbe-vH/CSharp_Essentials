/*short getal = 2;
short tweedeGetal = 3;

getal *= tweedeGetal;

bool isGelijkAanZes = getal != 6; //checkt of getal != 6 en plaatst uitkomst in bool
bool isNietGelijkAanZes = getal != 6;

int aantalWielen = 4;

bool isVrachtwagen = aantalWielen > 4;

Console.WriteLine("Is het een vrahctwagen? ");
Console.WriteLine(isVrachtwagen);
*/



/*bool isWaar = true;
Console.WriteLine(!isWaar);

int bedrag = 99;
bool isGoedkoop = false;
bool isKwaliteit = true;

bool isGoedeAankoop = isGoedkoop && isKwaliteit && ++bedrag < 100;


bool isZaterdag = false;
bool isZondag = true;

bool isWeekend = isZaterdag | isZondag;
*/


/*//XOR operator, er mag maar 1 vd 2 waar zijn
bool isMember = false;
bool isPremium = true;

//dit is true, als ze beide waar zijn, is Ontvanger false
bool isOntvangerEmail = isMember ^ isPremium;
*/


//  CONVERTEREN

int resultaat;
double kommaGetal = 2.5;
string inputGebruiker = "9.99";

//  explicitie cast naar datatype
resultaat = (int)kommaGetal;

//  Convert.ToIets() is een conversie van object naar Iets
double inputKommagetal = Convert.ToDouble(inputGebruiker);
inputKommagetal = Convert.ToDouble(1.5f);


//  datatype.parse() altijd van string naar datatype
int geheelGetal = int.Parse("2761");
double kommaGetal = double.Parse("8743");

//  Naar string

kommaGetal = 9.34;
string uitkomst = kommaGetal.ToString();

Console.WriteLine($"De uitkomst is {uitkomst}%");


