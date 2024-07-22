using System.Drawing;

namespace Noted
{
    public class Label
    {
        private string? _name;

        public required string Name 
        {
            get { return _name!; }
            set { _name = value; }
        }

        private Color _color;

        public required Color Color {
            get { return _color; }
            set { _color = value; } 
        }

        //public override string ToString()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    return $"{Name}";
        //}

    }
}
