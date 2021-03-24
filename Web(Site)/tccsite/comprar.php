<?php
include("conexao.php");
?>

<html class="no-js" lang="en">
<!--<![endif]-->

<head>
 <link rel="icon" href="images/icon.png" type="image/png">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Passagem</title>
    <meta name="description" content="Sufee Admin - HTML5 Admin Template">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="apple-touch-icon" href="apple-icon.png">
    <link rel="shortcut icon" href="favicon.ico">


    <link rel="stylesheet" href="vendors/bootstrap/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="vendors/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="vendors/themify-icons/css/themify-icons.css">
    <link rel="stylesheet" href="vendors/flag-icon-css/css/flag-icon.min.css">
    <link rel="stylesheet" href="vendors/selectFX/css/cs-skin-elastic.css">

    <link rel="stylesheet" href="assets/css/style2.css">
    <link rel="stylesheet" href="layout/styles/layout.css">	


    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800' rel='stylesheet' type='text/css'>



</head>

<body>
    <!-- Left Panel -->

   <div id="right-panel" class="right-panel">

        <!-- Header-->

        <!-- Header-->

  <header id="header" class="hoc clear">
    <div id="logo" class="fl_left"> 
	
 
      <div class="logo"> 	 <img src="images/logobly.png"> </div>


	</div>
    <nav id="mainav" class="fl_right"> 

      <ul class="clear">
			<li class=""><a href="index.php">Home</a></li>
			<li class=""><a href="buscar.php">Horários</a></li>
			<li><a href="login.php"> Login</a></li>
      </ul>

    </nav>


        <div class="content mt-3">
            <div class="animated fadeIn">

	
                <div class="">
                  <div class="">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Comprar passagem</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  <div class="card-title">
                                      <h3 class="text-center">Fatura de pagamento</h3>
                                  </div>
                                  <hr>
								  
								  
								  
								   
								  <?php
								  $Codigo = $_GET["cod"];
								 
									$query  = mysqli_query($conexao,"SELECT * FROM rota WHERE codigo_rota = $Codigo ;");
											$exibir = mysqli_fetch_array($query);
											?>
								  
								  
								  
								  
								  
								  
								  
								  
                                  <form action="" method="post" novalidate="novalidate">
                                      <div class="form-group text-center">
                                          <ul class="list-inline">
                                              <li class="list-inline-item"><i class="text-muted fa fa-cc-visa fa-2x"></i></li>
                                              <li class="list-inline-item"><i class="fa fa-cc-mastercard fa-2x"></i></li>
                                              <li class="list-inline-item"><i class="fa fa-cc-amex fa-2x"></i></li>
                                              <li class="list-inline-item"><i class="fa fa-cc-discover fa-2x"></i></li>
                                          </ul>
                                      </div>
                                      <div class="form-group">
                                          <label for="cc-payment" class="control-label mb-1">Valor da compra</label>
                                          <input id="cc-pament" name="cc-payment" type="text" class="form-control" aria-required="true" aria-invalid="false" value="<?php echo $exibir["preco"] ?>">
										  
										  
	 
										  
                                      </div>
                                      <div class="form-group has-success">
                                          <label for="cc-name" class="control-label mb-1">Tipo de cartão</label>
                                          <input id="cc-name" name="cc-name" type="text" class="form-control cc-name valid" data-val="true" data-val-required="Please enter the name on card" autocomplete="cc-name" aria-required="true" aria-invalid="false" aria-describedby="cc-name-error">
                                          <span class="help-block field-validation-valid" data-valmsg-for="cc-name" data-valmsg-replace="true">  </span>
                                      </div>
                                      <div class="form-group">
                                          <label for="cc-number" class="control-label mb-1">Número do cartão</label>
                                          <input id="cc-number" name="cc-number" type="tel" class="form-control cc-number identified visa" value="" data-val="true" data-val-required="Please enter the card number" data-val-cc-number="Please enter a valid card number" autocomplete="cc-number">
                                          <span class="help-block" data-valmsg-for="cc-number" data-valmsg-replace="true"></span>
                                      </div>
                                      <div class="row">
                                          <div class="col-6">
                                              <div class="form-group">
                                                  <label for="cc-exp" class="control-label mb-1">Expiração</label>
                                                  <input id="cc-exp" name="cc-exp" type="tel" class="form-control cc-exp" value="" data-val="true" data-val-required="Please enter the card expiration" data-val-cc-exp="Please enter a valid month and year" placeholder="MM / YY" autocomplete="cc-exp">
                                                  <span class="help-block" data-valmsg-for="cc-exp" data-valmsg-replace="true"></span>
                                              </div>
                                          </div>
                                          <div class="col-6">
                                              <label for="x_card_code" class="control-label mb-1">Código de segurança</label>
                                              <div class="input-group">
                                                  <input id="x_card_code" name="x_card_code" type="tel" class="form-control cc-cvc" value="" data-val="true" data-val-required="Please enter the security code" data-val-cc-cvc="Please enter a valid security code" autocomplete="off">
                                                  <div class="input-group-addon">
                                                      <span class="fa fa-question-circle fa-lg" data-toggle="popover" data-container="body" data-html="true" data-title="Security Code"
                                                      data-content="<div class='text-center one-card'>The 3 digit code on back of the card..<div class='visa-mc-cvc-preview'></div></div>"
                                                      data-trigger="hover"></span>
                                                  </div>
                                              </div>
                                          </div>
                                      </div>
                                      <div>
								<script>
									  function funcao1()
										{
											alert("Compra concluída com sucesso");
											
																	}  
											</script>
									
									  
									  
						
									  
                                            <button id="payment-button" type="submit" onclick="funcao1()" class="btn btn-lg btn-info btn-block"  >
                                              <i class="fa fa-lock fa-lg"></i>&nbsp;
                                              <a href="buscar.php">Finalizar Compra </a>
                                           
                                          </button>
                                      </div>
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->

                 

                 

               

                 

               

                

               


                 

                

                 

             
                </div>


            </div><!-- .animated -->
        </div><!-- .content -->

<div class="rodape"><img src="images/rodape2.png"></div>
    </div><!-- /#right-panel -->

    <!-- Right Panel -->

  	
    <script src="assets/js/vendor/jquery-2.1.4.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/plugins.js"></script>
    <script src="assets/js/main.js"></script>


</body>
</html>
