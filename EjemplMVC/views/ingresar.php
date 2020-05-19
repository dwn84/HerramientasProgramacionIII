<h1>Ingresar al sistema</h1>

<form method="post">
  <div class="form-group">
  <div class="form-group">
    <label for="exampleInputPassword1">Usuario</label>
    <input type="text" class="form-control" name="txtUsuI" required>
  </div>

  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
    <input type="password" class="form-control" name="txtPasI" required>
  </div>
  <button type="submit" class="btn btn-primary">Ingresar</button>
</form>

<?php

$usuario = new mvcController();
$usuario->ingresarUsuarioController();

?>