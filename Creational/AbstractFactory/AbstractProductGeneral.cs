namespace Creational.AbstractFactory
{
    public abstract class AbstractProductGeneral
    {
        //declares an interface for a type of product object

        public abstract void GenerateCompleteList();
        public abstract void GenerateFullList(GeneralHormones generalHormones);

    }
}