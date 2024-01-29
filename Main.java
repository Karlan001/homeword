import java.io.FileWriter;
import java.io.IOException;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        String txt = "Test";
        String filepath = "/Users/ivanandreev/Documents/Уроки Java/untitled/seminar2/src/test.txt";
        try {
            FileWriter fl = new FileWriter(filepath);
            for (int i = 0; i < 10; i++) {
                fl.write(txt);
                fl.write("\n");
            }
            fl.close();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}