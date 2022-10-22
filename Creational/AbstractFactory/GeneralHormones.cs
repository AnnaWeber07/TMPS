namespace Creational.AbstractFactory
{
    public class GeneralHormones : AbstractAnalysisGeneral
    {
        public GeneralHormones()
        {

        }

        public GeneralHormones(int eryth, int leuko, int thromb, int sugar, int clot, int color, 
            int hemo, int oxxxy) : base(eryth, leuko, thromb, sugar, clot, color, hemo, oxxxy)
        {
            //TODO: write smth here...
        }
    }
}