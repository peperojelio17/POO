import java.util.ArrayList;
import java.util.List;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    static Persona p2;
    public static void main(String[] args) {

        List<Persona> personas =  new ArrayList<>();// En esta lista se guardan objetos de tipo persona
        // En las listas no guardan la información sino que guardn su ubicacion en la memo

        // personas[0] = ffff:90AA
        // personas[1] = fff:80F


        // es un objeto, y persona es una clase, una instancia es un espacio que se reserva
        p2 = new Persona("Ernesto","15/08/1990" ); // primero crea la instancia de la clase persona y luego hace el pasaje de parametros
        personas.add(p2);

        p2 = new Persona("pablo","15/08/1890" );


        p2 = new Persona("Alberto","15/08/1937" );
        personas.add(p2);

        p2 = new Persona("Marcos","15/08/1913" );
        personas.add(p2);

        p2 = personas.get(2);
        System.out.println(p2.nombre+ " tiene " + p2.edad() + " años");

    }
}