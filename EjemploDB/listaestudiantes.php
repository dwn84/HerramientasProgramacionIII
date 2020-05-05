<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Listado de alumnos</h1>
    <table border=1>
        <tr>
            <th>Cedula</th>
            <th>Nombre</th>
            <th>Correo</th>
            <th>Curso</th>
        </tr>

        <?php

        $con = new mysqli("localhost", "root", "", "tecnologicox");
        if($con->connect_error){
            echo "Error en la conexión: " . $con->connect_error;
            exit();
        }
        $q = "select * from alumnos";
        if($data=$con->query($q)){
            while($fila=$data->fetch_object()){
                echo "<tr>";
                echo "<td>$fila->cedula</td>";
                echo "<td>$fila->nombre</td>";
                echo "<td>$fila->correo</td>";
                echo "<td>$fila->codigocurso</td>";
                echo "</tr>";
            }
        }else{
            echo "error en la consulta de informacion";
        }
        ?>

    </table>
</body>
</html>