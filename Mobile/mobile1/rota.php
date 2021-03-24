<?php 
include_once("conexao.php");

$cidades =$_REQUEST['cidades'];  



    $query="SELECT * FROM rota where local_saida = '$cidades'";
	
	$result = mysqli_query($con,$query);

  $rows = array();
  while($r = mysqli_fetch_array($result)) {
    $rows[] = $r;
  }
  echo json_encode($rows);

  mysqli_close($con);
?>
