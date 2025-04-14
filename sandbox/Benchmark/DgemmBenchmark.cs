using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BlasSharp;

namespace Benchmark;

public unsafe class DgemmBenchmark
{
    const int Size = 1024;

    double[] A, B, C;

    [GlobalSetup]
    public void Setup()
    {
        A = new double[Size * Size];
        B = new double[Size * Size];
        C = new double[Size * Size];

        var rand = new Random(0x1234);
        for (int i = 0; i < A.Length; i++) A[i] = rand.NextDouble();
        for (int i = 0; i < B.Length; i++) B[i] = rand.NextDouble();
    }

    [Benchmark]
    public void ForLoop()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                double sum = 0;
                for (int k = 0; k < Size; k++)
                {
                    sum += A[i * Size + k] * B[k * Size + j];
                }
                C[i * Size + j] = sum;
            }
        }
    }

    [Benchmark]
    public void AppleAccelerate()
    {
        fixed (double* aPtr = A, bPtr = B, cPtr = C)
        {
            BlasSharp.AppleAccelerate.NativeMethods.cblas_dgemm(
                CBLAS_ORDER.CblasRowMajor, CBLAS_TRANSPOSE.CblasNoTrans, CBLAS_TRANSPOSE.CblasNoTrans,
                Size, Size, Size,
                1.0, aPtr, Size,
                bPtr, Size,
                0.0, cPtr, Size
            );
        }
    }

    [Benchmark]
    public void OpenBlas()
    {
        fixed (double* aPtr = A, bPtr = B, cPtr = C)
        {
            BlasSharp.OpenBlas.NativeMethods.cblas_dgemm(
                CBLAS_ORDER.CblasRowMajor, CBLAS_TRANSPOSE.CblasNoTrans, CBLAS_TRANSPOSE.CblasNoTrans,
                Size, Size, Size,
                1.0, aPtr, Size,
                bPtr, Size,
                0.0, cPtr, Size
            );
        }
    }
}