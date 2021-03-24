package br.com.tcc;


import java.util.ArrayList;

import org.apache.http.message.BasicNameValuePair;







import android.net.Uri;
import android.os.Bundle;
import android.os.StrictMode;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.ActivityNotFoundException;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.view.Menu;
import android.view.View;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

public class TccActivity extends Activity {
	
	 static final String ACTION_SCAN = "com.google.zxing.client.android.SCAN";
	ImageButton btn_horarios, btn_rotas, btn_recarga, btn_qrcode, btnlogoff;
	TextView error;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tcc);
        
        SharedPreferences prefs = getSharedPreferences("meu_arquivo_de_preferencias", 0);
        boolean jaLogou = prefs.getBoolean("estaLogado", false);

         if(jaLogou) {
             // chama a tela inicial
        		
         }else {
             // chama a tela de login
        		Intent chamatela = new Intent(TccActivity.this,LoginActivity.class);
				startActivity(chamatela);
         }
        
        if (android.os.Build.VERSION.SDK_INT > 9) { 
			StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build(); 
			StrictMode.setThreadPolicy(policy); 
		}

		error = (TextView) findViewById(R.id.error); 
        btn_recarga = (ImageButton) findViewById(R.id.btn_recarga);
		btn_horarios = (ImageButton) findViewById(R.id.btn_horarios);
		btn_rotas = (ImageButton) findViewById(R.id.btn_rotas);
		btnlogoff = (ImageButton) findViewById(R.id.btnlogoff);
		

		btnlogoff.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				SharedPreferences prefs = getSharedPreferences("meu_arquivo_de_preferencias", 0);
				SharedPreferences.Editor editor = prefs.edit();
				editor.putBoolean("estaLogado", false);

				editor.commit();
				Intent chamatela = new Intent(TccActivity.this,LoginActivity.class);
				startActivity(chamatela);
			}
		});

		
		btn_rotas.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent chamatela = new Intent(TccActivity.this,MapaActivity.class);
				startActivity(chamatela);
			}
		});
		
		
		
		btn_recarga.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent intent0 = getIntent();
  				Bundle bundle = intent0.getExtras();
  				String cod = bundle.getString("Bundle");
  				
  				Bundle bundle1 = new Bundle();
				bundle1.putString("Bundle", cod);
				Intent intent1 = new Intent(TccActivity.this, RecargaActivity.class);
				intent1.putExtras(bundle1);
				startActivity(intent1);
			}
		});
		
		btn_horarios.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				Intent chamatela = new Intent(TccActivity.this,HorariosActivity.class);
				startActivity(chamatela);
	
			}
		});
		
    }
    @SuppressLint("NewApi")
	public void onBackPressed() {
        //nada acontece usando este
		 finishAffinity();
        //nem este, continua saindo de todo o app e não para a tela anterior
        super.onBackPressed();
 }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.tcc, menu);
        return true;
    }
    public void scanQR(View v) {
    	try {
    	 //start the scanning activity from the com.google.zxing.client.android.SCAN intent
    	Intent intent = new Intent(ACTION_SCAN);
    	intent.putExtra("SCAN_MODE", "QR_CODE_MODE");
    	startActivityForResult(intent, 0);
    	} catch (ActivityNotFoundException anfe) {
    	//on catch, show the download dialog
    	showDialog(TccActivity.this, "No Scanner Found", "Download a scanner code activity?", "Yes", "No").show();
    	}
    	}

    	 //alert dialog for downloadDialog

    	    private static AlertDialog showDialog(final Activity act, CharSequence title, CharSequence message, CharSequence buttonYes, CharSequence buttonNo) {
    	AlertDialog.Builder downloadDialog = new AlertDialog.Builder(act);
    	downloadDialog.setTitle(title);
    	downloadDialog.setMessage(message);
    	downloadDialog.setPositiveButton(buttonYes, new DialogInterface.OnClickListener() {
    	public void onClick(DialogInterface dialogInterface, int i) {
    	Uri uri = Uri.parse("market://search?q=pname:" + "com.google.zxing.client.android");
    	Intent intent = new Intent(Intent.ACTION_VIEW, uri);
    	try {
    	act.startActivity(intent);
    	} catch (ActivityNotFoundException anfe) {
    	}
    	}
    	});
    	downloadDialog.setNegativeButton(buttonNo, new DialogInterface.OnClickListener() {
    	public void onClick(DialogInterface dialogInterface, int i) {
    	}
    	});
    	return downloadDialog.show();
    	 }

    	 

    	    //on ActivityResult method

    	    public void onActivityResult(int requestCode, int resultCode, Intent intent) {
    	if (requestCode == 0) {
    	if (resultCode == RESULT_OK) {
    	//get the extras that are returned from the intent
    	String contents = intent.getStringExtra("SCAN_RESULT");
    	if (contents.equals("GASUD09AUSJDUAH13DAUADHASU27HDAUSHD")) {
    			Intent intent0 = getIntent();
				Bundle bundle = intent0.getExtras();
				String cod = bundle.getString("Bundle");
    		ArrayList<BasicNameValuePair> postParameter = new ArrayList<BasicNameValuePair>(1);
			// TODO Auto-generated method stub
			postParameter.add(new BasicNameValuePair("Nome","1"));
			postParameter.add(new BasicNameValuePair("Codigo",cod));
			String response = null;
			
			try
			{			
		     	  //endereço Ip de conexao ao BD, deve colocar na pasta no htdocs os arquivos PHP
				   response= CustomHttpClient.executeHttpPost("http://10.68.36.60/tccCatraca/cadcliente.php", postParameter);
				   String res = response.toString();
				  
		    	
				
			
			}catch(Exception e){
				error.setText(e.toString());
			}
    	}
    	else{
    		
    		Toast.makeText(TccActivity.this, "Código QR incorreto", Toast.LENGTH_SHORT).show();
    	}

    	}
    	}
    	}

    	}



