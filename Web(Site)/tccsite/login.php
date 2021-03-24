<?php 
 include("conexao.php");
 
 
 

?>
<!doctype html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang=""> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8" lang=""> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9" lang=""> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang=""> <!--<![endif]-->
<head>
 <link rel="icon" href="images/icon.png" type="image/png">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Login</title>
    <meta name="description" content="Ela Admin - HTML5 Admin Template">
    <meta name="viewport" content="width=device-width, initial-scale=1">



     <link rel="stylesheet" href="assets/css_login/style.css">
    <link rel="stylesheet" href="assets/css/cs-skin-elastic.css">
    <link rel="stylesheet" href="assets/css/style.css">
    <link rel="stylesheet" href="layout/style/layout.css">	
   

    <!-- <script type="text/javascript" src="https://cdn.jsdelivr.net/html5shiv/3.7.3/html5shiv.min.js"></script> -->
</head>


<body class="color" >


 <?php
 if (empty($_GET["erro"])){
 
 ?>
    <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content">
                <div class="login-logo">
                    <a href="index.html">

                    </a>
                </div>
                <div class="login-form">
                    <form action="validar_login.php" method="post" >
					                <div class="circle">
                  <img src="images/avatar.png">
               
                </div>
                        <div class="form-group">
                            <label>Email</label>
                            <input name="Email" type="email" class="txtEmail" placeholder=" Email">
                        </div>
                        <div class="form-group">
                            <label>Senha</label>
                            <input name="Senha" type="password" class="txtSenha" placeholder=" Senha">
                        </div>
                        <div class="checkbox lblEspaco ">
                            <label>
                                <input type="checkbox" class="lblEspaco"> Lembre de mim
                            </label >
							
						
                        </div>
                       <a href="validar_login.php"> <button type="submit" class="btn btnEntrar">Entrar</button></a>

                        <div class="register-link m-t-15 text-center lblEspaco">
                            <p>Você não tem conta? <a href="conta.php"> Criar uma conta</a></p>
                        </div>
                    </form>
        </div>
            </div>
        </div>
    </div >
<?php }

else if($_GET["erro"] == 1){ 


 ?>
 
 
     <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content">
                <div class="login-logo">
                    <a href="index.html">
                        <img class="align-content" src="images/logo.png" alt="">
                    </a>
                </div>
                <div class="login-form">
                    <form action="validar_login.php" method="post" >
					                <div class="circle foto" style="background-image:url(images/avatar.png);">
                  
               
                </div>
                        <div class="form-group">
                            <label>Email</label>
                            <input name="Email" type="email" class="txtEmail" placeholder=" Email">
                        </div>
                        <div class="form-group">
                            <label>Senha</label>
                            <input name="Senha" type="password" class="txtSenha" placeholder=" Senha">
                        </div>
												<div class="invalido">
                        <p>Campo da senha e do email vazios</p>
					</div>
                        <div class="checkbox lblEspaco ">
                            <label>
                                <input type="checkbox" class="lblEspaco"> Lembre de mim
                            </label >
							
                            <label class="lblEspaco">
                                <a href="#"> Esqueceu sua senha?</a>
                            </label>
                            
                        </div>
                       <a href="validar_login.php"> <button type="submit" class="btn btnEntrar">Entrar</button></a>

                        <div class="register-link m-t-15 text-center lblEspaco">
                            <p>Você não tem conta? <a href="conta.php"> Criar uma conta</a></p>
                        </div>
                    </form>
        </div>
            </div>
        </div>
    </div >
	
	<?php } 
	
	else if($_GET["erro"] == 2){ 


 ?>
 
 
     <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content">
			

                <div class="login-form">
                    <form action="validar_login.php" method="post" >
					                <div class="circle foto" >
                  
               
                </div>
                        <div class="form-group" >
                            <label>Email</label>
                            <input name="Email" type="email" class="txtEmail" placeholder=" Email" >
							 
                        </div>
						
                        <div class="form-group">
                            <label>Senha</label>
                            <input name="Senha" type="password" class="txtSenha" placeholder=" Senha">
                        </div>
						<div class="invalido">
                        <p>Email ou senha inválidos</p>
					</div>
                        <div class="checkbox lblEspaco ">
						
                            <label>
                                <input type="checkbox" class="lblEspaco"> Lembre de mim
                            </label >
							
                            <label class="lblEspaco">
                                <a href="#"> Esqueceu sua senha?</a>
                            </label>
                            
                        </div>

                       <a href="validar_login.php"> <button type="submit" class="btn btnEntrar">Entrar</button></a>

                        <div class="register-link m-t-15 text-center lblEspaco">
                            <p>Você não tem conta? <a href="conta.php"> Criar uma conta</a></p>
                        </div>
                    </form>

        </div>
            </div>
        </div>
    </div >
	
	<?php } ?>
	
	
	
	
	
	
    <script src="https://cdn.jsdelivr.net/npm/jquery@2.2.4/dist/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.4/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/jquery-match-height@0.7.2/dist/jquery.matchHeight.min.js"></script>
    <script src="assets/js/main.js"></script>

</body>
</html>
