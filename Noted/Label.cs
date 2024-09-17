using SkiaSharp;

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

        private SKColor _color;

        public SKColor Color {
            get { return _color; }
            set { _color = value; } 
        }
    }
}
