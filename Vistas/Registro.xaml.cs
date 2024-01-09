namespace jnarvaezExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
        InitializeComponent();
        lblUsuario.Text = usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double pagoInicial = Convert.ToInt32(txtPagoInicial.Text);
        double pagoMensual;

        pagoMensual = ((1500 - pagoInicial) / 4) + (0.04 * 1500);
        txtPago.Text = pagoMensual.ToString();
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = Fecha.Date.ToString();
        string pais = pkPais.SelectedItem.ToString();
        string ciudad = pkCiudad.SelectedItem.ToString();
        string montoInicial = txtPagoInicial.Text;
        string pagoMensual = txtPago.Text;
        double total = Convert.ToDouble(montoInicial) + Convert .ToDouble(pagoMensual) * 4;

        DisplayAlert("RESUMEN \n", "Nombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad + "\nFecha: " + fecha + 
            "\nCiudad: " + ciudad + "\nPais: " + pais + "\nMonto Inicial: " + montoInicial + "\nPago Mensual: " + pagoMensual + "\nPago Total: " + total,"Regresar");
    }

    private void txtInicialPago_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtPagoInicial_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtPago_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtEdad_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}