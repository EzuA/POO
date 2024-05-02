public class Circulo: Figura
{
    // Atributos, propiedades
    public double Radio { get; set; }

    // Constructores
    public Circulo(double radio)
    {
        Radio=radio;
    }

    // Métodos
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
        // return Math.PI * Radio * Radio
    }
}