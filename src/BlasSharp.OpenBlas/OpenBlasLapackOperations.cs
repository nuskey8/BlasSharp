using static BlasSharp.OpenBlas.NativeMethods;

namespace BlasSharp.OpenBlas;

public sealed class OpenBlasLapackOperations : ILapackOperations
{
    public static readonly OpenBlasLapackOperations Default = new();

    public unsafe void Cbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, float* d, float* e, void* vt, int* ldvt, void* u, int* ldu, void* c, int* ldc, float* work, int* info)
    {
        cbdsqr_(uplo, n, ncvt, nru, ncc, d, e, (_lapack_complex_float*)vt, ldvt, (_lapack_complex_float*)u, ldu, (_lapack_complex_float*)c, ldc, work, info, default);
    }

    public unsafe void Cgbcon(byte* norm, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, float* anorm, float* rcond, void* work, float* rwork, int* info)
    {
        cgbcon_(norm, n, kl, ku, (_lapack_complex_float*)ab, ldab, ipiv, anorm, rcond, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cgbequ(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info)
    {
        cgbequ_(m, n, kl, ku, (_lapack_complex_float*)ab, ldab, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Cgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgbrfs_(trans, n, kl, ku, nrhs, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)afb, ldafb, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, ferr, berr, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cgbsv(int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info)
    {
        cgbsv_(n, kl, ku, nrhs, (_lapack_complex_float*)ab, ldab, ipiv, (_lapack_complex_float*)b, ldb, info);
    }

    public unsafe void Cgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgbsvx_(fact, trans, n, kl, ku, nrhs, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)afb, ldafb, ipiv, equed, r, c, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default, default);
    }

    public unsafe void Cgbtrf(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, int* info)
    {
        cgbtrf_(m, n, kl, ku, (_lapack_complex_float*)ab, ldab, ipiv, info);
    }

    public unsafe void Cgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info)
    {
        cgbtrs_(trans, n, kl, ku, nrhs, (_lapack_complex_float*)ab, ldab, ipiv, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cgebrd(int* m, int* n, void* a, int* lda, float* d, float* e, void* tauq, void* taup, void* work, int* lwork, int* info)
    {
        cgebrd_(m, n, (_lapack_complex_float*)a, lda, d, e, (_lapack_complex_float*)tauq, (_lapack_complex_float*)taup, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cgecon(byte* norm, int* n, void* a, int* lda, float* anorm, float* rcond, void* work, float* rwork, int* info)
    {
        cgecon_(norm, n, (_lapack_complex_float*)a, lda, anorm, rcond, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cgeequ(int* m, int* n, void* a, int* lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info)
    {
        cgeequ_(m, n, (_lapack_complex_float*)a, lda, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Cgees(byte* jobvs, byte* sort, void* select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, float* rwork, int* bwork, int* info)
    {
        cgees_(jobvs, sort, (delegate* unmanaged[Cdecl]<_lapack_complex_float*, int>)select, n, (_lapack_complex_float*)a, lda, sdim, (_lapack_complex_float*)w, (_lapack_complex_float*)vs, ldvs, (_lapack_complex_float*)work, lwork, rwork, bwork, info, default, default);
    }

    public unsafe void Cgeev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* w, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, float* rwork, int* info)
    {
        cgeev_(jobvl, jobvr, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)w, (_lapack_complex_float*)vl, ldvl, (_lapack_complex_float*)vr, ldvr, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Cgehrd(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cgehrd_(n, ilo, ihi, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cgels(byte* trans, int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        cgels_(trans, m, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Cgelsd(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, float* s, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* iwork, int* info)
    {
        cgelsd_(m, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, s, rcond, rank, (_lapack_complex_float*)work, lwork, rwork, iwork, info);
    }

    public unsafe void Cgelss(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, float* s, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* info)
    {
        cgelss_(m, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, s, rcond, rank, (_lapack_complex_float*)work, lwork, rwork, info);
    }

    public unsafe void Cgelsy(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* jpvt, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* info)
    {
        cgelsy_(m, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, jpvt, rcond, rank, (_lapack_complex_float*)work, lwork, rwork, info);
    }

    public unsafe void Cgeqp3(int* m, int* n, void* a, int* lda, int* jpvt, void* tau, void* work, int* lwork, float* rwork, int* info)
    {
        cgeqp3_(m, n, (_lapack_complex_float*)a, lda, jpvt, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, rwork, info);
    }

    public unsafe void Cgeqr2(int* m, int* n, void* a, int* lda, void* tau, void* work, int* info)
    {
        cgeqr2_(m, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, info);
    }

    public unsafe void Cgeqrf(int* m, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cgeqrf_(m, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cgerfs(byte* trans, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgerfs_(trans, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)af, ldaf, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, ferr, berr, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cgesdd(byte* jobz, int* m, int* n, void* a, int* lda, float* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, float* rwork, int* iwork, int* info)
    {
        cgesdd_(jobz, m, n, (_lapack_complex_float*)a, lda, s, (_lapack_complex_float*)u, ldu, (_lapack_complex_float*)vt, ldvt, (_lapack_complex_float*)work, lwork, rwork, iwork, info, default);
    }

    public unsafe int Cgesv(int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info)
    {
        cgesv_(n, nrhs, (_lapack_complex_float*)a, lda, ipiv, (_lapack_complex_float*)b, ldb, info);
        return *info;
    }

    public unsafe void Cgesvd(byte* jobu, byte* jobvt, int* m, int* n, void* a, int* lda, float* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, float* rwork, int* info)
    {
        cgesvd_(jobu, jobvt, m, n, (_lapack_complex_float*)a, lda, s, (_lapack_complex_float*)u, ldu, (_lapack_complex_float*)vt, ldvt, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Cgesvx(byte* fact, byte* trans, int* n, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgesvx_(fact, trans, n, nrhs, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)afb, ldafb, ipiv, equed, r, c, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default, default);
    }

    public unsafe void Cgetf2(int* m, int* n, void* a, int* lda, int* ipiv, int* info)
    {
        cgetf2_(m, n, (_lapack_complex_float*)a, lda, ipiv, info);
    }

    public unsafe void Cgetrf(int* m, int* n, void* a, int* lda, int* ipiv, int* info)
    {
        cgetrf_(m, n, (_lapack_complex_float*)a, lda, ipiv, info);
    }

    public unsafe void Cgetri(int* n, void* a, int* lda, int* ipiv, void* work, int* lwork, int* info)
    {
        cgetri_(n, (_lapack_complex_float*)a, lda, ipiv, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cgetrs(byte* trans, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info)
    {
        cgetrs_(trans, n, nrhs, (_lapack_complex_float*)a, lda, ipiv, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<void*, void*, int> selctg, int* n, void* a, int* lda, void* b, int* ldb, int* sdim, void* alpha, void* beta, void* vsl, int* ldvsl, void* vsr, int* ldvsr, void* work, int* lwork, float* rwork, int* bwork, int* info)
    {
        cgges_(jobvsl, jobvsr, sort, selctg, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, sdim, (_lapack_complex_float*)alpha, (_lapack_complex_float*)beta, (_lapack_complex_float*)vsl, ldvsl, (_lapack_complex_float*)vsr, ldvsr, (_lapack_complex_float*)work, lwork, rwork, bwork, info, default, default, default);
    }

    public unsafe void Cggev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* b, int* ldb, void* alpha, void* beta, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, float* rwork, int* info)
    {
        cggev_(jobvl, jobvr, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)alpha, (_lapack_complex_float*)beta, (_lapack_complex_float*)vl, ldvl, (_lapack_complex_float*)vr, ldvr, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Cggglm(int* n, int* m, int* p, void* a, int* lda, void* b, int* ldb, void* d, void* x, void* y, void* work, int* lwork, int* info)
    {
        cggglm_(n, m, p, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)d, (_lapack_complex_float*)x, (_lapack_complex_float*)y, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cgglse(int* m, int* n, int* p, void* a, int* lda, void* b, int* ldb, void* c, void* d, void* x, void* work, int* lwork, int* info)
    {
        cgglse_(m, n, p, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)c, (_lapack_complex_float*)d, (_lapack_complex_float*)x, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, void* a, int* lda, void* b, int* ldb, float* alpha, float* beta, void* u, int* ldu, void* v, int* ldv, void* q, int* ldq, void* work, float* rwork, int* iwork, int* info)
    {
        cggsvd_(jobu, jobv, jobq, m, n, p, k, l, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, alpha, beta, (_lapack_complex_float*)u, ldu, (_lapack_complex_float*)v, ldv, (_lapack_complex_float*)q, ldq, (_lapack_complex_float*)work, rwork, iwork, info, default, default, default);
    }

    public unsafe void Cgtcon(byte* norm, int* n, void* dl, void* d, void* du, void* du2, int* ipiv, float* anorm, float* rcond, void* work, int* info)
    {
        cgtcon_(norm, n, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)du2, ipiv, anorm, rcond, (_lapack_complex_float*)work, info, default);
    }

    public unsafe void Cgtrfs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgtrfs_(trans, n, nrhs, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)dlf, (_lapack_complex_float*)df, (_lapack_complex_float*)duf, (_lapack_complex_float*)du2, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, ferr, berr, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cgtsv(int* n, int* nrhs, void* dl, void* d, void* du, void* b, int* ldb, int* info)
    {
        cgtsv_(n, nrhs, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)b, ldb, info);
    }

    public unsafe void Cgtsvx(byte* fact, byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cgtsvx_(fact, trans, n, nrhs, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)dlf, (_lapack_complex_float*)df, (_lapack_complex_float*)duf, (_lapack_complex_float*)du2, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default);
    }

    public unsafe void Cgttrf(int* n, void* dl, void* d, void* du, void* du2, int* ipiv, int* info)
    {
        cgttrf_(n, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)du2, ipiv, info);
    }

    public unsafe void Cgttrs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* du2, int* ipiv, void* b, int* ldb, int* info)
    {
        cgttrs_(trans, n, nrhs, (_lapack_complex_float*)dl, (_lapack_complex_float*)d, (_lapack_complex_float*)du, (_lapack_complex_float*)du2, ipiv, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Chbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, void* ab, int* ldab, void* bb, int* ldbb, float* w, void* z, int* ldz, void* work, float* rwork, int* info)
    {
        chbgv_(jobz, uplo, n, ka, kb, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)bb, ldbb, w, (_lapack_complex_float*)z, ldz, (_lapack_complex_float*)work, rwork, info, default, default);
    }

    public unsafe void Cheev(byte* jobz, byte* uplo, int* n, void* a, int* lda, float* w, void* work, int* lwork, float* rwork, int* info)
    {
        cheev_(jobz, uplo, n, (_lapack_complex_float*)a, lda, w, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Cheevd(byte* jobz, byte* uplo, int* n, void* a, int* lda, float* w, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        cheevd_(jobz, uplo, n, (_lapack_complex_float*)a, lda, w, (_lapack_complex_float*)work, lwork, rwork, lrwork, iwork, liwork, info, default, default);
    }

    public unsafe void Chegv(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, float* w, void* work, int* lwork, float* rwork, int* info)
    {
        chegv_(itype, jobz, uplo, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, w, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Chegvd(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, float* w, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        chegvd_(itype, jobz, uplo, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, w, (_lapack_complex_float*)work, lwork, rwork, lrwork, iwork, liwork, info, default, default);
    }

    public unsafe void Chesv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        chesv_(uplo, n, nrhs, (_lapack_complex_float*)a, lda, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Chesvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, int* lwork, float* rwork, int* info)
    {
        chesvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)af, ldaf, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Chetrd(byte* uplo, int* n, void* a, int* lda, float* d, float* e, void* tau, void* work, int* lwork, int* info)
    {
        chetrd_(uplo, n, (_lapack_complex_float*)a, lda, d, e, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Chpgv(int* itype, byte* jobz, byte* uplo, int* n, void* ap, void* bp, float* w, void* z, int* ldz, void* work, float* rwork, int* info)
    {
        chpgv_(itype, jobz, uplo, n, (_lapack_complex_float*)ap, (_lapack_complex_float*)bp, w, (_lapack_complex_float*)z, ldz, (_lapack_complex_float*)work, rwork, info, default, default);
    }

    public unsafe void Chpsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info)
    {
        chpsv_(uplo, n, nrhs, (_lapack_complex_float*)ap, ipiv, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Chpsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        chpsvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)ap, (_lapack_complex_float*)afp, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default);
    }

    public unsafe void Chseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, void* h, int* ldh, void* w, void* z, int* ldz, void* work, int* lwork, int* info)
    {
        chseqr_(job, compz, n, ilo, ihi, (_lapack_complex_float*)h, ldh, (_lapack_complex_float*)w, (_lapack_complex_float*)z, ldz, (_lapack_complex_float*)work, lwork, info, default, default);
    }

    public unsafe void Clacgv(int* n, void* x, int* incx)
    {
        clacgv_(n, (_lapack_complex_float*)x, incx);
    }

    public unsafe void Clacpy(byte* uplo, int* m, int* n, void* a, int* lda, void* b, int* ldb)
    {
        clacpy_(uplo, m, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, default);
    }

    public unsafe void Clacrm(int* m, int* n, void* a, int* lda, float* b, int* ldb, void* c, int* ldc, float* rwork)
    {
        clacrm_(m, n, (_lapack_complex_float*)a, lda, b, ldb, (_lapack_complex_float*)c, ldc, rwork);
    }

    public unsafe void Clacrt(int* n, void* cx, int* incx, void* cy, int* incy, void* c, void* s)
    {
        throw new NotSupportedException();
    }

    public unsafe float Clange(byte* norm, int* m, int* n, void* a, int* lda, float* work)
    {
        return clange_(norm, m, n, (_lapack_complex_float*)a, lda, work, default);
    }

    public unsafe float Clanhe(byte* norm, byte* uplo, int* n, void* a, int* lda, float* work)
    {
        return clanhe_(norm, uplo, n, (_lapack_complex_float*)a, lda, work, default, default);
    }

    public unsafe float Clansy(byte* norm, byte* uplo, int* n, void* a, int* lda, float* work)
    {
        return clansy_(norm, uplo, n, (_lapack_complex_float*)a, lda, work, default, default);
    }

    public unsafe float Clantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, void* a, int* lda, float* work)
    {
        return clantr_(norm, uplo, diag, m, n, (_lapack_complex_float*)a, lda, work, default, default, default);
    }

    public unsafe void Clapmt(int* forwrd, int* m, int* n, void* x, int* ldx, int* k)
    {
        clapmt_(forwrd, m, n, (_lapack_complex_float*)x, ldx, k);
    }

    public unsafe void Clarf(byte* side, int* m, int* n, void* v, int* incv, void* tau, void* c, int* ldc, void* work)
    {
        clarf_(side, m, n, (_lapack_complex_float*)v, incv, (_lapack_complex_float*)tau, (_lapack_complex_float*)c, ldc, (_lapack_complex_float*)work, default);
    }

    public unsafe void Clarfg(int* n, void* alpha, void* x, int* incx, void* tau)
    {
        clarfg_(n, (_lapack_complex_float*)alpha, (_lapack_complex_float*)x, incx, (_lapack_complex_float*)tau);
    }

    public unsafe void Clargv(int* n, void* x, int* incx, void* y, int* incy, float* c, void* s, int* incc)
    {
        throw new NotSupportedException();
    }

    public unsafe void Clarnv(int* idist, int* iseed, int* n, void* x)
    {
        clarnv_(idist, iseed, n, (_lapack_complex_float*)x);
    }

    public unsafe void Clartg(void* f, void* g, float* cs, void* sn, void* r)
    {
        throw new NotSupportedException();
    }

    public unsafe void Clascl(byte* type, int* kl, int* ku, float* cfrom, float* cto, int* m, int* n, void* a, int* lda, int* info)
    {
        clascl_(type, kl, ku, cfrom, cto, m, n, (_lapack_complex_float*)a, lda, info, default);
    }

    public unsafe void Claset(byte* uplo, int* m, int* n, void* alpha, void* beta, void* a, int* lda)
    {
        claset_(uplo, m, n, (_lapack_complex_float*)alpha, (_lapack_complex_float*)beta, (_lapack_complex_float*)a, lda, default);
    }

    public unsafe void Clasr(byte* side, byte* pivot, byte* direct, int* m, int* n, float* c, float* s, void* a, int* lda)
    {
        throw new NotSupportedException();
    }

    public unsafe void Claswp(int* n, void* a, int* lda, int* k1, int* k2, int* ipiv, int* incx)
    {
        claswp_(n, (_lapack_complex_float*)a, lda, k1, k2, ipiv, incx);
    }

    public unsafe void Cpbsv(byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* b, int* ldb, int* info)
    {
        cpbsv_(uplo, n, kd, nrhs, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cpbsvx_(fact, uplo, n, kd, nrhs, (_lapack_complex_float*)ab, ldab, (_lapack_complex_float*)afb, ldafb, equed, s, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default, default);
    }

    public unsafe void Cpocon(byte* uplo, int* n, void* a, int* lda, float* anorm, float* rcond, void* work, float* rwork, int* info)
    {
        cpocon_(uplo, n, (_lapack_complex_float*)a, lda, anorm, rcond, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cpoequ(int* n, void* a, int* lda, float* s, float* scond, float* amax, int* info)
    {
        cpoequ_(n, (_lapack_complex_float*)a, lda, s, scond, amax, info);
    }

    public unsafe void Cporfs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cporfs_(uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)af, ldaf, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, ferr, berr, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Cposv(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info)
    {
        cposv_(uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cposvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cposvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)af, ldaf, equed, s, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default, default);
    }

    public unsafe void Cpotf2(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        cpotf2_(uplo, n, (_lapack_complex_float*)a, lda, info, default);
    }

    public unsafe void Cpotrf(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        cpotrf_(uplo, n, (_lapack_complex_float*)a, lda, info, default);
    }

    public unsafe void Cpotri(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        cpotri_(uplo, n, (_lapack_complex_float*)a, lda, info, default);
    }

    public unsafe void Cpotrs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info)
    {
        cpotrs_(uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cppsv(byte* uplo, int* n, int* nrhs, void* ap, void* b, int* ldb, int* info)
    {
        cppsv_(uplo, n, nrhs, (_lapack_complex_float*)ap, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cppsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cppsvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)ap, (_lapack_complex_float*)afp, equed, s, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default, default);
    }

    public unsafe void Cptsv(int* n, int* nrhs, float* d, void* e, void* b, int* ldb, int* info)
    {
        cptsv_(n, nrhs, d, (_lapack_complex_float*)e, (_lapack_complex_float*)b, ldb, info);
    }

    public unsafe void Cptsvx(byte* fact, int* n, int* nrhs, float* d, void* e, float* df, void* ef, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cptsvx_(fact, n, nrhs, d, (_lapack_complex_float*)e, df, (_lapack_complex_float*)ef, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default);
    }

    public unsafe void Crot(int* n, void* cx, int* incx, void* cy, int* incy, float* c, void* s)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cspmv(byte* uplo, int* n, void* alpha, void* ap, void* x, int* incx, void* beta, void* y, int* incy)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cspr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* ap)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cspsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info)
    {
        cspsv_(uplo, n, nrhs, (_lapack_complex_float*)ap, ipiv, (_lapack_complex_float*)b, ldb, info, default);
    }

    public unsafe void Cspsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info)
    {
        cspsvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)ap, (_lapack_complex_float*)afp, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, rwork, info, default, default);
    }

    public unsafe void Csrot(int* n, void* cx, int* incx, void* cy, int* incy, float* c, float* s)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cstedc(byte* compz, int* n, float* d, float* e, void* z, int* ldz, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        cstedc_(compz, n, d, e, (_lapack_complex_float*)z, ldz, (_lapack_complex_float*)work, lwork, rwork, lrwork, iwork, liwork, info, default);
    }

    public unsafe void Csteqr(byte* compz, int* n, float* d, float* e, void* z, int* ldz, float* work, int* info)
    {
        csteqr_(compz, n, d, e, (_lapack_complex_float*)z, ldz, work, info, default);
    }

    public unsafe void Csymv(byte* uplo, int* n, void* alpha, void* a, int* lda, void* x, int* incx, void* beta, void* y, int* incy)
    {
        throw new NotSupportedException();
    }

    public unsafe void Csyr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* a, int* lda)
    {
        csyr_(uplo, n, (_lapack_complex_float*)alpha, (_lapack_complex_float*)x, incx, (_lapack_complex_float*)a, lda, default);
    }

    public unsafe void Csysv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        csysv_(uplo, n, nrhs, (_lapack_complex_float*)a, lda, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Csysvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, int* lwork, float* rwork, int* info)
    {
        csysvx_(fact, uplo, n, nrhs, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)af, ldaf, ipiv, (_lapack_complex_float*)b, ldb, (_lapack_complex_float*)x, ldx, rcond, ferr, berr, (_lapack_complex_float*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Ctrti2(byte* uplo, byte* diag, int* n, void* a, int* lda, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cung2r(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cungbr(byte* vect, int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cungbr_(vect, m, n, k, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Cunghr(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cunghr_(n, ilo, ihi, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cungqr(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cungqr_(m, n, k, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info);
    }

    public unsafe void Cungtr(byte* uplo, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        cungtr_(uplo, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)work, lwork, info, default);
    }

    public unsafe void Cunm2r(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Cunmqr(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info)
    {
        cunmqr_(side, trans, m, n, k, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)c, ldc, (_lapack_complex_float*)work, lwork, info, default, default);
    }

    public unsafe void Cunmtr(byte* side, byte* uplo, byte* trans, int* m, int* n, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info)
    {
        cunmtr_(side, uplo, trans, m, n, (_lapack_complex_float*)a, lda, (_lapack_complex_float*)tau, (_lapack_complex_float*)c, ldc, (_lapack_complex_float*)work, lwork, info, default, default, default);
    }

    public unsafe void Dbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, double* d, double* e, double* vt, int* ldvt, double* u, int* ldu, double* c, int* ldc, double* work, int* info)
    {
        dbdsqr_(uplo, n, ncvt, nru, ncc, d, e, vt, ldvt, u, ldu, c, ldc, work, info, default);
    }

    public unsafe void Dgbcon(byte* norm, int* n, int* kl, int* ku, double* ab, int* ldab, int* ipiv, double* anorm, double* rcond, double* work, int* iwork, int* info)
    {
        dgbcon_(norm, n, kl, ku, ab, ldab, ipiv, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Dgbequ(int* m, int* n, int* kl, int* ku, double* ab, int* ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info)
    {
        dgbequ_(m, n, kl, ku, ab, ldab, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Dgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgbrfs_(trans, n, kl, ku, nrhs, ab, ldab, afb, ldafb, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Dgbsv(int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, int* ipiv, double* b, int* ldb, int* info)
    {
        dgbsv_(n, kl, ku, nrhs, ab, ldab, ipiv, b, ldb, info);
    }

    public unsafe void Dgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgbsvx_(fact, trans, n, kl, ku, nrhs, ab, ldab, afb, ldafb, ipiv, equed, r, c, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Dgbtrf(int* m, int* n, int* kl, int* ku, double* ab, int* ldab, int* ipiv, int* info)
    {
        dgbtrf_(m, n, kl, ku, ab, ldab, ipiv, info);
    }

    public unsafe void Dgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, int* ipiv, double* b, int* ldb, int* info)
    {
        dgbtrs_(trans, n, kl, ku, nrhs, ab, ldab, ipiv, b, ldb, info, default);
    }

    public unsafe void Dgebrd(int* m, int* n, double* a, int* lda, double* d, double* e, double* tauq, double* taup, double* work, int* lwork, int* info)
    {
        dgebrd_(m, n, a, lda, d, e, tauq, taup, work, lwork, info);
    }

    public unsafe void Dgecon(byte* norm, int* n, double* a, int* lda, double* anorm, double* rcond, double* work, int* iwork, int* info)
    {
        dgecon_(norm, n, a, lda, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Dgeequ(int* m, int* n, double* a, int* lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info)
    {
        dgeequ_(m, n, a, lda, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Dgees(byte* jobvs, byte* sort, void* select, int* n, double* a, int* lda, int* sdim, double* wr, double* wi, double* vs, int* ldvs, double* work, int* lwork, int* bwork, int* info)
    {
        dgees_(jobvs, sort, (delegate* unmanaged[Cdecl]<double*, double*, int>)select, n, a, lda, sdim, wr, wi, vs, ldvs, work, lwork, bwork, info, default, default);
    }

    public unsafe void Dgeev(byte* jobvl, byte* jobvr, int* n, double* a, int* lda, double* wr, double* wi, double* vl, int* ldvl, double* vr, int* ldvr, double* work, int* lwork, int* info)
    {
        dgeev_(jobvl, jobvr, n, a, lda, wr, wi, vl, ldvl, vr, ldvr, work, lwork, info, default, default);
    }

    public unsafe void Dgehrd(int* n, int* ilo, int* ihi, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dgehrd_(n, ilo, ihi, a, lda, tau, work, lwork, info);
    }

    public unsafe void Dgels(byte* trans, int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* work, int* lwork, int* info)
    {
        dgels_(trans, m, n, nrhs, a, lda, b, ldb, work, lwork, info, default);
    }

    public unsafe void Dgelsd(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* s, double* rcond, int* rank, double* work, int* lwork, int* iwork, int* info)
    {
        dgelsd_(m, n, nrhs, a, lda, b, ldb, s, rcond, rank, work, lwork, iwork, info);
    }

    public unsafe void Dgelss(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* s, double* rcond, int* rank, double* work, int* lwork, int* info)
    {
        dgelss_(m, n, nrhs, a, lda, b, ldb, s, rcond, rank, work, lwork, info);
    }

    public unsafe void Dgelsy(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* jpvt, double* rcond, int* rank, double* work, int* lwork, int* info)
    {
        dgelsy_(m, n, nrhs, a, lda, b, ldb, jpvt, rcond, rank, work, lwork, info);
    }

    public unsafe void Dgeqp3(int* m, int* n, double* a, int* lda, int* jpvt, double* tau, double* work, int* lwork, int* info)
    {
        dgeqp3_(m, n, a, lda, jpvt, tau, work, lwork, info);
    }

    public unsafe void Dgeqr2(int* m, int* n, double* a, int* lda, double* tau, double* work, int* info)
    {
        dgeqr2_(m, n, a, lda, tau, work, info);
    }

    public unsafe void Dgeqrf(int* m, int* n, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dgeqrf_(m, n, a, lda, tau, work, lwork, info);
    }

    public unsafe void Dgerfs(byte* trans, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgerfs_(trans, n, nrhs, a, lda, af, ldaf, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Dgesdd(byte* jobz, int* m, int* n, double* a, int* lda, double* s, double* u, int* ldu, double* vt, int* ldvt, double* work, int* lwork, int* iwork, int* info)
    {
        dgesdd_(jobz, m, n, a, lda, s, u, ldu, vt, ldvt, work, lwork, iwork, info, default);
    }

    public unsafe int Dgesv(int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info)
    {
        return dgesv_(n, nrhs, a, lda, ipiv, b, ldb, info);
    }

    public unsafe void Dgesvd(byte* jobu, byte* jobvt, int* m, int* n, double* a, int* lda, double* s, double* u, int* ldu, double* vt, int* ldvt, double* work, int* lwork, int* info)
    {
        dgesvd_(jobu, jobvt, m, n, a, lda, s, u, ldu, vt, ldvt, work, lwork, info, default, default);
    }

    public unsafe void Dgesvx(byte* fact, byte* trans, int* n, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgesvx_(fact, trans, n, nrhs, ab, ldab, afb, ldafb, ipiv, equed, r, c, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Dgetf2(int* m, int* n, double* a, int* lda, int* ipiv, int* info)
    {
        dgetf2_(m, n, a, lda, ipiv, info);
    }

    public unsafe void Dgetrf(int* m, int* n, double* a, int* lda, int* ipiv, int* info)
    {
        dgetrf_(m, n, a, lda, ipiv, info);
    }

    public unsafe void Dgetri(int* n, double* a, int* lda, int* ipiv, double* work, int* lwork, int* info)
    {
        dgetri_(n, a, lda, ipiv, work, lwork, info);
    }

    public unsafe void Dgetrs(byte* trans, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info)
    {
        dgetrs_(trans, n, nrhs, a, lda, ipiv, b, ldb, info, default);
    }

    public unsafe void Dgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<double*, double*, double*, int> selctg, int* n, double* a, int* lda, double* b, int* ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int* ldvsl, double* vsr, int* ldvsr, double* work, int* lwork, int* bwork, int* info)
    {
        dgges_(jobvsl, jobvsr, sort, selctg, n, a, lda, b, ldb, sdim, alphar, alphai, beta, vsl, ldvsl, vsr, ldvsr, work, lwork, bwork, info, default, default, default);
    }

    public unsafe void Dggev(byte* jobvl, byte* jobvr, int* n, double* a, int* lda, double* b, int* ldb, double* alphar, double* alphai, double* beta, double* vl, int* ldvl, double* vr, int* ldvr, double* work, int* lwork, int* info)
    {
        dggev_(jobvl, jobvr, n, a, lda, b, ldb, alphar, alphai, beta, vl, ldvl, vr, ldvr, work, lwork, info, default, default);
    }

    public unsafe void Dggglm(int* n, int* m, int* p, double* a, int* lda, double* b, int* ldb, double* d, double* x, double* y, double* work, int* lwork, int* info)
    {
        dggglm_(n, m, p, a, lda, b, ldb, d, x, y, work, lwork, info);
    }

    public unsafe void Dgglse(int* m, int* n, int* p, double* a, int* lda, double* b, int* ldb, double* c, double* d, double* x, double* work, int* lwork, int* info)
    {
        dgglse_(m, n, p, a, lda, b, ldb, c, d, x, work, lwork, info);
    }

    public unsafe void Dggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, double* a, int* lda, double* b, int* ldb, double* alpha, double* beta, double* u, int* ldu, double* v, int* ldv, double* q, int* ldq, double* work, int* iwork, int* info)
    {
        dggsvd_(jobu, jobv, jobq, m, n, p, k, l, a, lda, b, ldb, alpha, beta, u, ldu, v, ldv, q, ldq, work, iwork, info, default, default, default);
    }

    public unsafe void Dgtcon(byte* norm, int* n, double* dl, double* d, double* du, double* du2, int* ipiv, double* anorm, double* rcond, double* work, int* iwork, int* info)
    {
        dgtcon_(norm, n, dl, d, du, du2, ipiv, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Dgtrfs(byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgtrfs_(trans, n, nrhs, dl, d, du, dlf, df, duf, du2, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Dgtsv(int* n, int* nrhs, double* dl, double* d, double* du, double* b, int* ldb, int* info)
    {
        dgtsv_(n, nrhs, dl, d, du, b, ldb, info);
    }

    public unsafe void Dgtsvx(byte* fact, byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dgtsvx_(fact, trans, n, nrhs, dl, d, du, dlf, df, duf, du2, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default);
    }

    public unsafe void Dgttrf(int* n, double* dl, double* d, double* du, double* du2, int* ipiv, int* info)
    {
        dgttrf_(n, dl, d, du, du2, ipiv, info);
    }

    public unsafe void Dgttrs(byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int* ldb, int* info)
    {
        dgttrs_(trans, n, nrhs, dl, d, du, du2, ipiv, b, ldb, info, default);
    }

    public unsafe void Dhseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, double* h, int* ldh, double* wr, double* wi, double* z, int* ldz, double* work, int* lwork, int* info)
    {
        dhseqr_(job, compz, n, ilo, ihi, h, ldh, wr, wi, z, ldz, work, lwork, info, default, default);
    }

    public unsafe void Dlacpy(byte* uplo, int* m, int* n, double* a, int* lda, double* b, int* ldb)
    {
        dlacpy_(uplo, m, n, a, lda, b, ldb, default);
    }

    public unsafe double Dlamch(byte* cmach)
    {
        return dlamch_(cmach, default);
    }

    public unsafe double Dlange(byte* norm, int* m, int* n, double* a, int* lda, double* work)
    {
        return dlange_(norm, m, n, a, lda, work, default);
    }

    public unsafe double Dlansy(byte* norm, byte* uplo, int* n, double* a, int* lda, double* work)
    {
        return dlansy_(norm, uplo, n, a, lda, work, default, default);
    }

    public unsafe double Dlantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, double* a, int* lda, double* work)
    {
        return dlantr_(norm, uplo, diag, m, n, a, lda, work, default, default, default);
    }

    public unsafe void Dlapmt(int* forwrd, int* m, int* n, double* x, int* ldx, int* k)
    {
        dlapmt_(forwrd, m, n, x, ldx, k);
    }

    public unsafe double Dlapy2(double* x, double* y)
    {
        return dlapy2_(x, y);
    }

    public unsafe double Dlapy3(double* x, double* y, double* z)
    {
        return dlapy3_(x, y, z);
    }

    public unsafe void Dlarf(byte* side, int* m, int* n, double* v, int* incv, double* tau, double* c, int* ldc, double* work)
    {
        dlarf_(side, m, n, v, incv, tau, c, ldc, work, default);
    }

    public unsafe void Dlarfg(int* n, double* alpha, double* x, int* incx, double* tau)
    {
        dlarfg_(n, alpha, x, incx, tau);
    }

    public unsafe void Dlargv(int* n, double* x, int* incx, double* y, int* incy, double* c, int* incc)
    {
        throw new NotSupportedException();
    }

    public unsafe void Dlarnv(int* idist, int* iseed, int* n, double* x)
    {
        dlarnv_(idist, iseed, n, x);
    }

    public unsafe void Dlartg(double* f, double* g, double* cs, double* sn, double* r)
    {
        throw new NotSupportedException();
    }

    public unsafe void Dlascl(byte* type, int* kl, int* ku, double* cfrom, double* cto, int* m, int* n, double* a, int* lda, int* info)
    {
        dlascl_(type, kl, ku, cfrom, cto, m, n, a, lda, info, default);
    }

    public unsafe void Dlaset(byte* uplo, int* m, int* n, double* alpha, double* beta, double* a, int* lda)
    {
        dlaset_(uplo, m, n, alpha, beta, a, lda, default);
    }

    public unsafe void Dlasr(byte* side, byte* pivot, byte* direct, int* m, int* n, double* c, double* s, double* a, int* lda)
    {
        throw new NotSupportedException();
    }

    public unsafe void Dlaswp(int* n, double* a, int* lda, int* k1, int* k2, int* ipiv, int* incx)
    {
        dlaswp_(n, a, lda, k1, k2, ipiv, incx);
    }

    public unsafe void Dorg2r(int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Dorgbr(byte* vect, int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dorgbr_(vect, m, n, k, a, lda, tau, work, lwork, info, default);
    }

    public unsafe void Dorghr(int* n, int* ilo, int* ihi, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dorghr_(n, ilo, ihi, a, lda, tau, work, lwork, info);
    }

    public unsafe void Dorgqr(int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dorgqr_(m, n, k, a, lda, tau, work, lwork, info);
    }

    public unsafe void Dorgtr(byte* uplo, int* n, double* a, int* lda, double* tau, double* work, int* lwork, int* info)
    {
        dorgtr_(uplo, n, a, lda, tau, work, lwork, info, default);
    }

    public unsafe void Dorm2r(byte* side, byte* trans, int* m, int* n, int* k, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Dormqr(byte* side, byte* trans, int* m, int* n, int* k, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* lwork, int* info)
    {
        dormqr_(side, trans, m, n, k, a, lda, tau, c, ldc, work, lwork, info, default, default);
    }

    public unsafe void Dormtr(byte* side, byte* uplo, byte* trans, int* m, int* n, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* lwork, int* info)
    {
        dormtr_(side, uplo, trans, m, n, a, lda, tau, c, ldc, work, lwork, info, default, default, default);
    }

    public unsafe void Dpbsv(byte* uplo, int* n, int* kd, int* nrhs, double* ab, int* ldab, double* b, int* ldb, int* info)
    {
        dpbsv_(uplo, n, kd, nrhs, ab, ldab, b, ldb, info, default);
    }

    public unsafe void Dpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dpbsvx_(fact, uplo, n, kd, nrhs, ab, ldab, afb, ldafb, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Dpocon(byte* uplo, int* n, double* a, int* lda, double* anorm, double* rcond, double* work, int* iwork, int* info)
    {
        dpocon_(uplo, n, a, lda, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Dpoequ(int* n, double* a, int* lda, double* s, double* scond, double* amax, int* info)
    {
        dpoequ_(n, a, lda, s, scond, amax, info);
    }

    public unsafe void Dporfs(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dporfs_(uplo, n, nrhs, a, lda, af, ldaf, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Dposv(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info)
    {
        dposv_(uplo, n, nrhs, a, lda, b, ldb, info, default);
    }

    public unsafe void Dposvx(byte* fact, byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dposvx_(fact, uplo, n, nrhs, a, lda, af, ldaf, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Dpotf2(byte* uplo, int* n, double* a, int* lda, int* info)
    {
        dpotf2_(uplo, n, a, lda, info, default);
    }

    public unsafe void Dpotrf(byte* uplo, int* n, double* a, int* lda, int* info)
    {
        dpotrf_(uplo, n, a, lda, info, default);
    }

    public unsafe void Dpotri(byte* uplo, int* n, double* a, int* lda, int* info)
    {
        dpotri_(uplo, n, a, lda, info, default);
    }

    public unsafe void Dpotrs(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info)
    {
        dpotrs_(uplo, n, nrhs, a, lda, b, ldb, info, default);
    }

    public unsafe void Dppsv(byte* uplo, int* n, int* nrhs, double* ap, double* b, int* ldb, int* info)
    {
        dppsv_(uplo, n, nrhs, ap, b, ldb, info, default);
    }

    public unsafe void Dppsvx(byte* fact, byte* uplo, int* n, int* nrhs, double* ap, double* afp, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dppsvx_(fact, uplo, n, nrhs, ap, afp, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Dptsv(int* n, int* nrhs, double* d, double* e, double* b, int* ldb, int* info)
    {
        dptsv_(n, nrhs, d, e, b, ldb, info);
    }

    public unsafe void Dptsvx(byte* fact, int* n, int* nrhs, double* d, double* e, double* df, double* ef, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* info)
    {
        dptsvx_(fact, n, nrhs, d, e, df, ef, b, ldb, x, ldx, rcond, ferr, berr, work, info, default);
    }

    public unsafe void Dsbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, double* ab, int* ldab, double* bb, int* ldbb, double* w, double* z, int* ldz, double* work, int* info)
    {
        dsbgv_(jobz, uplo, n, ka, kb, ab, ldab, bb, ldbb, w, z, ldz, work, info, default, default);
    }

    public unsafe void Dspgv(int* itype, byte* jobz, byte* uplo, int* n, double* ap, double* bp, double* w, double* z, int* ldz, double* work, int* info)
    {
        dspgv_(itype, jobz, uplo, n, ap, bp, w, z, ldz, work, info, default, default);
    }

    public unsafe void Dspsv(byte* uplo, int* n, int* nrhs, double* ap, int* ipiv, double* b, int* ldb, int* info)
    {
        dspsv_(uplo, n, nrhs, ap, ipiv, b, ldb, info, default);
    }

    public unsafe void Dspsvx(byte* fact, byte* uplo, int* n, int* nrhs, double* ap, double* afp, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info)
    {
        dspsvx_(fact, uplo, n, nrhs, ap, afp, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default);
    }

    public unsafe void Dstedc(byte* compz, int* n, double* d, double* e, double* z, int* ldz, double* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        dstedc_(compz, n, d, e, z, ldz, work, lwork, iwork, liwork, info, default);
    }

    public unsafe void Dsteqr(byte* compz, int* n, double* d, double* e, double* z, int* ldz, double* work, int* info)
    {
        dsteqr_(compz, n, d, e, z, ldz, work, info, default);
    }

    public unsafe void Dsterf(int* n, double* d, double* e, int* info)
    {
        dsterf_(n, d, e, info);
    }

    public unsafe void Dsyev(byte* jobz, byte* uplo, int* n, double* a, int* lda, double* w, double* work, int* lwork, int* info)
    {
        dsyev_(jobz, uplo, n, a, lda, w, work, lwork, info, default, default);
    }

    public unsafe void Dsyevd(byte* jobz, byte* uplo, int* n, double* a, int* lda, double* w, double* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        dsyevd_(jobz, uplo, n, a, lda, w, work, lwork, iwork, liwork, info, default, default);
    }

    public unsafe void Dsygv(int* itype, byte* jobz, byte* uplo, int* n, double* a, int* lda, double* b, int* ldb, double* w, double* work, int* lwork, int* info)
    {
        dsygv_(itype, jobz, uplo, n, a, lda, b, ldb, w, work, lwork, info, default, default);
    }

    public unsafe void Dsygvd(int* itype, byte* jobz, byte* uplo, int* n, double* a, int* lda, double* b, int* ldb, double* w, double* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        dsygvd_(itype, jobz, uplo, n, a, lda, b, ldb, w, work, lwork, iwork, liwork, info, default, default);
    }

    public unsafe void Dsysv(byte* uplo, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, double* work, int* lwork, int* info)
    {
        dsysv_(uplo, n, nrhs, a, lda, ipiv, b, ldb, work, lwork, info, default);
    }

    public unsafe void Dsysvx(byte* fact, byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* lwork, int* iwork, int* info)
    {
        dsysvx_(fact, uplo, n, nrhs, a, lda, af, ldaf, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, lwork, iwork, info, default, default);
    }

    public unsafe void Dsytrd(byte* uplo, int* n, double* a, int* lda, double* d, double* e, double* tau, double* work, int* lwork, int* info)
    {
        dsytrd_(uplo, n, a, lda, d, e, tau, work, lwork, info, default);
    }

    public unsafe void Dtrti2(byte* uplo, byte* diag, int* n, double* a, int* lda, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe double Dzsum1(int* n, void* cx, int* incx)
    {
        return cblas_dzsum(*n, cx, *incx);
    }

    public unsafe int Icmax1(int* n, void* cx, int* incx)
    {
        return (int)cblas_icmax(*n, cx, *incx);
    }

    public unsafe int Ilaenv(int* ispec, byte* name, byte* opts, int* n1, int* n2, int* n3, int* n4)
    {
        throw new NotSupportedException();
    }

    public unsafe int Izmax1(int* n, void* cx, int* incx)
    {
        return (int)cblas_izmax(*n, cx, *incx);
    }

    public unsafe int Lsame(byte* ca, byte* cb)
    {
        return lsame_(ca, cb, 1, 1, default, default);
    }

    public unsafe int Lsamen(int* n, byte* ca, byte* cb)
    {
        throw new NotSupportedException();
    }

    public unsafe void Sbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, float* d, float* e, float* vt, int* ldvt, float* u, int* ldu, float* c, int* ldc, float* work, int* info)
    {
        sbdsqr_(uplo, n, ncvt, nru, ncc, d, e, vt, ldvt, u, ldu, c, ldc, work, info, default);
    }

    public unsafe float Scsum1(int* n, void* cx, int* incx)
    {
        return cblas_scsum(*n, cx, *incx);
    }

    public unsafe void Sgbcon(byte* norm, int* n, int* kl, int* ku, float* ab, int* ldab, int* ipiv, float* anorm, float* rcond, float* work, int* iwork, int* info)
    {
        sgbcon_(norm, n, kl, ku, ab, ldab, ipiv, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Sgbequ(int* m, int* n, int* kl, int* ku, float* ab, int* ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info)
    {
        sgbequ_(m, n, kl, ku, ab, ldab, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Sgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgbrfs_(trans, n, kl, ku, nrhs, ab, ldab, afb, ldafb, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Sgbsv(int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, int* ipiv, float* b, int* ldb, int* info)
    {
        sgbsv_(n, kl, ku, nrhs, ab, ldab, ipiv, b, ldb, info);
    }

    public unsafe void Sgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgbsvx_(fact, trans, n, kl, ku, nrhs, ab, ldab, afb, ldafb, ipiv, equed, r, c, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Sgbtrf(int* m, int* n, int* kl, int* ku, float* ab, int* ldab, int* ipiv, int* info)
    {
        sgbtrf_(m, n, kl, ku, ab, ldab, ipiv, info);
    }

    public unsafe void Sgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, int* ipiv, float* b, int* ldb, int* info)
    {
        sgbtrs_(trans, n, kl, ku, nrhs, ab, ldab, ipiv, b, ldb, info, default);
    }

    public unsafe void Sgebrd(int* m, int* n, float* a, int* lda, float* d, float* e, float* tauq, float* taup, float* work, int* lwork, int* info)
    {
        sgebrd_(m, n, a, lda, d, e, tauq, taup, work, lwork, info);
    }

    public unsafe void Sgecon(byte* norm, int* n, float* a, int* lda, float* anorm, float* rcond, float* work, int* iwork, int* info)
    {
        sgecon_(norm, n, a, lda, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Sgeequ(int* m, int* n, float* a, int* lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info)
    {
        sgeequ_(m, n, a, lda, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Sgees(byte* jobvs, byte* sort, void* select, int* n, float* a, int* lda, int* sdim, float* wr, float* wi, float* vs, int* ldvs, float* work, int* lwork, int* bwork, int* info)
    {
        sgees_(jobvs, sort, (delegate* unmanaged[Cdecl]<float*, float*, int>)select, n, a, lda, sdim, wr, wi, vs, ldvs, work, lwork, bwork, info, default, default);
    }

    public unsafe void Sgeev(byte* jobvl, byte* jobvr, int* n, float* a, int* lda, float* wr, float* wi, float* vl, int* ldvl, float* vr, int* ldvr, float* work, int* lwork, int* info)
    {
        sgeev_(jobvl, jobvr, n, a, lda, wr, wi, vl, ldvl, vr, ldvr, work, lwork, info, default, default);
    }

    public unsafe void Sgehrd(int* n, int* ilo, int* ihi, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sgehrd_(n, ilo, ihi, a, lda, tau, work, lwork, info);
    }

    public unsafe void Sgels(byte* trans, int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* work, int* lwork, int* info)
    {
        sgels_(trans, m, n, nrhs, a, lda, b, ldb, work, lwork, info, default);
    }

    public unsafe void Sgelsd(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* s, float* rcond, int* rank, float* work, int* lwork, int* iwork, int* info)
    {
        sgelsd_(m, n, nrhs, a, lda, b, ldb, s, rcond, rank, work, lwork, iwork, info);
    }

    public unsafe void Sgelss(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* s, float* rcond, int* rank, float* work, int* lwork, int* info)
    {
        sgelss_(m, n, nrhs, a, lda, b, ldb, s, rcond, rank, work, lwork, info);
    }

    public unsafe void Sgelsy(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* jpvt, float* rcond, int* rank, float* work, int* lwork, int* info)
    {
        sgelsy_(m, n, nrhs, a, lda, b, ldb, jpvt, rcond, rank, work, lwork, info);
    }

    public unsafe void Sgeqp3(int* m, int* n, float* a, int* lda, int* jpvt, float* tau, float* work, int* lwork, int* info)
    {
        sgeqp3_(m, n, a, lda, jpvt, tau, work, lwork, info);
    }

    public unsafe void Sgeqr2(int* m, int* n, float* a, int* lda, float* tau, float* work, int* info)
    {
        sgeqr2_(m, n, a, lda, tau, work, info);
    }

    public unsafe void Sgeqrf(int* m, int* n, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sgeqrf_(m, n, a, lda, tau, work, lwork, info);
    }

    public unsafe void Sgerfs(byte* trans, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgerfs_(trans, n, nrhs, a, lda, af, ldaf, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Sgesdd(byte* jobz, int* m, int* n, float* a, int* lda, float* s, float* u, int* ldu, float* vt, int* ldvt, float* work, int* lwork, int* iwork, int* info)
    {
        sgesdd_(jobz, m, n, a, lda, s, u, ldu, vt, ldvt, work, lwork, iwork, info, default);
    }

    public unsafe int Sgesv(int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info)
    {
        return sgesv_(n, nrhs, a, lda, ipiv, b, ldb, info);
    }

    public unsafe void Sgesvd(byte* jobu, byte* jobvt, int* m, int* n, float* a, int* lda, float* s, float* u, int* ldu, float* vt, int* ldvt, float* work, int* lwork, int* info)
    {
        sgesvd_(jobu, jobvt, m, n, a, lda, s, u, ldu, vt, ldvt, work, lwork, info, default, default);
    }

    public unsafe void Sgesvx(byte* fact, byte* trans, int* n, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgesvx_(fact, trans, n, nrhs, ab, ldab, afb, ldafb, ipiv, equed, r, c, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Sgetf2(int* m, int* n, float* a, int* lda, int* ipiv, int* info)
    {
        sgetf2_(m, n, a, lda, ipiv, info);
    }

    public unsafe void Sgetrf(int* m, int* n, float* a, int* lda, int* ipiv, int* info)
    {
        sgetrf_(m, n, a, lda, ipiv, info);
    }

    public unsafe void Sgetri(int* n, float* a, int* lda, int* ipiv, float* work, int* lwork, int* info)
    {
        sgetri_(n, a, lda, ipiv, work, lwork, info);
    }

    public unsafe void Sgetrs(byte* trans, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info)
    {
        sgetrs_(trans, n, nrhs, a, lda, ipiv, b, ldb, info, default);
    }

    public unsafe void Sgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<float*, float*, float*, int> selctg, int* n, float* a, int* lda, float* b, int* ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int* ldvsl, float* vsr, int* ldvsr, float* work, int* lwork, int* bwork, int* info)
    {
        sgges_(jobvsl, jobvsr, sort, selctg, n, a, lda, b, ldb, sdim, alphar, alphai, beta, vsl, ldvsl, vsr, ldvsr, work, lwork, bwork, info, default, default, default);
    }

    public unsafe void Sggev(byte* jobvl, byte* jobvr, int* n, float* a, int* lda, float* b, int* ldb, float* alphar, float* alphai, float* beta, float* vl, int* ldvl, float* vr, int* ldvr, float* work, int* lwork, int* info)
    {
        sggev_(jobvl, jobvr, n, a, lda, b, ldb, alphar, alphai, beta, vl, ldvl, vr, ldvr, work, lwork, info, default, default);
    }

    public unsafe void Sggglm(int* n, int* m, int* p, float* a, int* lda, float* b, int* ldb, float* d, float* x, float* y, float* work, int* lwork, int* info)
    {
        sggglm_(n, m, p, a, lda, b, ldb, d, x, y, work, lwork, info);
    }

    public unsafe void Sgglse(int* m, int* n, int* p, float* a, int* lda, float* b, int* ldb, float* c, float* d, float* x, float* work, int* lwork, int* info)
    {
        sgglse_(m, n, p, a, lda, b, ldb, c, d, x, work, lwork, info);
    }

    public unsafe void Sggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, float* a, int* lda, float* b, int* ldb, float* alpha, float* beta, float* u, int* ldu, float* v, int* ldv, float* q, int* ldq, float* work, int* iwork, int* info)
    {
        sggsvd_(jobu, jobv, jobq, m, n, p, k, l, a, lda, b, ldb, alpha, beta, u, ldu, v, ldv, q, ldq, work, iwork, info, default, default, default);
    }

    public unsafe void Sgtcon(byte* norm, int* n, float* dl, float* d, float* du, float* du2, int* ipiv, float* anorm, float* rcond, float* work, int* iwork, int* info)
    {
        sgtcon_(norm, n, dl, d, du, du2, ipiv, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Sgtrfs(byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgtrfs_(trans, n, nrhs, dl, d, du, dlf, df, duf, du2, ipiv, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Sgtsv(int* n, int* nrhs, float* dl, float* d, float* du, float* b, int* ldb, int* info)
    {
        sgtsv_(n, nrhs, dl, d, du, b, ldb, info);
    }

    public unsafe void Sgtsvx(byte* fact, byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sgtsvx_(fact, trans, n, nrhs, dl, d, du, dlf, df, duf, du2, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default);
    }

    public unsafe void Sgttrf(int* n, float* dl, float* d, float* du, float* du2, int* ipiv, int* info)
    {
        sgttrf_(n, dl, d, du, du2, ipiv, info);
    }

    public unsafe void Sgttrs(byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int* ldb, int* info)
    {
        sgttrs_(trans, n, nrhs, dl, d, du, du2, ipiv, b, ldb, info, default);
    }

    public unsafe void Shseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, float* h, int* ldh, float* wr, float* wi, float* z, int* ldz, float* work, int* lwork, int* info)
    {
        shseqr_(job, compz, n, ilo, ihi, h, ldh, wr, wi, z, ldz, work, lwork, info, default, default);
    }

    public unsafe void Slacpy(byte* uplo, int* m, int* n, float* a, int* lda, float* b, int* ldb)
    {
        slacpy_(uplo, m, n, a, lda, b, ldb, default);
    }

    public unsafe float Slamch(byte* cmach)
    {
        return slamch_(cmach, default);
    }

    public unsafe float Slange(byte* norm, int* m, int* n, float* a, int* lda, float* work)
    {
        return slange_(norm, m, n, a, lda, work, default);
    }

    public unsafe float Slansy(byte* norm, byte* uplo, int* n, float* a, int* lda, float* work)
    {
        return slansy_(norm, uplo, n, a, lda, work, default, default);
    }

    public unsafe float Slantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, float* a, int* lda, float* work)
    {
        return slantr_(norm, uplo, diag, m, n, a, lda, work, default, default, default);
    }

    public unsafe void Slapmt(int* forwrd, int* m, int* n, float* x, int* ldx, int* k)
    {
        slapmt_(forwrd, m, n, x, ldx, k);
    }

    public unsafe float Slapy2(float* x, float* y)
    {
        return slapy2_(x, y);
    }

    public unsafe float Slapy3(float* x, float* y, float* z)
    {
        return slapy3_(x, y, z);
    }

    public unsafe void Slarf(byte* side, int* m, int* n, float* v, int* incv, float* tau, float* c, int* ldc, float* work)
    {
        slarf_(side, m, n, v, incv, tau, c, ldc, work, default);
    }

    public unsafe void Slarfg(int* n, float* alpha, float* x, int* incx, float* tau)
    {
        slarfg_(n, alpha, x, incx, tau);
    }

    public unsafe void Slargv(int* n, float* x, int* incx, float* y, int* incy, float* c, int* incc)
    {
        throw new NotSupportedException();
    }

    public unsafe void Slarnv(int* idist, int* iseed, int* n, float* x)
    {
        slarnv_(idist, iseed, n, x);
    }

    public unsafe void Slartg(float* f, float* g, float* cs, float* sn, float* r)
    {
        throw new NotSupportedException();
    }

    public unsafe void Slascl(byte* type, int* kl, int* ku, float* cfrom, float* cto, int* m, int* n, float* a, int* lda, int* info)
    {
        slascl_(type, kl, ku, cfrom, cto, m, n, a, lda, info, default);
    }

    public unsafe void Slaset(byte* uplo, int* m, int* n, float* alpha, float* beta, float* a, int* lda)
    {
        slaset_(uplo, m, n, alpha, beta, a, lda, default);
    }

    public unsafe void Slasr(byte* side, byte* pivot, byte* direct, int* m, int* n, float* c, float* s, float* a, int* lda)
    {
        throw new NotSupportedException();
    }

    public unsafe void Slaswp(int* n, float* a, int* lda, int* k1, int* k2, int* ipiv, int* incx)
    {
        slaswp_(n, a, lda, k1, k2, ipiv, incx);
    }

    public unsafe void Sorg2r(int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Sorgbr(byte* vect, int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sorgbr_(vect, m, n, k, a, lda, tau, work, lwork, info, default);
    }

    public unsafe void Sorghr(int* n, int* ilo, int* ihi, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sorghr_(n, ilo, ihi, a, lda, tau, work, lwork, info);
    }

    public unsafe void Sorgqr(int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sorgqr_(m, n, k, a, lda, tau, work, lwork, info);
    }

    public unsafe void Sorgtr(byte* uplo, int* n, float* a, int* lda, float* tau, float* work, int* lwork, int* info)
    {
        sorgtr_(uplo, n, a, lda, tau, work, lwork, info, default);
    }

    public unsafe void Sorm2r(byte* side, byte* trans, int* m, int* n, int* k, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Sormqr(byte* side, byte* trans, int* m, int* n, int* k, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* lwork, int* info)
    {
        sormqr_(side, trans, m, n, k, a, lda, tau, c, ldc, work, lwork, info, default, default);
    }

    public unsafe void Sormtr(byte* side, byte* uplo, byte* trans, int* m, int* n, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* lwork, int* info)
    {
        sormtr_(side, uplo, trans, m, n, a, lda, tau, c, ldc, work, lwork, info, default, default, default);
    }

    public unsafe void Spbsv(byte* uplo, int* n, int* kd, int* nrhs, float* ab, int* ldab, float* b, int* ldb, int* info)
    {
        spbsv_(uplo, n, kd, nrhs, ab, ldab, b, ldb, info, default);
    }

    public unsafe void Spbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        spbsvx_(fact, uplo, n, kd, nrhs, ab, ldab, afb, ldafb, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Spocon(byte* uplo, int* n, float* a, int* lda, float* anorm, float* rcond, float* work, int* iwork, int* info)
    {
        spocon_(uplo, n, a, lda, anorm, rcond, work, iwork, info, default);
    }

    public unsafe void Spoequ(int* n, float* a, int* lda, float* s, float* scond, float* amax, int* info)
    {
        spoequ_(n, a, lda, s, scond, amax, info);
    }

    public unsafe void Sporfs(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sporfs_(uplo, n, nrhs, a, lda, af, ldaf, b, ldb, x, ldx, ferr, berr, work, iwork, info, default);
    }

    public unsafe void Sposv(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info)
    {
        sposv_(uplo, n, nrhs, a, lda, b, ldb, info, default);
    }

    public unsafe void Sposvx(byte* fact, byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sposvx_(fact, uplo, n, nrhs, a, lda, af, ldaf, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Spotf2(byte* uplo, int* n, float* a, int* lda, int* info)
    {
        spotf2_(uplo, n, a, lda, info, default);
    }

    public unsafe void Spotrf(byte* uplo, int* n, float* a, int* lda, int* info)
    {
        spotrf_(uplo, n, a, lda, info, default);
    }

    public unsafe void Spotri(byte* uplo, int* n, float* a, int* lda, int* info)
    {
        spotri_(uplo, n, a, lda, info, default);
    }

    public unsafe void Spotrs(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info)
    {
        spotrs_(uplo, n, nrhs, a, lda, b, ldb, info, default);
    }

    public unsafe void Sppsv(byte* uplo, int* n, int* nrhs, float* ap, float* b, int* ldb, int* info)
    {
        sppsv_(uplo, n, nrhs, ap, b, ldb, info, default);
    }

    public unsafe void Sppsvx(byte* fact, byte* uplo, int* n, int* nrhs, float* ap, float* afp, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sppsvx_(fact, uplo, n, nrhs, ap, afp, equed, s, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default, default);
    }

    public unsafe void Sptsv(int* n, int* nrhs, float* d, float* e, float* b, int* ldb, int* info)
    {
        sptsv_(n, nrhs, d, e, b, ldb, info);
    }

    public unsafe void Sptsvx(byte* fact, int* n, int* nrhs, float* d, float* e, float* df, float* ef, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* info)
    {
        sptsvx_(fact, n, nrhs, d, e, df, ef, b, ldb, x, ldx, rcond, ferr, berr, work, info, default);
    }

    public unsafe void Ssbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, float* ab, int* ldab, float* bb, int* ldbb, float* w, float* z, int* ldz, float* work, int* info)
    {
        ssbgv_(jobz, uplo, n, ka, kb, ab, ldab, bb, ldbb, w, z, ldz, work, info, default, default);
    }

    public unsafe void Sspgv(int* itype, byte* jobz, byte* uplo, int* n, float* ap, float* bp, float* w, float* z, int* ldz, float* work, int* info)
    {
        sspgv_(itype, jobz, uplo, n, ap, bp, w, z, ldz, work, info, default, default);
    }

    public unsafe void Sspsv(byte* uplo, int* n, int* nrhs, float* ap, int* ipiv, float* b, int* ldb, int* info)
    {
        sspsv_(uplo, n, nrhs, ap, ipiv, b, ldb, info, default);
    }

    public unsafe void Sspsvx(byte* fact, byte* uplo, int* n, int* nrhs, float* ap, float* afp, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info)
    {
        sspsvx_(fact, uplo, n, nrhs, ap, afp, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, iwork, info, default, default);
    }

    public unsafe void Sstedc(byte* compz, int* n, float* d, float* e, float* z, int* ldz, float* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        sstedc_(compz, n, d, e, z, ldz, work, lwork, iwork, liwork, info, default);
    }

    public unsafe void Ssteqr(byte* compz, int* n, float* d, float* e, float* z, int* ldz, float* work, int* info)
    {
        ssteqr_(compz, n, d, e, z, ldz, work, info, default);
    }

    public unsafe void Ssterf(int* n, float* d, float* e, int* info)
    {
        ssterf_(n, d, e, info);
    }

    public unsafe void Ssyev(byte* jobz, byte* uplo, int* n, float* a, int* lda, float* w, float* work, int* lwork, int* info)
    {
        ssyev_(jobz, uplo, n, a, lda, w, work, lwork, info, default, default);
    }

    public unsafe void Ssyevd(byte* jobz, byte* uplo, int* n, float* a, int* lda, float* w, float* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        ssyevd_(jobz, uplo, n, a, lda, w, work, lwork, iwork, liwork, info, default, default);
    }

    public unsafe void Ssygv(int* itype, byte* jobz, byte* uplo, int* n, float* a, int* lda, float* b, int* ldb, float* w, float* work, int* lwork, int* info)
    {
        ssygv_(itype, jobz, uplo, n, a, lda, b, ldb, w, work, lwork, info, default, default);
    }

    public unsafe void Ssygvd(int* itype, byte* jobz, byte* uplo, int* n, float* a, int* lda, float* b, int* ldb, float* w, float* work, int* lwork, int* iwork, int* liwork, int* info)
    {
        ssygvd_(itype, jobz, uplo, n, a, lda, b, ldb, w, work, lwork, iwork, liwork, info, default, default);
    }

    public unsafe void Ssysv(byte* uplo, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, float* work, int* lwork, int* info)
    {
        ssysv_(uplo, n, nrhs, a, lda, ipiv, b, ldb, work, lwork, info, default);
    }

    public unsafe void Ssysvx(byte* fact, byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* lwork, int* iwork, int* info)
    {
        ssysvx_(fact, uplo, n, nrhs, a, lda, af, ldaf, ipiv, b, ldb, x, ldx, rcond, ferr, berr, work, lwork, iwork, info, default, default);
    }

    public unsafe void Ssytrd(byte* uplo, int* n, float* a, int* lda, float* d, float* e, float* tau, float* work, int* lwork, int* info)
    {
        ssytrd_(uplo, n, a, lda, d, e, tau, work, lwork, info, default);
    }

    public unsafe void Strti2(byte* uplo, byte* diag, int* n, float* a, int* lda, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, double* d, double* e, void* vt, int* ldvt, void* u, int* ldu, void* c, int* ldc, double* work, int* info)
    {
        zbdsqr_(uplo, n, ncvt, nru, ncc, d, e, (_lapack_complex_double*)vt, ldvt, (_lapack_complex_double*)u, ldu, (_lapack_complex_double*)c, ldc, work, info, default);
    }

    public unsafe void Zdrot(int* n, void* cx, int* incx, void* cy, int* incy, double* c, double* s)
    {
        cblas_zdrot(*n, cx, *incx, cy, *incy, *c, *s);
    }

    public unsafe void Zgbcon(byte* norm, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, double* anorm, double* rcond, void* work, double* rwork, int* info)
    {
        zgbcon_(norm, n, kl, ku, (_lapack_complex_double*)ab, ldab, ipiv, anorm, rcond, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zgbequ(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info)
    {
        zgbequ_(m, n, kl, ku, (_lapack_complex_double*)ab, ldab, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Zgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgbrfs_(trans, n, kl, ku, nrhs, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)afb, ldafb, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, ferr, berr, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zgbsv(int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info)
    {
        zgbsv_(n, kl, ku, nrhs, (_lapack_complex_double*)ab, ldab, ipiv, (_lapack_complex_double*)b, ldb, info);
    }

    public unsafe void Zgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgbsvx_(fact, trans, n, kl, ku, nrhs, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)afb, ldafb, ipiv, equed, r, c, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default, default);
    }

    public unsafe void Zgbtrf(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, int* info)
    {
        zgbtrf_(m, n, kl, ku, (_lapack_complex_double*)ab, ldab, ipiv, info);
    }

    public unsafe void Zgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info)
    {
        zgbtrs_(trans, n, kl, ku, nrhs, (_lapack_complex_double*)ab, ldab, ipiv, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zgebrd(int* m, int* n, void* a, int* lda, double* d, double* e, void* tauq, void* taup, void* work, int* lwork, int* info)
    {
        zgebrd_(m, n, (_lapack_complex_double*)a, lda, d, e, (_lapack_complex_double*)tauq, (_lapack_complex_double*)taup, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zgecon(byte* norm, int* n, void* a, int* lda, double* anorm, double* rcond, void* work, double* rwork, int* info)
    {
        zgecon_(norm, n, (_lapack_complex_double*)a, lda, anorm, rcond, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zgeequ(int* m, int* n, void* a, int* lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info)
    {
        zgeequ_(m, n, (_lapack_complex_double*)a, lda, r, c, rowcnd, colcnd, amax, info);
    }

    public unsafe void Zgees(byte* jobvs, byte* sort, void* select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, double* rwork, int* bwork, int* info)
    {
        zgees_(jobvs, sort, (delegate* unmanaged[Cdecl]<_lapack_complex_double*, int>)select, n, (_lapack_complex_double*)a, lda, sdim, (_lapack_complex_double*)w, (_lapack_complex_double*)vs, ldvs, (_lapack_complex_double*)work, lwork, rwork, bwork, info, default, default);
    }

    public unsafe void Zgeev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* w, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, double* rwork, int* info)
    {
        zgeev_(jobvl, jobvr, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)w, (_lapack_complex_double*)vl, ldvl, (_lapack_complex_double*)vr, ldvr, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zgehrd(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zgehrd_(n, ilo, ihi, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zgels(byte* trans, int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        zgels_(trans, m, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zgelsd(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, double* s, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* iwork, int* info)
    {
        zgelsd_(m, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, s, rcond, rank, (_lapack_complex_double*)work, lwork, rwork, iwork, info);
    }

    public unsafe void Zgelss(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, double* s, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* info)
    {
        zgelss_(m, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, s, rcond, rank, (_lapack_complex_double*)work, lwork, rwork, info);
    }

    public unsafe void Zgelsy(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* jpvt, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* info)
    {
        zgelsy_(m, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, jpvt, rcond, rank, (_lapack_complex_double*)work, lwork, rwork, info);
    }

    public unsafe void Zgeqp3(int* m, int* n, void* a, int* lda, int* jpvt, void* tau, void* work, int* lwork, double* rwork, int* info)
    {
        zgeqp3_(m, n, (_lapack_complex_double*)a, lda, jpvt, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, rwork, info);
    }

    public unsafe void Zgeqr2(int* m, int* n, void* a, int* lda, void* tau, void* work, int* info)
    {
        zgeqr2_(m, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, info);
    }

    public unsafe void Zgeqrf(int* m, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zgeqrf_(m, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zgerfs(byte* trans, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgerfs_(trans, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)af, ldaf, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, ferr, berr, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zgesdd(byte* jobz, int* m, int* n, void* a, int* lda, double* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, double* rwork, int* iwork, int* info)
    {
        zgesdd_(jobz, m, n, (_lapack_complex_double*)a, lda, s, (_lapack_complex_double*)u, ldu, (_lapack_complex_double*)vt, ldvt, (_lapack_complex_double*)work, lwork, rwork, iwork, info, default);
    }

    public unsafe int Zgesv(int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info)
    {
        return zgesv_(n, nrhs, (_lapack_complex_double*)a, lda, ipiv, (_lapack_complex_double*)b, ldb, info);
    }

    public unsafe void Zgesvd(byte* jobu, byte* jobvt, int* m, int* n, void* a, int* lda, double* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, double* rwork, int* info)
    {
        zgesvd_(jobu, jobvt, m, n, (_lapack_complex_double*)a, lda, s, (_lapack_complex_double*)u, ldu, (_lapack_complex_double*)vt, ldvt, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zgesvx(byte* fact, byte* trans, int* n, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgesvx_(fact, trans, n, nrhs, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)afb, ldafb, ipiv, equed, r, c, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default, default);
    }

    public unsafe void Zgetf2(int* m, int* n, void* a, int* lda, int* ipiv, int* info)
    {
        zgetf2_(m, n, (_lapack_complex_double*)a, lda, ipiv, info);
    }

    public unsafe void Zgetrf(int* m, int* n, void* a, int* lda, int* ipiv, int* info)
    {
        zgetrf_(m, n, (_lapack_complex_double*)a, lda, ipiv, info);
    }

    public unsafe void Zgetri(int* n, void* a, int* lda, int* ipiv, void* work, int* lwork, int* info)
    {
        zgetri_(n, (_lapack_complex_double*)a, lda, ipiv, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zgetrs(byte* trans, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info)
    {
        zgetrs_(trans, n, nrhs, (_lapack_complex_double*)a, lda, ipiv, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<void*, void*, int> selctg, int* n, void* a, int* lda, void* b, int* ldb, int* sdim, void* alpha, void* beta, void* vsl, int* ldvsl, void* vsr, int* ldvsr, void* work, int* lwork, double* rwork, int* bwork, int* info)
    {
        zgges_(jobvsl, jobvsr, sort, selctg, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, sdim, (_lapack_complex_double*)alpha, (_lapack_complex_double*)beta, (_lapack_complex_double*)vsl, ldvsl, (_lapack_complex_double*)vsr, ldvsr, (_lapack_complex_double*)work, lwork, rwork, bwork, info, default, default, default);
    }

    public unsafe void Zggev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* b, int* ldb, void* alpha, void* beta, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, double* rwork, int* info)
    {
        zggev_(jobvl, jobvr, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)alpha, (_lapack_complex_double*)beta, (_lapack_complex_double*)vl, ldvl, (_lapack_complex_double*)vr, ldvr, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zggglm(int* n, int* m, int* p, void* a, int* lda, void* b, int* ldb, void* d, void* x, void* y, void* work, int* lwork, int* info)
    {
        zggglm_(n, m, p, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)d, (_lapack_complex_double*)x, (_lapack_complex_double*)y, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zgglse(int* m, int* n, int* p, void* a, int* lda, void* b, int* ldb, void* c, void* d, void* x, void* work, int* lwork, int* info)
    {
        zgglse_(m, n, p, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)c, (_lapack_complex_double*)d, (_lapack_complex_double*)x, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, void* a, int* lda, void* b, int* ldb, double* alpha, double* beta, void* u, int* ldu, void* v, int* ldv, void* q, int* ldq, void* work, double* rwork, int* iwork, int* info)
    {
        zggsvd_(jobu, jobv, jobq, m, n, p, k, l, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, alpha, beta, (_lapack_complex_double*)u, ldu, (_lapack_complex_double*)v, ldv, (_lapack_complex_double*)q, ldq, (_lapack_complex_double*)work, rwork, iwork, info, default, default, default);
    }

    public unsafe void Zgtcon(byte* norm, int* n, void* dl, void* d, void* du, void* du2, int* ipiv, double* anorm, double* rcond, void* work, int* info)
    {
        zgtcon_(norm, n, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)du2, ipiv, anorm, rcond, (_lapack_complex_double*)work, info, default);
    }

    public unsafe void Zgtrfs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgtrfs_(trans, n, nrhs, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)dlf, (_lapack_complex_double*)df, (_lapack_complex_double*)duf, (_lapack_complex_double*)du2, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, ferr, berr, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zgtsv(int* n, int* nrhs, void* dl, void* d, void* du, void* b, int* ldb, int* info)
    {
        zgtsv_(n, nrhs, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)b, ldb, info);
    }

    public unsafe void Zgtsvx(byte* fact, byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zgtsvx_(fact, trans, n, nrhs, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)dlf, (_lapack_complex_double*)df, (_lapack_complex_double*)duf, (_lapack_complex_double*)du2, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default);
    }

    public unsafe void Zgttrf(int* n, void* dl, void* d, void* du, void* du2, int* ipiv, int* info)
    {
        zgttrf_(n, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)du2, ipiv, info);
    }

    public unsafe void Zgttrs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* du2, int* ipiv, void* b, int* ldb, int* info)
    {
        zgttrs_(trans, n, nrhs, (_lapack_complex_double*)dl, (_lapack_complex_double*)d, (_lapack_complex_double*)du, (_lapack_complex_double*)du2, ipiv, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zhbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, void* ab, int* ldab, void* bb, int* ldbb, double* w, void* z, int* ldz, void* work, double* rwork, int* info)
    {
        zhbgv_(jobz, uplo, n, ka, kb, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)bb, ldbb, w, (_lapack_complex_double*)z, ldz, (_lapack_complex_double*)work, rwork, info, default, default);
    }

    public unsafe void Zheev(byte* jobz, byte* uplo, int* n, void* a, int* lda, double* w, void* work, int* lwork, double* rwork, int* info)
    {
        zheev_(jobz, uplo, n, (_lapack_complex_double*)a, lda, w, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zheevd(byte* jobz, byte* uplo, int* n, void* a, int* lda, double* w, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        zheevd_(jobz, uplo, n, (_lapack_complex_double*)a, lda, w, (_lapack_complex_double*)work, lwork, rwork, lrwork, iwork, liwork, info, default, default);
    }

    public unsafe void Zhegv(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, double* w, void* work, int* lwork, double* rwork, int* info)
    {
        zhegv_(itype, jobz, uplo, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, w, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zhegvd(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, double* w, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        zhegvd_(itype, jobz, uplo, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, w, (_lapack_complex_double*)work, lwork, rwork, lrwork, iwork, liwork, info, default, default);
    }

    public unsafe void Zhesv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        zhesv_(uplo, n, nrhs, (_lapack_complex_double*)a, lda, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zhesvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, int* lwork, double* rwork, int* info)
    {
        zhesvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)af, ldaf, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Zhetrd(byte* uplo, int* n, void* a, int* lda, double* d, double* e, void* tau, void* work, int* lwork, int* info)
    {
        zhetrd_(uplo, n, (_lapack_complex_double*)a, lda, d, e, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zhpgv(int* itype, byte* jobz, byte* uplo, int* n, void* ap, void* bp, double* w, void* z, int* ldz, void* work, double* rwork, int* info)
    {
        zhpgv_(itype, jobz, uplo, n, (_lapack_complex_double*)ap, (_lapack_complex_double*)bp, w, (_lapack_complex_double*)z, ldz, (_lapack_complex_double*)work, rwork, info, default, default);
    }

    public unsafe void Zhpsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info)
    {
        zhpsv_(uplo, n, nrhs, (_lapack_complex_double*)ap, ipiv, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zhpsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zhpsvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)ap, (_lapack_complex_double*)afp, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default);
    }

    public unsafe void Zhseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, void* h, int* ldh, void* w, void* z, int* ldz, void* work, int* lwork, int* info)
    {
        zhseqr_(job, compz, n, ilo, ihi, (_lapack_complex_double*)h, ldh, (_lapack_complex_double*)w, (_lapack_complex_double*)z, ldz, (_lapack_complex_double*)work, lwork, info, default, default);
    }

    public unsafe void Zlacgv(int* n, void* x, int* incx)
    {
        zlacgv_(n, (_lapack_complex_double*)x, incx);
    }

    public unsafe void Zlacpy(byte* uplo, int* m, int* n, void* a, int* lda, void* b, int* ldb)
    {
        zlacpy_(uplo, m, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, default);
    }

    public unsafe void Zlacrm(int* m, int* n, void* a, int* lda, double* b, int* ldb, void* c, int* ldc, double* rwork)
    {
        zlacrm_(m, n, (_lapack_complex_double*)a, lda, b, ldb, (_lapack_complex_double*)c, ldc, rwork);
    }

    public unsafe void Zlacrt(int* n, void* cx, int* incx, void* cy, int* incy, void* c, void* s)
    {
        throw new NotSupportedException();
    }

    public unsafe double Zlange(byte* norm, int* m, int* n, void* a, int* lda, double* work)
    {
        return zlange_(norm, m, n, (_lapack_complex_double*)a, lda, work, default);
    }

    public unsafe double Zlanhe(byte* norm, byte* uplo, int* n, void* a, int* lda, double* work)
    {
        return zlanhe_(norm, uplo, n, (_lapack_complex_double*)a, lda, work, default, default);
    }

    public unsafe double Zlansy(byte* norm, byte* uplo, int* n, void* a, int* lda, double* work)
    {
        return zlansy_(norm, uplo, n, (_lapack_complex_double*)a, lda, work, default, default);
    }

    public unsafe double Zlantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, void* a, int* lda, double* work)
    {
        return zlantr_(norm, uplo, diag, m, n, (_lapack_complex_double*)a, lda, work, default, default, default);
    }

    public unsafe void Zlapmt(int* forwrd, int* m, int* n, void* x, int* ldx, int* k)
    {
        zlapmt_(forwrd, m, n, (_lapack_complex_double*)x, ldx, k);
    }

    public unsafe void Zlarf(byte* side, int* m, int* n, void* v, int* incv, void* tau, void* c, int* ldc, void* work)
    {
        zlarf_(side, m, n, (_lapack_complex_double*)v, incv, (_lapack_complex_double*)tau, (_lapack_complex_double*)c, ldc, (_lapack_complex_double*)work, default);
    }

    public unsafe void Zlarfg(int* n, void* alpha, void* x, int* incx, void* tau)
    {
        zlarfg_(n, (_lapack_complex_double*)alpha, (_lapack_complex_double*)x, incx, (_lapack_complex_double*)tau);
    }

    public unsafe void Zlargv(int* n, void* x, int* incx, void* y, int* incy, double* c, void* s, int* incc)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zlarnv(int* idist, int* iseed, int* n, void* x)
    {
        zlarnv_(idist, iseed, n, (_lapack_complex_double*)x);
    }

    public unsafe void Zlartg(void* f, void* g, double* cs, void* sn, void* r)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zlascl(byte* type, int* kl, int* ku, double* cfrom, double* cto, int* m, int* n, void* a, int* lda, int* info)
    {
        zlascl_(type, kl, ku, cfrom, cto, m, n, (_lapack_complex_double*)a, lda, info, default);
    }

    public unsafe void Zlaset(byte* uplo, int* m, int* n, void* alpha, void* beta, void* a, int* lda)
    {
        zlaset_(uplo, m, n, (_lapack_complex_double*)alpha, (_lapack_complex_double*)beta, (_lapack_complex_double*)a, lda, default);
    }

    public unsafe void Zlasr(byte* side, byte* pivot, byte* direct, int* m, int* n, double* c, double* s, void* a, int* lda)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zlaswp(int* n, void* a, int* lda, int* k1, int* k2, int* ipiv, int* incx)
    {
        zlaswp_(n, (_lapack_complex_double*)a, lda, k1, k2, ipiv, incx);
    }

    public unsafe void Zpbsv(byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* b, int* ldb, int* info)
    {
        zpbsv_(uplo, n, kd, nrhs, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zpbsvx_(fact, uplo, n, kd, nrhs, (_lapack_complex_double*)ab, ldab, (_lapack_complex_double*)afb, ldafb, equed, s, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default, default);
    }

    public unsafe void Zpocon(byte* uplo, int* n, void* a, int* lda, double* anorm, double* rcond, void* work, double* rwork, int* info)
    {
        zpocon_(uplo, n, (_lapack_complex_double*)a, lda, anorm, rcond, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zpoequ(int* n, void* a, int* lda, double* s, double* scond, double* amax, int* info)
    {
        zpoequ_(n, (_lapack_complex_double*)a, lda, s, scond, amax, info);
    }

    public unsafe void Zporfs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zporfs_(uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)af, ldaf, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, ferr, berr, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zposv(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info)
    {
        zposv_(uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zposvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zposvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)af, ldaf, equed, s, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default, default);
    }

    public unsafe void Zpotf2(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        zpotf2_(uplo, n, (_lapack_complex_double*)a, lda, info, default);
    }

    public unsafe void Zpotrf(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        zpotrf_(uplo, n, (_lapack_complex_double*)a, lda, info, default);
    }

    public unsafe void Zpotri(byte* uplo, int* n, void* a, int* lda, int* info)
    {
        zpotri_(uplo, n, (_lapack_complex_double*)a, lda, info, default);
    }

    public unsafe void Zpotrs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info)
    {
        zpotrs_(uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zppsv(byte* uplo, int* n, int* nrhs, void* ap, void* b, int* ldb, int* info)
    {
        zppsv_(uplo, n, nrhs, (_lapack_complex_double*)ap, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zppsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zppsvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)ap, (_lapack_complex_double*)afp, equed, s, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default, default);
    }

    public unsafe void Zptsv(int* n, int* nrhs, double* d, void* e, void* b, int* ldb, int* info)
    {
        zptsv_(n, nrhs, d, (_lapack_complex_double*)e, (_lapack_complex_double*)b, ldb, info);
    }

    public unsafe void Zptsvx(byte* fact, int* n, int* nrhs, double* d, void* e, double* df, void* ef, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zptsvx_(fact, n, nrhs, d, (_lapack_complex_double*)e, df, (_lapack_complex_double*)ef, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default);
    }

    public unsafe void Zrot(int* n, void* cx, int* incx, void* cy, int* incy, double* c, void* s)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zspmv(byte* uplo, int* n, void* alpha, void* ap, void* x, int* incx, void* beta, void* y, int* incy)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zspr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* ap)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zspsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info)
    {
        zspsv_(uplo, n, nrhs, (_lapack_complex_double*)ap, ipiv, (_lapack_complex_double*)b, ldb, info, default);
    }

    public unsafe void Zspsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info)
    {
        zspsvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)ap, (_lapack_complex_double*)afp, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, rwork, info, default, default);
    }

    public unsafe void Zstedc(byte* compz, int* n, double* d, double* e, void* z, int* ldz, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info)
    {
        zstedc_(compz, n, d, e, (_lapack_complex_double*)z, ldz, (_lapack_complex_double*)work, lwork, rwork, lrwork, iwork, liwork, info, default);
    }

    public unsafe void Zsteqr(byte* compz, int* n, double* d, double* e, void* z, int* ldz, double* work, int* info)
    {
        zsteqr_(compz, n, d, e, (_lapack_complex_double*)z, ldz, work, info, default);
    }

    public unsafe void Zsymv(byte* uplo, int* n, void* alpha, void* a, int* lda, void* x, int* incx, void* beta, void* y, int* incy)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zsyr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* a, int* lda)
    {
        zsyr_(uplo, n, (_lapack_complex_double*)alpha, (_lapack_complex_double*)x, incx, (_lapack_complex_double*)a, lda, default);
    }

    public unsafe void Zsysv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info)
    {
        zsysv_(uplo, n, nrhs, (_lapack_complex_double*)a, lda, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zsysvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, int* lwork, double* rwork, int* info)
    {
        zsysvx_(fact, uplo, n, nrhs, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)af, ldaf, ipiv, (_lapack_complex_double*)b, ldb, (_lapack_complex_double*)x, ldx, rcond, ferr, berr, (_lapack_complex_double*)work, lwork, rwork, info, default, default);
    }

    public unsafe void Ztrti2(byte* uplo, byte* diag, int* n, void* a, int* lda, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zung2r(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zungbr(byte* vect, int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zungbr_(vect, m, n, k, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zunghr(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zunghr_(n, ilo, ihi, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zungqr(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zungqr_(m, n, k, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info);
    }

    public unsafe void Zungtr(byte* uplo, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info)
    {
        zungtr_(uplo, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)work, lwork, info, default);
    }

    public unsafe void Zunm2r(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* info)
    {
        throw new NotSupportedException();
    }

    public unsafe void Zunmqr(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info)
    {
        zunmqr_(side, trans, m, n, k, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)c, ldc, (_lapack_complex_double*)work, lwork, info, default, default);
    }

    public unsafe void Zunmtr(byte* side, byte* uplo, byte* trans, int* m, int* n, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info)
    {
        zunmtr_(side, uplo, trans, m, n, (_lapack_complex_double*)a, lda, (_lapack_complex_double*)tau, (_lapack_complex_double*)c, ldc, (_lapack_complex_double*)work, lwork, info, default, default, default);
    }
}
