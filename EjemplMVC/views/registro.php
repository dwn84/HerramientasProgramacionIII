<h1>Registrarse</h1>

<form method="post">
  <div class="form-group">
  <div class="form-group">
    <label for="exampleInputPassword1">Usuario</label>
    <input type="text" class="form-control" name="txtUsuR" required>
  </div>
  <div class="form-group">
    <label for="exampleInputEmail1">Email</label>
    <input type="email" class="form-control" name="txtEmaR" aria-describedby="emailHelp" required>
    <small id="emailHelp" class="form-text text-muted">El correo no será compartido ni vendido a nadie</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
    <input type="password" class="form-control" name="txtPasR" required>
  </div>
  <button type="submit" class="btn btn-primary">Registrarse</button>
</form>

<?php

$usuario = new mvcController();
$usuario->registrarusuarioController();

?>