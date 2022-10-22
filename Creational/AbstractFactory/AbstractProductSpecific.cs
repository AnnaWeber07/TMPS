namespace Creational.AbstractFactory
{
    public class AbstractProductSpecific
    {
        //declares an interface for a type of product object
        //here you can find specific fields that can help you find the illness markers

        private int sugar;
        private int t3;
        private int t4;

        public AbstractProductSpecific()
        {

        }

        public AbstractProductSpecific(int sugar, int t3, int t4)
        {
            this.sugar = sugar;
            this.t3 = t3;
            this.t4 = t4;
        }

    }
}