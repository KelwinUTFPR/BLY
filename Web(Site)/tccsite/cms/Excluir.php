<?php

include("conexao.php");

	$deletar = $_GET["idD"];

	  mysqli_query($conexao,"DELETE FROM corpo WHERE codigo_corpo = '$deletar'");
	  
	 header("location:tables-data.php");
?>