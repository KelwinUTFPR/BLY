<?php
include("conexao.php");
?>
<html lang="pt-br">
<!-- To declare your language - read more here: https://www.w3.org/International/questions/qa-html-language-declarations -->
<head>
        <link rel="icon" href="images/icon.png" type="image/png">
<title>Horários</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
<link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
</head>
<body id="top">

<div class="">
  <header id="header" class="hoc clear">
    <div id="logo" class="fl_left"> 
	
 
      <div class="logo"> 	 <img src="images/logobly.png"> </div>


	</div>
    <nav id="mainav" class="fl_right"> 

      <ul class="clear">
			<li class=""><a href="index.php">Home</a></li>
			<li class="active"><a href="buscar.php">Horários</a></li>
			<li><a href="login.php"> Login</a></li>
      </ul>

    </nav>
  </header>
</div>




<div class="wrapper gradient">
  <div class="hoc container clear"> 
   
    <div class="sectiontitle">
      <p class="nospace font-xs"> </p>
      <h6 class="heading font-x2">Encontre seus horários de onibûs!</h6><br>
    </div>
    <ul class="nospace group team">
   
   

   <div align="center" class="grupo" >
   <form action="buscar.php" method="post" > 
	<h1>Insira sua origem:  <img src="images/origem.png"><input type="text" name="origem" class="grupo1"></h1>
	<h2 >Insira seu destino: 	<img src="images/destino.png">   <input type="text" name="destino" class="grupo2"></h2>
	

	
	<h3><input type="submit" value="Buscar"></h3>

</form>

</div>



	<?php
	//restrito
     if(empty($_POST["origem"]))
	 {
	 ?>

<table border="1" width="500" class="xxx">
<thead>
	<tr>
	
		
		<td align="center"><b>Horario</b></td>
		<td align="center"><b>Embarque</b></td>	
		<td align="center"><b>Desembarque</b></td>
		<td align="center"><b>Empresa</b></td>
		<td align="center"><b>Preço</b></td>
		<td align="center"><b>Comprar</b></td>
	</tr>
	</thead>
	
	
	<?php
	 $buscar = "%";
	
	$query  = mysqli_query($conexao,"SELECT * FROM rota order by RAND() LIMIT 10");
	
	while($exibir = mysqli_fetch_array($query)) {
	?>
	

	
     

	 
	<tr>

		<td align="center"><?php echo $exibir["horario_saida"] ?>   <img src="images/arrow2	.png">  <?php echo $exibir["horario_chegada"] ?>  </td>
		<td align="center"><?php echo $exibir["local_saida"] ?></td>
		<td align="center"><?php echo $exibir["local_destino"] ?></td>
		<td align="center"><?php echo $exibir["empresa"] ?></td>
		<td align="center"><?php echo "R$ ".$exibir["preco"] ?></td>
		<td align="center"> <footer><a class="btn" href="comprar.php?cod=<?php echo $exibir["codigo_rota"];?>">Comprar</a></footer></td>	
		
		
	</tr>
	





		
	
	    
	
	 <?php 
	 }
	 }

		else {
?>


<table border="1" width="500" class="yyy">
	<tr>
	
		
		<td align="center"><b>Horario</b></td>
		<td align="center"><b>Embarque</b></td>	
		<td align="center"><b>Desembarque</b></td>
		<td align="center"><b>Empresa</b></td>
		<td align="center"><b>Preço</b></td>
		<td align="center"><b>Comprar</b></td>
	</tr>
	
	
	
	<?php
	 $origem = $_POST["origem"];
	 $destino = $_POST["destino"];
	
	$query  = mysqli_query($conexao,"SELECT * FROM rota Where local_saida = '$origem ' and local_destino = '$destino';");
	
	while($exibir = mysqli_fetch_array($query)) {
	?>
	

	
     

	 
	<tr>

		<td align="center"><?php echo $exibir["horario_saida"] ?>  <img src="images/arrow2.png">  <?php echo $exibir["horario_chegada"] ?>  </td>
		<td align="center"><?php echo $exibir["local_saida"] ?></td>
		<td align="center"><?php echo $exibir["local_destino"] ?></td>
		<td align="center"><?php echo $exibir["empresa"] ?></td>
		<td align="center"><?php echo "R$ ".$exibir["preco"] ?></td>
		<td align="center"> <footer><a class="btn" href="comprar.php?cod=<?php echo $exibir["codigo_rota"]?> ">Comprar</a></footer></td>		
	</tr>
	



		<?php } }  ?>



   
 
   </table>
    </ul>
   
  </div>
</div>

  	


<div>
<img src="images/rodape.png">
</div>

<a id="backtotop" href="#top"><i class="fas fa-chevron-up"></i></a>
<!-- JAVASCRIPTS -->
<script src="layout/scripts/jquery.min.js"></script>
<script src="layout/scripts/jquery.backtotop.js"></script>
<script src="layout/scripts/jquery.mobilemenu.js"></script>
<!-- Homepage specific -->
<script src="layout/scripts/jquery.easypiechart.min.js"></script>
<!-- / Homepage specific -->
</body>
</html>