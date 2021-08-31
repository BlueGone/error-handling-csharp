package main

import (
	"fmt"
	"io/ioutil"
)

var path = "file.txt"

func printAndGetContent(path string) string {
	content, _ := ioutil.ReadFile(path)
	fmt.Printf("%p", content)
	return string(content)
}

func main() {
	content := printAndGetContent(path)

	fmt.Printf("%s", content)
}
