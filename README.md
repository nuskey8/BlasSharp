# BlasSharp
 BLAS/LAPACK bindings for .NET (OpenBLAS, MKL, Apple Accelerate)

[![Releases](https://img.shields.io/github/release/nuskey8/BlasSharp.svg)](https://github.com/nuskey8/BlasSharp/releases)  
[![GitHub license](https://img.shields.io/github/license/nuskey8/BlasSharp.svg)](./LICENSE)

English | [日本語](./README_JA.md)

## Overview

BlasSharp is a library that provides bindings to BLAS/LAPACK for .NET.

BLAS/LAPACK libraries optimized for various CPUs are provided by Intel, Apple, and others. By bringing these libraries into C#, you can perform linear algebra computations with optimal performance.

> [!CAUTION]
> This library is currently provided as an alpha version and may introduce breaking changes without notice.

## Usage

You can use the bindings by installing the package that corresponds to the desired library. Below is a sample using OpenBLAS:

```cs
using BlasSharp;
using static BlasSharp.OpenBlas.NativeMethods;

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

    fixed (double* a = A, b = B, c = C)
    {
        cblas_dgemm(CBLAS_ORDER.CblasColMajor,
            CBLAS_TRANSPOSE.CblasNoTrans,
            CBLAS_TRANSPOSE.CblasNoTrans,
            3, 3, 3, 1.0, a, 3, b, 3, 0.0, c, 3);
    }

    Console.WriteLine(string.Join(',', C));
}
```

## OpenBLAS

[![NuGet](https://img.shields.io/nuget/v/BlasSharp.OpenBlas.svg)](https://www.nuget.org/packages/BlasSharp.OpenBlas)

You can use the OpenBLAS binaries and bindings by adding [BlasSharp.OpenBlas](https://www.nuget.org/packages/BlasSharp.OpenBlas/) to your project.

BlasSharp.OpenBlas supports multiple platforms:  
`win-x64`, `osx-x64`, `osx-arm64`, `linux-x64`, and `linux-arm64`.

### .NET CLI

```ps1
dotnet add package BlasSharp.OpenBlas
```

### Package Manager

```ps1
Install-Package BlasSharp.OpenBlas
```

## MKL

[![NuGet](https://img.shields.io/nuget/v/BlasSharp.Mkl.svg)](https://www.nuget.org/packages/BlasSharp.Mkl)

You can use the bindings for Intel's MKL by adding [BlasSharp.Mkl](https://www.nuget.org/packages/BlasSharp.Mkl/) to your project.

### .NET CLI

```ps1
dotnet add package BlasSharp.Mkl
```

### Package Manager

```ps1
Install-Package BlasSharp.Mkl
```

To use MKL, you also need to install the official Intel MKL NuGet package (e.g., `intelmkl.devel.win-x64`).  
See the [MKL download page](https://www.intel.com/content/www/us/en/developer/tools/oneapi/onemkl-download.html?operatingsystem=windows&windows-install=nuget) for more details.

## Accelerate (Apple)

[![NuGet](https://img.shields.io/nuget/v/BlasSharp.AppleAccelerate.svg)](https://www.nuget.org/packages/BlasSharp.AppleAccelerate)

You can use the bindings for Apple’s Accelerate framework by adding [BlasSharp.AppleAccelerate](https://www.nuget.org/packages/BlasSharp.AppleAccelerate/) to your project.

BlasSharp.AppleAccelerate currently supports only `osx-arm64`.

### .NET CLI

```ps1
dotnet add package BlasSharp.AppleAccelerate
```

### Package Manager

```ps1
Install-Package BlasSharp.AppleAccelerate
```

## License

This library is released under the [MIT License]((./LICENSE)).