class Pine : Tree // клас Сосна 
{
    public int CountLongCones { get; set; }
    public bool IsCollectConesPine { get; set; }
    public Pine(int Hight, int Age)
    : base(Hight, Age)
    {
        this.CountLongCones = CountLongCones;
        this.IsCollectConesPine = false;
    }
    public override void CollectFruits()
    {
        Console.WriteLine("Зібрані довгі соснові шишки.");
    }
    public void CheckIsCollectConesPine()
    {
        if (this.IsCollectConesPine)
        {
            Console.WriteLine("Соснові шишки зібрано.");
        }
        else
        {
            Console.WriteLine("Соснові шишки не зібрано.");
        }
    }
}