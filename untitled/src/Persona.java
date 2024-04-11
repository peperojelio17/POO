import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Persona {
    String nombre;
    int edad;
    DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
    LocalDate fechaNac;
    LocalDate ahora = LocalDate.now();

    Period periodo = Period.between(fechaNac, ahora);
    // 01/01/2000



    public Persona(){   //Constructor. Te das cuenta de que es un constructor porque tienen el mismo nombre que la clase

    }
    public Persona(String s, LocalDate e ){    //Aca hay variables locales
        nombre = s;

    }
    public Persona(String s){   //Constructor
        nombre = s;
    }
}