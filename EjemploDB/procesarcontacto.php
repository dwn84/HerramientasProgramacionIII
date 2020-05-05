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
    
    
    <div class="container">


    <?php
       
        $con = new mysqli("localhost", "root", "", "tecnologicox");
        if($con->connect_error){
            echo "
             <div class='alert alert-danger' role='alert'>
                Ha ocurrido un error: $con->connect_error
            </div>";
            exit();
        }
        echo "
            <div class='alert alert-primary' role='alert'>
                 Alumno guardado satisfactoriamente
            </div>
            ";
        //$this->connection->query($query);
        $query = "insert into alumnos values('$_REQUEST[txtCed]','$_REQUEST[txtNom]','$_REQUEST[txtCor]','$_REQUEST[txtCur]')";
        $con->query($query);
        $con->close();
       
    ?>

    </div>


    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    
    </body>
    </html>
