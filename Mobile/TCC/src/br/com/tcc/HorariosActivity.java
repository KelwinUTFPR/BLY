package br.com.tcc;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ImageButton;
import android.widget.Spinner;

public class HorariosActivity extends Activity {
	ImageButton btn_voltar;
	private Spinner cidades; 
	private Itens itens;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_horarios);
		btn_voltar = (ImageButton) findViewById(R.id.btn_voltar);
		
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
		getMenuInflater().inflate(R.menu.horarios, menu);
		return true;	}

}
