using System;
using System.Collections.Generic;

namespace Figura2
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
       
 
    abstract class Figura
    {
    protected Vector2d position;
        
        //constructor de figura
        public Figura(Vector2d position){
            this.position=position;
        }
          public Figura():this(new Vector2d(100,100)){

          }
           
        //Clase dibuja
       public virtual void Dibuja(){
           Console.WriteLine(" Se dibuja una figura en {0}",position);
       }
        
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }
     public new void Dibuja()
         {
             Console.WriteLine("Se dibuja un circulo en {0}",position);
         }
    }

    class Triangulo: Figura
    {
        public Triangulo(Vector2d pos):base(pos) {  
        }
        public Triangulo():base()  {  
        }  

        //Override de Clase figura
        public override void Dibuja()
         {
             Console.WriteLine("Se dibuja un rectangulo en {0}",position);
         }
    }
    class Rectangulo : Figura
    {

     public Rectangulo(Vector2d pos):base(pos) {
     }
     public Rectangulo ():base() {
        
     }   
     public new void Dibuja()
         {
             Console.WriteLine("Se dibuja un rectangulo en {0}",position);
         }
    }
    
        class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(new Vector2d(311,345),10));
            figuras.Add(new Rectangulo(new Vector2d(200,200)));
            figuras.Add(new Triangulo(new Vector2d(350,233)));
            foreach(Figura f in figuras)
            {
              f.Dibuja();
            }    
        }
    }
}