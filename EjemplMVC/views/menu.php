<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="index.php?action=index">Inicio</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
    <div class="navbar-nav">
      <?php
        session_start();
        if(!isset($_SESSION['ingreso']) || !$_SESSION['ingreso']==true){
          echo "

            <a class='nav-item nav-link' href='index.php?action=registro'>Registrarse</a>
            <a class='nav-item nav-link' href='index.php?action=ingresar'>Login</a>
          ";
        }else{

          echo "
            <a class='nav-item nav-link' href='index.php?action=listar'>Listar usuarios</a>
          ";
        }
      ?>


      <a class="nav-item nav-link" href="index.php?action=salir">Salir</a>
    </div>
  </div>
</nav>