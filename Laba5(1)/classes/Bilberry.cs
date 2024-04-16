class Bilberry : Bush// клас Чорниця
{
    public int CountBerry { get; set; }

    public int CollectBarryVal { get; set; }

    public bool OrCollect { get; set; }
    public List<Berry> BerryList { get; set; }

    public Bilberry(int CountBerry)
    : base(CountBerry)
    {
        this.CountBerry = CountBerry;
        this.OrCollect = false;
        CreateObjectBerry();
    }
    public void CreateObjectBerry()
    {
        BerryList = new List<Berry>();
        for (int i = 0; i < this.CountBerry; i++)
        {
            BerryList.Add(new Berry("Чорний", 1));
        }
    }
    public void CollectBerry()
    {
        if (!OrCollect && IsPlantBush)
        {
            int fresh = 0;
            int not_fresh = 0;
            foreach (Berry berry in BerryList)
            {

                if (berry.IsFresh == true)
                {
                    fresh++;
                }
                else
                {
                    not_fresh++;
                }
            }
            CollectBarryVal = fresh;

            Console.WriteLine($"Зібрано {fresh} свіжих ягід. {not_fresh} не свіжих ягід");
        }
        else if (!IsPlantBush)
        {
            Console.WriteLine("Кущ ще не посадженний");
        }
        else
        {
            Console.WriteLine("Ягіди вже зібрані!");
        }
    }
    public void HowCollectBarry()
    {
        Console.WriteLine($"Зібрано {CollectBarryVal} ягід");
    }
}