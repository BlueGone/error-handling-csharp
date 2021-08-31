package main

import (
	"fmt"
	"io/ioutil"
)

var path = "file.txt"

func printAndGetContent(path string) (string, error) {
	content, err := ioutil.ReadFile(path)
	if err != nil {
		return "", err
	}
	fmt.Println(string(content))
	return string(content), nil
}

func main() {
	content, err := printAndGetContent(path)

	if err != nil {
		fmt.Printf("Oops ! %s", err)
		return
	}

	fmt.Printf("%s", content)
}
