<?php

class mvcController{


    public function template(){
        
        if(isset($_GET["action"]) && $_GET["action"]=="servicioweb"){
            $respuesta = modelo::url("servicioweb");
            include $respuesta;
            exit;
        }

        include "views/template.php";
    }

    public function paginasController(){

            if(isset($_GET["action"])){
                $enlace = $_GET["action"];
            }
            else{
                $enlace = "inicio";
            }

            $respuesta = modelo::url($enlace);

            include $respuesta;


    }

    public function registrarusuarioController(){

        if(isset($_POST["txtUsuR"])){

            $info = array("usu"=>$_POST["txtUsuR"],
                           "ema"=>$_POST["txtEmaR"] ,
                           "con"=>md5($_POST["txtPasR"])
                            );
            $respuesta = datos::registrarUsuarioModel($info,"usuarios");

            if ($respuesta=="ok"){
                echo "<script>
                        alert('registro exitoso');
                        window.location.href = 'index.php?action=ingresar';
                    </script>";
            }

        }
    }

    public function ingresarUsuarioController(){
        if(isset($_POST["txtUsuI"])){
            $info = array("usu"=>$_POST["txtUsuI"],
                           "con"=>md5($_POST["txtPasI"])
                            );
        $respuesta = datos::ingresoUsuarioModel($info,"usuarios");

        if ($respuesta=="ok"){
            //activar acceso a la lista de usuarios
            $_SESSION['ingreso']=true;
            echo "<script>
                    alert('Bienvenido al sistema');
                    window.location.href = 'index.php?action=listar';
                </script>";
        }else{
            echo "<script>
            alert('Datos incorrectos');
            window.location.href = 'index.php?action=ingresar';
        </script>";

        }          

        }
    }

    public function listarUsuariosController(){

        $respuesta = datos::listarUsuariosModel("usuarios");
        $i = 1;
        while($fila=$respuesta->fetch_object()){
            echo "<tr>
                    <th scope='row'>$i</th>
                    <td>$fila->id</td>
                    <td>$fila->usuario</td>
                    <td>$fila->email</td>
                    <td><a href = index.php?action=editar&id=$fila->id><button type='button' class='btn btn-info'>Editar</button></a></td>
                    <td><button type='button' class='btn btn-danger'>Eliminar</button></td>
                </tr>";
            $i++;


        }


    }

    public function editarUsuarioController(){

        if(isset($_GET['id'])){
            $id = $_GET['id'];
            
            //llamar la modelo para obtener todos los datos correspondientes al id
            $respuesta = datos::editarUsuarioModel($id,"usuarios");
            echo "
            <form method='post'>
                <div class='form-group'>
                <div class='form-group'>
                    <label for='exampleInputPassword1'>Usuario</label>
                    <input type='text' class='form-control' name='txtUsuE' value='$respuesta[nombreUsu]' required>
                </div>
                <div class='form-group'>
                    <label for='exampleInputEmail1'>Email</label>
                    <input type='email' class='form-control' name='txtEmaE' value='$respuesta[emailUsu]' aria-describedby='emailHelp' required>
                </div>
                <div class='form-group'>
                    <label for='exampleInputPassword1'>Password Nuevo</label>
                    <input type='password' class='form-control' name='txtPasE' required>
                </div>
                <input type='hidden' name='txtIdE' value='$respuesta[idusuario]'>
                <button type='submit' class='btn btn-primary'>Actualizar</button>
            </form>
            ";

        }
    }

    public function actualizarUsuarioController(){
        if(isset($_POST["txtUsuE"])){
            $info = array("usu"=>$_POST["txtUsuE"],
                           "con"=>md5($_POST["txtPasE"]),
                           "email"=>$_POST["txtEmaE"],
                           "id"=>$_POST["txtIdE"],
                            );
        $respuesta = datos::actualizarUsuarioModel($info,"usuarios");

        if ($respuesta=="ok"){
            //activar acceso a la lista de usuarios
            $_SESSION['ingreso']=true;
            echo "<script>
                    alert('Usuario actualizado correctamente');
                    window.location.href = 'index.php?action=listar';
                </script>";
        }else{
            echo "<script>
            alert('Ocurrio un error, contacte al administrador');
            window.location.href = 'index.php';
        </script>";

        }          

        }

    }

    public function servicioWebController(){
        $respuesta = datos::servicioWebModel("usuarios");
        if ($respuesta=="NoDatos"){
            echo json_encode(
                array(
                    "estado" => 2,
                    "mensaje" => "No hay datos"
                )
            );
        }else{
            echo json_encode(
                array(
                    "estado" => 1,
                    "usuarios" => $respuesta->fetch_all(MYSQLI_ASSOC)
                )
            );

        }

    }
}

?>