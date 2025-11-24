## Encapsula lo que varía

trata de distinguir las partes del programa que se modifican y separarlas de aquellas que se mantienen constantes, con el fin de reducir al mínimo el efecto de los cambios

## Encapsulación a nivel del método

Consiste en extraer el código que varía dentro de un método y encapsularlo en métodos separados. Esto permite que el método principal se mantenga estable mientras que las variaciones se manejan en métodos específicos, facilitando el mantenimiento y la modificación del código

## Encapsulación a nivel de la clase

Se refiere a agrupar comportamientos relacionados que varían juntos en clases separadas. En lugar de tener múltiples condicionales o variaciones dentro de una misma clase, se crean clases específicas para cada variación, permitiendo que cada clase encapsule su propio comportamiento y facilitando la extensión del código sin modificar las clases existentes

## Favorece la composición sobre la herencia

Este principio sugiere que en lugar de usar herencia para reutilizar código y comportamientos, es mejor usar composición (tener objetos dentro de otros objetos). La composición ofrece mayor flexibilidad, ya que permite cambiar comportamientos en tiempo de ejecución y evita los problemas de acoplamiento rígido que puede generar la herencia. Permite construir objetos complejos combinando objetos más simples

## Programa a una interfaz, no a una implementación

Este principio indica que el código debe depender de abstracciones en lugar de depender de implementaciones concretas. Esto permite que el código sea más flexible y mantenible, ya que las implementaciones pueden cambiarse sin afectar el código que las utiliza, siempre y cuando respeten la interfaz definida

