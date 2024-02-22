using System.Diagnostics.Contracts;
using System.Text;

namespace DiamondKata
{
    public class DiamondPrinter
    {
        public static string PrintDiamond(char midpoint)
        {
            Contract.Requires(Char.IsLetter(midpoint) && !Char.IsLower(midpoint), "Invalid input. Please provide an uppercase letter.");

            if (!Char.IsLetter(midpoint) || Char.IsLower(midpoint))
            {
                throw new ArgumentException("Invalid input. Please provide an uppercase letter.");
            }

            int size = midpoint - 'A' + 1;
            StringBuilder diamond = new StringBuilder();

            // Upper half of the diamond
            for (int i = 0; i < size; i++)
            {
                char currentChar = (char)('A' + i);
                string spaces = new string('_', size - i - 1);
                string middlePart = i == 0 ? currentChar.ToString() : currentChar + new string('_', 2 * i - 1) + currentChar;
                diamond.AppendLine(spaces + middlePart + spaces);
            }

            // Lower half of the diamond (excluding the middle row)
            for (int i = size - 2; i >= 0; i--)
            {
                char currentChar = (char)('A' + i);
                string spaces = new string('_', size - i - 1);
                string middlePart = i == 0 ? currentChar.ToString() : currentChar + new string('_', 2 * i - 1) + currentChar;
                diamond.AppendLine(spaces + middlePart + spaces);
            }

            var result = diamond.ToString();

            Contract.Ensures(result.Length >= 1);
            return result;
        }
    }
}
