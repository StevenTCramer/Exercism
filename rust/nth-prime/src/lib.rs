use std::convert::TryFrom;

pub fn nth(n: u32) -> u32 {
    let n: usize = usize::try_from(n).unwrap();

    let mut primes = vec![2, 3, 5, 7, 11];
    // even numbers are not prime so can go up by 2
    // also only need to go up half way actually sqrt of n way.

    if n < primes.len() {
        return primes[n];
    }

    let mut possible_prime = primes.last().unwrap() + 2;

    while primes.len() <= n {
        let mut x = 3;
        let mut is_factor = false;

        let upperbound = (possible_prime as f32).sqrt() as usize + 1;
        while x < upperbound && !is_factor {
            is_factor = (possible_prime as usize) % x == 0;
            x += 1;
        }

        if !is_factor {
            primes.push(possible_prime);
        } 
        possible_prime += 2;
    }
    primes[n]
}
