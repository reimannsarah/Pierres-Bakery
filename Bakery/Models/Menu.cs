using System.Collections.Generic;

namespace Bakery.Models
{
  public abstract class Menu
  {
    public Dictionary<string,int> MenuItems { get; } = new Dictionary<string,int>()
    {
      {"sourdough", 2},
      {"baguette", 3},
      {"rye", 5},
      {"whole wheat", 4},
      {"pumpernickle", 5},
      {"blueberry muffin", 2},
      {"branmuffin", 2},
      {"criossant", 3},
      {"marionberry scone", 3},
      
    };
  }
}