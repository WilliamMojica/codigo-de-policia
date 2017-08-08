using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigodePolicia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a nuestra pagina de sanciones del Codigo de Policia");
            Console.WriteLine();
            Console.WriteLine("En este sitio web podras encontrar las diferentes sanciones " +
                "por tipo desde el 1 hasta el 4 cada una con sus diferentes saciones y multas" +
                "en cada una de ellas encontraras los motivos por lo cual la policia te puede imponer una sanción.");
            Console.WriteLine();


            int i1 = 0;
            string s1 = null;


            do
            {
                Console.WriteLine("Elija la Multa por su tipo\n" +
                "\n1.- Multa Tipo 1" +
                "\n2.- Multa Tipo 2" +
                "\n3.- Multa Tipo 3" +
                "\n4.- Multa Tipo 4" );
                Console.WriteLine(); 

                i1 = Convert.ToInt16(Console.ReadLine());

                switch (i1)
                {
                    case 1:
                        Console.WriteLine("Tipo 1 ");
                        Console.WriteLine();
                        Console.WriteLine("multa de $98.360");
                        Console.WriteLine("por realizar comportamientos prohividos como: ");
                        Console.WriteLine("-obstruir las manifestaciones de afecto y cariño que no" +
                            " configuren actos sexuales en razón de la raza, origen nacional o familiar," +
                            " orientación sexual, identidad de género u otra condición similar.");
                        Console.WriteLine("-inducir a los niños a utilizar indebidamente las" +
                            " telecomunicaciones o sistemas de emergencia.");
                        Console.WriteLine("-No recoger el excremento de su mascota" +
                            " o después de recogidos dejarlos abandonados en espacio público o áreas comunes.");
                        Console.WriteLine("-Obstruir la ciclo ruta o carril exclusivo para las bicicletas.");
                        Console.WriteLine("Ingresar y salir de las estaciones de transporte público " +
                            "masivo por sitios distintos a las puertas destinadas para el efecto.");

                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("este tipo de multa permite que usted pague la multa" +
                            "realizando actividades pedagogicas, participar en actividades comunitarias");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Este tipo de multa no tiene porcentaje de descuento por proto pago.");
                        Console.WriteLine();

                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Tipo 2");
                        Console.WriteLine();
                        Console.WriteLine("multa de $196.720");
                        Console.WriteLine("por realizar comportamientos prohividos como: ");
                        Console.WriteLine();
                        Console.WriteLine("- incitar o incurrir en confrontaciones" +
                            " violentas que puedan derivar en agresiones físicas.");

                        Console.WriteLine("-Lanzar objetos que puedan causar daño " +
                            "sustancias peligrosas a personas.");

                        Console.WriteLine("-Amenazar con causar daño físico a personas por cualquier medio.");

                        Console.WriteLine("-Portar armas, elementos cortantes, punzantes o semejantes," +
                            " o sustancias peligrosas en áreas comunes o lugares abiertos al público.");

                        Console.WriteLine("Irrespetar a las autoridades de Policía.");

                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("este tipo de multa permite que usted pague la multa" +
                            "realizando actividades pedagogicas, participar en actividades comunitarias");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Este tipo de multa no tiene porcentaje de descuento por proto pago.");
                        Console.WriteLine();

                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Tipo 3");
                        Console.WriteLine();
                        Console.WriteLine("multa de $393.440");
                        Console.WriteLine("por realizar comportamientos prohividos como: ");
                        Console.WriteLine();
                        Console.WriteLine("- Realizar en espacio público actos sexuales o " +
                            "de exhibicionismo que generen molestia a la comunidad.");

                        Console.WriteLine("-Perturbar o permitir que se afecte el sosiego en el vecindario" +
                            " por altos ruidos, fiestas, reuniones cuando afecten la tranquilidad de las personas.");

                        Console.WriteLine("-Agredir físicamente a personas por cualquier medio.");

                        Console.WriteLine("-Poner en riesgo a personas o bienes durante la instalación, " +
                            "utilización, mantenimiento o modificación de las estructuras de los servicios públicos.");

                        Console.WriteLine("Modificar o alterar redes o instalaciones de servicios públicos.");

                        Console.WriteLine("Tener animales silvestres en calidad de mascotas.");

                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("este tipo de actos no permite que usted pague la multa con actividades sociales");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("pueden llegar a tener un descuento del 50%, siempre y cuando" +
                            " los ciudadanos la cancelen dentro de los cinco días hábiles siguientes " +
                            "a la imposición del comparendo ");
                        Console.WriteLine();

                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Tipo 4");
                        Console.WriteLine();
                        Console.WriteLine("multa de $$786.880");
                        Console.WriteLine("por realizar comportamientos prohividos como: ");
                        Console.WriteLine();
                        Console.WriteLine("- Arrojar a los alcantarillados cualquier tipo de" +
                            "escombro, liquido o lodo que pueda obstruir el normal funcionamiento" +
                            "del mismo.");

                        Console.WriteLine("-fabricación, almacenamiento, comercialización," +
                            " transporte, distribución entre otras acciones que impliquen" +
                            " el uso de artículos pirotécnicos y sustancias peligrosas.");

                        Console.WriteLine("-Tener, almacenar, facilitar, distribuir o expender bebidas " +
                            "alcohólicas, drogas o sustancias prohibidas dentro de una institución o " +
                            "centro educativo.");

                        Console.WriteLine("-Todo desacato, resistencia, obstaculización," +
                            " negarse a dar información veraz sobre residencia a autoridades de Policía..");

                        Console.WriteLine("Agresión o poner en peligro a las autoridades de policía.");

                        Console.WriteLine("Ejercer la prostitución por fuera de lo establecido en la normatividad" +
                            " vigente para los establecimientos según zonas, horarios asignados por la ley para eso.");

                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("este tipo de actos no permite que usted pague la multa con actividades sociales");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("pueden llegar a tener un descuento del 50%, siempre y cuando" +
                            " los ciudadanos la cancelen dentro de los cinco días hábiles siguientes " +
                            "a la imposición del comparendo ");
                        Console.WriteLine();

                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("¿Desea continuar viendo otros tipos de sanción? (S/N)");
                s1 = Console.ReadLine();
            } while (s1 == "S" || s1 == "s");
        }
        
    }
}
