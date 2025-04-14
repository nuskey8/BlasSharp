namespace BlasSharp;

public unsafe interface IBlas
{
    static abstract float cblas_sdsdot(int n, float alpha, float* x, int incx, float* y, int incy);
}