namespace ResponsiveSite
{
    public static class ResponsiveSiteTestVariables
    {
        private static string _env;
        public static string Environment
        {
            get
            {
                return _env;
            }

            set
            {
                _env = value;
            }
        }
    }
}
