# Small Library
 Erick Benítez

Desarrollo de Backend y Login App Small Library --- El contenido del README detalla lo desarrollado hasta el momento

Hola buen dia.

He desarrollado las siguientes funcionalidades, las cuales cada una de ellas se han probado y validado su funcionamiento con Postman:

Backend:

Desarrollo de la Base de Datos usando Code First con Entity Framework

Desarrollo del Backend en C# .Net Framework

Enpoints desarrollados, funcionales y probados en Postman
- Crear estudiante
   - Nombre del enpoint: Create
    
- Consultando libros por autor, genero y titulo
   - Nombre del enpoint: GetSearchCriteria,
    
- Agregar Nuevos Libros 
   - Nombre del enpoint: Create
    
- Buscar estudiantes que tengan libros prestados(Función para el Bibliotecario) y Estudiantes obtienen su lista personal de libros prestados.
   - Nombre del enpoint: GetReservasByUserId,
   
- Devolución de libros prestados 
    - Nombre del enpoint: Devolucion

- Ver listado de libros existentes en la biblioteca 
    - Nombre del enpoint: GetAll
    
- Ver historico de libros prestados. 
    - Nombre del enpoint: GetReservasByUserId
    
-  Reserva de libro para tomarlo prestado 
    - Nombre del enpoint: CreateReserva

- Login de la aplicación
    - Nombre del enpoint: Login
    
    
Servicios creados:
   - Actualización de stock después de reservar un libro (Se resta la cantidad prestada al stock)

   - Actualización de stock después de la devolución de libros (Se suma la cantidad devuelta al stock)



-- FrontEnd
- Funcionalidades desarrolladas:

- Desarrollo de Login usando angular

---------------------------------------------
    - Pendiente del FrontEnd: 
      - Agregar Nuevos Usuarios 
      - Agregar Nuevos Libros 
      - Buscar personas que tengan libros prestados
