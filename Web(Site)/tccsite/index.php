<?php
include("conexao.php");
session_start();

?>
<html lang="pt-br">

<head>
        <link rel="icon" href="images/icon.png" type="image/png">
<title>BLY</title>
<meta charset="utf-8">  
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
<link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
</head>
<body id="top">



  <header id="header" class="hoc clear">
     <div id="logo" class="fl_left">    

     	<div class="logo"> 	 <img src="images/logobly.png"> </div>

	</div>
    <nav id="mainav" class="fl_right">  

      <ul class="clear"> 
        <li class="active"><a href="index.php">Home</a></li>
        <li class=""><a href="buscar.php">Horários</a></li>
        <li><a href="login.php"> Login</a></li>
      </ul>
      
    </nav>
  </header>


<div class="bgded overlay" style="background-image:url('images/maps2.jpg');">
  <div id="pageintro" class="hoc clear"> 
			
	
		<article>
	 <div class="celular"><img src="images/fotinha.png"></div>
        
		<div class="tt"> <?php
	$query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 13"); 
	while($exibir = mysqli_fetch_array($query)) { 	?>		
		<?php echo $exibir["titulo_corpo"];}?></p>
		<!-- ################################################################################################ -->
				 <?php
	$query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 13"); 
	while($exibir = mysqli_fetch_array($query)) { 	?>		
		<?php echo $exibir["texto_corpo"];}?></p> </div>
		
	 <div class="pp"><?php
	$query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 1"); 
	while($exibir = mysqli_fetch_array($query)) { 	?>		
		<?php echo $exibir["titulo_corpo"];}?></p>
	<!-- ################################################################################################ -->
	 <?php
	$query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 1"); 
	while($exibir = mysqli_fetch_array($query)) { 	?>		
		<?php echo $exibir["texto_corpo"];}?>
	<!-- ################################################################################################ -->	
<br>
      <footer><a class="btn" href="#">Download</a></footer></div>
    </article>

  </div>
</div>



<div class="bgded overlay light" style="background-image:url('images/demo/backgrounds/01.png');">
  <section id="services" class="hoc container clear"> 
    
    <div class="sectiontitle">
      <p class="nospace font-xs"></p>
      <h6 class="heading font-x2">Confira as funções do aplicativo</h6>
    </div>
    <ul class="nospace group elements elements-three">
<li class="one_third">
        <article><img src="images/002-pin.png">
          <h6 class="heading">	
		  <?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 4"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?></h6>
          <p>
				<?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 4"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
      </li>
	<!-- ################################################################################################ -->	
       <li class="one_third">
        <article><img src="images/011-qr-code.png">
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 5"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?></h6>
          <p><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 5"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
      </li>
	<!-- ################################################################################################ -->	
      <li class="one_third">
        <article><img src="images/002-bus.png">
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 6"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?></h6>
					
          <p><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 6"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
      </li>
	  <!-- ################################################################################################ -->
     <li class="one_third">
        <article><img src="images/013-bill.png">
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 7"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?></h6>
					
          <p><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 7"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
      </li>
	  <!-- ################################################################################################ -->
       <li class="one_third">
        <article><img src="images/009-time.png">
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 8"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?> </h6>
					
          <p><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 8"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
      </li>
	  <!-- ################################################################################################ -->
         <li class="one_third">
        <article><img src="images/005-payment.png">
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 9"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?></h6>
					
          <p><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 9"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
        </article>
	  <!-- ################################################################################################ -->
    </ul>
  
  </section>
</div>


<div class="wrapper coloured">
  <section id="testimonials" class="hoc container clear"> 
    <!-- ################################################################################################ -->
    <div class="sectiontitle">
      
      <h6 class="heading font-x2"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 10"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?> </h6>
					
	  <p class="nospace f"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 10"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?></p>
    </div>
	    <!-- ################################################################################################ -->
   <article class="one_half first">
      <figure class="clear"><img src="images/demo/100x100.png" alt="">
        <figcaption>
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 11"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?> </h6>
          <em></em></figcaption>
      </figure>
      <?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 11"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?> 
    </article>
		    <!-- ################################################################################################ -->
     <article class="one_half">
      <figure class="clear"><img src="images/demo/100x100.png" alt="">
        <figcaption>
          <h6 class="heading"><?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 12"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["titulo_corpo"];}?> </h6>
					
          <em></em></figcaption>
      </figure>
    <?php $query  = mysqli_query($conexao,"SELECT * FROM corpo WHERE codigo_corpo = 12"); 
					while($exibir = mysqli_fetch_array($query)) { 	?>		
					<?php echo $exibir["texto_corpo"];}?> 
    </article>
    <!-- ################################################################################################ -->
  </section>
    
</div>
	
<div class="wrapper row2">
  <section id="ctdetails" class="hoc container clear"> 
    <!-- ################################################################################################ -->
    <div class="sectiontitle">

      <h6 class="heading font-x2">Contato do suporte</h6>
    </div>
    <figure class="one_half first">
      <ul class="nospace clear">
        <li class="block clear"><a href="#"><i class="fas fa-phone"></i></a> <span><strong>Telefone celular</strong> +55(13)997301130</span></li>
        <li class="block clear"><a href="#"><i class="fas fa-envelope"></i></a> <span><strong>Email</strong> sup.localbus@gmail.com</span></li>
        <li class="block clear"><a href="#"><i class="fas fa-map-marker-alt"></i></a> <span><strong>Come visit us:</strong> Directions to <a href="#">our location</a></span></li>
      </ul>
    </figure>
    <article class="one_half">
      <h6 class="heading">Envie uma menssagem ao suporte</h6>
      <p class="nospace btmspace-15">Mande sugestões de como melhorar ou de algo que não o agradou, faremos o possivel para ajudar, atenciosamente, suporte</p>
      <form action="#" method="post">
        <fieldset>
          <legend>Newsletter:</legend>
          <input type="text" value="" placeholder="Nome">
          <input type="text" value="" placeholder="Email">
          <button type="submit" value="submit">Submit</button>
        </fieldset>
      </form>
	  
    </article>

    <!-- ################################################################################################ -->
  </section>
  	<img src="images/rodape.png">

</div>

<div class="bgded overlay row4" style="background-image:url('images/demo/backgrounds/01.png');">
  <footer id="footer" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <div class="one_quarter first">
      <h1 class="logoname"><a href="index.php"><div class="loo"> 	 <img src="images/logobly.png"> </div></h1>
      <p>Não se preocupe mais com a perda de horário, o aplicativo consiste em facilitar a rotina de usuários do transporte público viário atrazvés de funções exclusivas e inovadoras! [<a href="#">&hellip;</a>]</p>
      <ul class="faico clear">
        <li><a class="faicon-facebook" href="#"><i class="fab fa-facebook"></i></a></li>
        <li><a class="faicon-google-plus" href="#"><i class="fab fa-google-plus-g"></i></a></li>
        <li><a class="faicon-linkedin" href="#"><i class="fab fa-linkedin"></i></a></li>
        <li><a class="faicon-twitter" href="#"><i class="fab fa-twitter"></i></a></li>
        <li><a class="faicon-vk" href="#"><i class="fab fa-vk"></i></a></li>
      </ul>
    </div>
    <div class="one_quarter">
      <h6 class="heading">Confira sites das empresas de onibus </h6>
      <ul class="nospace linklist">
        <li><a href="http://www.princesadoscampos.com.br/">Princesa dos Campos</a></li>
        <li><a href="http://www.vallesulservicos.com.br/">Vallesul</a></li>
        <li><a href="https://www.viacaovaledoribeira.com.br/">Viação Vale do Ribeira</a></li>

      </ul>
    </div>
	
	
   
    <!-- ################################################################################################ -->
  </footer>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->

<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
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