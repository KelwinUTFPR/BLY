<?php 
include_once("conexao.php");

$saldo =$_REQUEST['Saldo_Valor'];  
$Codigo =$_REQUEST['Codigo'];


    $query="SELECT(Saldo_Valor) FROM saldo where Saldo_Codigo = '$Codigo'";
	
	$result = mysqli_query($con,$query);

  $rows = array();
  while($r = mysqli_fetch_array($result)) {
    $rows[] = $r;
  }
  echo json_encode($rows);

  mysqli_close($con);
?>
