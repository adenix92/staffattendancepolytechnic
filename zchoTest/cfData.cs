namespace ZKTEchoTest
{

    public static class cfData
    {
        private static string _serialNumber;
        public static string serialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
        public static string IPAddress = "192.168.10.201";
        public static int PortNum = 4370;
        public static Form1 fmHome = new Form1();
        public static ucSettings fmfmSettings = new ucSettings();
        public static int dwMachineNumber = 1;
        public static lnqAttendanceDataContext dc = new lnqAttendanceDataContext();
        public static StaffDetail staff;
    }

}
