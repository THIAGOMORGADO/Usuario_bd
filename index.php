<?php
require 'usuario.php';


$u = new Usuario(2);
$u->delete(2);

echo "Usuario deletado com sucesso";
?>