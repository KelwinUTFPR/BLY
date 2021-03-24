<?php
include_once("conexao.php");

$Valor =$_REQUEST['Valor'];  
$Codigo =$_REQUEST['Codigo'];  

$insere = mysqli_query($con,"Update saldo set Saldo_Valor = Saldo_Valor + $Valor WHERE Saldo_Codigo = $Codigo");

if($insere){
echo "Dados atualizados com sucesso";
}
else{
echo "Não foi possível inserir os dados!!";
}

?>
