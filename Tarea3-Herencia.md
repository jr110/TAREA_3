# Tarea 3 - Herencia
## 1.  Define: Clase Base, Clase Derivada. 
### Clase Base:
Puede decirse que este tipo de clase es una clase que no depende de otras para su funcionamiento, osease, que no esta heredada y
cuenta con sus propias propiedades, que en caso de quererse, se pueden hacer clases heredadas de esta o clases derivadas.
### Clase Derivada: 
Son las clases cuyas propiedades (al menos una) provienen de otras clases.
##  2.  Haz un diagrama UML donde se muestre la relación de herencia entre las  clases Figura, Recangulo y Circulo como vimos en clase.
![UML](https://github.com/jr110/TAREA_3/blob/master/Imagenes/UML%20BIEN.png)
 
 ## 3.Indica cuales son las clases base y las derivadas.
 + Las clases base son: Figura.
 + Las clases Derivadas son: Circulo y rectangulo.
 
 ## 4. ¿Que es herencia simple y herencia múltiple? ¿En c# se puede hacer herencia múltiple?
 
+ Herencia simple es cuando una clase hereda a una unica clase.
+ Herencia multiple es cuando una clase hereda a mas de una clase.
+ Si se puede hacer herencia multiple en c#.
## 5. Escribe el programa de Figura como vimos en clase, donde agregues varios tipos de figuras a una lista y recorre la lista llamando a un metodo de las figuras, además :
###  5.1 Se sobrecarguen los constructores y se acceda a los constructores de la clase base 

### 5.2 Explica para que nos sirve la palabra base
Nos sirve para llamar miembros de una clase a otra. Por ejemplo, nos sirve para pasar un constructor de una clase principal a otra.

### 5.3  Haz el método Dibuja() que sea virtual y redefinelo en solo una de las clases derivadas.
Link de programa : https://github.com/jr110/TAREA_3/blob/master/Programa%20figuras/Program.cs
