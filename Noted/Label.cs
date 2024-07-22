using System.Drawing;

namespace Noted
{
    public class Label
    {

        public required string Name { get; set; }

        public required Color Color { get; set; }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"{Name}";
        }

    }
}
