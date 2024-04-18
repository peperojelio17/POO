//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    static Persona p2;
    public static void main(String[] args) {

        p2 = new Persona("Ernesto","15/08/1990" ); // primero crea la instancia de la clase persona y luego hace el pasaje de parametros
        System.out.println(p2.nombre+ " tiene " + p2.edad() + " años");

    }
}