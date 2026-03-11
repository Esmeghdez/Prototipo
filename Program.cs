using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExam
{
    class Program
    {
            static void Main(string[] args)
            {
                ExamPrototype protoEspanol = new EspanolPrototype();
                ExamPrototype protoMatematicas = new MatematicasPrototype();
                ExamPrototype protoCiencias = new CienciasPrototype();
                ExamPrototype protoQuimica = new QuimicaPrototype();
                ExamPrototype protoSocial = new SocialPrototype();
                ExamPrototype protoFisica = new FisicaPrototype();
                ExamPrototype protoComputacion = new ComputacionPrototype();
                ExamPrototype protoIngles = new InglesPrototype();


            ExamPrototype ExamenE = protoEspanol.Clone();
            ExamenE.materia = "Español";
            ExamenE.modalidad = "Escrito";
            ExamenE.cantidad_preguntas = 10;
            ExamenE.aciertos = 8;
            ExamenE.maestro = "Melissa";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenM = protoMatematicas.Clone();
            ExamenE.materia = "Matematicas";
            ExamenE.modalidad = "Escrito";
            ExamenE.cantidad_preguntas = 15;
            ExamenE.aciertos = 5;
            ExamenE.maestro = "Martha";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenC = protoCiencias.Clone();
            ExamenE.materia = "Ciencias Naturales";
            ExamenE.modalidad = "En linea";
            ExamenE.cantidad_preguntas = 12;
            ExamenE.aciertos = 10;
            ExamenE.maestro = "Yessica";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenQ = protoQuimica.Clone();
            ExamenE.materia = "Quimica";
            ExamenE.modalidad = "En linea";
            ExamenE.cantidad_preguntas = 8;
            ExamenE.aciertos = 5;
            ExamenE.maestro = "Yomara";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenS = protoSocial.Clone();
            ExamenE.materia = "Sociales";
            ExamenE.modalidad = "Hibrido";
            ExamenE.cantidad_preguntas = 30;
            ExamenE.aciertos = 22;
            ExamenE.maestro = "Lucero";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenF = protoFisica.Clone();
            ExamenE.materia = "Fisica";
            ExamenE.modalidad = "Hibrido";
            ExamenE.cantidad_preguntas = 15;
            ExamenE.aciertos = 5;
            ExamenE.maestro = "Ivan";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenCom = protoComputacion.Clone();
            ExamenE.materia = "Computacion";
            ExamenE.modalidad = "En linea";
            ExamenE.cantidad_preguntas = 12;
            ExamenE.aciertos = 10;
            ExamenE.maestro = "Alejandro";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();

            ExamPrototype ExamenI = protoIngles.Clone();
            ExamenE.materia = "Ingles";
            ExamenE.modalidad = "En linea";
            ExamenE.cantidad_preguntas = 10;
            ExamenE.aciertos = 10;
            ExamenE.maestro = "Edwin";
            ExamenE.alumno = "Esmeralda";
            ExamenE.salon = "91L4";
            ExamenE.MostrarExamen();


            Console.ReadKey();
            }

            public abstract class ExamPrototype
        {
            protected string Materia;
            protected string Modalidad;
            protected int Cantidad_preguntas;
            protected int Aciertos;
            protected string Maestro;
            protected string Alumno;
            protected string Salon;

            public string materia { set => Materia = value; }
            public string modalidad { set => Modalidad = value; }
            public int cantidad_preguntas { set => Cantidad_preguntas = value; }
            public int aciertos { set => Aciertos = value; }
            public string maestro { set => Maestro = value; }
            public string alumno { set => Alumno = value; }
            public string salon { set => Salon = value; }


            public abstract ExamPrototype Clone();

            public abstract void MostrarExamen();
        }

        public class EspanolPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (EspanolPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a EspanolPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class MatematicasPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (MatematicasPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a MatematicasPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class CienciasPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (CienciasPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a CienciasPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class QuimicaPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (QuimicaPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a QuimicaPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class SocialPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (SocialPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a SocialPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class FisicaPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (FisicaPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a FisicaPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class ComputacionPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (ComputacionPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a ComputacionPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }
        public class InglesPrototype : ExamPrototype
        {
            public override ExamPrototype Clone()
            {
                return (InglesPrototype)this.MemberwiseClone();// devuelve una copia superficial del objeto y lo enviara a InglesPrototype
            }


            public override void MostrarExamen()
            {
                Console.WriteLine($"Materia: {Materia}");
                Console.WriteLine($"Modalidad: {Modalidad}");
                Console.WriteLine($"Cantidad de preguntas: {Cantidad_preguntas}");
                Console.WriteLine($"Aciertos: {Aciertos}");
                Console.WriteLine($"Maestro: {Maestro}");
                Console.WriteLine($"Alumno: {Alumno}");
                Console.WriteLine($"Salón: {Salon}");
                Console.WriteLine("");

            }
        }

    }
}
