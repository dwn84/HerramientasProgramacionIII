<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestion Alumnos</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

    <script src="js/all.js"></script>



</head>
<body>
    
    <?php
        include 'menu.php';
    ?>
    
    
    <div class="container">


    <h1><i class="far fa-address-book"></i> Lista estudiantes</h1>

    <table class="table table-dark" >
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Cédula</th>
      <th scope="col">Nombre</th>
      <th scope="col">Correo</th>
      <th scope="col">Código curso</th>
      <th scope="col">Foto</th>
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
                $curso11 = '';
                $curso22 = '';
                $curso33 = '';
                switch($fila->codigocurso){
                    case '11':
                        $curso11 = 'selected';
                        break;
                    case '22':
                        $curso22 = 'selected';
                        break;
                    case '33':
                        $curso33 = 'selected';
                        break;
                }
                echo "<td><img src='$fila->foto' width='20%'></td>";
                echo "<td><button type='button' class='btn btn-primary'  data-toggle='modal' data-target='#editarAlumno$fila->cedula'>Actualizar</button></td>";
                echo "<td><button type='button' class='btn btn-danger' data-toggle='modal' data-target='#borrarAlumno$fila->cedula' ><i class='far fa-trash-alt'></i> Borrar</button><td>";
                echo "</tr>";
                $i++;

                //modal de edicion de alumno
                echo "
                <div class='modal fade' id='editarAlumno$fila->cedula' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                <div class='modal-dialog' role='document'>
                  <div class='modal-content'>
                    <div class='modal-header'>
                      <h5 class='modal-title' id='exampleModalLabel'>Editar alumno: $fila->cedula</h5>
                      <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                        <span aria-hidden='true'>&times;</span>
                      </button>
                    </div>
                    <div class='modal-body'>
                    <form action='editarAlumno.php' method='post'>
                    <div class='form-group row'>
                          <label class='col-sm-4 col-form-label'>Cedula</label>
                          <div class='col-sm-8'>
                              <input type='text' name='txtCed' id='' required class='form-control' value='$fila->cedula'>
                          </div>
                    </div>
              
                    <div class='form-group row'>
                          <label class='col-sm-4 col-form-label'>Nombre</label>
                          <div class='col-sm-8'>
                              <input type='text' name='txtNom' id='' required class='form-control' value='$fila->nombre'>
                          </div>
                    </div>
              
                    <div class ='form-group row'>
                          <label class='col-sm-4 col-form-label'>Correo electrónico</label>
                          <div class='col-sm-8'>
                              <input type='email' name='txtCor' id='' required class='form-control' value='$fila->correo'>
                          </div>
                    </div>
                    <div class='form-group row'>
                          <label class='col-sm-4 col-form-label'>Curso</label>
                          <div class='col-sm-8'>
                              <select name='txtCur' id='' required class='custom-select'>
                                  <option value='11' $curso11>PHP</option>
                                  <option value='22' $curso22>JavaScript</option>
                                  <option value='33' $curso33>C#</option>
                              </select>

                              <input type ='hidden' name ='txtcedoriginal' value='$fila->cedula'>
                          </div>
                    </div>
                      
                      
              
                    </div>
              
                  
                    <div class='modal-footer'>
                      <input type='reset' class='btn btn-warning' value='Limpiar'>
                      <button type='button' class='btn btn-secondary' data-dismiss='modal'>Cerrar</button>
                      <input type='submit' class='btn btn-primary' value='Enviar'>
              
                    </div>
                    </form>
                  </div>
                </div>
              </div>
                ";

                 //modal de borrar
                 echo "
                 <div class='modal fade' id='borrarAlumno$fila->cedula' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                 <div class='modal-dialog' role='document'>
                   <div class='modal-content'>
                     <div class='modal-header'>
                       <h5 class='modal-title' id='exampleModalLabel'>Borrar alumno: $fila->cedula</h5>
                       <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                         <span aria-hidden='true'>&times;</span>
                       </button>
                     </div>
                     <div class='modal-body'>
                     ¿Esta seguro que desea borrar al alumno?
                     <form action='borrarAlumno.php' method='post'>
                     
                     <input type ='hidden' name ='txtCed' value='$fila->cedula'>

                       
               
                     </div>
               
                   
                     <div class='modal-footer'>
                       <button type='button' class='btn btn-secondary' data-dismiss='modal'>No</button>
                       <input type='submit' class='btn btn-danger' value='Si'>
               
                     </div>
                     </form>
                   </div>
                 </div>
               </div>
                 ";
            }
        }else{
            echo "error en la consulta de informacion";
        }
        ?>


  </tbody>
</table>

<button type="button" class="btn btn-info" data-toggle="modal" data-target="#agregarAlumno">Agregar alumno</button>

    
  </div>




<!-- Modal de agregar Alumno-->
<div class="modal fade" id="agregarAlumno" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Agregar nuevo alumno</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
      <form action="agregarAlumno.php" method="post" enctype="multipart/form-data">
      <div class="form-group row">
            <label class="col-sm-4 col-form-label">Cedula</label>
            <div class="col-sm-8">
                <input type="text" name="txtCed" id="" required class="form-control">
            </div>
      </div>

      <div class="form-group row">
            <label class="col-sm-4 col-form-label">Nombre</label>
            <div class="col-sm-8">
                <input type="text" name="txtNom" id="" required class="form-control">
            </div>
      </div>

      <div class="form-group row">
            <label class="col-sm-4 col-form-label">Correo electrónico</label>
            <div class="col-sm-8">
                <input type="email" name="txtCor" id="" required class="form-control">
            </div>
      </div>
      <div class="form-group row">
            <label class="col-sm-4 col-form-label">Curso</label>
            <div class="col-sm-8">
                <select name="txtCur" id="" required class="custom-select">
                    <option value="11">PHP</option>
                    <option value="22">JavaScript</option>
                    <option value="33">C#</option>
                </select>
            </div>
      </div>


      <div class="form-group row">
            <label class="col-sm-4 col-form-label">Subir foto</label>
            <div class="col-sm-8">
                <div class="custom-file">
                    <input type="file" name = "txtImg"  class="custom-file-input" id="txtImg" required>
                    <label class="custom-file-label" for="validatedCustomFile">Seleccione una imagen...</label>
                    <div class="invalid-feedback">Archivo invalido</div>
                </div>
            </div>
      </div>



      
        
        

      </div>

    
      <div class="modal-footer">
        <input type="reset" class="btn btn-warning" value="Limpiar">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
        <input type="submit" class="btn btn-primary" value="Enviar">

      </div>
      </form>
    </div>
  </div>
</div>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>