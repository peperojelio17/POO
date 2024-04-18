import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    static Persona p2;
    public static void main(String[] args) {

        List<Persona> personas =  new ArrayList<>();
        Scanner lectura = new Scanner(System.in);

        for (int i = 0; i<3; i ++){
            System.out.println("Ingrese su nombre: ");

            String nombre = lectura.next();

            System.out.println("Ingrese su fecha de nacimiento: ");

            String edad = lectura.next();
            p2 = new Persona(nombre,edad );
            personas.add(p2);
        }

        for (int i = 0; i<3; i ++){
            p2 = personas.get(i);
            System.out.println(p2.nombre+ " tiene " + p2.edad() + " años");
        }
        // es un objeto, y persona es una clase, una instancia es un espacio que se reserva
//        p2 = new Persona("Ernesto","15/08/1990" ); // primero crea la instancia de la clase persona y luego hace el pasaje de parametros
//        personas.add(p2);
//
//        p2 = new Persona("pablo","15/08/1890" );
//
//
//        p2 = new Persona("Alberto","15/08/1937" );
//        personas.add(p2);
//
//        p2 = new Persona("Marcos","15/08/1913" );
//        personas.add(p2);
//
//        p2 = personas.get(2);
//        System.out.println(p2.nombre+ " tiene " + p2.edad() + " años");

    }
}