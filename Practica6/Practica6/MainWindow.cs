using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTerminarClicked (object sender, System.EventArgs e)
	{
		int aciertos = 0;
		
		string codigo = this.txtcodigo.Text;
		string nombre = this.txtnombre.Text;
		
		if(this.df.Active){
			aciertos++;
		}
		if(this.portugal.Active){
			aciertos++;
		}
		if(this.reino.Active){
			aciertos++;
		}
		if(this.macedonia.Active){
			aciertos++;
		}
		string estados = this.spinEstados.Text;
		if(estados == "31"){
			aciertos++;
		}
		DateTime fecha = this.calFecha.GetDate();
		if(fecha.ToShortDateString()== "02/09/1945"){
			aciertos++;
		}
		
		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None,  "Código: " + codigo +"\n"+
                           "Nombre: " + nombre +"\n"+
                           " " + aciertos +" Aciertos\n"
        );
		md.Show();
	}
}
