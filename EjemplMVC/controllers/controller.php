<?php

class mvcController{


    public function template(){
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
                           "ema"=>$_POST["txtEmaR"],
                           "con"=>$_POST["txtPasR"]
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

}

?>