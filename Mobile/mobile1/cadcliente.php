<?php
include_once("conexao.php");

$email =$_REQUEST['Login_Email']; 
$senha =$_REQUEST['Login_Senha'];  


$insere = mysqli_query($con,"Insert into login (Login_Email, Login_Senha) values ('".$email."','".$senha."')");
$insere2 = mysqli_query($con,"Insert into saldo (Saldo_Valor, Saldo_Passar) values ('0','0')");
if($insere){
echo "Dados atualizados com sucesso";
}
else{
echo "Não foi possível inserir os dados!!";
}
?>
