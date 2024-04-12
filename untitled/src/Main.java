import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Main {
    static Persona p1, p2, p3;
    public static void main(String[] args) {
        Period periodo;
        DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        p1 = new Persona();
        p1.nombre = "Pablo";
        p1.fechaNac =  LocalDate.parse("15/08/1990", fmt);
        periodo = Period.between(p1.fechaNac, p1.ahora);

        System.out.println(p1.nombre+ " tiene " + periodo.getYears() + " años");


        p2 = new Persona("Ernesto", LocalDate.parse("10/08/2007", fmt));

        periodo = Period.between(p2.fechaNac, p1.ahora);


        System.out.println(p2.nombre+ " tiene " + periodo.getYears() + " años");


        p3 = new Persona("Juan");
        p3.fechaNac = LocalDate.parse("19/10/2013", fmt);

        periodo = Period.between(p3.fechaNac, p1.ahora);

        System.out.println(p3.nombre+ " tiene " + periodo.getYears() + " años");
    }
}