using static BlasSharp.AppleAccelerate.NativeMethods;

namespace BlasSharp.AppleAccelerate;

public sealed class AppleAccelerateBlasOperations : IBlasOperations
{
    public static readonly AppleAccelerateBlasOperations Default = new();

    public unsafe void Caxpy(int n, void* alpha, void* x, int incX, void* y, int incY)
    {
        cblas_caxpy(n, alpha, x, incX, y, incY);
    }

    public unsafe void Ccopy(int n, float* x, int incX, float* y, int incY)
    {
        cblas_ccopy(n, x, incX, y, incY);
    }

    public unsafe void CDotc(int n, void* x, int incX, void* y, int incY, void* dotc)
    {
        cblas_cdotc_sub(n, x, incX, y, incY, dotc);
    }

    public unsafe void Cdotu(int n, void* x, int incX, void* y, int incY, void* dotc)
    {
        cblas_cdotu_sub(n, x, incX, y, incY, dotc);
    }

    public unsafe void Cgbmv(uint order, uint transA, int m, int n, int kl, int ku, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_cgbmv(order, transA, m, n, kl, ku, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Cgemm(uint order, uint transA, uint transB, int m, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_cgemm(order, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Cgemv(uint order, uint transA, int m, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_cgemv(order, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Cgerc(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_cgerc(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Cgeru(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_cgeru(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Chbmv(uint order, uint uplo, int n, int k, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_chbmv(order, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Chemm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_chemm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Chemv(uint order, uint uplo, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_chemv(order, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Cher(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a, int ldA)
    {
        cblas_cher(order, uplo, n, alpha, x, incX, a, ldA);
    }

    public unsafe void Cher2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_cher2(order, uplo, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Cher2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, float beta, void* c, int ldC)
    {
        cblas_cher2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Cherk(uint order, uint uplo, uint trans, int n, int k, float alpha, void* a, int ldA, float beta, void* c, int ldC)
    {
        cblas_cherk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Chpmv(uint order, uint uplo, int n, void* alpha, void* a, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_chpmv(order, uplo, n, alpha, a, x, incX, beta, y, incY);
    }

    public unsafe void Chpr(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a)
    {
        cblas_chpr(order, uplo, n, alpha, x, incX, a);
    }

    public unsafe void Chpr2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a)
    {
        cblas_chpr2(order, uplo, n, alpha, x, incX, y, incY, a);
    }

    public unsafe void Crotg(void* a, void* b, float* c, float* s)
    {
        cblas_crotg(a, b, c, s);
    }

    public unsafe float Csasum(int n, void* x, int incX)
    {
        return cblas_scasum(n, x, incX);
    }

    public unsafe void Cscal(int n, void* a, void* x, int incX)
    {
        cblas_cscal(n, a, x, incX);
    }

    public unsafe void Csrot(int n, void* x, int incX, void* y, int incY, float c, float s)
    {
        cblas_csrot(n, x, incX, y, incY, c, s);
    }

    public unsafe void Csscal(int n, float a, void* x, int incX)
    {
        cblas_csscal(n, a, x, incX);
    }

    public unsafe void Cswap(int n, void* x, int incX, void* y, int incY)
    {
        cblas_cswap(n, x, incX, y, incY);
    }

    public unsafe void Csymm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_csymm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Csyr2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_csyr2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Csyrk(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* beta, void* c, int ldC)
    {
        cblas_csyrk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Ctbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX)
    {
        cblas_ctbmv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Ctbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX)
    {
        cblas_ctbsv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Ctpmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, void* x, int incX)
    {
        cblas_ctpmv(order, uplo, transA, diag, n, a, x, incX);
    }

    public unsafe void Ctpsv(uint order, uint uplo, uint transA, uint diag, int n, void* ap, void* x, int incX)
    {
        cblas_ctpsv(order, uplo, transA, diag, n, ap, x, incX);
    }

    public unsafe void Ctrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB)
    {
        cblas_ctrmm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Ctrmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX)
    {
        cblas_ctrmv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe void Ctrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB)
    {
        cblas_ctrsm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Ctrsv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX)
    {
        cblas_ctrsv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe double Dasum(int n, double* x, int incX)
    {
        return cblas_dasum(n, x, incX);
    }

    public unsafe void Daxpy(int n, double alpha, double* x, int incX, double* y, int incY)
    {
        cblas_daxpy(n, alpha, x, incX, y, incY);
    }

    public unsafe void Dcopy(int n, double* x, int incX, double* y, int incY)
    {
        cblas_dcopy(n, x, incX, y, incY);
    }

    public unsafe double Ddot(int n, double* x, int incX, double* y, int incY)
    {
        return cblas_ddot(n, x, incX, y, incY);
    }

    public unsafe void Dgbmv(uint order, uint transA, int m, int n, int kl, int ku, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
    {
        cblas_dgbmv(order, transA, m, n, kl, ku, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Dgemm(uint order, uint transA, uint transB, int m, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC)
    {
        cblas_dgemm(order, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Dgemv(uint order, uint transA, int m, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
    {
        cblas_dgemv(order, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Dger(uint order, int m, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
    {
        cblas_dger(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe double Dnrm2(int n, double* x, int incX)
    {
        return cblas_dnrm2(n, x, incX);
    }

    public unsafe void Drot(int n, double* x, int incX, double* y, int incY, double c, double s)
    {
        cblas_drot(n, x, incX, y, incY, c, s);
    }

    public unsafe void Drotg(double* a, double* b, double* c, double* s)
    {
        cblas_drotg(a, b, c, s);
    }

    public unsafe void Drotm(int n, double* x, int incX, double* y, int incY, double* p)
    {
        cblas_drotm(n, x, incX, y, incY, p);
    }

    public unsafe void Drotmg(double* d1, double* d2, double* b1, double b2, double* p)
    {
        cblas_drotmg(d1, d2, b1, b2, p);
    }

    public unsafe void Dsbmv(uint order, uint uplo, int n, int k, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
    {
        cblas_dsbmv(order, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Dscal(int n, double a, double* x, int incX)
    {
        cblas_dscal(n, a, x, incX);
    }

    public unsafe void Dspmv(uint order, uint uplo, int n, double alpha, double* a, double* x, int incX, double beta, double* y, int incY)
    {
        cblas_dspmv(order, uplo, n, alpha, a, x, incX, beta, y, incY);
    }

    public unsafe void Dspr(uint order, uint uplo, int n, double alpha, double* x, int incX, double* a)
    {
        cblas_dspr(order, uplo, n, alpha, x, incX, a);
    }

    public unsafe void Dspr2(uint order, uint uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a)
    {
        cblas_dspr2(order, uplo, n, alpha, x, incX, y, incY, a);
    }

    public unsafe void Dswap(int n, double* x, int incX, double* y, int incY)
    {
        cblas_dswap(n, x, incX, y, incY);
    }

    public unsafe void Dsymm(uint order, uint side, uint uplo, int m, int n, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC)
    {
        cblas_dsymm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Dsymv(uint order, uint uplo, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
    {
        cblas_dsymv(order, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Dsyr(uint order, uint uplo, int n, double alpha, double* x, int incX, double* a, int ldA)
    {
        cblas_dsyr(order, uplo, n, alpha, x, incX, a, ldA);
    }

    public unsafe void Dsyr2(uint order, uint uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
    {
        cblas_dsyr2(order, uplo, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Dsyr2k(uint order, uint uplo, uint trans, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC)
    {
        cblas_dsyr2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Dsyrk(uint order, uint uplo, uint trans, int n, int k, double alpha, double* a, int ldA, double beta, double* c, int ldC)
    {
        cblas_dsyrk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Dtbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, double* a, int ldA, double* x, int incX)
    {
        cblas_dtbmv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Dtbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, double* a, int ldA, double* x, int incX)
    {
        cblas_dtbsv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Dtpmv(uint order, uint uplo, uint transA, uint diag, int n, double* a, double* x, int incX)
    {
        cblas_dtpmv(order, uplo, transA, diag, n, a, x, incX);
    }

    public unsafe void Dtpsv(uint order, uint uplo, uint transA, uint diag, int n, double* ap, double* x, int incX)
    {
        cblas_dtpsv(order, uplo, transA, diag, n, ap, x, incX);
    }

    public unsafe void Dtrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
    {
        cblas_dtrmm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Dtrmv(uint order, uint uplo, uint transA, uint diag, int n, double* a, int ldA, double* x, int incX)
    {
        cblas_dtrmv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe void Dtrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
    {
        cblas_dtrsm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Dtrsv(uint order, uint uplo, uint transA, uint diag, int n, double* a, int ldA, double* x, int incX)
    {
        cblas_dtrsv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe double Dzasum(int n, void* x, int incX)
    {
        return cblas_dzasum(n, x, incX);
    }

    public unsafe double Dznrm2(int n, void* x, int incX)
    {
        return cblas_dznrm2(n, x, incX);
    }

    public unsafe int Icamax(int n, void* x, int incX)
    {
        return cblas_icamax(n, x, incX);
    }

    public unsafe int Icamin(int n, void* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe int Idamax(int n, double* x, int incX)
    {
        return cblas_idamax(n, x, incX);
    }

    public unsafe int Idamin(int n, double* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe int Idmax(int n, double* x, int incX)
    {
        return cblas_idamax(n, x, incX);
    }

    public unsafe int Idmin(int n, double* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe int Isamax(int n, float* x, int incX)
    {
        return cblas_isamax(n, x, incX);
    }

    public unsafe int Isamin(int n, float* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe int Ismax(int n, float* x, int incX)
    {
        // use cblas_isamax
        return cblas_isamax(n, x, incX);
    }

    public unsafe int Ismin(int n, float* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe int Izamax(int n, void* x, int incX)
    {
        return cblas_izamax(n, x, incX);
    }

    public unsafe int Izamin(int n, void* x, int incX)
    {
        throw new NotSupportedException();
    }

    public unsafe float Sasum(int n, float* x, int incX)
    {
        return cblas_sasum(n, x, incX);
    }

    public unsafe void Saxpy(int n, float alpha, float* x, int incX, float* y, int incY)
    {
        cblas_saxpy(n, alpha, x, incX, y, incY);
    }

    public unsafe float Scnrm2(int n, void* x, int incX)
    {
        return cblas_scnrm2(n, x, incX);
    }

    public unsafe void Scopy(int n, float* x, int incX, float* y, int incY)
    {
        cblas_scopy(n, x, incX, y, incY);
    }

    public unsafe float Sdot(int n, float* x, int incX, float* y, int incY)
    {
        return cblas_sdot(n, x, incX, y, incY);
    }

    public unsafe void Sgbmv(uint order, uint transA, int m, int n, int kl, int ku, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
    {
        cblas_sgbmv(order, transA, m, n, kl, ku, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Sgemm(uint order, uint transA, uint transB, int m, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
    {
        cblas_sgemm(order, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Sgemv(uint order, uint transA, int m, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
    {
        cblas_sgemv(order, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Sger(uint order, int m, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
    {
        cblas_sger(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe float Snrm2(int n, float* x, int incX)
    {
        return cblas_snrm2(n, x, incX);
    }

    public unsafe void Srot(int n, float* x, int incX, float* y, int incY, float c, float s)
    {
        cblas_srot(n, x, incX, y, incY, c, s);
    }

    public unsafe void Srotg(float* a, float* b, float* c, float* s)
    {
        cblas_srotg(a, b, c, s);
    }

    public unsafe void Srotm(int n, float* x, int incX, float* y, int incY, float* p)
    {
        cblas_srotm(n, x, incX, y, incY, p);
    }

    public unsafe void Srotmg(float* d1, float* d2, float* b1, float b2, float* p)
    {
        cblas_srotmg(d1, d2, b1, b2, p);
    }

    public unsafe void Ssbmv(uint order, uint uplo, int n, int k, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
    {
        cblas_ssbmv(order, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Sscal(int n, float a, float* x, int incX)
    {
        cblas_sscal(n, a, x, incX);
    }

    public unsafe void Sspmv(uint order, uint uplo, int n, float alpha, float* a, float* x, int incX, float beta, float* y, int incY)
    {
        cblas_sspmv(order, uplo, n, alpha, a, x, incX, beta, y, incY);
    }

    public unsafe void Sspr(uint order, uint uplo, int n, float alpha, float* x, int incX, float* a)
    {
        cblas_sspr(order, uplo, n, alpha, x, incX, a);
    }

    public unsafe void Sspr2(uint order, uint uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a)
    {
        cblas_sspr2(order, uplo, n, alpha, x, incX, y, incY, a);
    }

    public unsafe void Sswap(int n, float* x, int incX, float* y, int incY)
    {
        cblas_sswap(n, x, incX, y, incY);
    }

    public unsafe void Ssymm(uint order, uint side, uint uplo, int m, int n, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
    {
        cblas_ssymm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Ssymv(uint order, uint uplo, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
    {
        cblas_ssymv(order, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Ssyr(uint order, uint uplo, int n, float alpha, float* x, int incX, float* a, int ldA)
    {
        cblas_ssyr(order, uplo, n, alpha, x, incX, a, ldA);
    }

    public unsafe void Ssyr2(uint order, uint uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
    {
        cblas_ssyr2(order, uplo, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Ssyr2k(uint order, uint uplo, uint trans, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
    {
        cblas_ssyr2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Ssyrk(uint order, uint uplo, uint trans, int n, int k, float alpha, float* a, int ldA, float beta, float* c, int ldC)
    {
        cblas_ssyrk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Stbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, float* a, int ldA, float* x, int incX)
    {
        cblas_stbmv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Stbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, float* a, int ldA, float* x, int incX)
    {
        cblas_stbsv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Stpmv(uint order, uint uplo, uint transA, uint diag, int n, float* a, float* x, int incX)
    {
        cblas_stpmv(order, uplo, transA, diag, n, a, x, incX);
    }

    public unsafe void Stpsv(uint order, uint uplo, uint transA, uint diag, int n, float* ap, float* x, int incX)
    {
        cblas_stpsv(order, uplo, transA, diag, n, ap, x, incX);
    }

    public unsafe void Strmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
    {
        cblas_strmm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Strmv(uint order, uint uplo, uint transA, uint diag, int n, float* a, int ldA, float* x, int incX)
    {
        cblas_strmv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe void Strsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
    {
        cblas_strsm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Strsv(uint order, uint uplo, uint transA, uint diag, int n, float* a, int ldA, float* x, int incX)
    {
        cblas_strsv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe void Zaxpy(int n, void* alpha, void* x, int incX, void* y, int incY)
    {
        cblas_zaxpy(n, alpha, x, incX, y, incY);
    }

    public unsafe void Zcopy(int n, double* x, int incX, double* y, int incY)
    {
        cblas_zcopy(n, x, incX, y, incY);
    }

    public unsafe void ZDotc(int n, void* x, int incX, void* y, int incY, void* dotc)
    {
        cblas_zdotc_sub(n, x, incX, y, incY, dotc);
    }

    public unsafe void Zdotu(int n, void* x, int incX, void* y, int incY, void* dotu)
    {
        cblas_zdotu_sub(n, x, incX, y, incY, dotu);
    }

    public unsafe void Zdrot(int n, void* x, int incX, void* y, int incY, double c, double s)
    {
        cblas_zdrot(n, x, incX, y, incY, c, s);
    }

    public unsafe void Zdscal(int n, double a, void* x, int incX)
    {
        cblas_zdscal(n, a, x, incX);
    }

    public unsafe void Zgbmv(uint order, uint transA, int m, int n, int kl, int ku, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_zgbmv(order, transA, m, n, kl, ku, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Zgemm(uint order, uint transA, uint transB, int m, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_zgemm(order, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Zgemv(uint order, uint transA, int m, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_zgemv(order, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Zgerc(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_zgerc(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Zgeru(uint order, int m, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_zgeru(order, m, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Zhbmv(uint order, uint uplo, int n, int k, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_zhbmv(order, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Zhemm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_zhemm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Zhemv(uint order, uint uplo, int n, void* alpha, void* a, int ldA, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_zhemv(order, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
    }

    public unsafe void Zher(uint order, uint uplo, int n, float alpha, void* x, int incX, void* a, int ldA)
    {
        cblas_zher(order, uplo, n, alpha, x, incX, a, ldA);
    }

    public unsafe void Zher2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a, int ldA)
    {
        cblas_zher2(order, uplo, n, alpha, x, incX, y, incY, a, ldA);
    }

    public unsafe void Zher2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, double beta, void* c, int ldC)
    {
        cblas_zher2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Zherk(uint order, uint uplo, uint trans, int n, int k, double alpha, void* a, int ldA, double beta, void* c, int ldC)
    {
        cblas_zherk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Zhpmv(uint order, uint uplo, int n, void* alpha, void* a, void* x, int incX, void* beta, void* y, int incY)
    {
        cblas_zhpmv(order, uplo, n, alpha, a, x, incX, beta, y, incY);
    }

    public unsafe void Zhpr(uint order, uint uplo, int n, double alpha, void* x, int incX, void* a)
    {
        cblas_zhpr(order, uplo, n, alpha, x, incX, a);
    }

    public unsafe void Zhpr2(uint order, uint uplo, int n, void* alpha, void* x, int incX, void* y, int incY, void* a)
    {
        cblas_zhpr2(order, uplo, n, alpha, x, incX, y, incY, a);
    }

    public unsafe void Zrotg(void* a, void* b, double* c, double* s)
    {
        cblas_zrotg(a, b, c, s);
    }

    public unsafe void Zscal(int n, void* a, void* x, int incX)
    {
        cblas_zscal(n, a, x, incX);
    }

    public unsafe void Zswap(int n, void* x, int incX, void* y, int incY)
    {
        cblas_zswap(n, x, incX, y, incY);
    }

    public unsafe void Zsymm(uint order, uint side, uint uplo, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_zsymm(order, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Zsyr2k(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* b, int ldB, void* beta, void* c, int ldC)
    {
        cblas_zsyr2k(order, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
    }

    public unsafe void Zsyrk(uint order, uint uplo, uint trans, int n, int k, void* alpha, void* a, int ldA, void* beta, void* c, int ldC)
    {
        cblas_zsyrk(order, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
    }

    public unsafe void Ztbmv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX)
    {
        cblas_ztbmv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Ztbsv(uint order, uint uplo, uint transA, uint diag, int n, int k, void* a, int ldA, void* x, int incX)
    {
        cblas_ztbsv(order, uplo, transA, diag, n, k, a, ldA, x, incX);
    }

    public unsafe void Ztpmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, void* x, int incX)
    {
        cblas_ztpmv(order, uplo, transA, diag, n, a, x, incX);
    }

    public unsafe void Ztpsv(uint order, uint uplo, uint transA, uint diag, int n, void* ap, void* x, int incX)
    {
        cblas_ztpsv(order, uplo, transA, diag, n, ap, x, incX);
    }

    public unsafe void Ztrmm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB)
    {
        cblas_ztrmm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Ztrmv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX)
    {
        cblas_ztrmv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }

    public unsafe void Ztrsm(uint order, uint side, uint uplo, uint transA, uint diag, int m, int n, void* alpha, void* a, int ldA, void* b, int ldB)
    {
        cblas_ztrsm(order, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
    }

    public unsafe void Ztrsv(uint order, uint uplo, uint transA, uint diag, int n, void* a, int ldA, void* x, int incX)
    {
        cblas_ztrsv(order, uplo, transA, diag, n, a, ldA, x, incX);
    }
}