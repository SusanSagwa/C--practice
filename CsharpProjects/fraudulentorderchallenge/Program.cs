string[] fraudulentIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string fraudid in fraudulentIDs)
{
   if (fraudid.StartsWith("B"))
   {
    Console.WriteLine(fraudid);
   } 
}