class Spruce : Tree// клас Ялина 
{
    public int CountCones { get; set; }
    public bool IsCollectCones { get; set; }
    public Spruce(int Hight, int Age)
    : base(Hight, Age)
    {
        this.CountCones = CountCones;
        this.IsCollectCones = false;
    }
    public override void CollectFruits()
    {
        this.IsCollectCones = true;
        Console.WriteLine("Шишки зібрано");
    }
    public void CheckCollectFruits()
    {
        if (this.IsCollectCones)
        {
            Console.WriteLine("Шишки зібрано");
        }
        else { Console.WriteLine("Шишки не зібрано"); }
    }
}