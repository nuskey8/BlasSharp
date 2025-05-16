namespace BlasSharp;

public interface IBlasOperations : IBlasLevel1, IBlasLevel2, IBlasLevel3
{
}

public unsafe interface IBlasLevel1
{
    void Saxpy(int n, float alpha, float* x, int incX, float* y, int incY);
    void Daxpy(int n, double alpha, double* x, int incX, double* y, int incY);
    void Caxpy(int n, void* alpha, void* x, int incX, void* y, int incY);
    void Zaxpy(int n, void* alpha, void* x, int incX, void* y, int incY);

    float Sasum(int n, float* x, int incX);
    double Dasum(int n, double* x, int incX);
    float Csasum(int n, void* x, int incX);
    double Dzasum(int n, void* x, int incX);

    void Scopy(int n, float* x, int incX, float* y, int incY);
    void Dcopy(int n, double* x, int incX, double* y, int incY);
    void Ccopy(int n, float* x, int incX, float* y, int incY);
    void Zcopy(int n, double* x, int incX, double* y, int incY);

    float Sdot(int n, float* x, int incX, float* y, int incY);
    double Ddot(int n, double* x, int incX, double* y, int incY);

    void CDotc(int n, void* x, int incX, void* y, int incY, void* dotc);
    void ZDotc(int n, void* x, int incX, void* y, int incY, void* dotc);

    void Cdotu(int n, void* x, int incX, void* y, int incY, void* dotc);
    void Zdotu(int n, void* x, int incX, void* y, int incY);

    float Snrm2(int n, float* x, int incX);
    double Dnrm2(int n, double* x, int incX);
    float Scnrm2(int n, void* x, int incX);
    double Dznrm2(int n, void* x, int incX);

    void Srot(int n, float* x, int incX, float* y, int incY, float c, float s);
    void Drot(int n, double* x, int incX, double* y, int incY, double c, double s);
    void Csrot(int n, void* x, int incX, void* y, int incY, float c, float s);
    void Zdrot(int n, void* x, int incX, void* y, int incY, double c, double s);

    void Srotg(float* a, float* b, float* c, float* s);
    void Drotg(double* a, double* b, double* c, double* s);
    void Crotg(void* a, void* b, float* c, float* s);
    void Zrotg(void* a, void* b, double* c, double* s);

    void Srotm(int n, float* x, int incX, float* y, int incY, float* p);
    void Drotm(int n, double* x, int incX, double* y, int incY, double* p);

    void Srotmg(float* d1, float* d2, float* b1, float b2, float* p);
    void Drotmg(double* d1, double* d2, double* b1, double b2, double* p);

    void Sscal(int n, float a, float* x, int incX);
    void Dscal(int n, double a, double* x, int incX);
    void Cscal(int n, void* a, void* x, int incX);
    void Zscal(int n, void* a, void* x, int incX);
    void Csscal(int n, float a, void* x, int incX);
    void Zdscal(int n, double a, void* x, int incX);

    void Sswap(int n, float* x, int incX, float* y, int incY);
    void Dswap(int n, double* x, int incX, double* y, int incY);
    void Cswap(int n, void* x, int incX, void* y, int incY);
    void Zswap(int n, void* x, int incX, void* y, int incY);

    int Isamax(int n, float* x, int incX);
    int Idamax(int n, double* x, int incX);
    int Icamax(int n, void* x, int incX);
    int Izamax(int n, void* x, int incX);

    int Isamin(int n, float* x, int incX);
    int Idamin(int n, double* x, int incX);
    int Icamin(int n, void* x, int incX);
    int Izamin(int n, void* x, int incX);

    int Ismax(int n, float* x, int incX);
    int Idmax(int n, double* x, int incX);

    int Ismin(int n, float* x, int incX);
    int Idmin(int n, double* x, int incX);
}

public unsafe interface IBlasLevel2
{
    void Sgbmv(uint order, uint transA, int m, int n, int kl, int ku, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY);
    void Dgbmv(uint order, uint transA, int m, int n, int kl, int ku, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY);
    void Cgbmv(uint order, uint transA, int m, int n, int kl, int ku, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);
    void Zgbmv(uint order, uint transA, int m, int n, int kl, int ku, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);

    void Sgemv(uint order, uint transA, int m, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY);
    void Dgemv(uint order, uint transA, int m, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY);
    void Cgemv(uint order, uint transA, int m, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);
    void Zgemv(uint order, uint transA, int m, int b, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);

    void Sger(uint order, int m, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA);
    void Dger(uint order, int m, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA);

    void Cgerc(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);
    void Zgerc(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);

    void Cgeru(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);
    void Zgeru(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);

    void Chbmv(uint order, uint uplo, int n, int k, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);
    void Zhbmv(uint order, uint uplo, int n, int k, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);

    void Chemv(uint order, uint uplo, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);
    void Zhemv(uint order, uint uplo, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY);

    void Cher(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a, int ldA);
    void Zher(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a, int ldA);

    void Cher2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);
    void Zher2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA);

    void Chpmv(uint order, uint uplo, int n, void* alpha, void* a, void* x, int incX, void* beta, void* y, int incY);
    void Zhpmv(uint order, uint uplo, int n, void* alpha, void* a, void* x, int incX, void* beta, void* y, int incY);

    void Chpr(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a);
    void Zhpr(uint order, uint uplo, int n, double alpha, void* x, int incX, void* a);

    void Chpr2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a);
    void Zhpr2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a);

    void Ssbmv(uint order, uint uplo, int n, int k, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY);
    void Dsbmv(uint order, uint uplo, int n, int k, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY);

    void Sspmv(uint order, uint uplo, int n, float alpha, float* a, float* x, int incX, float beta, float* y, int incY);
    void Dspmv(uint order, uint uplo, int n, double alpha, double* a, double* x, int incX, double beta, double* y, int incY);

    void Sspr(uint order, uint uplo, int n, float alpha, float* x, int incX, float* a);
    void Dspr(uint order, uint uplo, int n, double alpha, double* x, int incX, double* a);

    void Sspr2(uint order, uint uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a);
    void Dspr2(uint order, uint uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a);

    void Ssymv(uint order, uint uplo, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY);
    void Dsymv(uint order, uint uplo, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY);

    void Ssyr(uint order, uint uplo, int n, float alpha, float* x, int incX, float* a, int ldA);
    void Dsyr(uint order, uint uplo, int n, double alpha, double* x, int incX, double* a, int ldA);

    void Ssyr2(uint order, uint uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA);
    void Dsyr2(uint order, uint uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA);

    void Stbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, float* a, int ldA, float* x, int incX);
    void Dtbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, double* a, int ldA, double* x, int incX);
    void Ctbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX);
    void Ztbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX);

    void Stbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, float* a, int ldA, float* x, int incX);
    void Dtbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, double* a, int ldA, double* x, int incX);
    void Ctbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX);
    void Ztbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX);

    void Stpmv(uint order, uint uplo, uint transA, uint diag, int n, float* a, float* x, int incX);
    void Dtpmv(uint order, uint uplo, uint transA, uint diag, int n, double* a, double* x, int incX);
    void Ctpmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, void* x, int incX);
    void Ztpmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, void* x, int incX);

    void Stpsv(uint order, uint uplo, uint transA, uint diag, int n, float* ap, float* x, int incX);
    void Dtpsv(uint order, uint uplo, uint transA, uint diag, int n, double* ap, double* x, int incX);
    void Ctpsv(uint order, uint uplo, uint transA, uint diag, int n, void* ap, void* x, int incX);
    void Ztpsv(uint order, uint uplo, uint transA, uint diag, int n, void* ap, void* x, int incX);

    void Strmv(uint order, uint uplo, uint transA, uint diag, int n, float* a, int ldA, float* x, int incX);
    void Dtrmv(uint order, uint uplo, uint transA, uint diag, int n, double* a, int ldA, double* x, int incX);
    void Ctrmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX);
    void Ztrmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX);

    void Strsv(uint order, uint uplo, uint transA, uint diag, int n, float* a, int ldA, float* x, int incX);
    void Dtrsv(uint order, uint uplo, uint transA, uint diag, int n, double* a, int ldA, double* x, int incX);
    void Ctrsv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX);
    void Ztrsv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX);
}

public unsafe interface IBlasLevel3
{
    void Sgemm(uint order, uint transA, uint transB, int m, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC);
    void Dgemm(uint order, uint transA, uint transB, int m, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC);
    void Cgemm(uint order, uint transA, uint transB, int m, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);
    void Zgemm(uint order, uint transA, uint transB, int m, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);

    void Chemm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);
    void Zhemm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);

    void Cherk(uint order, uint uplo, uint trans, int n, int k, float alpha, void* a, int ldA, float beta, void* c, int ldC);
    void Zherk(uint order, uint uplo, uint trans, int n, int k, double alpha, void* a, int ldA, double beta, void* c, int ldC);

    void Cher2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, float beta, void* c, int ldC);
    void Zher2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, double beta, void* c, int ldC);

    void Ssymm(uint order, uint side, uint uplo, int m, int n, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC);
    void Dsymm(uint order, uint side, uint uplo, int m, int n, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC);
    void Csymm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);
    void Zsymm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);

    void Ssyrk(uint order, uint uplo, uint trans, int n, int k, float alpha, float* a, int ldA, float beta, float* c, int ldC);
    void Dsyrk(uint order, uint uplo, uint trans, int n, int k, double alpha, double* a, int ldA, double beta, double* c, int ldC);
    void Csyrk(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* beta, void* c, int ldC);
    void Zsyrk(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* beta, void* c, int ldC);

    void Ssyr2k(uint order, uint uplo, uint trans, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC);
    void Dsyr2k(uint order, uint uplo, uint trans, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC);
    void Csyr2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);
    void Zsyr2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC);

    void Strmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB);
    void Dtrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB);
    void Ctrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB);
    void Ztrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB);

    void Strsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB);
    void Dtrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB);
    void Ctrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB);
    void Ztrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB);
}