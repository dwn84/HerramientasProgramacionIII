<?php

require_once "conexion.php";

class datos{

    public function registrarUsuarioModel($datos,$tabla){

        $con = conexion::conectar();
        $sql = $con->prepare("insert into $tabla(usuario, contras, email) values (?,?,?)");
        var_dump($datos);
        exit;
        $sql->bind_param('sss',$datos["usu"],$datos["con"],$datos["ema"]);
        if($sql->execute()){
            return "ok";
        }else{
            return "error";
        }
    }

}


?>