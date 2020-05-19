<?php
//desactivar el menu de usuarios
session_destroy();
?>
<script>
    alert('Ha salido del sistema');
    window.location.href = 'index.php';
</script>

