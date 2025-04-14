fn main() {
    bindgen::Builder::default()
        .headers(["headers/mkl_cblas.h", "headers/mkl_lapack.h"])
        .generate()
        .unwrap()
        .write_to_file("src/mkl.rs")
        .unwrap();

    csbindgen::Builder::default()
        .input_bindgen_file("src/mkl.rs")
        .rust_method_prefix("ffi_")
        .csharp_entry_point_prefix("")
        .csharp_method_prefix("")
        .csharp_disable_emit_dll_name(true)
        .csharp_namespace("BlasSharp.Mkl")
        .csharp_class_accessibility("public")
        .rust_file_header("use super::mkl::*;")
        .method_filter(|x| method_filter(x))
        .generate_to_file(
            "src/mkl_ffi.rs",
            "../../src/BlasSharp.Mkl/NativeMethods.g.cs",
        )
        .unwrap();
}

fn method_filter(x: String) -> bool {
    if x.starts_with("cblas_") {
        return true;
    };
    if x.starts_with("mkl_") {
        return true;
    };
    if x.ends_with("_") && !x.chars().any(|x| x.is_uppercase()) {
        return true;
    };
    return false;
}
