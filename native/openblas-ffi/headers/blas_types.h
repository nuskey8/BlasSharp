
typedef int blasint;
typedef struct
{
    unsigned long x[2];
} xdouble;

#define OPENBLAS_COMPLEX_STRUCT
typedef struct
{
    float real, imag;
} openblas_complex_float;
typedef struct
{
    double real, imag;
} openblas_complex_double;
typedef struct
{
    xdouble real, imag;
} openblas_complex_xdouble;

#define openblas_make_complex_float(real, imag) {(real), (imag)}
#define openblas_make_complex_double(real, imag) {(real), (imag)}
#define openblas_make_complex_xdouble(real, imag) {(real), (imag)}
