Bilförarens Simulator
Välkommen till Bilförarens Simulator, en konsolapplikation skapad i C# som låter användaren simulera upplevelsen av att vara en bilförare!

Innehåll
1. Översikt
2. Funktioner
3. Användargränssnitt
4. Tekniska specifikationer
5. Testning
6. Så kör du programmet

1. Översikt
Programmet simulerar en bilförarens upplevelse där användaren kan mata in olika kommandon för att styra bilen. Medan bilen kör blir föraren trött och bilen konsumerar bensin. Både bilens och förarens status presenteras till användaren efter varje kommando.

2. Funktioner
Riktning: Användaren kan ändra bilens riktning (Norrut, Söderut, Västerut, Österut).
Bensin: Bilen behöver bensin för att köra. När tanken är tom, meddelar programmet användaren.
Trötthet: Föraren blir tröttare för varje kommando. När tröttheten är hög, varnar programmet användaren.
3. Användargränssnitt
Alla tillgängliga kommandon visas i konsolfönstret. Användaren kan enkelt interagera med applikationen genom att mata in önskade kommandon.

4. Tekniska specifikationer
Applikationen har byggts med följande principer i åtanke:

SRP (Single Responsibility Principle): Varje klass har en klar och distinkt funktion.
Services/Library: För att hålla kodavsnitt organiserade och återanvändbara.
Namngivning: Alla variabler, klasser och metoder har beskrivande namn för tydlighet.
DRY (Don't Repeat Yourself): Återanvändning av kod där det är lämpligt.
Interface: Implementerade för flexibilitet och utvidgbarhet.
5. Testning
Programmet har genomgått noggrann testning med MSTest. Alla tester har PASSERAT och inkluderar:

Trötthet: Kontrollerar att trötthetsnivån ökar som förväntat och varnar användaren vid rätt tidpunkt.
Bensin: Ser till att bensinen förbrukas och att användaren meddelas när den är slut.
Riktning: Kontrollerar att bilens riktning ändras korrekt.
Menyval: Ser till att varje menyval fungerar som förväntat.
6. Så kör du programmet
För att köra programmet:

Klona eller ladda ner källkoden.
Öppna lösningen i ditt favorit C# utvecklingsverktyg.
Kör programmet och följ instruktionerna i konsolfönstret.
