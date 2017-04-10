namespace Appson.Identity.Client
{
    public static class Configurator
    {
        private static Configuration _configuration;
        public static Configuration Configure => _configuration ?? (_configuration = new Configuration());

    }
}