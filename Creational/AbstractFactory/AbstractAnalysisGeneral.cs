namespace Creational.AbstractFactory
{
    public class AbstractAnalysisGeneral
    {
        //declares an interface for a type of product object
        private int erythrocytes;
        private int leukocytes;
        private int thrombocytes;
        private int sugar;
        private int clotting;
        private int color;
        private int hemoglobin;
        private int oxygen;

        public AbstractAnalysisGeneral()
        {

        }

        public AbstractAnalysisGeneral(int eryth, int leuko, int thromb,
            int sugar, int clot, int color, int hemo, int oxxxy)
        {
            this.erythrocytes = eryth;
            this.leukocytes = leuko;
            this.thrombocytes = thromb;
            this.sugar = sugar;
            this.clotting = clot;
            this.color = color;
            this.hemoglobin = hemo;
            this.oxygen = oxxxy;
        }
    }
}