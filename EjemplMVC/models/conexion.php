<?php

class conexion{

    public function conectar(){
        $con = new mysqli("localhost","root","","");
        return $con;

    }
}
