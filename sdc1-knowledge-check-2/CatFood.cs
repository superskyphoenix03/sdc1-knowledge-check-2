// CatFood.cs
    public class CatFood : Product
    {
        public bool KittenFood { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}, KittenFood: {KittenFood}";
        }
    }
