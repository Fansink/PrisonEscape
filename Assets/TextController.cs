using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States
    {
        cel, lakens_0, spiegel_0, spiegel_1, deur_0, lakens_1, spiegel_cel, kijken_spiegel, deur_1,
        gang_0, gang_1, gang_2, gang_3, vloer_0, vloer_1, kastdeur_0, kastdeur_1, trap_0, trap_1, trap_2,
        in_de_kast_1, in_de_kast_schoonmaakspullen, in_de_kast_prullenbakken,
        in_de_kast_kleren,
        // Schoonmaak kleren aan
        kleren_aan_kast, kleren_aan_in_de_kast_schoonmaakspullen, kleren_aan_in_de_kast_prullenbakken,
        // Schoonmaak kleren aan in de gang
        schoonmaak_kleren_aan_in_de_gang, schoonmaak_kleren_trap_op, schoonmaak_kleren_aan_vloer_onderzoeken,
        schoonmaak_kleren_aan_terug_naar_kast, schoonmaak_kleren_aan_terug_in_cel,
        // Schoonmaak kleren aan bovenaan de trap
        schoonmaak_kleren_bovenaan_trap, schoonmaak_kleren_niet_wc, schoonmaak_kleren_bewaker_aanvallen
    }

    private States myState;

    // Use this for initialization
    void Start() {
        myState = States.cel;
    }

    // Update is called once per frame
    void Update() {
        print(myState);
        if (myState == States.cel) { cel(); }
        else if (myState == States.lakens_0) { lakens_0(); }
        else if (myState == States.spiegel_0) { spiegel_0(); }
        else if (myState == States.deur_0) { deur_0(); }
        else if (myState == States.spiegel_cel) { spiegel_cel(); }
        else if (myState == States.lakens_1) { lakens_1(); }
        else if (myState == States.spiegel_1) { spiegel_1(); }
        else if (myState == States.kijken_spiegel) { kijken_spiegel(); }
        else if (myState == States.deur_1) { deur_1(); }
        else if (myState == States.gang_0) { gang_0(); }
        else if (myState == States.trap_0) { trap_0(); }
        else if (myState == States.vloer_0) { vloer_0(); }
        else if (myState == States.vloer_1) { vloer_0(); }
        else if (myState == States.kastdeur_0) { kastdeur_0(); }
        else if (myState == States.kastdeur_1) { kastdeur_1(); }
        else if (myState == States.gang_1) { gang_1(); }
        else if (myState == States.gang_2) { gang_2(); }
        else if (myState == States.gang_3) { gang_3(); }
        else if (myState == States.in_de_kast_1) { in_de_kast_1(); }
        else if (myState == States.in_de_kast_schoonmaakspullen) { in_de_kast_schoonmaakspullen(); }
        else if (myState == States.in_de_kast_prullenbakken) { in_de_kast_prullenbakken(); }
        else if (myState == States.in_de_kast_kleren) { in_de_kast_kleren(); }
        else if (myState == States.kleren_aan_kast) { kleren_aan_kast(); }
        else if (myState == States.kleren_aan_in_de_kast_schoonmaakspullen) { kleren_aan_in_de_kast_schoonmaakspullen(); }
        else if (myState == States.kleren_aan_in_de_kast_prullenbakken) { kleren_aan_in_de_kast_prullenbakken(); }

        else if (myState == States.schoonmaak_kleren_aan_in_de_gang) { schoonmaak_kleren_aan_in_de_gang(); }
        else if (myState == States.schoonmaak_kleren_trap_op) { schoonmaak_kleren_trap_op(); }
        else if (myState == States.schoonmaak_kleren_aan_vloer_onderzoeken) { schoonmaak_kleren_aan_vloer_onderzoeken(); }
        else if (myState == States.schoonmaak_kleren_aan_terug_in_cel) { schoonmaak_kleren_aan_terug_in_cel(); }
        else if (myState == States.schoonmaak_kleren_bewaker_aanvallen) { schoonmaak_kleren_bewaker_aanvallen(); }

        else if (myState == States.schoonmaak_kleren_bovenaan_trap) { schoonmaak_kleren_bovenaan_trap(); }
        
    }
    void cel()
    {
        text.text = "Je bent in een gevangenis cel en je wilt ontsnappen. Er liggen " +
                        "wat vieze lakens op het bed, een spiegel aan de muur en er is " +
                        "een deur.\n\n" +
                        // Acties
                        "Druk 'L' om naar de Lakens te kijken.\n" +
                        "Druk 'S' om naar de Spiegel te kijken.\n" +
                        "Druk 'D' om naar de Deur te kijken.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.lakens_0; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.spiegel_0; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.deur_0; }
    }

    void lakens_0()
    {
        text.text = "Wat een smerige dingen, je kunt je niet voorstellen dat iemand hier in kan slapen. " +
                    "Iemand zou ze moeten vervangen, 1 van de vele fijne dingen van het gevangenis " +
                    "leven...\n\n" +
                    "Jeeeej, lang leve de gevangenis..!!?\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cel; }
    }

    void spiegel_0()
    {
        text.text = "Toch aardig van ze dat je naar jezelf mag kijken terwijl je hier wanhopig zit te zijn. " +
                    "De spiegel is wat smerig maar je kunt jezelf er wel in zien... Je hebt er wel eens " +
                    "beter uit gezien\n\n" +
                    "Je moet hier weg!!\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel.\n" +
                    "Druk 'P' om een stuk van de spiegel te Pakken";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cel; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.spiegel_cel; }

    }

    void deur_0()
    {
        text.text = "Het is een stevige ijzeren deur met een een slot met drukknoppen. Als je op één " +
                    "of andere manier de vieze vingerafdrukken zou kunnen zien die op het slot zitten. " +
                    "Misschien dat je dan de combinatie zou kunnen vinden\n\n" +
                    "Maar hoe...?\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cel; }
    }

    //**************************************************
    // Stukje spiegel is gepakt
    //**************************************************

    void spiegel_cel()
    {
        text.text = "Daar sta je dan met een stukje spiegel in je hand en nog steeds in dezelfde " +
                    "vieze cel. De vieze lakens liggen er nog steeds. Het andere deel van de spiegel " +
                    "hangt nog aan de muur en de deur zit nog steeds op slot.\n\n" +
                    // Acties
                    "Druk 'L' om naar de Lakens te kijken.\n" +
                    "Druk 'S' om naar de Spiegel te kijken.\n" +
                    "Druk 'D' om naar de Deur te kijken.";
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.lakens_1; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.spiegel_1; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.deur_1; }
    }

    void lakens_1()
    {
        text.text = "De lakens zijn nog steeds te vies voor woorden. Ook als je via de spiegel naar de " +
                    "lakens kijkt wordt het er niet beter op.\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.spiegel_cel; }
    }

    void spiegel_1()
    {
        text.text = "De spiegel is nog steeds vies en er mist een stuk. Het stuk dat je in je hand " +
                    "hebt.\n\n" +
                    // Acties
                    "Druk 'K' om een stap dichterbij te doen en naar jezelf te Kijken in de spiegel.\n" +
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel.";
        if (Input.GetKeyDown(KeyCode.K)) { myState = States.kijken_spiegel; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.spiegel_cel; }
    }

    void kijken_spiegel()
    {
        text.text = "Nope, je ziet er nog steeds niet uit...\n\n" +
                    // Acties
                    "Druk 'T' om een stap Terug te doen.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.spiegel_1; }
    }

    void deur_1()
    {
        text.text = "De spiegel past door de tralies...\n\n" +
                    "Voorzichtig steek je het stukje spiegel door de tralies en je kunt zien dat de " +
                    "code van het slot 8345 is. Je kunt je vingers net bij de knopjes krijgen en druk " +
                    "de smerige toetsen in en hoort een 'klik'.\n\n" +
                    //Acties
                    "Druk 'O' om de deur te Openen.\n" +
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.gang_0; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.spiegel_cel; }
    }

    void gang_0()
    {
        text.text = "Yes, gelukt!!\n\n" +
                    "De eerste stap richting je vrijheid is genomen. Je staat in de deuropening en " +
                    "je ziet dat je er nog niet bent. Je ziet een gang met een trap en een kast.\n\n" +
                    //Acties
                    "Druk 'O' om de gang te gaan Onderzoeken.\n" +
                    "Druk 'T' om weer Terug je cel in te gaan.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.gang_1; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.spiegel_cel; }
    }

    //**************************************************
    // Deur geopend en je staat in de gang
    //**************************************************

    void gang_1()
    {
        text.text = "Het voelt lekker om uit de cel te zijn en tegelijk zie je dat je er nog niet bent." +
                    "Je kijkt de gang rond en ziet een trap, je kunt niet zien wat er bovenaan de trap " +
                    "zit. Ook zie je een kast in de gang, wellicht het onderzoeken waard. " +
                    "De vloer is ook al een tijdje niet schoongemaakt...\n\n" +
                    //Acties
                    "Druk 'T' om de Trap op te lopen.\n" +
                    "Druk 'V' om de Vloer te onderzoeken.\n" +
                    "Druk 'K' om de Kast te onderzoeken.\n" +
                    "Druk 'C' om weer veilig terug terug je Cel in te gaan en de deur dicht te trekken.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.trap_0; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.vloer_0; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.kastdeur_0; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.spiegel_cel; }
    }

    void trap_0()
    {
        text.text = "Je begint langzaam de trap op te lopen, wat zou er bovenaan de trap zitten." +
                    "Als je bovenkomt kijk je recht tegen een bewaker aan die ook jou recht aan kijkt.\n\n" +
                    "Je bent gesnapt en wordt hardhandig terug de cel in gestopt.\n\n" +
                    //Acties
                    "Druk 'O' om het spel opnieuw te starten.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.cel; }
    }

    void vloer_0()
    {
        text.text = "De vloer van de gang is echt smerig. Je kunt zien dat hij al een tijd niet is schoon" +
                    "gemaakt. Niet heel verrassend denk je terwijl je denkt aan de minstens net zo smerige " +
                    "lakens! UGH!\n\n" +
                    "Tussen het stof en vuil zie je iets liggen, een haarclip...\n" +
                    "Hoe komt die daar nou? Dit is een mannen afdeling...\n\n" +
                    //Acties
                    "Druk 'P' om de haarclip te Pakken.\n" +
                    "Druk 'K' om verder te Kijken in de gang.";
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.gang_3; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.gang_2; }
    }

    void kastdeur_0()
    {
        text.text = "Je loopt voorzichtig naar de kast in de gang. Boven de deur staat ´Concierge´, " +
                    "waarschijnlijk zitten er schoonmaakspullen in de kast. Je probeert of de kast " +
                    "open is.\n\n" +
                    "Je hebt geen geluk, de kast zit op slot...\n\n" +
                    //Acties
                    "Druk op 'K' om verder te Kijken in de gang";
        if (Input.GetKeyDown(KeyCode.K)) { myState = States.gang_2; }
    }

    void gang_2()
    {
        text.text = "Je staat nog steeds in dezelfde gang met dezelfde mogelijkheden... Jammer!\n\n" +
                    //Acties
                    "Druk 'T' om de Trap op te lopen.\n" +
                    "Druk 'V' om de Vloer te onderzoeken.\n" +
                    "Druk 'K' om de Kast te onderzoeken.\n" +
                    "Druk 'C' om weer veilig terug terug je Cel in te gaan en de deur dicht te trekken.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.trap_0; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.vloer_0; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.kastdeur_0; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.spiegel_cel; }
    }

    //**************************************************
    // Haarclip opgepakt, je staat nog steeds in de gang
    //**************************************************

    void gang_3()
    {
        text.text = "Daar sta je dan, in de gang van een gevangenis met een haarclip in je hand. \n" +
                    "Wat ga je er mee doen? Een bewaker heeft een wapenstok daar ga jij met je haarclip niks tegenin brengen...\n" +
                    "Je zou de trap kunnen proberen, je weet het maar nooit. Je hebt natuurlijk ook nog de kast, " +
                    "of zou er misschien nog wat beters te vinden zijn op de vloer?\n\n" +
                    //Acties
                    "Druk 'T' om de Trap op te lopen.\n" +
                    "Druk 'V' om de vloer nog een keer te onderzoeken.\n" +
                    "Druk 'K' om de kastdeur nog een keer te onderzoeken.\n" +
                    "Druk 'C' om weer veilig terug terug je Cel in te gaan en de deur dicht te trekken.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.trap_1; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.vloer_1; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.kastdeur_1; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.spiegel_cel; }
    }

    void trap_1()
    {
        text.text = "Je begint langzaam de trap op te lopen, wat zou er bovenaan de trap zitten." +
                    "Als je bovenkomt kijk je recht tegen een bewaker aan die ook jou recht aan kijkt.\n\n" +
                    "Daar sta je dan met je haarclip tegenover een bewaker met zijn wapenstok. Je bent " +
                    "gesnapt en wordt hardhandig terug de cel in gestopt.\n\n" +
                    //Acties
                    "Druk 'O' om het spel opnieuw te starten.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.cel; }
    }

    void vloer_1()
    {
        text.text = "De vloer is nog steeds smerig en vies. Er ligt niks anders dan stof en vuil." +
                    //Acties
                    "Druk 'T' om terug te gaan en de gang verder te onderzoeken.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.gang_3; }
    }

    void kastdeur_1()
    {
        text.text = "De kastdeur zit nog steeds op slot. Misschien kun je de haarclip gebruiken om hem " +
                    "open te maken.\n\n" +
                    //Acties
                    "Druk 'O' om de haarclip te gebruiken om de deur open te maken.\n" +
                    "Druk 'T' om terug te gaan en de gang verder te onderzoeken.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.in_de_kast_1; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.gang_3; }
    }

    //**************************************************
    // Kast in de gang geopend en je staat nu binnen
    //**************************************************

    void in_de_kast_1()
    {
        text.text = "Je staat in de veel te grote 'kast'...\n" +
                    "Het is 'gezellig' hok met allemaal schoonmaak spullen, prullenbakken en kleren.\n\n" +
                    //Acties
                    "Druk 'S' om de Schoonmaakspullen te bekijken.\n" +
                    "Druk 'P' om de Prullenbakken te onderzoeken.\n" +
                    "Druk 'K' om de Kleren te onderzoeken.\n" +
                    "Druk 'D' de kast Dicht te doen en terug naar de gang te gaan.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.in_de_kast_schoonmaakspullen; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.in_de_kast_prullenbakken; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.in_de_kast_kleren; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.gang_3; }
    }

    void in_de_kast_schoonmaakspullen()
    {
        text.text = "Er staan rijen hoog schoonmaakspullen opgestapeld. Misschien zouden ze die " +
                    "eens een keer moeten gebruiken in plaats van ze hier opslaan. Om bijvoorbeeld " +
                    "de vloer en de lakens eens te wassen.\n\n" +
                    "Voor nu kan je hier niks mee...\n\n" +
                    //Acties
                    "Druk 'O' om de kast verder te Onderzoeken";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.in_de_kast_1; }
    }

    void in_de_kast_prullenbakken()
    {
        text.text = "De prullenbakken zijn helemaal leeg, het lijkt wel of hier nooit wordt schoongemaakt. " +
                    "Ook niks, jammer genoeg...\n\n" +
                    //Acties
                    "Druk 'O' om de kast verder te Onderzoeken";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.in_de_kast_1; }
    }

    void in_de_kast_kleren()
    {
        text.text = "De kleren van de concierge, ze zien er gebruikt uit... Misschien dat iemand dan toch " +
                    "schoonmaakt hier.\n\n" +
                    //Acties
                    "Druk 'A' om de kleren aan te trekken\n" +
                    "Druk 'O' om de kast verder te Onderzoeken";
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.kleren_aan_kast; }
        else if (Input.GetKeyDown(KeyCode.O)) { myState = States.in_de_kast_1; }
    }

    //**************************************************
    // Schoonmaak kleren aan
    //**************************************************

    void kleren_aan_kast()
    {
        text.text = "Daar sta je dan...\n" +
                    "In het concierge hok van een gevangenis met de kleren van de schoonmaker aan...\n\n" +
                    "Je vader en moeder kunnen trots op je zijn! En nu...?!\n\n" +
                    //Acties
                    "Druk 'S' om de Schoonmaakspullen te bekijken.\n" +
                    "Druk 'P' om de Prullenbakken te onderzoeken.\n" +
                    "Druk 'K' om de Kleren uit te trekken.\n" +
                    "Druk 'D' de kast Dicht te doen en terug naar de gang te gaan.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.kleren_aan_in_de_kast_schoonmaakspullen; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.kleren_aan_in_de_kast_prullenbakken; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.in_de_kast_1; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.schoonmaak_kleren_aan_in_de_gang; }
    }

    void kleren_aan_in_de_kast_schoonmaakspullen()
    {
        text.text = "Er staan rijen hoog schoonmaakspullen opgestapeld. Misschien zouden ze die " +
                    "eens een keer moeten gebruiken in plaats van ze hier opslaan. Om bijvoorbeeld " +
                    "de vloer en de lakens eens te wassen.\n\n" +
                    "Misschien moet je het zelf gaan doen, je hebt tenslotte het pakje er al voor aan...hahahaha\n\n" +
                    //Acties
                    "Druk 'O' om de kast verder te Onderzoeken";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.kleren_aan_kast; }
    }

    void kleren_aan_in_de_kast_prullenbakken()
    {
        text.text = "De prullenbakken zijn helemaal leeg, het lijkt wel of hier nooit wordt schoongemaakt. " +
                    "Vandaar dat dit 'mooie' pakje hier niks hangt te doen...\n" +
                    "Hmmmm...?!\n\n" +
                    //Acties
                    "Druk 'O' om de kast verder te Onderzoeken";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.kleren_aan_kast; }
    }

    //**************************************************
    // Schoonmaak kleren aan in de gang
    //**************************************************

    void schoonmaak_kleren_aan_in_de_gang()
    {
        text.text = "In de smerige gang van de gevangenis is weinig gebeurt terwijl je in de kast was. \n" +
                    "De boel is nog steeds smerig, je celdeur staat open en de trap ziet er nog steeds \n" +
                    "spannend uit.\n\n" +
                    //Acties
                    "Druk 'T' om de Trap op te lopen.\n" +
                    "Druk 'V' om de Vloer te onderzoeken.\n" +
                    "Druk 'K' om toch nog eens de Kast te bekijken.\n" +
                    "Druk 'C' om terug je Cel in te gaan.";
        if      (Input.GetKeyDown(KeyCode.T)) { myState = States.schoonmaak_kleren_trap_op; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.schoonmaak_kleren_aan_vloer_onderzoeken; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.kleren_aan_kast; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.schoonmaak_kleren_aan_terug_in_cel; }
    }

    void schoonmaak_kleren_trap_op()
    {
        text.text = "Daar ga je, in je prachtige nieuwe outfit de trap op.\n" +
                    "Als je bovenaan de trap komt zie je een bewaker en hij ziet jou, \n" +
                    "jullie kijken elkaar recht aan...\n\n" +
                    //Acties
                    "Druk 'Z' om te Zwaaien en om te draaien.\n" +
                    "Druk 'H' om Hallo te zeggen en door te lopen.\n" +
                    "Druk 'A' om te proberen de bewaker Aan te vallen.";
        if      (Input.GetKeyDown(KeyCode.Z)) { myState = States.schoonmaak_kleren_aan_in_de_gang; }
        else if (Input.GetKeyDown(KeyCode.H)) { myState = States.schoonmaak_kleren_bovenaan_trap; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.schoonmaak_kleren_bewaker_aanvallen; }
    }

    void schoonmaak_kleren_aan_vloer_onderzoeken()
    {
        text.text = "Nog steeds smerig daar veranderen je nieuwe kleren helemaal niks aan. " +
                    "Je hebt ook niet de stiekeme behoefte om de boel schoon te gaan maken...!\n\n" +
                    //Acties
                    "Druk 'O' om Op te staan.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.schoonmaak_kleren_aan_in_de_gang; }
    }

    void schoonmaak_kleren_aan_terug_in_cel()
    {
        text.text = "Terug je cel in, dat voelt toch niet goed... " +
                    "Je ziet jezelf in de spiegel, hahaha je ziet er niet uit!\n\n" +
                    //Acties
                    "Druk 'T' om de Terug naar de gang te gaan.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.schoonmaak_kleren_aan_in_de_gang; }
    }

    //**************************************************
    // Schoonmaak kleren aan bovenaan de trap
    //**************************************************

    void schoonmaak_kleren_bovenaan_trap()
    {
        text.text = "Daar sta je dan oog in oog met een enorme bewaker. Hij kijkt je met " +
                    "vragende ogen aan, nadat je 'Hallo' hebt gezegd.\n\n" +
                    "Wat ben jij aan het doen? Vraagt hij.\n\n" +
                    // Acties
                    "Druk 'N' om te zeggen:'Niks, bemoei je met je eigen zaken.'\n" +
                    "Druk 'T' om te zeggen:'Owh, dit is niet de wc?'\n" +
                    "Druk 'S' om te zeggen:'Schoonmaken, wat denk je dan, dat ik voor de lol in zo'n pakje rond loop?' \n" +
                    "Druk 'A' om de bewaker aan te vallen";
        //if      (Input.GetKeyDown(KeyCode.N)) { myState = States.---; }
        else if (Input.GetKeyDown(KeyCode.T)) { myState = States.schoonmaak_kleren_niet_wc; }
        //else if (Input.GetKeyDown(KeyCode.S)) { myState = States.-- -; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.schoonmaak_kleren_bewaker_aanvallen; }
    }

    void schoonmaak_kleren_niet_wc()
    {
        text.text = "Nee, dat is het niet!\n\n" +
                    "Je bent gepakt en wordt hardhandig terug in de cel gezet.\n\n" +
                    //Acties
                    "Druk 'O' om het spel opnieuw te starten.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.cel; }
    }

    void schoonmaak_kleren_lol_in_pakje()
    {
        text.text = "'Dan mag je wel wat beter je best doen.' zegt de bewaker. Natuurlijk wel terecht want de \n" +
                    "gevangenis is echt een zooitje. 'Jaja, ik weet het ik ben pas net begonnen en ik kan niet \n'" +
                    "alles tegelijk." +
                    //Acties
                    "Druk op 'B' om te vragen waar de deur naar buiten is, je moet je water weggooien.\n" +
                    "Druk op 'V' om je te verontschuldigen en te vragen waar je beter je best zou moeten doen.\n" +
                    "Druk op 'W' om te zeggen 'Tsja, ik zou er ook niet in willen Wonen, maarja ik krijg ook maar per uur betaald.'";
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.---; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.-- -; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.-- -; }
    }

    void schoonmaak_kleren_bewaker_aanvallen()
    {
        text.text = "Ja? Dat leek je een goed idee? \n" +
                    "Met je haarclip en je schoonmakers pakje...\n\n" +
                    //Acties
                    "Druk 'O' om het spel opnieuw te starten.";
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.cel; }
    }
}
