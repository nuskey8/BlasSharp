namespace BlasSharp;

public interface ILapackOperations : ILapackDriverRoutines
{
}

public unsafe interface ILapackDriverRoutines
{
    // General matrix - simple drivers
    public int Sgesv(int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);
    public int Cgesv(int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info);
    public int Dgesv(int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);
    public int Zgesv(int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info);

    // General matrix - expert drivers
    public void Sgesvx(byte* fact, byte* trans, int* n, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgesvx(byte* fact, byte* trans, int* n, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgesvx(byte* fact, byte* trans, int* n, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgesvx(byte* fact, byte* trans, int* n, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // General band matrix - simple drivers
    public void Sgbsv(int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, int* ipiv, float* b, int* ldb, int* info);
    public void Cgbsv(int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info);
    public void Dgbsv(int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, int* ipiv, double* b, int* ldb, int* info);
    public void Zgbsv(int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info);

    // General band matrix - expert drivers
    public void Sgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, float* r, float* c, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgbsvx(byte* fact, byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, byte* equed, double* r, double* c, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // General tridiagonal matrix - simple drivers
    public void Sgtsv(int* n, int* nrhs, float* dl, float* d, float* du, float* b, int* ldb, int* info);
    public void Cgtsv(int* n, int* nrhs, void* dl, void* d, void* du, void* b, int* ldb, int* info);
    public void Dgtsv(int* n, int* nrhs, double* dl, double* d, double* du, double* b, int* ldb, int* info);
    public void Zgtsv(int* n, int* nrhs, void* dl, void* d, void* du, void* b, int* ldb, int* info);

    // General tridiagonal matrix - expert drivers
    public void Sgtsvx(byte* fact, byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgtsvx(byte* fact, byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgtsvx(byte* fact, byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgtsvx(byte* fact, byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Symmetric/Hermitian positive definite matrix - simple drivers
    public void Sposv(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);
    public void Cposv(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info);
    public void Dposv(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info);
    public void Zposv(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info);

    // Symmetric/Hermitian positive definite matrix - expert drivers
    public void Sposvx(byte* fact, byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cposvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dposvx(byte* fact, byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zposvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Symmetric/Hermitian positive definite matrix (packed storage) - simple drivers
    public void Sppsv(byte* uplo, int* n, int* nrhs, float* ap, float* b, int* ldb, int* info);
    public void Cppsv(byte* uplo, int* n, int* nrhs, void* ap, void* b, int* ldb, int* info);
    public void Dppsv(byte* uplo, int* n, int* nrhs, double* ap, double* b, int* ldb, int* info);
    public void Zppsv(byte* uplo, int* n, int* nrhs, void* ap, void* b, int* ldb, int* info);

    // Symmetric/Hermitian positive definite matrix (packed storage) - expert drivers
    public void Sppsvx(byte* fact, byte* uplo, int* n, int* nrhs, float* ap, float* afp, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cppsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dppsvx(byte* fact, byte* uplo, int* n, int* nrhs, double* ap, double* afp, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zppsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Symmetric/Hermitian positive definite band matrix - simple drivers
    public void Spbsv(byte* uplo, int* n, int* kd, int* nrhs, float* ab, int* ldab, float* b, int* ldb, int* info);
    public void Cpbsv(byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* b, int* ldb, int* info);
    public void Dpbsv(byte* uplo, int* n, int* kd, int* nrhs, double* ab, int* ldab, double* b, int* ldb, int* info);
    public void Zpbsv(byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* b, int* ldb, int* info);

    // Symmetric/Hermitian positive definite band matrix - expert drivers
    public void Spbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, byte* equed, float* s, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, byte* equed, float* s, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, byte* equed, double* s, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zpbsvx(byte* fact, byte* uplo, int* n, int* kd, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, byte* equed, double* s, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Symmetric/Hermitian positive definite tridiagonal matrix - simple drivers
    public void Sptsv(int* n, int* nrhs, float* d, float* e, float* b, int* ldb, int* info);
    public void Cptsv(int* n, int* nrhs, float* d, void* e, void* b, int* ldb, int* info);
    public void Dptsv(int* n, int* nrhs, double* d, double* e, double* b, int* ldb, int* info);
    public void Zptsv(int* n, int* nrhs, double* d, void* e, void* b, int* ldb, int* info);

    // Symmetric/Hermitian positive definite tridiagonal matrix - expert drivers
    public void Sptsvx(byte* fact, int* n, int* nrhs, float* d, float* e, float* df, float* ef, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* info);
    public void Cptsvx(byte* fact, int* n, int* nrhs, float* d, void* e, float* df, void* ef, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dptsvx(byte* fact, int* n, int* nrhs, double* d, double* e, double* df, double* ef, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* info);
    public void Zptsvx(byte* fact, int* n, int* nrhs, double* d, void* e, double* df, void* ef, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Symmetric/Hermitian indefinite matrix - simple drivers
    public void Ssysv(byte* uplo, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, float* work, int* lwork, int* info);
    public void Chesv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info);
    public void Dsysv(byte* uplo, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, double* work, int* lwork, int* info);
    public void Zhesv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info);

    // Symmetric/Hermitian indefinite matrix - expert drivers
    public void Ssysvx(byte* fact, byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* lwork, int* iwork, int* info);
    public void Chesvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, int* lwork, float* rwork, int* info);
    public void Dsysvx(byte* fact, byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* lwork, int* iwork, int* info);
    public void Zhesvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, int* lwork, double* rwork, int* info);

    // Complex symmetric matrix - simple drivers
    public void Csysv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info);
    public void Zsysv(byte* uplo, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, void* work, int* lwork, int* info);

    // Complex symmetric matrix - expert drivers
    public void Csysvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, int* lwork, float* rwork, int* info);
    public void Zsysvx(byte* fact, byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, int* lwork, double* rwork, int* info);

    // Symmetric/Hermitian indefinite matrix (packed storage) - simple drivers
    public void Sspsv(byte* uplo, int* n, int* nrhs, float* ap, int* ipiv, float* b, int* ldb, int* info);
    public void Chpsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info);
    public void Dspsv(byte* uplo, int* n, int* nrhs, double* ap, int* ipiv, double* b, int* ldb, int* info);
    public void Zhpsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info);

    // Symmetric/Hermitian indefinite matrix (packed storage) - expert drivers
    public void Sspsvx(byte* fact, byte* uplo, int* n, int* nrhs, float* ap, float* afp, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Chpsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dspsvx(byte* fact, byte* uplo, int* n, int* nrhs, double* ap, double* afp, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zhpsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Complex symmetric matrix (packed storage) - simple drivers
    public void Cspsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info);
    public void Zspsv(byte* uplo, int* n, int* nrhs, void* ap, int* ipiv, void* b, int* ldb, int* info);

    // Complex symmetric matrix (packed storage) - expert drivers
    public void Cspsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* rcond, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Zspsvx(byte* fact, byte* uplo, int* n, int* nrhs, void* ap, void* afp, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* rcond, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Linear least squares using QR or LQ factorization
    public void Sgels(byte* trans, int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* work, int* lwork, int* info);
    public void Cgels(byte* trans, int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, void* work, int* lwork, int* info);
    public void Dgels(byte* trans, int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* work, int* lwork, int* info);
    public void Zgels(byte* trans, int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, void* work, int* lwork, int* info);

    // Linear least squares using complete orthogonal factorization
    public void Sgelsy(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* jpvt, float* rcond, int* rank, float* work, int* lwork, int* info);
    public void Cgelsy(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* jpvt, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* info);
    public void Dgelsy(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* jpvt, double* rcond, int* rank, double* work, int* lwork, int* info);
    public void Zgelsy(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* jpvt, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* info);

    // Linear least squares using SVD
    public void Sgelss(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* s, float* rcond, int* rank, float* work, int* lwork, int* info);
    public void Cgelss(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, float* s, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* info);
    public void Dgelss(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* s, double* rcond, int* rank, double* work, int* lwork, int* info);
    public void Zgelss(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, double* s, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* info);

    // Linear least squares using divide-and-conquer SVD
    public void Sgelsd(int* m, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, float* s, float* rcond, int* rank, float* work, int* lwork, int* iwork, int* info);
    public void Cgelsd(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, float* s, float* rcond, int* rank, void* work, int* lwork, float* rwork, int* iwork, int* info);
    public void Dgelsd(int* m, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, double* s, double* rcond, int* rank, double* work, int* lwork, int* iwork, int* info);
    public void Zgelsd(int* m, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, double* s, double* rcond, int* rank, void* work, int* lwork, double* rwork, int* iwork, int* info);

    // Generalized linear least squares - LSE problem using GRQ
    public void Sgglse(int* m, int* n, int* p, float* a, int* lda, float* b, int* ldb, float* c, float* d, float* x, float* work, int* lwork, int* info);
    public void Cgglse(int* m, int* n, int* p, void* a, int* lda, void* b, int* ldb, void* c, void* d, void* x, void* work, int* lwork, int* info);
    public void Dgglse(int* m, int* n, int* p, double* a, int* lda, double* b, int* ldb, double* c, double* d, double* x, double* work, int* lwork, int* info);
    public void Zgglse(int* m, int* n, int* p, void* a, int* lda, void* b, int* ldb, void* c, void* d, void* x, void* work, int* lwork, int* info);

    // Generalized linear least squares - GLM problem using GQR
    public void Sggglm(int* n, int* m, int* p, float* a, int* lda, float* b, int* ldb, float* d, float* x, float* y, float* work, int* lwork, int* info);
    public void Cggglm(int* n, int* m, int* p, void* a, int* lda, void* b, int* ldb, void* d, void* x, void* y, void* work, int* lwork, int* info);
    public void Dggglm(int* n, int* m, int* p, double* a, int* lda, double* b, int* ldb, double* d, double* x, double* y, double* work, int* lwork, int* info);
    public void Zggglm(int* n, int* m, int* p, void* a, int* lda, void* b, int* ldb, void* d, void* x, void* y, void* work, int* lwork, int* info);

    // Symmetric eigenvalue problems
    public void Ssyev(byte* jobz, byte* uplo, int* n, float* a, int* lda, float* w, float* work, int* lwork, int* info);
    public void Cheev(byte* jobz, byte* uplo, int* n, void* a, int* lda, float* w, void* work, int* lwork, float* rwork, int* info);
    public void Dsyev(byte* jobz, byte* uplo, int* n, double* a, int* lda, double* w, double* work, int* lwork, int* info);
    public void Zheev(byte* jobz, byte* uplo, int* n, void* a, int* lda, double* w, void* work, int* lwork, double* rwork, int* info);

    // Symmetric eigenvalue problems (divide-and-conquer)
    public void Ssyevd(byte* jobz, byte* uplo, int* n, float* a, int* lda, float* w, float* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Cheevd(byte* jobz, byte* uplo, int* n, void* a, int* lda, float* w, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info);
    public void Dsyevd(byte* jobz, byte* uplo, int* n, double* a, int* lda, double* w, double* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Zheevd(byte* jobz, byte* uplo, int* n, void* a, int* lda, double* w, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info);

    // Nonsymmetric eigenvalue problems
    public void Sgeev(byte* jobvl, byte* jobvr, int* n, float* a, int* lda, float* wr, float* wi, float* vl, int* ldvl, float* vr, int* ldvr, float* work, int* lwork, int* info);
    public void Cgeev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* w, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, float* rwork, int* info);
    public void Dgeev(byte* jobvl, byte* jobvr, int* n, double* a, int* lda, double* wr, double* wi, double* vl, int* ldvl, double* vr, int* ldvr, double* work, int* lwork, int* info);
    public void Zgeev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* w, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, double* rwork, int* info);

    // Nonsymmetric eigenvalue problems (Schur factorization)
    public void Sgees(byte* jobvs, byte* sort, delegate* unmanaged[Cdecl]<float*, float*, int> select, int* n, float* a, int* lda, int* sdim, float* wr, float* wi, float* vs, int* ldvs, float* work, int* lwork, int* bwork, int* info);
    public void Cgees(byte* jobvs, byte* sort, delegate* unmanaged[Cdecl]<void*, int> select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, float* rwork, int* bwork, int* info);
    public void Dgees(byte* jobvs, byte* sort, delegate* unmanaged[Cdecl]<double*, double*, int> select, int* n, double* a, int* lda, int* sdim, double* wr, double* wi, double* vs, int* ldvs, double* work, int* lwork, int* bwork, int* info);
    public void Zgees(byte* jobvs, byte* sort, delegate* unmanaged[Cdecl]<void*, int> select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, double* rwork, int* bwork, int* info);

    // Singular value decomposition
    public void Sgesvd(byte* jobu, byte* jobvt, int* m, int* n, float* a, int* lda, float* s, float* u, int* ldu, float* vt, int* ldvt, float* work, int* lwork, int* info);
    public void Cgesvd(byte* jobu, byte* jobvt, int* m, int* n, void* a, int* lda, float* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, float* rwork, int* info);
    public void Dgesvd(byte* jobu, byte* jobvt, int* m, int* n, double* a, int* lda, double* s, double* u, int* ldu, double* vt, int* ldvt, double* work, int* lwork, int* info);
    public void Zgesvd(byte* jobu, byte* jobvt, int* m, int* n, void* a, int* lda, double* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, double* rwork, int* info);

    // Singular value decomposition (divide-and-conquer)
    public void Sgesdd(byte* jobz, int* m, int* n, float* a, int* lda, float* s, float* u, int* ldu, float* vt, int* ldvt, float* work, int* lwork, int* iwork, int* info);
    public void Cgesdd(byte* jobz, int* m, int* n, void* a, int* lda, float* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, float* rwork, int* iwork, int* info);
    public void Dgesdd(byte* jobz, int* m, int* n, double* a, int* lda, double* s, double* u, int* ldu, double* vt, int* ldvt, double* work, int* lwork, int* iwork, int* info);
    public void Zgesdd(byte* jobz, int* m, int* n, void* a, int* lda, double* s, void* u, int* ldu, void* vt, int* ldvt, void* work, int* lwork, double* rwork, int* iwork, int* info);

    // Generalized symmetric eigenvalue problems - simple drivers
    public void Ssygv(int* itype, byte* jobz, byte* uplo, int* n, float* a, int* lda, float* b, int* ldb, float* w, float* work, int* lwork, int* info);
    public void Chegv(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, float* w, void* work, int* lwork, float* rwork, int* info);
    public void Dsygv(int* itype, byte* jobz, byte* uplo, int* n, double* a, int* lda, double* b, int* ldb, double* w, double* work, int* lwork, int* info);
    public void Zhegv(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, double* w, void* work, int* lwork, double* rwork, int* info);

    // Generalized symmetric eigenvalue problems - divide-and-conquer drivers
    public void Ssygvd(int* itype, byte* jobz, byte* uplo, int* n, float* a, int* lda, float* b, int* ldb, float* w, float* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Chegvd(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, float* w, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info);
    public void Dsygvd(int* itype, byte* jobz, byte* uplo, int* n, double* a, int* lda, double* b, int* ldb, double* w, double* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Zhegvd(int* itype, byte* jobz, byte* uplo, int* n, void* a, int* lda, void* b, int* ldb, double* w, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info);

    // Generalized symmetric eigenvalue problems (packed storage) - simple drivers
    public void Sspgv(int* itype, byte* jobz, byte* uplo, int* n, float* ap, float* bp, float* w, float* z, int* ldz, float* work, int* info);
    public void Chpgv(int* itype, byte* jobz, byte* uplo, int* n, void* ap, void* bp, float* w, void* z, int* ldz, void* work, float* rwork, int* info);
    public void Dspgv(int* itype, byte* jobz, byte* uplo, int* n, double* ap, double* bp, double* w, double* z, int* ldz, double* work, int* info);
    public void Zhpgv(int* itype, byte* jobz, byte* uplo, int* n, void* ap, void* bp, double* w, void* z, int* ldz, void* work, double* rwork, int* info);

    // Generalized symmetric eigenvalue problems (band matrices) - simple drivers
    public void Ssbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, float* ab, int* ldab, float* bb, int* ldbb, float* w, float* z, int* ldz, float* work, int* info);
    public void Chbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, void* ab, int* ldab, void* bb, int* ldbb, float* w, void* z, int* ldz, void* work, float* rwork, int* info);
    public void Dsbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, double* ab, int* ldab, double* bb, int* ldbb, double* w, double* z, int* ldz, double* work, int* info);
    public void Zhbgv(byte* jobz, byte* uplo, int* n, int* ka, int* kb, void* ab, int* ldab, void* bb, int* ldbb, double* w, void* z, int* ldz, void* work, double* rwork, int* info);

    // Generalized nonsymmetric eigenvalue problems - Schur factorization
    public void Sgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<float*, float*, float*, int> selctg, int* n, float* a, int* lda, float* b, int* ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int* ldvsl, float* vsr, int* ldvsr, float* work, int* lwork, int* bwork, int* info);
    public void Cgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<void*, void*, int> selctg, int* n, void* a, int* lda, void* b, int* ldb, int* sdim, void* alpha, void* beta, void* vsl, int* ldvsl, void* vsr, int* ldvsr, void* work, int* lwork, float* rwork, int* bwork, int* info);
    public void Dgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<double*, double*, double*, int> selctg, int* n, double* a, int* lda, double* b, int* ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int* ldvsl, double* vsr, int* ldvsr, double* work, int* lwork, int* bwork, int* info);
    public void Zgges(byte* jobvsl, byte* jobvsr, byte* sort, delegate* unmanaged[Cdecl]<void*, void*, int> selctg, int* n, void* a, int* lda, void* b, int* ldb, int* sdim, void* alpha, void* beta, void* vsl, int* ldvsl, void* vsr, int* ldvsr, void* work, int* lwork, double* rwork, int* bwork, int* info);

    // Generalized nonsymmetric eigenvalue problems - eigenvalues/vectors
    public void Sggev(byte* jobvl, byte* jobvr, int* n, float* a, int* lda, float* b, int* ldb, float* alphar, float* alphai, float* beta, float* vl, int* ldvl, float* vr, int* ldvr, float* work, int* lwork, int* info);
    public void Cggev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* b, int* ldb, void* alpha, void* beta, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, float* rwork, int* info);
    public void Dggev(byte* jobvl, byte* jobvr, int* n, double* a, int* lda, double* b, int* ldb, double* alphar, double* alphai, double* beta, double* vl, int* ldvl, double* vr, int* ldvr, double* work, int* lwork, int* info);
    public void Zggev(byte* jobvl, byte* jobvr, int* n, void* a, int* lda, void* b, int* ldb, void* alpha, void* beta, void* vl, int* ldvl, void* vr, int* ldvr, void* work, int* lwork, double* rwork, int* info);

    // Generalized singular value decomposition
    public void Sggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, float* a, int* lda, float* b, int* ldb, float* alpha, float* beta, float* u, int* ldu, float* v, int* ldv, float* q, int* ldq, float* work, int* iwork, int* info);
    public void Cggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, void* a, int* lda, void* b, int* ldb, float* alpha, float* beta, void* u, int* ldu, void* v, int* ldv, void* q, int* ldq, void* work, float* rwork, int* iwork, int* info);
    public void Dggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, double* a, int* lda, double* b, int* ldb, double* alpha, double* beta, double* u, int* ldu, double* v, int* ldv, double* q, int* ldq, double* work, int* iwork, int* info);
    public void Zggsvd(byte* jobu, byte* jobv, byte* jobq, int* m, int* n, int* p, int* k, int* l, void* a, int* lda, void* b, int* ldb, double* alpha, double* beta, void* u, int* ldu, void* v, int* ldv, void* q, int* ldq, void* work, double* rwork, int* iwork, int* info);
}