import java.time.LocalDate;public class Persona {    String nombre;    LocalDate fechaNac;    LocalDate ahora; // 01/01/2000    public Persona(){   //Constructor. Te das cuenta de que es un constructor porque tienen el mismo nombre que la clase        ahora = LocalDate.now();    }    public Persona(String s, LocalDate e ){    //Aca hay variables locales        nombre = s;        fechaNac = e;    }    public Persona(String s){   //Constructor        nombre = s;    }}