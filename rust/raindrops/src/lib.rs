pub fn raindrops(n: u32) -> String {
    let pling = "Pling";
    let plang = "Plang";
    let plong = "Plong";

    let mut result = String::new();

    if n % 3 == 0 {
        result.push_str(pling)
    }

    if n % 5 == 0 {
        result.push_str(plang)
    }

    if n % 7 == 0 {
        result.push_str(plong)
    }

    if result.is_empty() {
        result.push_str(&n.to_string())
    }

    result
}
