pub fn verse(n: u32) -> String {
    match n {
        0 => format!("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall."),
        1 => format!("1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n"),
        2 => format!("2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n"),
        _ => format!("{} bottles of beer on the wall, {} bottles of beer.\nTake one down and pass it around, {} bottles of beer on the wall.\n", n.to_string(), n.to_string(), (n-1).to_string())
    }
}

pub fn sing(start: u32, end: u32) -> String {
    let mut song: String = "".to_owned();
    for i in (end..=start).rev()  {
        let v = verse(i);
        song.push_str(v.as_str());
        if i != end || i == 0
        {
            song.push_str("\n");
        }
    }
    song
}
