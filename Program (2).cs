namespace Assignment
{
    static class Program
    {
        static void Main()
        public class TreasureChest
{
    private string _material;
    private string _lockType;
    private string _lootQuality;
    private string _state;

    public TreasureChest()
    {
        _material = "Wood";
        _lockType = "None";
        _lootQuality = "Common";
        _state = "Closed";
    }

    public TreasureChest(string material, string lockType, string lootQuality)
    {
        _material = material;
        _lockType = lockType;
        _lootQuality = lootQuality;
        _state = "Closed";
    }

    public string Material => _material;
    public string LockType => _lockType;
    public string LootQuality => _lootQuality;

    public string State => _state;

    public bool Unlock()
    {
        if (_state == "Locked")
        {
            _state = "Closed";
            Console.WriteLine("The chest has been unlocked.");
            return true;
        }

        Console.WriteLine("The chest is not locked. Unlocking failed.");
        return false;
    }

    public bool Lock()
    {
        if (_state == "Closed")
        {
            _state = "Locked";
            Console.WriteLine("The chest has been locked.");
            return true;
        }

        Console.WriteLine("The chest is not closed. Locking failed.");
        return false;
    }

    public bool Open()
    {
        if (_state == "Closed")
        {
            _state = "Open";
            Console.WriteLine("The chest has been opened.");
            return true;
        }

        Console.WriteLine("The chest is not closed. Opening failed.");
        return false;
    }

    public bool Close()
    {
        if (_state == "Open")
        {
            _state = "Closed";
            Console.WriteLine("The chest has been closed.");
            return true;
        }

        Console.WriteLine("The chest is not open. Closing failed.");
        return false;
    }

    public string Manipulate(string action)
    {
        switch (action)
        {
            case "Unlock":
                Unlock();
                break;
            case "Lock":
                Lock();
                break;
            case "Open":
                Open();
                break;
            case "Close":
                Close();
                break;
            default:
                Console.WriteLine("Invalid action.");
                break;
        }

        return _state;
    }
}
    }
}
