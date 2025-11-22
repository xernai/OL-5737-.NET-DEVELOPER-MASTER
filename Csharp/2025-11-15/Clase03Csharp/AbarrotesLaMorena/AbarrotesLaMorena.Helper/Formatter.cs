using System;

namespace AbarrotesLaMorena.Helper
{
    public static class Transformer
    {
        public static string FormatName(string name, string firstName, string lastName)
        {
            return name + " " + firstName + " " + lastName;
        }
    }
}
