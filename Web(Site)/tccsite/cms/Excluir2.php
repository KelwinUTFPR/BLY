<?php

include("conexao.php");

	$codigo= $_POST["codigo"];
		  mysqli_query($conexao,"DELETE FROM corpo WHERE  codigo_corpo = '$codigo'");
	  
	 header("location:tables-data.php");
?>