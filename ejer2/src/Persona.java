import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Persona {
    String nombre;
    LocalDate fechaNac;
    LocalDate ahora;
    Period periodo;
    private DateTimeFormatter fmt;
    // 01/01/2000

public int edad(){
    ahora = LocalDate.now(); // now es un metodo de la clase LocalDate
    periodo = Period.between(fechaNac, ahora);
    return periodo.getYears();
}
    public Persona(String nombre, String fechaNacimiento ){
        fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");//Aca hay variables locales
        this.nombre = nombre;
        this.fechaNac = LocalDate.parse(fechaNacimiento, fmt);

    }
}