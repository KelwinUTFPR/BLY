package br.com.tcc;

import java.util.ArrayList;

import org.apache.http.message.BasicNameValuePair;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu; 
import android.view.View;
import android.widget.ArrayAdapter; 
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;



public class EfetuarRecargaActivity extends Activity {
	private Spinner cidades; 
	private Itens itens;
	ImageButton btn_voltar;
	Button btnefetuar;
	RadioGroup rdg_pagemento;
	RadioButton rdb_cartao, rdb_boleto;
	TextView error;
	EditText txtvalor;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_efetuar_recarga);
		btn_voltar = (ImageButton) findViewById(R.id.btn_voltar);
		btnefetuar = (Button) findViewById(R.id.btnefetuar);
		error = (TextView) findViewById(R.id.error);
		txtvalor = (EditText) findViewById(R.id.txtvalor);		
	
		
		btnefetuar.setOnClickListener(new View.OnClickListener() {
			
  			@Override
  			public void onClick(View v) {
  				Intent intent2 = getIntent();
  				Bundle bundle2 = intent2.getExtras();
  				String cod = bundle2.getString("Bundle");
  				
  				// TODO Auto-generated method stub
				ArrayList<BasicNameValuePair> postParameter = new ArrayList<BasicNameValuePair>(1);
				//nomes dos campos que serão armazenados no BD - pegas os valores da caixa de texto e passa para o arquivo PHP
				postParameter.add(new BasicNameValuePair("Valor",txtvalor.getText().toString()));
				postParameter.add(new BasicNameValuePair("Codigo",cod));
				
				String response = null;
			
				try
				{
				
			     	  //endereço Ip de conexao ao BD, deve colocar na pasta no htdocs os arquivos PHP
					   response= CustomHttpClient.executeHttpPost("http://10.68.36.60/tccCatraca/cadsaldo.php", postParameter);
					   String res = response.toString();
					   error.setText(res.toString());
						
			    	
				}catch(Exception e){
					error.setText(e.toString());
				}

  			}
  		});
		
		 btn_voltar.setOnClickListener(new View.OnClickListener() {
	  			
	  			@Override
	  			public void onClick(View v) {
	  				// TODO Auto-generated method stub
	  				finish();
	  			}
	  		});
		
        InicializaListeners(); 
        ValorPersonalizado(); 
 
	}
	public void onRadioButtonClicked(View view) {
	    // Is the button now checked?
	Intent chamatela = new Intent(EfetuarRecargaActivity.this, DialogCardActivity.class);
	    boolean checked = ((RadioButton) view).isChecked();

	    // Check which radio button was clicked
	
		switch(view.getId()) {
	        case R.id.rdbcartao:
			if (checked)
	                // Pirates are the best
				startActivity(chamatela);
	        case R.id.rdboleto:
	            if (checked)
	                // Ninjas rule
	            break;
	    }
	}

	 public void InicializaListeners() 
     { 
          cidades = (Spinner) findViewById(R.id.cidades);
          itens = new Itens(); 
     }  
     
     public void ValorPersonalizado() 
     {        
         ArrayAdapter<String> arrayAdapter1 = new ArrayAdapter<String>(this,R.layout.spinner_item, itens.RetornarCidades); 
         cidades.setAdapter(arrayAdapter1); 
     }
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.efetuar_recarga, menu);
		return true;
	}

}
