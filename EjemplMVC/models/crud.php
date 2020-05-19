<?php

require_once "conexion.php";

class datos{

    public function registrarUsuarioModel($datos,$tabla){

        $con = conexion::conectar();
        $sql = $con->prepare("insert into $tabla(usuario, contras, email) values (?,?,?)");
        $sql->bind_param('sss',$datos["usu"],$datos["con"],$datos["ema"]);
        if($sql->execute()){
            return "ok";
        }else{
            return "error";
        }
    }

    public function ingresoUsuarioModel($datos,$tabla){
        $con = conexion::conectar();
        $sql = $con->prepare("select * from $tabla where usuario = ? and contras = ?");
        $sql->bind_param('ss',$datos["usu"],$datos["con"]);
        $sql->execute();
        $sql->store_result();
        if($sql->num_rows()==1){
            return "ok";
        }else{
            return "error";
        }

    }

    public function listarUsuariosModel($tabla){
        $con = conexion::conectar();
        $sql = $con->query("select * from $tabla");
        return $sql;

    }

    public function editarUsuarioModel($dato,$tabla){
        $con = conexion::conectar();
        $sql = $con->prepare("select usuario, email from $tabla where id = ?");
        $sql->bind_param('s',$dato);
        $sql->execute();
        $sql->bind_result($u, $e);
        $sql->fetch();
        $resultado = array( 
            "idusuario" => $dato,
            "nombreUsu" => $u,
            "emailUsu" => $e
        );
        return $resultado;
    }

    public function actualizarUsuarioModel($datos,$tabla){
        $con = conexion::conectar();
        $sql = $con->prepare("update $tabla set usuario = ?, contras = ?, email = ? where id = ?");
        $sql->bind_param('sssi',$datos["usu"],$datos["con"],$datos["email"],$datos["id"]);
        if($sql->execute()){
            return "ok";
        }else{
            return "error";
        }

    }

    public function servicioWebModel($tabla){
        $con = conexion::conectar();
        $sql = $con->query("select usuario,email from $tabla");
        if($sql->num_rows>0){
            return $sql;
        }else{
            return "NoDatos";
        }
    }
}


?>