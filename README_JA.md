# BlasSharp
 BLAS/LAPACK bindings for .NET (OpenBLAS, MKL, Apple Accelerate)

[![Releases](https://img.shields.io/github/release/nuskey8/BlasSharp.svg)](https://github.com/nuskey8/BlasSharp/releases)
[![GitHub license](https://img.shields.io/github/license/nuskey8/BlasSharp.svg)](./LICENSE)

[English]((./README.md)) | 日本語

## 概要

BlasSharpは.NET向けにBLAS/LAPACKのバインディングを提供するライブラリです。

BLAS/LAPACKはIntelやAppleなどから各種CPUに最適化されたライブラリが提供されています。これらのライブラリをC#に持ち込むことで、最適なパフォーマンスで線形計算を行うことが可能になります。

## 使い方

各種ライブラリに対応したパッケージをインストールすることでバインディングが利用可能になります。以下はOpenBLASを用いたサンプルです。

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

## IBlasOperations

BlasSharp.SharedパッケージではBLASのメソッドを抽象化する`IBlasOperations`を提供しており、それぞれのパッケージで実装が用意されています。

```cs
public interface IBlasOperations : IBlasLevel1, IBlasLevel2, IBlasLevel3
{
}

public unsafe interface IBlasLevel1
{
    void Saxpy(int n, float alpha, float* x, int incX, float* y, int incY);
    void Daxpy(int n, double alpha, double* x, int incX, double* y, int incY);
    void Caxpy(int n, void* alpha, void* x, int incX, void* y, int incY);
    void Zaxpy(int n, void* alpha, void* x, int incX, void* y, int incY);

    ...
}
```

## OpenBLAS

[![NuGet](https://img.shields.io/nuget/v/BlasSharp.OpenBlas.svg)](https://www.nuget.org/packages/BlasSharp.OpenBlas)

[BlasSharp.OpenBlas](https://www.nuget.org/packages/BlasSharp.OpenBlas/)をプロジェクトに追加することで、OpenBlasのバイナリとバインディングが利用可能になります。

BlasSharp.OpenBlasは各種プラットフォーム(`win-x64`, `osx-x64`, `osx-arm64`, `linux-x64`, `linux-arm64`)に対応しています。

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

[BlasSharp.Mkl](https://www.nuget.org/packages/BlasSharp.Mkl/)をプロジェクトに追加することで、IntelのMKLのバインディングが利用可能になります。

### .NET CLI

```ps1
dotnet add package BlasSharp.Mkl
```

### Package Manager

```ps1
Install-Package BlasSharp.Mkl
```

MKLを利用するには、Intel公式が提供するMKLのNuGetパッケージ(e.g. `intelmkl.devel.win-x64`)をインストールする必要があります。詳細は[MKLのダウンロードページ](https://www.intel.com/content/www/us/en/developer/tools/oneapi/onemkl-download.html?operatingsystem=windows&windows-install=nuget)を参照してください。

## Accelerate (Apple)

[![NuGet](https://img.shields.io/nuget/v/BlasSharp.AppleAccelerate.svg)](https://www.nuget.org/packages/BlasSharp.AppleAccelerate)

[BlasSharp.AppleAccelerate](https://www.nuget.org/packages/BlasSharp.AppleAccelerate/)をプロジェクトに追加することで、AppleのAccelerateのバインディングが利用可能になります。

BlasSharp.AppleAccelerateは`osx-arm64`のみに対応しています。

### .NET CLI

```ps1
dotnet add package BlasSharp.AppleAccelerate
```

### Package Manager

```ps1
Install-Package BlasSharp.AppleAccelerate
```

## ライセンス

このライブラリは[MITライセンス](./LICENSE)の下に公開されています。