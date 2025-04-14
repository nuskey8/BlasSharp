namespace BlasSharp.Mkl;

public static partial class NativeMethods
{
#if LINUX || OSX
    const string __DllName = "libmkl_rt";
#else
    const string __DllName = "mkl_rt";
#endif
}