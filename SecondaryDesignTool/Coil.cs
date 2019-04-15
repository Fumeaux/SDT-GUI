using System;

namespace SecondaryDesignTool
{
    public class Coil
    {
        private readonly double _height;
        private readonly double _width;
        private readonly double _wirediameter;

        public Coil(double width, double height, double wirediameter)
        {
            _width = width;
            _height = height;
            _wirediameter = wirediameter;
        }
        public override string ToString()
        {
            return CoilDiameter.ToString("#.##") + "mm X " + CoilLength.ToString("#.##") + "mm  Wire: " + WireDiameter + "mm  Frequency: " + Frequency.ToString("#.#") + "kHz Impedance: " + Impedance.ToString("#.#") + "Ohm";
        }
        public double Ratio => CoilLength / CoilDiameter;
        public double CoilDiameter => _width;
        public double CoilLength => _height;
        public double WireDiameter => _wirediameter;
        public double WireLength => ((CoilDiameter * Math.PI * Turns) / 1000);
        public double WireSpacing => WireDiameter / 10;
        public double Turns => (CoilLength / (WireDiameter + WireSpacing));
        public double Inductance => (Math.Pow(Turns, 2) * Math.Pow(CoilDiameter / 50.8, 2) / ((CoilDiameter / 5.64444444444) + (CoilLength / 2.54)));
        public double ToroidMajorDiameter => CoilLength * ToLoFa;
        public double ToroidMinorDiameter => CoilDiameter * ToLoFa;
        public double ToroidCapacity => 2.8*(1.2781-(ToroidMinorDiameter/ToroidMajorDiameter))*Math.Sqrt(((2*(Math.PI * Math.PI)*(ToroidMajorDiameter*0.0393701-ToroidMinorDiameter*0.0393701)*(ToroidMinorDiameter*0.0393701/2))/(4*Math.PI)));
        public double Frequency => (1 / (2 * Math.PI * Math.Sqrt((Inductance / 1000000) * (ToroidCapacity / 1000000000000)))) / 1000;
        public double Impedance => Math.Sqrt((Inductance / 1000000) / (ToroidCapacity / 1000000000000));
        public bool isDoubleSafe => Ratio <= UpAccRa && Ratio >= LoAccRa && Impedance <= UpAccIm && Impedance >= LoAccIm;
        public bool isImpedanceSafe => Impedance <= middleIm + radiusIm * 0.4 && Impedance >= middleIm - radiusIm * 0.4;
        private double middleIm => (UpAccIm + LoAccIm) / 2;
        private double radiusIm => LoAccIm < middleIm ? middleIm - LoAccIm: LoAccIm - middleIm;
        public double UpAccIm { get; set; }
        public double LoAccIm { get; set; }
        public double UpAccRa { get; set; }
        public double LoAccRa { get; set; }
        public double ToLoFa { get; set; }
    }
}
