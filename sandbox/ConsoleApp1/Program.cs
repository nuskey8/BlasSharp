using BlasSharp;
using static BlasSharp.AppleAccelerate.NativeMethods;

unsafe
{
    double[] A = [
        1.0, 2.0, 3.0,
        4.0, 5.0, 6.0,
        7.0, 8.0, 9.0
    ];

    double[] B = [
        1.0, 2.0, 3.0,
        4.0, 5.0, 6.0,
        7.0, 8.0, 9.0,
    ];

    double[] C = new double[9];

    fixed (double* aPtr = A, bPtr = B, cPtr = C)
    {
        cblas_dgemm(CBLAS_ORDER.CblasColMajor,
            CBLAS_TRANSPOSE.CblasNoTrans,
            CBLAS_TRANSPOSE.CblasNoTrans,
            3, 3, 3, 1.0, aPtr, 3, bPtr, 3, 0.0, cPtr, 3);
    }

    Console.WriteLine(string.Join(',', C));
}