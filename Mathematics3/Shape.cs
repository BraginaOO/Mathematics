
namespace Mathematics3D
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract double Volume();
        public abstract void DisplayInfo();
    }
}
