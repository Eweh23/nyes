namespace Kod
{
class Fordon
{
    private string märke;
    private string modell;
    private int år;

    public Fordon(string nyttMärke, string nyModell, int nyttÅr)
    {       
        märke = nyttMärke;
        modell = nyModell;
        år = nyttÅr;
    }
    public Fordon()
    {

    }
    public string Märke
    {
        get{return märke;}
        set{märke = value;}
    }

    public string Modell
    {
        get{return modell;}
        set{modell = value;}
    }

    public int År
    {
        get{return år;}
        set{år = value;}
    }
}
}