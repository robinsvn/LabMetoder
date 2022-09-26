using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMetoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Denne leksjonen handler om metoder

            //            En metode er en blokk med kode som bare kjører når den kalles.

            //Du kan overføre data, kjent som parametere, til en metode.

            //Metoder brukes til å utføre visse handlinger, og de er også kjent som funksjoner.

            //Hvorfor bruke metoder? For å gjenbruke kode: definer koden en gang, og bruk den mange ganger.

            //LESESTOFF
            //https://www.w3schools.com/cs/cs_methods.asp

            //Se på metoden MinMetode() Alt den gjør er å skrive ut noe. For å ta den i bruk må vi KALLE på den, slik:
            MinMetode();//Det er alt vi trenger å gjøre. 

            //oppgave1
            //Kall på metoden Addisjon. Husk å "sende" med tallene.

            //oppgave2
            //lag en metode som tar imot 2 tall, altså 2 parametre, som multipliserer 2 tall. Deretter kall på denne metoden. (Blir nesten det samme som metoden Addisjon)
            //Velg selv et passende navn for metoden. Metodenavn skal alltid ha stor forbokstav.

            //oppgave 3
            //Hva er en static metode? Hva er forskjellen på det og en non static?

            //oppgave 4
            //Metoder som returnerer noe
            //Lag en metode som returnerer noe. Google c# methods og return etc, for å finne en snippet
            //Kall på metoden og ta vare på verdien som blir returnert.
            Console.WriteLine("Oppgave 1:");
            Addisjon(1, 2);
            Console.WriteLine("Oppgave 2:");
            Multiplikasjon(5, 6);
            Console.WriteLine("Oppgave 3:");
            Console.WriteLine("I en static metode kan man ikke forandre/lage objekter og forandre på koden generellt som er i selve metoden.");
            Console.WriteLine("Oppgave 4:");
            Console.WriteLine(Imposter());

            Console.ReadLine();
        }

        static void MinMetode()//denne koden kjøres kun når den blir kalt.
        {
            Console.WriteLine("Denne teksten blir skrevet ut fra MinMetode");
        }

        //eksempel på en metode som tar imot parametre. Denne har 2 parametre. tall1 og tall2
        static void Addisjon(int tall1, int tall2)
        {
            Console.WriteLine(tall1 + tall2);//her skjer utregning og utskrift av svaret
        }
        static void Multiplikasjon(int tall1, int tall2)
        {
            Console.WriteLine(tall1 * tall2);//her skjer utregning og utskrift av svaret
        }
        static string Imposter()
        {
            return "You are the imposter in Among Us.";
        }


    }
}

