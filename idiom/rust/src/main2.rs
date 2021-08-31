use std::fs::read_to_string;

const PATH: &str = "file.txt";

fn print_and_get_content(path: &str) -> Result<String, std::io::Error> {
    let content_result = read_to_string(path);

    match content_result {
        Ok(content) => {
            println!("{}", content);
            return Ok(content)
        },
        Err(error) => return Err(error),
    }
}

fn main() {
    let content = print_and_get_content(PATH);

    match content {
        Ok(content) => println!("{}", content),
        Err(error) => println!("oops ! {}", error),
    }
}
