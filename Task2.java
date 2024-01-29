import java.io.FileWriter;
import java.io.IOException;
import java.sql.Array;
import java.sql.Timestamp;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.Arrays;

public class Task2 {
    public static FileWriter fl;
    public static void main(String[] args) {
        int[] arr = new int[]{1, 2, 3, 4, 10, 7, 6, 8, 9, 5};
        createLog();
        newarr(arr);
        cancelLog();
    }
    static void newarr(int[] arr) { // Сортировка пузырьком
        int temp = 0;
            for (int i = arr.length - 1; i >= 0; i--) {  //Внешний цикл
                for (int j = 0; j < i; j++) {       //Внутренний цикл
                    if (arr[j] > arr[j + 1]) {               // Проверка елементов
                        temp = arr[j];                      // Елемент с идексом j кладем в временноую переменную
                        arr[j] = arr[j + 1];                   // Меняем местами элементы
                        arr[j + 1] = temp;  // Присваеваем элементу значение временной переменной
                    }

                }
                log(Arrays.toString(arr));
            }
    }
    static void log(String str){ // Запись данных в файл
        LocalDate date = LocalDate.now();
        LocalTime time = LocalTime.now();
        try {
            fl.write(String.valueOf(date) + " ");
            fl.write(String.valueOf(time.getHour()) + ':');
            fl.write(String.valueOf(time.getMinute()) + " ");
            fl.write(str);
            fl.write("\n");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
    static void cancelLog(){ // Закрытие файла
        try {
            fl.flush();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
    static void createLog(){ // Открытие файла для записи
        try {
            fl = new FileWriter("/Users/ivanandreev/Documents/Уроки Java/untitled/seminar2/src/test.txt");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
