<?php
include_once("conexao.php");

$Nome =$_REQUEST['Nome'];  
$Codigo =$_REQUEST['Codigo'];

$insere = mysqli_query($con,"Update saldo set Saldo_Passar = $Nome, Saldo_Valor = Saldo_Valor - 4 WHERE Saldo_Codigo = $Codigo and Saldo_Valor > 4");

if($insere){
echo "Dados atualizados com sucesso";
}
else{
echo "Saldo Insuficiente";
}

?>
