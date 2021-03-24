<?php

include("conexao.php");

	$COD= $_POST["codigo"];
	$TITULO= $_POST["titulo"];
	$TEXTO= $_POST["texto"];
	
	
 
		 mysqli_query ($conexao,"INSERT INTO corpo(codigo_corpo,titulo_corpo,texto_corpo) VALUES ('$COD','$TITULO','$TEXTO')");
 	  
        header("location:tables-data.php");
	     	
?>