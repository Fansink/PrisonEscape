using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States
    {
        cel, lakens_0, spiegel_0, spiegel_1, deur_0, lakens_1, spiegel_cel, kijken_spiegel, deur_1,
        gang_0
    };
    private States myState;
    
	// Use this for initialization
	void Start () {
        myState = States.cel;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cel)                  {cel();}
        else if (myState == States.lakens_0)        {lakens_0();}
        else if (myState == States.spiegel_0)       {spiegel_0();}
        else if (myState == States.deur_0)          {deur_0();}
        else if (myState == States.spiegel_cel)     {spiegel_cel();}
        else if (myState == States.lakens_1)        {lakens_1();}
        else if (myState == States.spiegel_1)       {spiegel_1();}
        else if (myState == States.kijken_spiegel)  {kijken_spiegel();}
        else if (myState == States.deur_1)          {deur_1();}
        else if (myState == States.gang_0)          {gang_0();}

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
        if      (Input.GetKeyDown(KeyCode.L))   {myState = States.lakens_0;}
        else if (Input.GetKeyDown(KeyCode.S))   {myState = States.spiegel_0;}
        else if (Input.GetKeyDown(KeyCode.D))   {myState = States.deur_0;}
    }

    void lakens_0()
    {
        text.text = "Wat een smerige dingen, je kunt je niet voorstellen dat iemand hier in kan slapen. " +
                    "Iemand zou ze moeten vervangen, 1 van de vele fijne dingen van het gevangenis " +
                    "leven...\n\n" +
                    "Jeeeej, lang leve de gevangenis..!!?\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if      (Input.GetKeyDown(KeyCode.T))    {myState = States.cel;}
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
        if      (Input.GetKeyDown(KeyCode.T))   {myState = States.cel;}
        else if (Input.GetKeyDown(KeyCode.P))   {myState = States.spiegel_cel;}

    }

    void deur_0()
    {
        text.text = "Het is een stevige ijzeren deur met een een slot met drukknoppen. Als je op één " +
                    "of andere manier de vieze vingerafdrukken zou kunnen zien die op het slot zitten. " +
                    "Misschien dat je dan de combinatie zou kunnen vinden\n\n" +
                    "Maar hoe...?\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if      (Input.GetKeyDown(KeyCode.T))   {myState = States.cel;}
    }

    //*************************
    // Stukje spiegel is gepakt
    //*************************

    void spiegel_cel()
    {
        text.text = "Daar sta je dan met een stukje spiegel in je hand en nog steeds in dezelfde " +
                    "vieze cel. De vieze lakens liggen er nog steeds. Het andere deel van de spiegel " +
                    "hangt nog aan de muur en de deur zit nog steeds op slot.\n\n" +
                    // Acties
                    "Druk 'L' om naar de Lakens te kijken.\n" +
                    "Druk 'S' om naar de Spiegel te kijken.\n" +
                    "Druk 'D' om naar de Deur te kijken.";
        if      (Input.GetKeyDown(KeyCode.L))   {myState = States.lakens_1;}
        else if (Input.GetKeyDown(KeyCode.S))   {myState = States.spiegel_1;}
        else if (Input.GetKeyDown(KeyCode.D))   {myState = States.deur_1;}
    }

    void lakens_1()
    {
        text.text = "De lakens zijn nog steeds te vies voor woorden. Ook als je via de spiegel naar de " +
                    "lakens kijkt wordt het er niet beter op.\n\n" +
                    // Acties
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel";
        if      (Input.GetKeyDown(KeyCode.T))   {myState = States.spiegel_cel;}
    }

    void spiegel_1()
    {
        text.text = "De spiegel is nog steeds vies en er mist een stuk. Het stuk dat je in je hand " +
                    "hebt.\n\n" +
                    // Acties
                    "Druk 'K' om een stap dichterbij te doen en naar jezelf te Kijken in de spiegel.\n" +
                    "Druk 'T' om Terug te gaan en verder te kijken in je cel.";
        if      (Input.GetKeyDown(KeyCode.K))   {myState = States.kijken_spiegel;}
        else if (Input.GetKeyDown(KeyCode.T))   {myState = States.spiegel_cel;}
    }

    void kijken_spiegel()
    {
        text.text = "Nope, je ziet er nog steeds niet uit...\n\n" +
                    // Acties
                    "Druk 'T' om een stap Terug te doen.";
        if      (Input.GetKeyDown(KeyCode.T))   {myState = States.spiegel_1;}
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
        if      (Input.GetKeyDown(KeyCode.O))   {myState = States.gang_0;}
        else if (Input.GetKeyDown(KeyCode.T))   {myState = States.spiegel_cel;}
    }

    //************************************
    // Deur geopend en je staat in de gang
    //************************************

    void gang_0()
    {
        text.text = "Yes, gelukt!!\n\n" +
                    "De eerste stap richting je vrijheid is genomen. Nu kijken hoe je uit de gang vol " +
                    "met cellen en andere gevangenen kunt komen.\n\n" +
                    "Als je om je heen kijkt zie je een Trap, zou die leiden naar vrijheid? Er is een " +
                    "kast in de gang en natuurlijk de Vloer." +
                    //Acties
                    "Druk 'T' om de Trap op te lopen.\n" +
                    "Druk 'V' om naar de vloer te kijken.\n" +
                    "Druk 'K' om de kastdeur te openen.\n" +
                    "Druk 'C' om weer terug je Cel in te gaan.";
        if      (Input.GetKeyDown(KeyCode.T))   {myState = States.trap_0;}
        else if (Input.GetKeyDown(KeyCode.V))   {myState = States.vloer;}
        else if (Input.GetKeyDown(KeyCode.K))   {myState = States.kastdeur;}
        else if (Input.GetKeyDown(KeyCode.C))   {myState = States.spiegel_cel;}
    }

    void trap_0()
    {
        text.text = "Je begint langzaam de trap op te lopen, wat zou er bovenaan de trap zitten." +
                    "Als je bovenkomt kijk je recht tegen een bewaker aan die ook jou recht aan kijkt.\n\n" +
                    "Je bent gesnapt en wordt hardhandig terug de cel in gestopt.\n\n" +
                    //Acties
                    "Druk 'O' om het spel opnieuw te starten.";
        if      (Input.GetKeyDown(KeyCode.O))    {myState = States.cel;}
    }

    void vloer()
    {
        text.text = "";
        if      (Input.GetKeyDown(KeyCode.P))   {myState = States.gang_1;}
    }

    void kastdeur()
    {
        text.text = "";
        if      (Input.GetKeyDown(KeyCode.))    {myState = States.;}
    }

    //**************************************************
    // Haarclip opgepakt, je staat nog steeds in de gang
    //**************************************************

}


void ()
{
    text.text = "";

    if (Input.GetKeyDown(KeyCode.))
    {
        myState = States.;
    }