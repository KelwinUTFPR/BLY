<?php
include("conexao.php");




$Email = $_POST["Email"];
$Senha = $_POST["Senha"];
$SenhaC = $_POST["SenhaC"];

	  if ( $Senha = $SenhaC) {
	 mysqli_query($conexao,"INSERT INTO login (Login_Email, Login_Senha) VALUES '$Email','$Senha')");
	
	  }
	  else 
	  {
		 echo "erro";
			}
    
	?>




































mysqli_query($conexao,"INSERT INTO login (Login_Email, Login_Senha) VALUES '$Email','$Senha')");