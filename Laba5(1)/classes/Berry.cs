class Berry// клас Ягода 
{
    public string Color { get; set; }
    public int Size { get; set; }

    public bool IsFresh { get; set; }
    public Berry(string Color, int Size)
    {
        this.Color = Color;
        this.Size = Size;
        this.IsFresh = FreshOrNot();
    }
    public bool FreshOrNot()
    {
        Random random = new Random();
        bool random_bool = random.Next(2) == 0;
        return random_bool;
    }
}