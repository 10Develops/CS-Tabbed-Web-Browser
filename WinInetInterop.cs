using System;
using System.Runtime.InteropServices;

namespace CS_Tabbed_Web_Browser
{
    public static class WinInetInterop
    {
        public struct Struct_INTERNET_PROXY_INFO
        {
            public int dwAccessType;
            public IntPtr proxy;
            public IntPtr proxyBypass;
        };

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        //to activate use like this strProxy="85.45.66.25:3633"
        //to deactivate use like this strProxy=":"
        public static void RefreshIESettings(string strProxy)
        {
            try
            {
                const int INTERNET_OPTION_PROXY = 38;
                const int INTERNET_OPEN_TYPE_PROXY = 3;

                Struct_INTERNET_PROXY_INFO struct_IPI;

                // Filling in structure 
                struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
                struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy);
                struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local");

                // Allocating memory 
                IntPtr intptrStruct = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI));

                // Converting structure to IntPtr 
                Marshal.StructureToPtr(struct_IPI, intptrStruct, true);

                bool iReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, Marshal.SizeOf(struct_IPI));
            }
            catch (Exception ex)
            {
            }
        }
    }
}
