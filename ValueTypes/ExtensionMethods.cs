// namespace is must.
    // Static class to hold the extension method
    public static class ExtensionMethods
    {
        // Extension method to count words
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            // Split the string into words
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the length of the words array
            return words.Length;
        }
    }
