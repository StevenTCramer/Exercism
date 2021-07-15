pub fn square_of_sum(n: u32) -> u32 {
    let x = n * (n + 1) / 2;
    x * x
    // let x: u32 = (1..=n).sum();
    // x * x
}

pub fn sum_of_squares(n: u32) -> u32 {
    n* (n+1)*(2*n+1)/6
    // (1..=n).map(|x| x * x).sum()
}

pub fn difference(n: u32) -> u32 {
    square_of_sum(n) - sum_of_squares(n)
}
