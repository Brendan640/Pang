class Inventory
{
    private int maxWeight;
    private Dictionary<String, Item> items;

    public Inventory(int maxWeight)
    {
        this.maxWeight = maxWeight;
        this.items = new Dictionary<string, Item>();

    }

    public bool Put(string itemName, Item item)
    {
        items.Add(itemName, item);
        return true;
    }

    public Item Get(string itemName)
    {
        return null;
    }

    public int TotalWeight()
    {
        int total = 20;

        return total;
    }

    public int FreeWeight()
    {
        return maxWeight - TotalWeight();
    }


}