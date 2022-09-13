# Critica

La clase AppointmentService no debería de validar si cada dato es correcto. Debería existir una clase concreta para validar los datos ingresados. Solo se debería recibir los datos del paciente y el doctor.
Para validar los datos pienso que se deberían validar por separado, ya que los datos del doctor y paciente no son los mismos. De uno solo se requiere nombre y especialidad, y del otro la gran mayoría de sus datos personales.
También se debería hacer clases separadas para ingresar datos del doctor y del paciente. 
El identificador puede ser un int static que se vaya sumando cada vez que se cree una cita ese día.
También crear una nueva clase llamada lugarfecha para que se valide y después se cree un lugar y una fecha para la cita. De manera que primero validemos con una clase y luego lo creamos.
