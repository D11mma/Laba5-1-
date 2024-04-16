class Program
{
    static void Main()
    {
        Spruce spruce = new Spruce(10, 5);
        Bilberry bilberry = new Bilberry(100);
        Bilberry bilberry2 = new Bilberry(100);
        bilberry.ToPlant();
        bilberry.CollectBerry();
        bilberry2.OutPutCountBush();
    }
}