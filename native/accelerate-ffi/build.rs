fn main() {
    println!("cargo:rustc-link-lib=framework=Accelerate");

    let sdk = std::process::Command::new("xcrun")
        .args("--sdk macosx --show-sdk-path".split(" "))
        .output()
        .expect("failed to execute xcrun");

    let sdk_root = String::from_utf8_lossy(&sdk.stdout);

    bindgen::Builder::default()
        .generate_inline_functions(true)
        .header("headers/blas.h")
        .clang_arg(format!("-isysroot{}", sdk_root.trim())) // add xcode as clang sys-root
        .generate()
        .unwrap()
        .write_to_file("src/accelerate.rs")
        .unwrap();

    csbindgen::Builder::default()
        .input_bindgen_file("src/accelerate.rs")
        .method_filter(|x| x.starts_with("cblas_") || x.starts_with("appleblas_") || x.starts_with("sparse_"))
        .rust_file_header("use super::accelerate::*;")
        .rust_method_prefix("ffi_")
        .csharp_entry_point_prefix("")
        .csharp_method_prefix("")
        .csharp_namespace("BlasSharp.AppleAccelerate")
        .csharp_dll_name("/System/Library/Frameworks/Accelerate.framework/Accelerate")
        .csharp_class_accessibility("public")
        .generate_to_file(
            "src/accelerate_ffi.rs",
            "../../src/BlasSharp.AppleAccelerate/NativeMethods.CBLAS.g.cs",
        )
        .unwrap();
}