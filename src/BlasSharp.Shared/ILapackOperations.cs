namespace BlasSharp;

public interface ILapackOperations : ILapackDriverRoutines, ILapackComputationalRoutines, ILapackAuxiliaryRoutines
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
    public void Sgees(byte* jobvs, byte* sort, void* select, int* n, float* a, int* lda, int* sdim, float* wr, float* wi, float* vs, int* ldvs, float* work, int* lwork, int* bwork, int* info);
    public void Cgees(byte* jobvs, byte* sort, void* select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, float* rwork, int* bwork, int* info);
    public void Dgees(byte* jobvs, byte* sort, void* select, int* n, double* a, int* lda, int* sdim, double* wr, double* wi, double* vs, int* ldvs, double* work, int* lwork, int* bwork, int* info);
    public void Zgees(byte* jobvs, byte* sort, void* select, int* n, void* a, int* lda, int* sdim, void* w, void* vs, int* ldvs, void* work, int* lwork, double* rwork, int* bwork, int* info);

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

public unsafe interface ILapackComputationalRoutines
{
    // Linear equations - General matrix
    public void Sgetrf(int* m, int* n, float* a, int* lda, int* ipiv, int* info);
    public void Cgetrf(int* m, int* n, void* a, int* lda, int* ipiv, int* info);
    public void Dgetrf(int* m, int* n, double* a, int* lda, int* ipiv, int* info);
    public void Zgetrf(int* m, int* n, void* a, int* lda, int* ipiv, int* info);

    public void Sgetrs(byte* trans, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);
    public void Cgetrs(byte* trans, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info);
    public void Dgetrs(byte* trans, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);
    public void Zgetrs(byte* trans, int* n, int* nrhs, void* a, int* lda, int* ipiv, void* b, int* ldb, int* info);

    public void Sgecon(byte* norm, int* n, float* a, int* lda, float* anorm, float* rcond, float* work, int* iwork, int* info);
    public void Cgecon(byte* norm, int* n, void* a, int* lda, float* anorm, float* rcond, void* work, float* rwork, int* info);
    public void Dgecon(byte* norm, int* n, double* a, int* lda, double* anorm, double* rcond, double* work, int* iwork, int* info);
    public void Zgecon(byte* norm, int* n, void* a, int* lda, double* anorm, double* rcond, void* work, double* rwork, int* info);

    public void Sgerfs(byte* trans, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgerfs(byte* trans, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgerfs(byte* trans, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgerfs(byte* trans, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info);

    public void Sgetri(int* n, float* a, int* lda, int* ipiv, float* work, int* lwork, int* info);
    public void Cgetri(int* n, void* a, int* lda, int* ipiv, void* work, int* lwork, int* info);
    public void Dgetri(int* n, double* a, int* lda, int* ipiv, double* work, int* lwork, int* info);
    public void Zgetri(int* n, void* a, int* lda, int* ipiv, void* work, int* lwork, int* info);

    public void Sgeequ(int* m, int* n, float* a, int* lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info);
    public void Cgeequ(int* m, int* n, void* a, int* lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info);
    public void Dgeequ(int* m, int* n, double* a, int* lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info);
    public void Zgeequ(int* m, int* n, void* a, int* lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info);

    // Linear equations - General band matrix
    public void Sgbtrf(int* m, int* n, int* kl, int* ku, float* ab, int* ldab, int* ipiv, int* info);
    public void Cgbtrf(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, int* info);
    public void Dgbtrf(int* m, int* n, int* kl, int* ku, double* ab, int* ldab, int* ipiv, int* info);
    public void Zgbtrf(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, int* info);

    public void Sgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, int* ipiv, float* b, int* ldb, int* info);
    public void Cgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info);
    public void Dgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, int* ipiv, double* b, int* ldb, int* info);
    public void Zgbtrs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, int* ipiv, void* b, int* ldb, int* info);

    public void Sgbcon(byte* norm, int* n, int* kl, int* ku, float* ab, int* ldab, int* ipiv, float* anorm, float* rcond, float* work, int* iwork, int* info);
    public void Cgbcon(byte* norm, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, float* anorm, float* rcond, void* work, float* rwork, int* info);
    public void Dgbcon(byte* norm, int* n, int* kl, int* ku, double* ab, int* ldab, int* ipiv, double* anorm, double* rcond, double* work, int* iwork, int* info);
    public void Zgbcon(byte* norm, int* n, int* kl, int* ku, void* ab, int* ldab, int* ipiv, double* anorm, double* rcond, void* work, double* rwork, int* info);

    public void Sgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, float* ab, int* ldab, float* afb, int* ldafb, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, double* ab, int* ldab, double* afb, int* ldafb, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgbrfs(byte* trans, int* n, int* kl, int* ku, int* nrhs, void* ab, int* ldab, void* afb, int* ldafb, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info);

    public void Sgbequ(int* m, int* n, int* kl, int* ku, float* ab, int* ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info);
    public void Cgbequ(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax, int* info);
    public void Dgbequ(int* m, int* n, int* kl, int* ku, double* ab, int* ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info);
    public void Zgbequ(int* m, int* n, int* kl, int* ku, void* ab, int* ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax, int* info);

    // Linear equations - General tridiagonal matrix  
    public void Sgttrf(int* n, float* dl, float* d, float* du, float* du2, int* ipiv, int* info);
    public void Cgttrf(int* n, void* dl, void* d, void* du, void* du2, int* ipiv, int* info);
    public void Dgttrf(int* n, double* dl, double* d, double* du, double* du2, int* ipiv, int* info);
    public void Zgttrf(int* n, void* dl, void* d, void* du, void* du2, int* ipiv, int* info);

    public void Sgttrs(byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int* ldb, int* info);
    public void Cgttrs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* du2, int* ipiv, void* b, int* ldb, int* info);
    public void Dgttrs(byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int* ldb, int* info);
    public void Zgttrs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* du2, int* ipiv, void* b, int* ldb, int* info);

    public void Sgtcon(byte* norm, int* n, float* dl, float* d, float* du, float* du2, int* ipiv, float* anorm, float* rcond, float* work, int* iwork, int* info);
    public void Cgtcon(byte* norm, int* n, void* dl, void* d, void* du, void* du2, int* ipiv, float* anorm, float* rcond, void* work, int* info);
    public void Dgtcon(byte* norm, int* n, double* dl, double* d, double* du, double* du2, int* ipiv, double* anorm, double* rcond, double* work, int* iwork, int* info);
    public void Zgtcon(byte* norm, int* n, void* dl, void* d, void* du, void* du2, int* ipiv, double* anorm, double* rcond, void* work, int* info);

    public void Sgtrfs(byte* trans, int* n, int* nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cgtrfs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dgtrfs(byte* trans, int* n, int* nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zgtrfs(byte* trans, int* n, int* nrhs, void* dl, void* d, void* du, void* dlf, void* df, void* duf, void* du2, int* ipiv, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info);

    // Linear equations - Symmetric/Hermitian positive definite matrix
    public void Spotrf(byte* uplo, int* n, float* a, int* lda, int* info);
    public void Cpotrf(byte* uplo, int* n, void* a, int* lda, int* info);
    public void Dpotrf(byte* uplo, int* n, double* a, int* lda, int* info);
    public void Zpotrf(byte* uplo, int* n, void* a, int* lda, int* info);

    public void Spotrs(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);
    public void Cpotrs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info);
    public void Dpotrs(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info);
    public void Zpotrs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* b, int* ldb, int* info);

    public void Spocon(byte* uplo, int* n, float* a, int* lda, float* anorm, float* rcond, float* work, int* iwork, int* info);
    public void Cpocon(byte* uplo, int* n, void* a, int* lda, float* anorm, float* rcond, void* work, float* rwork, int* info);
    public void Dpocon(byte* uplo, int* n, double* a, int* lda, double* anorm, double* rcond, double* work, int* iwork, int* info);
    public void Zpocon(byte* uplo, int* n, void* a, int* lda, double* anorm, double* rcond, void* work, double* rwork, int* info);

    public void Sporfs(byte* uplo, int* n, int* nrhs, float* a, int* lda, float* af, int* ldaf, float* b, int* ldb, float* x, int* ldx, float* ferr, float* berr, float* work, int* iwork, int* info);
    public void Cporfs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, void* b, int* ldb, void* x, int* ldx, float* ferr, float* berr, void* work, float* rwork, int* info);
    public void Dporfs(byte* uplo, int* n, int* nrhs, double* a, int* lda, double* af, int* ldaf, double* b, int* ldb, double* x, int* ldx, double* ferr, double* berr, double* work, int* iwork, int* info);
    public void Zporfs(byte* uplo, int* n, int* nrhs, void* a, int* lda, void* af, int* ldaf, void* b, int* ldb, void* x, int* ldx, double* ferr, double* berr, void* work, double* rwork, int* info);

    public void Spotri(byte* uplo, int* n, float* a, int* lda, int* info);
    public void Cpotri(byte* uplo, int* n, void* a, int* lda, int* info);
    public void Dpotri(byte* uplo, int* n, double* a, int* lda, int* info);
    public void Zpotri(byte* uplo, int* n, void* a, int* lda, int* info);

    public void Spoequ(int* n, float* a, int* lda, float* s, float* scond, float* amax, int* info);
    public void Cpoequ(int* n, void* a, int* lda, float* s, float* scond, float* amax, int* info);
    public void Dpoequ(int* n, double* a, int* lda, double* s, double* scond, double* amax, int* info);
    public void Zpoequ(int* n, void* a, int* lda, double* s, double* scond, double* amax, int* info);

    // Orthogonal factorizations - QR factorization
    public void Sgeqrf(int* m, int* n, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cgeqrf(int* m, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dgeqrf(int* m, int* n, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zgeqrf(int* m, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Sgeqp3(int* m, int* n, float* a, int* lda, int* jpvt, float* tau, float* work, int* lwork, int* info);
    public void Cgeqp3(int* m, int* n, void* a, int* lda, int* jpvt, void* tau, void* work, int* lwork, float* rwork, int* info);
    public void Dgeqp3(int* m, int* n, double* a, int* lda, int* jpvt, double* tau, double* work, int* lwork, int* info);
    public void Zgeqp3(int* m, int* n, void* a, int* lda, int* jpvt, void* tau, void* work, int* lwork, double* rwork, int* info);

    public void Sorgqr(int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cungqr(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dorgqr(int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zungqr(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Sormqr(byte* side, byte* trans, int* m, int* n, int* k, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* lwork, int* info);
    public void Cunmqr(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info);
    public void Dormqr(byte* side, byte* trans, int* m, int* n, int* k, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* lwork, int* info);
    public void Zunmqr(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info);

    // Symmetric eigenproblem - tridiagonal reduction
    public void Ssytrd(byte* uplo, int* n, float* a, int* lda, float* d, float* e, float* tau, float* work, int* lwork, int* info);
    public void Chetrd(byte* uplo, int* n, void* a, int* lda, float* d, float* e, void* tau, void* work, int* lwork, int* info);
    public void Dsytrd(byte* uplo, int* n, double* a, int* lda, double* d, double* e, double* tau, double* work, int* lwork, int* info);
    public void Zhetrd(byte* uplo, int* n, void* a, int* lda, double* d, double* e, void* tau, void* work, int* lwork, int* info);

    public void Sorgtr(byte* uplo, int* n, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cungtr(byte* uplo, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dorgtr(byte* uplo, int* n, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zungtr(byte* uplo, int* n, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Sormtr(byte* side, byte* uplo, byte* trans, int* m, int* n, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* lwork, int* info);
    public void Cunmtr(byte* side, byte* uplo, byte* trans, int* m, int* n, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info);
    public void Dormtr(byte* side, byte* uplo, byte* trans, int* m, int* n, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* lwork, int* info);
    public void Zunmtr(byte* side, byte* uplo, byte* trans, int* m, int* n, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* lwork, int* info);

    // Symmetric tridiagonal eigenvalues
    public void Ssteqr(byte* compz, int* n, float* d, float* e, float* z, int* ldz, float* work, int* info);
    public void Csteqr(byte* compz, int* n, float* d, float* e, void* z, int* ldz, float* work, int* info);
    public void Dsteqr(byte* compz, int* n, double* d, double* e, double* z, int* ldz, double* work, int* info);
    public void Zsteqr(byte* compz, int* n, double* d, double* e, void* z, int* ldz, double* work, int* info);

    public void Ssterf(int* n, float* d, float* e, int* info);
    public void Dsterf(int* n, double* d, double* e, int* info);

    public void Sstedc(byte* compz, int* n, float* d, float* e, float* z, int* ldz, float* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Cstedc(byte* compz, int* n, float* d, float* e, void* z, int* ldz, void* work, int* lwork, float* rwork, int* lrwork, int* iwork, int* liwork, int* info);
    public void Dstedc(byte* compz, int* n, double* d, double* e, double* z, int* ldz, double* work, int* lwork, int* iwork, int* liwork, int* info);
    public void Zstedc(byte* compz, int* n, double* d, double* e, void* z, int* ldz, void* work, int* lwork, double* rwork, int* lrwork, int* iwork, int* liwork, int* info);

    // Nonsymmetric eigenproblem - Hessenberg reduction
    public void Sgehrd(int* n, int* ilo, int* ihi, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cgehrd(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dgehrd(int* n, int* ilo, int* ihi, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zgehrd(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Sorghr(int* n, int* ilo, int* ihi, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cunghr(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dorghr(int* n, int* ilo, int* ihi, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zunghr(int* n, int* ilo, int* ihi, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Shseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, float* h, int* ldh, float* wr, float* wi, float* z, int* ldz, float* work, int* lwork, int* info);
    public void Chseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, void* h, int* ldh, void* w, void* z, int* ldz, void* work, int* lwork, int* info);
    public void Dhseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, double* h, int* ldh, double* wr, double* wi, double* z, int* ldz, double* work, int* lwork, int* info);
    public void Zhseqr(byte* job, byte* compz, int* n, int* ilo, int* ihi, void* h, int* ldh, void* w, void* z, int* ldz, void* work, int* lwork, int* info);

    // Singular value decomposition - bidiagonal reduction
    public void Sgebrd(int* m, int* n, float* a, int* lda, float* d, float* e, float* tauq, float* taup, float* work, int* lwork, int* info);
    public void Cgebrd(int* m, int* n, void* a, int* lda, float* d, float* e, void* tauq, void* taup, void* work, int* lwork, int* info);
    public void Dgebrd(int* m, int* n, double* a, int* lda, double* d, double* e, double* tauq, double* taup, double* work, int* lwork, int* info);
    public void Zgebrd(int* m, int* n, void* a, int* lda, double* d, double* e, void* tauq, void* taup, void* work, int* lwork, int* info);

    public void Sorgbr(byte* vect, int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* lwork, int* info);
    public void Cungbr(byte* vect, int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info);
    public void Dorgbr(byte* vect, int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* lwork, int* info);
    public void Zungbr(byte* vect, int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* lwork, int* info);

    public void Sbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, float* d, float* e, float* vt, int* ldvt, float* u, int* ldu, float* c, int* ldc, float* work, int* info);
    public void Cbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, float* d, float* e, void* vt, int* ldvt, void* u, int* ldu, void* c, int* ldc, float* work, int* info);
    public void Dbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, double* d, double* e, double* vt, int* ldvt, double* u, int* ldu, double* c, int* ldc, double* work, int* info);
    public void Zbdsqr(byte* uplo, int* n, int* ncvt, int* nru, int* ncc, double* d, double* e, void* vt, int* ldvt, void* u, int* ldu, void* c, int* ldc, double* work, int* info);
}

public unsafe interface ILapackAuxiliaryRoutines
{
    // Complex vector operations
    public void Clacgv(int* n, void* x, int* incx);
    public void Zlacgv(int* n, void* x, int* incx);

    // Matrix operations
    public void Clacrm(int* m, int* n, void* a, int* lda, float* b, int* ldb, void* c, int* ldc, float* rwork);
    public void Zlacrm(int* m, int* n, void* a, int* lda, double* b, int* ldb, void* c, int* ldc, double* rwork);

    public void Clacrt(int* n, void* cx, int* incx, void* cy, int* incy, void* c, void* s);
    public void Zlacrt(int* n, void* cx, int* incx, void* cy, int* incy, void* c, void* s);

    public void Crot(int* n, void* cx, int* incx, void* cy, int* incy, float* c, void* s);
    public void Zrot(int* n, void* cx, int* incx, void* cy, int* incy, double* c, void* s);

    public void Csrot(int* n, void* cx, int* incx, void* cy, int* incy, float* c, float* s);
    public void Zdrot(int* n, void* cx, int* incx, void* cy, int* incy, double* c, double* s);

    // Symmetric matrix operations
    public void Csymv(byte* uplo, int* n, void* alpha, void* a, int* lda, void* x, int* incx, void* beta, void* y, int* incy);
    public void Zsymv(byte* uplo, int* n, void* alpha, void* a, int* lda, void* x, int* incx, void* beta, void* y, int* incy);

    public void Csyr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* a, int* lda);
    public void Zsyr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* a, int* lda);

    public void Cspmv(byte* uplo, int* n, void* alpha, void* ap, void* x, int* incx, void* beta, void* y, int* incy);
    public void Zspmv(byte* uplo, int* n, void* alpha, void* ap, void* x, int* incx, void* beta, void* y, int* incy);

    public void Cspr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* ap);
    public void Zspr(byte* uplo, int* n, void* alpha, void* x, int* incx, void* ap);

    // Utility functions
    public int Ilaenv(int* ispec, byte* name, byte* opts, int* n1, int* n2, int* n3, int* n4);
    public int Lsame(byte* ca, byte* cb);
    public int Lsamen(int* n, byte* ca, byte* cb);

    public int Icmax1(int* n, void* cx, int* incx);
    public int Izmax1(int* n, void* cx, int* incx);

    public float Scsum1(int* n, void* cx, int* incx);
    public double Dzsum1(int* n, void* cx, int* incx);

    // Matrix copying
    public void Slacpy(byte* uplo, int* m, int* n, float* a, int* lda, float* b, int* ldb);
    public void Clacpy(byte* uplo, int* m, int* n, void* a, int* lda, void* b, int* ldb);
    public void Dlacpy(byte* uplo, int* m, int* n, double* a, int* lda, double* b, int* ldb);
    public void Zlacpy(byte* uplo, int* m, int* n, void* a, int* lda, void* b, int* ldb);

    // Matrix norms
    public float Slange(byte* norm, int* m, int* n, float* a, int* lda, float* work);
    public float Clange(byte* norm, int* m, int* n, void* a, int* lda, float* work);
    public double Dlange(byte* norm, int* m, int* n, double* a, int* lda, double* work);
    public double Zlange(byte* norm, int* m, int* n, void* a, int* lda, double* work);

    public float Slansy(byte* norm, byte* uplo, int* n, float* a, int* lda, float* work);
    public float Clansy(byte* norm, byte* uplo, int* n, void* a, int* lda, float* work);
    public float Clanhe(byte* norm, byte* uplo, int* n, void* a, int* lda, float* work);
    public double Dlansy(byte* norm, byte* uplo, int* n, double* a, int* lda, double* work);
    public double Zlansy(byte* norm, byte* uplo, int* n, void* a, int* lda, double* work);
    public double Zlanhe(byte* norm, byte* uplo, int* n, void* a, int* lda, double* work);

    public float Slantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, float* a, int* lda, float* work);
    public float Clantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, void* a, int* lda, float* work);
    public double Dlantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, double* a, int* lda, double* work);
    public double Zlantr(byte* norm, byte* uplo, byte* diag, int* m, int* n, void* a, int* lda, double* work);

    // Machine parameters
    public float Slamch(byte* cmach);
    public double Dlamch(byte* cmach);

    // Mathematical utilities
    public float Slapy2(float* x, float* y);
    public double Dlapy2(double* x, double* y);
    public float Slapy3(float* x, float* y, float* z);
    public double Dlapy3(double* x, double* y, double* z);

    // Matrix scaling
    public void Slascl(byte* type, int* kl, int* ku, float* cfrom, float* cto, int* m, int* n, float* a, int* lda, int* info);
    public void Clascl(byte* type, int* kl, int* ku, float* cfrom, float* cto, int* m, int* n, void* a, int* lda, int* info);
    public void Dlascl(byte* type, int* kl, int* ku, double* cfrom, double* cto, int* m, int* n, double* a, int* lda, int* info);
    public void Zlascl(byte* type, int* kl, int* ku, double* cfrom, double* cto, int* m, int* n, void* a, int* lda, int* info);

    // Matrix initialization
    public void Slaset(byte* uplo, int* m, int* n, float* alpha, float* beta, float* a, int* lda);
    public void Claset(byte* uplo, int* m, int* n, void* alpha, void* beta, void* a, int* lda);
    public void Dlaset(byte* uplo, int* m, int* n, double* alpha, double* beta, double* a, int* lda);
    public void Zlaset(byte* uplo, int* m, int* n, void* alpha, void* beta, void* a, int* lda);

    // Pivoting and permutation
    public void Slaswp(int* n, float* a, int* lda, int* k1, int* k2, int* ipiv, int* incx);
    public void Claswp(int* n, void* a, int* lda, int* k1, int* k2, int* ipiv, int* incx);
    public void Dlaswp(int* n, double* a, int* lda, int* k1, int* k2, int* ipiv, int* incx);
    public void Zlaswp(int* n, void* a, int* lda, int* k1, int* k2, int* ipiv, int* incx);

    public void Slapmt(int* forwrd, int* m, int* n, float* x, int* ldx, int* k);
    public void Clapmt(int* forwrd, int* m, int* n, void* x, int* ldx, int* k);
    public void Dlapmt(int* forwrd, int* m, int* n, double* x, int* ldx, int* k);
    public void Zlapmt(int* forwrd, int* m, int* n, void* x, int* ldx, int* k);

    // Householder reflectors
    public void Slarfg(int* n, float* alpha, float* x, int* incx, float* tau);
    public void Clarfg(int* n, void* alpha, void* x, int* incx, void* tau);
    public void Dlarfg(int* n, double* alpha, double* x, int* incx, double* tau);
    public void Zlarfg(int* n, void* alpha, void* x, int* incx, void* tau);

    public void Slarf(byte* side, int* m, int* n, float* v, int* incv, float* tau, float* c, int* ldc, float* work);
    public void Clarf(byte* side, int* m, int* n, void* v, int* incv, void* tau, void* c, int* ldc, void* work);
    public void Dlarf(byte* side, int* m, int* n, double* v, int* incv, double* tau, double* c, int* ldc, double* work);
    public void Zlarf(byte* side, int* m, int* n, void* v, int* incv, void* tau, void* c, int* ldc, void* work);

    // Plane rotations
    public void Slartg(float* f, float* g, float* cs, float* sn, float* r);
    public void Clartg(void* f, void* g, float* cs, void* sn, void* r);
    public void Dlartg(double* f, double* g, double* cs, double* sn, double* r);
    public void Zlartg(void* f, void* g, double* cs, void* sn, void* r);

    public void Slargv(int* n, float* x, int* incx, float* y, int* incy, float* c, int* incc);
    public void Clargv(int* n, void* x, int* incx, void* y, int* incy, float* c, void* s, int* incc);
    public void Dlargv(int* n, double* x, int* incx, double* y, int* incy, double* c, int* incc);
    public void Zlargv(int* n, void* x, int* incx, void* y, int* incy, double* c, void* s, int* incc);

    public void Slasr(byte* side, byte* pivot, byte* direct, int* m, int* n, float* c, float* s, float* a, int* lda);
    public void Clasr(byte* side, byte* pivot, byte* direct, int* m, int* n, float* c, float* s, void* a, int* lda);
    public void Dlasr(byte* side, byte* pivot, byte* direct, int* m, int* n, double* c, double* s, double* a, int* lda);
    public void Zlasr(byte* side, byte* pivot, byte* direct, int* m, int* n, double* c, double* s, void* a, int* lda);

    // Unblocked algorithms
    public void Sgetf2(int* m, int* n, float* a, int* lda, int* ipiv, int* info);
    public void Cgetf2(int* m, int* n, void* a, int* lda, int* ipiv, int* info);
    public void Dgetf2(int* m, int* n, double* a, int* lda, int* ipiv, int* info);
    public void Zgetf2(int* m, int* n, void* a, int* lda, int* ipiv, int* info);

    public void Spotf2(byte* uplo, int* n, float* a, int* lda, int* info);
    public void Cpotf2(byte* uplo, int* n, void* a, int* lda, int* info);
    public void Dpotf2(byte* uplo, int* n, double* a, int* lda, int* info);
    public void Zpotf2(byte* uplo, int* n, void* a, int* lda, int* info);

    public void Sgeqr2(int* m, int* n, float* a, int* lda, float* tau, float* work, int* info);
    public void Cgeqr2(int* m, int* n, void* a, int* lda, void* tau, void* work, int* info);
    public void Dgeqr2(int* m, int* n, double* a, int* lda, double* tau, double* work, int* info);
    public void Zgeqr2(int* m, int* n, void* a, int* lda, void* tau, void* work, int* info);

    // Generate orthogonal/unitary matrices
    public void Sorg2r(int* m, int* n, int* k, float* a, int* lda, float* tau, float* work, int* info);
    public void Cung2r(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* info);
    public void Dorg2r(int* m, int* n, int* k, double* a, int* lda, double* tau, double* work, int* info);
    public void Zung2r(int* m, int* n, int* k, void* a, int* lda, void* tau, void* work, int* info);

    // Multiply by orthogonal/unitary matrices
    public void Sorm2r(byte* side, byte* trans, int* m, int* n, int* k, float* a, int* lda, float* tau, float* c, int* ldc, float* work, int* info);
    public void Cunm2r(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* info);
    public void Dorm2r(byte* side, byte* trans, int* m, int* n, int* k, double* a, int* lda, double* tau, double* c, int* ldc, double* work, int* info);
    public void Zunm2r(byte* side, byte* trans, int* m, int* n, int* k, void* a, int* lda, void* tau, void* c, int* ldc, void* work, int* info);

    // Triangular matrix inversion
    public void Strti2(byte* uplo, byte* diag, int* n, float* a, int* lda, int* info);
    public void Ctrti2(byte* uplo, byte* diag, int* n, void* a, int* lda, int* info);
    public void Dtrti2(byte* uplo, byte* diag, int* n, double* a, int* lda, int* info);
    public void Ztrti2(byte* uplo, byte* diag, int* n, void* a, int* lda, int* info);

    // Random number generation
    public void Slarnv(int* idist, int* iseed, int* n, float* x);
    public void Clarnv(int* idist, int* iseed, int* n, void* x);
    public void Dlarnv(int* idist, int* iseed, int* n, double* x);
    public void Zlarnv(int* idist, int* iseed, int* n, void* x);
}