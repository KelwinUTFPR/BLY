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
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;


public class RecargaActivity extends Activity {
	Button btn_recarregar;
	ImageButton btn_voltar;
	TextView lblsaldo, error;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_recarga);
		error = (TextView) findViewById (R.id.error);
		btn_recarregar = (Button) findViewById(R.id.btn_recarregar);
		btn_voltar = (ImageButton) findViewById(R.id.btn_voltar);
		lblsaldo = (TextView) findViewById(R.id.lblsaldo);
		
		Intent intent1 = getIntent();
			Bundle bundle1 = intent1.getExtras();
			String cod = bundle1.getString("Bundle");
		
		JSONArray jArray;
		String result = null;
		InputStream is = null;
		StringBuilder sb = null;
		ArrayList<BasicNameValuePair> postParameters = new ArrayList<BasicNameValuePair>(1);
		
		try{
							
			
			postParameters.add(new BasicNameValuePair("Saldo_Valor", lblsaldo.getText().toString()));
			postParameters.add(new BasicNameValuePair("Codigo", cod));
			
			HttpClient httpclient = new DefaultHttpClient();
			HttpPost httpPost = new HttpPost("http://10.68.36.60/tccCatraca/consulta.php");
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
				String saldo = json_data.getString("Saldo_Valor");
				lblsaldo.setText(saldo.toString() + " R$");
			 }
								
		} catch (JSONException e1) {
			e1.printStackTrace();
			error.setText(e1.toString());
			
		}
	
		
		
		
		
		
          btn_recarregar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub	
				Intent intent1 = getIntent();
  				Bundle bundle1 = intent1.getExtras();
  				String cod = bundle1.getString("Bundle");
  				
  				Bundle bundle2 = new Bundle();
				bundle2.putString("Bundle", cod);
				Intent intent2 = new Intent(RecargaActivity.this, EfetuarRecargaActivity.class);
				intent2.putExtras(bundle2);
				startActivity(intent2);
			}
		});
          
          
          btn_voltar.setOnClickListener(new View.OnClickListener() {
  			
  			@Override
  			public void onClick(View v) {
  				// TODO Auto-generated method stub
  				finish();
  			}
  		});
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.recarga, menu);
		return true;
	}

}
