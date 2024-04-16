abstract class Bush : Forest // клас Кущ 
{
    public int NumberBerry { get; set; }
    public bool IsCollectFruits { get; set; }
    public bool IsPlantBush { get; set; }
    public bool IsCutDownBush { get; set; }
    public Bush(int CountBerry)
    {
        GlobalVariables.GlobalCountBush += 1;

        this.IsPlantBush = false;
        this.IsCutDownBush = false;
        this.NumberBerry = NumberBerry;
        this.IsCollectFruits = IsCollectFruits;
    }
    public override void ToPlant()
    {
        this.IsPlantBush = true;
        Console.WriteLine("Кущ посаджано.");
    }
    public void CheckToPlantBush()
    {
        if (this.IsPlantBush)
        {
            Console.WriteLine("Кущ посаджено");
        }
        else
        {
            Console.WriteLine("Кущ не посаджано");
        }
    }
    public void OutPutCountBush()
    {
        Console.WriteLine($"Посадженно {GlobalVariables.GlobalCountBush} кущів");
    }
    public override void CutDown()
    {
        this.IsCutDownBush = true;
        Console.WriteLine("Кущ зрубано.");
    }
    public void CheckCutDownTree()
    {
        if (this.IsCutDownBush)
        {
            Console.WriteLine("Кущ зрублено");
        }
        else
        {
            Console.WriteLine("Кущ не зрублено");
        }
    }
    public override void CollectFruits()
    {
        this.IsCollectFruits = true;
        Console.WriteLine("Плоди на кущах зібрано.");
    }
    public void CheckCollectFruitsBush()
    {
        if (this.IsCollectFruits)
        {
            Console.WriteLine("Плоди зібрано на кущах");
        }
        else
        {
            Console.WriteLine("Плоди не зібрано на кущах");
        }
    }
    public override string ToString()
    {
        return $"Number of Berry: {NumberBerry};";
    }
}