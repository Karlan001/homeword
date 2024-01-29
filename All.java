/*
public class Main4 {
public static void main(String[] args) {
int length = 10;
char c1 = 'a';
char c2 = 'b';
System.out.println(builder(length, c1, c2));


}
static String builder (int length, char c1, char c2){
StringBuilder result = new StringBuilder();
for (int i = 0; i < length; i++) {
if(i % 2 == 0){
result.append(c1);
} else {
result.append(c2);
}
}
return result.toString();
}
}
 */

/*
public class Main5 {
public static void main(String[] args) {
String start_str = "aaaabbbcdd";
System.out.println(compact(start_str));

}
static String compact (String string){
StringBuilder sb = new StringBuilder();
int count = 1;
for (int i = 1; i < string.length(); i++) {
if (string.charAt(i) == string.charAt(i - 1)){
count++;
} else if (count > 1) {
sb.append(string.charAt(i-1)).append(count);
count = 1;
} else {
sb.append(string.charAt(i-1));
count = 1;
}
if (i == string.length() - 1){
sb.append(string.charAt(i-1)).append(count);
}
}
return sb.toString();
}
}
 */

/*
/Напишите метод, который сжимает строку.
//Пример: вход aaaabbbcdd.
//Результат: a4b3cd2
public class Main02 {
public static void main(String[] args) {
String s = "aabbbbbccccd";
System.out.println(zip(s));
}
static String zip(String s){
StringBuilder sb = new StringBuilder();
int count = 1;
for (int i = 1; i < s.length(); i++) {
if (s.charAt(i) == s.charAt(i - 1)){
count++;
}
else{
sb.append(s.charAt(i-1));
if (count > 1){
sb.append(count);
}
count = 1;
}
}
sb.append(s.charAt(s.length()-1));
if (count > 1){
sb.append(count);
}
return sb.toString();
}
}
 */

/*
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;
import java.util.logging.FileHandler;
import java.util.logging.Handler;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

/*
Напишите метод, который составит строку, состоящую из 100 повторений слова TEST
и метод, который запишет эту строку в простой текстовый файл, обработайте исключения.

public class Main4 {
    static Logger logger = Logger.getAnonymousLogger();

    public static void main(String[] args) {
        String s = "test";
        String filePath = "src/lesson2/seminar/test.txt";
        String logPath = "src/lesson2/seminar/log.txt";
        int n = 10;

        createLogger(logPath);

        String s1 = repeat(s, n);
        writeToFile(s1, filePath);
        System.out.println("Конец программы");

        closeLogger();
    }

    static void createLogger(String logPath){
        try {
            FileHandler fh = new FileHandler(logPath, true);
            SimpleFormatter simpleFormatter = new SimpleFormatter();
            fh.setFormatter(simpleFormatter);
            logger.addHandler(fh);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    static void closeLogger(){
        Handler[] handlers = logger.getHandlers();
        for (Handler handler: handlers){
            handler.close();
        }
    }

    static void writeToFile(String s, String filePath) {
        try (FileWriter fileWriter = new FileWriter(filePath, true)){
            fileWriter.write(s);
            fileWriter.write("\n");
            logger.info("Запись в файл была успешна");
        } catch (IOException e) {
            logger.warning("Не удалось записать текст в файл");
            e.printStackTrace();
        }
    }

    static String readFile(String filePath){
        StringBuilder stringBuilder = new StringBuilder();
        File file = new File(filePath);
        try (Scanner scanner = new Scanner(file)){
            while (scanner.hasNext()){
                stringBuilder.append(scanner.nextLine());
            }
        } catch (IOException e){
            e.printStackTrace();
        }
        return stringBuilder.toString();
    }

    static String repeat(String s, int n){
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++) {
            sb.append(s);
            sb.append(" ");
        }
        return sb.toString();
    }
}

*/