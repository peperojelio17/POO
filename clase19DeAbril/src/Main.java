import java.util.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    static int nper = 3;
    static Persona p2;
    static List<Persona> personas =  new ArrayList<>();
    static List<Persona> menores =  new ArrayList<>();


    static Persona mayor() {
        Persona m = personas.get(0);

        for (int i = 0; i<nper; i ++){
            if(personas.get(i).edad() > m.edad()) {
                m = personas.get(i);
            }
        }
        return m;
    }
    static List <Persona> menor(){
        menores = personas;

        for (int i = 0; i < nper; i++) {
            for (int j = 1; j < (nper - i); j++) {
                if (menores.get(j - 1).edad() > menores.get(j).edad()) {
                    Collections.swap(menores, j-1, j);
                }
            }

        }
        return menores;
    }

    public static int promedio(){
        int num;
        int suma = 0;
        for (int i = 0; i<nper; i ++){
            p2 = personas.get(i);
            num = p2.edad();
            suma += num;
        }
        suma = suma/nper;
        return suma;
    }
    public static void main(String[] args) {


        Scanner lectura = new Scanner(System.in);



        for (int i = 0; i<nper; i ++){
            System.out.println("Ingrese su nombre: ");

            String nombre = lectura.next();

            System.out.println("Ingrese su fecha de nacimiento: ");

            String edad = lectura.next();
            p2 = new Persona(nombre,edad );
            personas.add(p2);
        }

        for (int i = 0; i<nper; i ++){
            p2 = personas.get(i);
            System.out.println(p2.nombre+ " tiene " + p2.edad() + " años");
        }

        System.out.println("La persona de mayor edad es " + mayor().nombre);
        for(int i = 0; i< 2; i ++){
            System.out.println( menor().get(i).nombre + " no es la persona con mayor edad");
        }

        int promedio = promedio();
        System.out.println( "El promedio de las edades es " + promedio);


    }
}