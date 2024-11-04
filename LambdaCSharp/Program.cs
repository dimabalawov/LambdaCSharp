
using System.Text;
using System.Xml.Schema;


Func<string, RGB> getRGB = delegate (string color)
{

    switch (color.ToLower())
    {
        case "red":
            return new RGB(255, 0, 0);
        case "orange":
            return new RGB(255, 127, 0);
        case "yellow":
            return new RGB(255, 255, 0);
        case "green":
            return new RGB(0, 255, 0);
        case "blue":
            return new RGB(0, 0, 255);
        case "purple":
            return new RGB(139, 0, 255);
        default:
            throw new ArgumentException("Unknown color");
    }
};

string colorName = "red";
RGB colorRGB = getRGB(colorName);
Console.WriteLine($"{colorName} in RGB is {colorRGB}");
class RGB
{
    public int Red { get; set; } = 0;
    public int Green { get; set; } = 0;
    public int Blue { get; set; } = 0;
    public override string ToString()
    {
        return $"R:{Red} G:{Green} B:{Blue}";
    }
    public RGB(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

