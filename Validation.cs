namespace IntegrationConfigurator
{
    public static class Validation
    {
        private static List<string> Strings = new List<string>();

        public static void SetStrings( List<string> strings )
        {
            Strings.Clear();
            Strings.AddRange( strings );
        }

        public static bool IsEmpty()
        {
            foreach( string s in Strings )
            {
                if( string.IsNullOrEmpty( s ) )
                    return true;
            }

            return false;
        }
    }
}
