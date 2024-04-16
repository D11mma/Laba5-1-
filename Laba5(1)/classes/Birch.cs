class Birch : Tree// клас Береза 
{
    public double CountJuiceBirch { get; set; }
    public bool IsCollectJuiceBirch { get; set; }
    public Birch(int Hight, int Age)
    : base(Hight, Age)
    {
        this.CountJuiceBirch = CountJuiceBirch;
        this.IsCollectJuiceBirch = false;
    }
    public override void CollectFruits()
    {
        Console.WriteLine("Березовий сік зібрано.");
    }
    public void CheckIsCollectCountJuiceBirch()
    {
        if (this.IsCollectJuiceBirch)
        {
            Console.WriteLine("Березовий сік зібрано.");
        }
        else
        {
            Console.WriteLine("Березовий сік не було зібрано.");
        }
    }
}