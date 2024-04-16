abstract class Tree : Forest // клас Дерево 
{
    public int Hight { get; set; }
    public int Age { get; set; }
    public bool IsPlantTree { get; set; }
    public bool IsCutDownTree { get; set; }
    public Tree(int Hight, int Age)
    {
        GlobalVariables.GlobalCountTree += 1;
        this.Hight = Hight;
        this.Age = Age;
        this.IsPlantTree = false;
        this.IsCutDownTree = false;
    }
    public override void ToPlant()
    {
        this.IsPlantTree = true;
        Console.WriteLine("Дерево посаджено.");
    }
    public void CheckToPlantTree()
    {
        if (this.IsPlantTree)
        {
            Console.WriteLine("Дерево посаджено");
        }
        else
        {
            Console.WriteLine("Дерево не посаджано");
        }
    }
    public void OutPutCountTree()
    {
        Console.WriteLine(GlobalVariables.GlobalCountTree);
    }
    public override void CutDown()
    {
        this.IsCutDownTree = true;
        Console.WriteLine("Дерево зрубано.");
    }
    public void CheckCutDownTree()
    {
        if (this.IsCutDownTree)
        {
            Console.WriteLine("Дерево зрублено");
        }
        else
        {
            Console.WriteLine("Дерево не зрублено");
        }
    }
    public override string ToString()
    {
        return $"Hight of Tree: {Hight}; Age of Tree: {Age}; Is plant Tree {IsPlantTree}";
    }
}