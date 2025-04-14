fn main() {
    bindgen::Builder::default()
        .headers(["headers/cblas.h", "headers/lapack.h"])
        .generate()
        .unwrap()
        .write_to_file("src/openblas.rs")
        .unwrap();

    csbindgen::Builder::default()
        .input_bindgen_file("src/openblas.rs")
        .method_filter(|x| method_filter(x))
        .rust_file_header("use super::openblas::*;")
        .rust_method_prefix("ffi_")
        .csharp_entry_point_prefix("")
        .csharp_method_prefix("")
        .csharp_namespace("BlasSharp.OpenBlas")
        .csharp_dll_name("libopenblas")
        .csharp_class_accessibility("public")
        .generate_to_file(
            "src/openblas_ffi.rs",
            "../../src/BlasSharp.OpenBlas/NativeMethods.g.cs",
        )
        .unwrap();
}


fn method_filter(x: String) -> bool {
    if x.starts_with("cblas_") {
        return true;
    };
    if x.starts_with("openblas_") {
        return true;
    };
    if x.ends_with("_") && !x.chars().any(|x| x.is_uppercase()) {
        return true;
    };
    return false;
}
