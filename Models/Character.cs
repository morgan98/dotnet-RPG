namespace dotnet_RPG.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Rook";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int ActionPoints { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Infantry;


    }
    
}