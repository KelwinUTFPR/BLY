<?php 
 include("conexao.php");
 
 
 

?>
<!doctype html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang=""> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8" lang=""> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9" lang=""> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang=""> <!--<![endif]-->
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Criar conta</title>
    <meta name="description" content="Ela Admin - HTML5 Admin Template">
    <meta name="viewport" content="width=device-width, initial-scale=1">



     <link rel="stylesheet" href="assets/css_login/style.css">
    <link rel="stylesheet" href="assets/css/cs-skin-elastic.css">
    <link rel="stylesheet" href="assets/css/style.css">

    

    <!-- <script type="text/javascript" src="https://cdn.jsdelivr.net/html5shiv/3.7.3/html5shiv.min.js"></script> -->
</head>
<body class="color" >

    <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content">
                <div class="login-logo">
                    <a href="index.html">
                        <img class="align-content" src="images/logo.png" alt="">
                    </a>
                </div>
                <div class="login-form">
                    <form action="cadastrar_conta.php" method="post" >
					                <div class="circle foto" >
                  
               
                </div>
                        <div class="form-group">
                            <label>Email</label>
                            <input name="Email" type="email" class="txtEmail" placeholder=" Email">
                        </div>
						<div class="form-group">
                            <label>Senha</label>
                            <input name="Senha" type="password" class="txtSenha" placeholder=" Senha">
                        </div>
						  <div class="form-group">
                            <label>Confirme a senha</label>
                            <input name="SenhaC" type="password" class="txtSenha" placeholder=" Confirmar Senha">
                        </div>
                       
                       <a href="cadastrar_conta.php"> <button type="submit" class="btn btnEntrar">Cadastrar-se</button></a>

                    </form>
        </div>
            </div>
        </div>
    </div >

 
  

	
	
	
	
	
	
    <script src="https://cdn.jsdelivr.net/npm/jquery@2.2.4/dist/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.4/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/jquery-match-height@0.7.2/dist/jquery.matchHeight.min.js"></script>
    <script src="assets/js/main.js"></script>

</body>
</html>
