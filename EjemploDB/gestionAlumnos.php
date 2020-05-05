<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestion Alumnos</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

</head>
<body>
    
    <?php
        include 'menu.php';
    ?>
    <h1 style="margin:20px 0px 10px 40px">Lista estudiantes</h1>

    <table class="table table-dark" style="margin:20px 40px 10px 40px">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Cédula</th>
      <th scope="col">Nombre</th>
      <th scope="col">Correo</th>
      <th scope="col">Código curso</th>
      <th scope="col" colspan=2>Acciones</th>
    </tr>
  </thead>
  <tbody>


  <?php

        $con = new mysqli("localhost", "root", "", "tecnologicox");
        if($con->connect_error){
            echo "Error en la conexión: " . $con->connect_error;
            exit();
        }
        $q = "select * from alumnos";
        if($data=$con->query($q)){
            $i=1;
            while($fila=$data->fetch_object()){
                echo "<tr>";
                echo "<th scope='row'>$i</th>";
                echo "<td>$fila->cedula</td>";
                echo "<td>$fila->nombre</td>";
                echo "<td>$fila->correo</td>";
                echo "<td>$fila->codigocurso</td>";
                echo "<td><button type='button' class='btn btn-primary'>Actualizar</button></td>";
                echo "<td><button type='button' class='btn btn-danger'>Borrar</button><td>";
                echo "</tr>";
                $i++;
            }
        }else{
            echo "error en la consulta de informacion";
        }
        ?>


  </tbody>
</table>

<button type="button" class="btn btn-info">Agregar alumno</button>


    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>