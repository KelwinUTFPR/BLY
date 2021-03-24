<?php
 include("conexao.php");


		if (empty($_POST["Email"] ) || empty($_POST["Senha"] ) ){
		
		 		      header("location:login.php?erro=1");
		}
		
        else if($_POST["Email"] == "Admin@gmail.com" && $_POST["Senha"])
		{
			
			header("location:cms/tables-data.php");
		} 
		
		else{
   $Email = $_POST["Email"];
   $Senha = $_POST["Senha"] ;
 

      
        $query= mysqli_query($conexao,"SELECT * FROM login WHERE Login_Email ='$Email'");
        $nada = mysqli_num_rows($query);
		
		
		         if(empty($nada))
		    {		
		
				header("location:login.php?erro=2");
		    }
			
			
			else{
		
		while($logar= mysqli_fetch_array($query))
		{
		
		      if($logar["Login_Email"]==$Email && $logar["Login_Senha"]==$Senha)
		    {		
		
				header("location:cms/tables-data.php");
		    }
  
              else
		    {
		      header("location:login.php?erro=2");
		    }
	    }
		}
}
?>
        