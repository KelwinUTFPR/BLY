package br.com.tcc;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import android.os.Bundle;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;


@SuppressLint("NewApi")
public class LoginActivity extends Activity {
Button btnentrar;
EditText txtemail, txtsenha;
TextView error, cadastro;


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_login);
		btnentrar = (Button) findViewById(R.id.btnentrar);
		txtemail = (EditText) findViewById(R.id.txtemail);
		txtsenha = (EditText) findViewById(R.id.txtsenha);
		error = (TextView) findViewById (R.id.error);
		cadastro = (TextView) findViewById (R.id.lblcadastro);
		
	
		
		btnentrar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				JSONArray jArray;
				String result = null;
				InputStream is = null;
				StringBuilder sb = null;
				ArrayList<BasicNameValuePair> postParameters = new ArrayList<BasicNameValuePair>(1);
				
				try{
									
					
					postParameters.add(new BasicNameValuePair("Login_Email", txtemail.getText().toString()));
					postParameters.add(new BasicNameValuePair("Login_Senha", txtsenha.getText().toString()));
					postParameters.add(new BasicNameValuePair("Saldo_Cod", "1"));
					
					HttpClient httpclient = new DefaultHttpClient();
					HttpPost httpPost = new HttpPost("http://10.68.36.60/mobile/consulta.php");
					httpPost.setEntity(new UrlEncodedFormEntity(postParameters));
					HttpResponse response = httpclient.execute(httpPost);
					HttpEntity entity = response.getEntity();
					is = entity.getContent();
					
					
					try {
						BufferedReader reader = new BufferedReader(new InputStreamReader(is, "UTF8"));
						sb = new StringBuilder();
						sb.append(reader.readLine() + "\n");
						String line= null;
						
						while((line = reader.readLine()) != null){
							sb.append(line+ "\n");
						}
						is.close();
						result = sb.toString();
						
						
					}
					catch(Exception e){
						error.setText(e.toString());
					}
					
				} catch (Exception e){
					error.setText(e.toString());
				}
				
				try {
					jArray = new JSONArray(result);
					JSONObject json_data=null;
					
					for(int i=0;i<jArray.length();i++){
						json_data = jArray.getJSONObject(i);
						String email = json_data.getString("Login_Email");
						String senha = json_data.getString("Login_Senha");
						String cod = json_data.getString("Saldo_Cod");
						if((email.equals(txtemail.getText().toString())) && (senha.equals(txtsenha.getText().toString()))){
							
							
							Bundle bundle = new Bundle();
							bundle.putString("Bundle", cod);
							Intent intent0 = new Intent(LoginActivity.this, TccActivity.class);
							intent0.putExtras(bundle);
							startActivity(intent0);
							SharedPreferences prefs = getSharedPreferences("meu_arquivo_de_preferencias", 0);
							SharedPreferences.Editor editor = prefs.edit();
							editor.putBoolean("estaLogado", true);

							editor.commit();
						}
						else{
							error.setText("Email ou senha incorretos!");
						}
					 }
										
				} catch (JSONException e1) {
					e1.printStackTrace();
					error.setText(e1.toString());
					
				}
			}
				
			
			});
	}
	
	 public void onBackPressed() {
         //nada acontece usando este
		 finishAffinity();
         //nem este, continua saindo de todo o app e não para a tela anterior
         super.onBackPressed();
  }
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.login, menu);
		return true;
	}

          public void cadastro(View v) {
        		Intent chamatela = new Intent(LoginActivity.this,CadastroActivity.class);
				startActivity(chamatela);
          }  
       

}

