use std::fs::read_to_string;

const PATH: &str = "file.txt";

fn print_and_get_content(path: &str) -> String {
    let content_result = read_to_string(path);

    return content_result
    // if let Ok(content) = content_result {
    //     println!("{}", content);
    //     return content
    // } else {
    //     return "EMPTY".to_string()
    // }
}

fn main() {
    let content = print_and_get_content(PATH);

    println!("{}", content);
}
