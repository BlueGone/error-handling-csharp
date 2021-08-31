use std::fs::read_to_string;

const PATH: &str = "file.txt";

fn print_and_get_content(path: &str) -> Result<String, std::io::Error> {
    let content = read_to_string(path)?;

    println!("{}", content);

    return Ok(content)
}

fn main() {
    let content = print_and_get_content(PATH);

    match content {
        Ok(content) => println!("{}", content),
        Err(error) => println!("oops ! {}", error),
    }
}
