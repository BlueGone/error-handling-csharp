import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class Main {
    private static String PATH = "file.txt";

    private static String printAndGetContent(String path) throws IOException {
        String content = Files.readString(Path.of(path));

        System.out.println(content);

        return content;
    }

    public static void main(String[] args) {
        try {
            String content = printAndGetContent(PATH);
            System.out.println(content);
        } catch (IOException e) {
            System.err.printf("Oops ! %s", e);
        }
    }
}
