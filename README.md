# Examen_RentaCar_BerneyJadierGomezSantana
Nombre: Berney Jadier Gomez Santana
Matricula: 2026-1831
Fecha: 11/19/26

Descripcion:
RentaCar Express es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Su propósito es registrar alquileres de vehículos y calcular el monto total que debe pagar cada cliente.

El programa permite agregar varios vehículos a un alquiler, seleccionar opciones adicionales, aplicar descuentos y calcular el ITBIS correspondiente.

Datos de entrega:

Nombre del cliente.

Fecha de salida.

Tipo de vehículo (se introduce manualmente).

Tarifa diaria del vehículo.

Cantidad de días de alquiler (de 1 a 30).

Tipo de seguro:

Básico (opción predeterminada).

Completo (+RD$300 por día).

GPS (opcional, +RD$100 por día).

Cliente corporativo (opcional).

Tipo de entrega:

En sucursal (opción predeterminada).

A domicilio (+RD$500).


Proceso:

1.Recibe los datos del cliente y del vehículo.

2.Calcula la tarifa diaria sumando RD$300 si el seguro es completo y RD$100 si se selecciona GPS.

3.Multiplica la tarifa diaria ajustada por la cantidad de días.

4.Acumula el subtotal de todos los vehículos agregados.

5.Aplica un descuento del 15% del subtotal si el cliente es corporativo.

6.Agrega RD$500 si se selecciona la entrega a domicilio.

7.Calcula la base imponible restando el descuento al subtotal y sumando el costo de entrega.

8.Calcula el ITBIS del 18% sobre la base imponible.

9.Calcula el total a pagar sumando la base imponible y el ITBIS.

Salida:

Lista de vehículos agregados al alquiler.

Cantidad de días de alquiler.

Nombre del vehículo y tipo de seguro.

Tarifa diaria ajustada.

Total correspondiente a cada vehículo.

Subtotal de los alquileres.

Descuento aplicado.

Costo de entrega a domicilio.

ITBIS del 18%.

Total final a pagar.

Capturas:





<img width="932" height="745" alt="image" src="https://github.com/user-attachments/assets/5f251884-236f-4a34-a750-c3421f24180e" />
<img width="917" height="741" alt="image" src="https://github.com/user-attachments/assets/692a96fb-35a9-494e-b4df-bda7266a92e3" />
<img width="917" height="741" alt="image" src="https://github.com/user-attachments/assets/ae160db2-9ff5-4ab3-ba7b-93d885636fe0" />



https://github.com/Jactu/Examen_RentaCar_BerneyJadierGomezSantana/tree/main

