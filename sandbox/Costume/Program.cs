namespace Costume;
class Program
{
    static void Main(string[] args)
    {
        List<Costume> myCostumes = new List<Costume>();

        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footwear = "dress shoes";
        detective._accessories = "fingerprint kit";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "hairnet";
        nurse._upperGarment = "trenchcoat";
        nurse._lowerGarment = "slacks";
        nurse._footwear = "dress shoes";
        nurse._accessories = "fingerprint kit";
        myCostumes.Add(nurse);

        foreach(Costume i in myCostumes)
        {
            i.Output();
        }
    }
}
