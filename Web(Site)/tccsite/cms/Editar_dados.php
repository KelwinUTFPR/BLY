<?php

include("conexao.php");



	$COD= $_GET["codigo"];
	$TITULO= $_POST["titulo_corpo"];
	$TEXTO= $_POST["texto_corpo"];



   
		$query=  mysqli_query ($conexao,"Update corpo set titulo_corpo = '$TITULO', texto_corpo = '$TEXTO'  WHERE codigo_corpo = $COD ");
		      header("location:tables-data.php");

	
	      
	
?>