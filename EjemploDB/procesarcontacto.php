<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
       
        $con = new mysqli("localhost", "root", "", "tecnologicox");
        if($con->connect_error){
            echo "Error en la conexión: " . $con->connect_error;
            exit();
        }
        echo "Procesando ingreso del alumno...";
        //$this->connection->query($query);
        $query = "insert into alumnos values('$_REQUEST[txtCed]','$_REQUEST[txtNom]','$_REQUEST[txtCor]','$_REQUEST[txtCur]')";
        $con->query($query);
        $con->close();
        echo "<a href='listaestudiantes.php'>Listado de estudiantes</a>";
    ?>
</body> 
</html>