package br.com.tcc;

import java.util.ArrayList;

import org.apache.http.message.BasicNameValuePair;




import android.os.Bundle;
import android.os.StrictMode;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

@SuppressLint("NewApi")
public class CadastroActivity extends Activity {
	Button btncadastrar;
	EditText txtemail, txtsenha, txtcsenha;
	TextView error;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		if (android.os.Build.VERSION.SDK_INT > 9) { 
			StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build(); 
			StrictMode.setThreadPolicy(policy); 
		}
		
		setContentView(R.layout.activity_cadastro);
		txtemail = (EditText) findViewById (R.id.txtemail);
		txtsenha = (EditText) findViewById (R.id.txtsenha);
		txtcsenha = (EditText) findViewById (R.id.txtcsenha);
		btncadastrar = (Button) findViewById (R.id.btncadastrar);
		error = (TextView) findViewById (R.id.error);
		
		btncadastrar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				
				ArrayList<BasicNameValuePair> postParameter = new ArrayList<BasicNameValuePair>(1);
				//nomes dos campos que serão armazenados no BD - pegas os valores da caixa de texto e passa para o arquivo PHP
				postParameter.add(new BasicNameValuePair("Login_Email",txtemail.getText().toString()));
				postParameter.add(new BasicNameValuePair("Login_Senha",txtsenha.getText().toString()));
				String response = null;
			
				try
				{
				  if(txtemail.getText().equals("")){
					error.setText("Preencha todos os campos");
				  }
			     	else{
			     	  //endereço Ip de conexao ao BD, deve colocar na pasta no htdocs os arquivos PHP
					   response= CustomHttpClient.executeHttpPost("http://10.68.36.60/mobile/cadcliente.php", postParameter);
					   String res = response.toString();
					   error.setText(res.toString());
					   Toast.makeText(CadastroActivity.this, "Cadastro concluído", Toast.LENGTH_SHORT).show();
					   Intent chamatela = new Intent(CadastroActivity.this,LoginActivity.class);
						startActivity(chamatela);
			    	}
				}catch(Exception e){
					error.setText(e.toString());
				}
			   }
			
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.cadastro, menu);
		return true;
	}

}
