<?php 
include_once("conexao.php");

$email =$_REQUEST['Login_Email'];  
$senha =$_REQUEST['Login_Senha'];  
$cod =$_REQUEST['Saldo_Cod'];  


    $query="SELECT * FROM login where Login_Email = '$email'";
	
	$result = mysqli_query($con,$query);

  $rows = array();
  while($r = mysqli_fetch_array($result)) {
    $rows[] = $r;
  }
  echo json_encode($rows);

  mysqli_close($con);
?>
