import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Main {
    static Persona p1, p2, p3;
    public static void main(String[] args) {
        //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
        // to see how IntelliJ IDEA suggests fixing it.
        DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        p1 = new Persona();
        p1.nombre = "Pablo";
        p1.fechaNac =  LocalDate.parse("15/08/1990", fmt);

        System.out.println(p1.nombre+ " tiene " + p1.periodo.getYears() + " años");


        //p2 = new Persona("Ernesto", );

        //System.out.println(p2.nombre+ " tiene " + p2.periodo.getYears() + " años");


        //p3 = new Persona("Juan");

        //System.out.printf("Tu edad es:" + periodo.getYears());


        //System.out.println(p3.nombre+ " tiene " + p3.periodo + " años");
    }
}