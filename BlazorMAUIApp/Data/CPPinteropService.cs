using System.Runtime.InteropServices;

namespace BlazorMAUIApp.Data;

public class CPPinteropService
{
    // Use 'AppDomain.CurrentDomain.BaseDirectory' to get the output directory and store
    // your dlls there (ideally as a pre-build process). Example:
    // '.\bin\Debug\net6.0-windows10.0.19041.0\win10-x64\AppX'
    [DllImport("test.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Diu(int a);

}