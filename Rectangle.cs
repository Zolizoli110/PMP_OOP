using System;

namespace Oop
{
  class Rectangle
  {
    private int width;
    private int height;
    private ConsoleColor color;

    public Rectangle(int width, int height, string color)
    {
      this.width = width;
      this.height = height;
      this.color = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);
    }

    private int Area() { return width * height; }

    public bool IsValid()
    {
      if (Area() > 0)
      {
        return true;
      }

      return false;
    }

    public void Draw()
    {
      Console.ForegroundColor = color;
      for (int i = 0; i < height; i++)
      {
        for (int j = 0; j < width; j++)
        {
          Console.Write("+");
        }

        Console.WriteLine();
      }
      Console.ResetColor();
    }
  }
}
