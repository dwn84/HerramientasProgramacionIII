<h1>Listado</h1>

<table class="table table-dark">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Identificador</th>
      <th scope="col">Nombre Usuario</th>
      <th scope="col">Correo electronico</th>
      <th scope="col" colspan =2>Acciones</th>

    </tr>
  </thead>
  <tbody>   
    <?php

        $usuario = new mvcController();
        $usuario->listarUsuariosController();

    ?>
  </tbody>
</table>