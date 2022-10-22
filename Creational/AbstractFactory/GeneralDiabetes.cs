namespace Creational.AbstractFactory
{
    public class GeneralDiabetes : AbstractAnalysisGeneral
    {
        public GeneralDiabetes()
        {
        }

        public GeneralDiabetes(int eryth, int leuko, int thromb, int sugar, int clot, int color, 
            int hemo, int oxxxy) : base(eryth, leuko, thromb, sugar, clot, color, hemo, oxxxy)
        {
            //TODO: write smth here...
        }
    }
}