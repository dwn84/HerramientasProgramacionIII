<?php

class modelo{


    public function url($pag){

        if($pag=="registro" || $pag=="ingresar" || $pag=="listar" || $pag=="servicioweb"|| $pag=="editar"|| $pag=="salir"){
            $modulo ="views/$pag.php";
        }elseif ($pag=="index"){
            $modulo ="views/inicio.php";
        }else{
            $modulo ="views/inicio.php";
        }

        
        return $modulo;

    }


}