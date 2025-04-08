namespace FOLYFOOD.Hellers
{
    public class UniqueStringGenerator
    {
        private HashSet<string> uniqueStrings;
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private Random random;

        public UniqueStringGenerator()
        {
            uniqueStrings = new HashSet<string>();
            random = new Random();
        }

        private string GenerateRandomString(int length)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateUniqueString(int length)
        {
            string newString;
            do
            {
                newString = GenerateRandomString(length);
            } while (uniqueStrings.Contains(newString));

            uniqueStrings.Add(newString);
            return newString;
        }
    }
    }
