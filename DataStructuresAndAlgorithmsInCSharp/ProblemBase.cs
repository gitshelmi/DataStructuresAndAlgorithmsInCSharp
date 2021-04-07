using System.Collections.Generic;

namespace DataStructuresAndAlgorithmsInCSharp
{
   public abstract class ProblemBase
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public string Source { get; set; }
      public Level Level { get; set; }
      public List<string> Keywords { get; set; }

      public abstract void SetBaseValues();

      protected ProblemBase()
      {
         SetBaseValues();
      }
   }
}
