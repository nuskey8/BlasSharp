namespace BlasSharp;

public static class CBLAS_ORDER
{
    public const uint CblasRowMajor = 101;
    public const uint CblasColMajor = 102;
}

public static class CBLAS_TRANSPOSE
{
    public const uint CblasNoTrans = 111;
    public const uint CblasTrans = 112;
    public const uint CblasConjTrans = 113;
    public const uint AtlasConj = 114;
}

public static class CBLAS_UPLO
{
    public const uint CblasUpper = 121;
    public const uint CblasLower = 122;
}

public static class CBLAS_DIAG
{
    public const uint CblasNonUnit = 131;
    public const uint CblasUnit = 132;
}

public static class CBLAS_SIDE
{
    public const uint CblasLeft = 141;
    public const uint CblasRight = 142;
}