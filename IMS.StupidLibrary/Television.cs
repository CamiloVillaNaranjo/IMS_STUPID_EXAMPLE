namespace IMS.StupidLibrary
{
    public class Television
    {
        private static Television tv = null;
        private static readonly object padlock = new object();

        Television() { }

        public static Television Instance
        {
            get
            {
                lock (padlock)
                {
                    if (tv==null)
                    {
                        tv = new Television();
                    }
                    return tv;
                }
            }
        }

        public static string PowerOn()
        {
            return "Television Powered On!";
        }

        private string _colorMode;
        public string ColorMode
        {
            get { return _colorMode; }
            set { _colorMode = value; }
        }
    }
}
