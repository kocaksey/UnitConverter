using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num = 0;
        private void convertButton_Click(object sender, EventArgs e)
        {


            if (fromText.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            //MessageBox.Show(fromBox3.FocusedItem.Text);
            switch (fromBox.SelectedItem)
            {
                
                case "meter":
                    //double.TryParse(fromText.Text, out num);
                    double.TryParse(fromText.Text, out num);
                    unitLen1.Text = "[m]";
                    break;
                case "millimeter":
                    double.TryParse(fromText.Text, out num);
                    num = num / 1000;
                    break;
                case "Centimeter":
                    double.TryParse(fromText.Text, out num);
                    num = num / 100;
                    unitLen1.Text = "[mm]";
                    break;
                case "Inch":
                    double.TryParse(fromText.Text, out num);
                    num = num * 0.0254;
                    unitLen1.Text = "[In\"]";
                    break;
                case "Foot":
                    double.TryParse(fromText.Text, out num);
                    num = num / 3.2808;
                    unitLen1.Text = "[Ft']";
                    break;
                case "Kilometer":
                    double.TryParse(fromText.Text, out num);
                    num = num * 1000;
                    unitLen1.Text = "[km]";
                    break;
                case "Nanometer":
                    double.TryParse(fromText.Text, out num);
                    num = num / 1000000000;
                    unitLen1.Text = "[nm]";
                    break;
                case "Micrometer":
                    double.TryParse(fromText.Text, out num);
                    num = num / 1000000;
                    unitLen1.Text = "[μm]";
                    break;
                case "Mile":
                    double.TryParse(fromText.Text, out num);
                    num = num * 1609.34;
                    unitLen1.Text = "[mi.]";
                    break;
                case "Yard":
                    double.TryParse(fromText.Text, out num);
                    num = num * 0.9144;
                    unitLen1.Text = "[yd]";
                    break;
                case "Light Year":
                    double.TryParse(fromText.Text, out num);
                    num = num * 9.461E+15;
                    unitLen1.Text = "[ly]";
                    break;
            }

            switch (toBox.SelectedItem)
            {
                case "Milimeter":
                    num = num * 1000;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[mm]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Centimeter":
                    num = num * 100;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[cm]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Meter":
                    num = num * 1;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[m]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Inch":
                    num = num / 0.0254;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[In\"]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Foot":
                    num = num * 3.2808;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[Ft']";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Kilometer":
                    num = num / 1000;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[km]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Nanometer":
                    num = num * 1000000000;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[nm]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Micrometer":
                    num = num * 1000000;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[μm]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Mile":
                    num = num / 1609.34;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[mi.]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Yard":
                    num = num / 0.9144;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[yd]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
                case "Light Year":
                    num = num / 9.461E+15;
                    num = Math.Round(num, 3);
                    toText.Text = Convert.ToString(num);
                    unitLen2.Text = "[ly]";
                    lbLen2.Text = Convert.ToString(num);
                    break;
            }

            lbLen1.Text = fromText.Text;
            lbLen2.Text = toText.Text;

        }


        private void WeightConverButton_Click(object sender, EventArgs e)
        {
            if (fromTextWeight.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }

            switch (fromBoxWeight.SelectedItem)
            {
                case "Kilogram[kg]":
                    double.TryParse(fromTextWeight.Text, out num);
                    break;
                case "Ton[t]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num * 1000;
                    break;
                case "Gram[g]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num / 1000;
                    break;
                case "Miligram[mg]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num / 1000000;
                    break;
                case "Pound[lbs]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num * 0.453592;
                    break;
                case "Ounce[oz]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num * 0.0283495;
                    break;
                case "Carat[car, ct]":
                    double.TryParse(fromTextWeight.Text, out num);
                    num = num * 0.0002;
                    break;

            }
            switch (toBoxWeight.SelectedItem)
            {
                case "Kilogram[kg]":
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Ton[t]":
                    num = num / 1000;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Gram[g]":
                    num = num * 1000;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Miligram[mg]":
                    num = num * 1000000;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Pound[lbs]":
                    num = num / 0.453592;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Ounce[oz]":
                    num = num / 0.0283495;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
                case "Carat[car, ct]":
                    num = num / 0.0002;
                    toTextWeight.Text = Convert.ToString(num);
                    break;
            }
        }

        private void Units_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = Units.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = Units.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.LightGray);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Bold, GraphicsUnit.Point);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void TempConverButton_Click(object sender, EventArgs e)
        {
            if (fromTextTemp.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxTemp.SelectedItem)
            {
                case "Kelvin[K]":
                    double.TryParse(fromTextTemp.Text, out num);
                    break;
                case "Celsius[°C]":
                    double.TryParse(fromTextTemp.Text, out num);
                    num = num + 273.15;
                    break;
                case "Fahrenheit[°F]":
                    double.TryParse(fromTextTemp.Text, out num);
                    num = ((((num - 32) * 5) / 9) + 273.15);
                    break;
                case "Rankine[°R]":
                    double.TryParse(fromTextTemp.Text, out num);
                    num = (num * 5) / 9;
                    break;
                case "Reaumur[°r]":
                    double.TryParse(fromTextTemp.Text, out num);
                    num = (num / (0.8)) + 273.15;
                    break;

            }
            switch (toBoxTemp.SelectedItem)
            {
                case "Kelvin[K]":
                    toTextTemp.Text = Convert.ToString(num);
                    break;
                case "Celsius[°C]":
                    num = num - 273.15;
                    toTextTemp.Text = Convert.ToString(num);
                    break;
                case "Fahrenheit[°F]":
                    num = ((((num - 273.15) * 9) / 5) + 32);
                    toTextTemp.Text = Convert.ToString(num);
                    break;
                case "Rankine[°R]":
                    num = num * 1.8;
                    toTextTemp.Text = Convert.ToString(num);
                    break;
                case "Reaumur[°r]":
                    num = (num -273.15) * 0.8;
                    toTextTemp.Text = Convert.ToString(num);
                    break;

            }
        }

        private void AngleConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextAngle.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }

            switch (fromBoxAngle.SelectedItem)
            {
                case "Degree[°]":
                    double.TryParse(fromTextAngle.Text, out num);
                    break;
                case "Radian[rad]":
                    double.TryParse(fromTextAngle.Text, out num);
                    num = num * 57.2958;
                    break;
                case "Grad[^g]":
                    double.TryParse(fromTextAngle.Text, out num);
                    num = num * 0.9;
                    break;
                case "Minute[']":
                    double.TryParse(fromTextAngle.Text, out num);
                    num = num / 60;
                    break;
                case "Second['']":
                    double.TryParse(fromTextAngle.Text, out num);
                    num = num / 3600;
                    break;

            }
            switch (toBoxAngle.SelectedItem)
            {
                case "Degree[°]":
                    toTextAngle.Text = Convert.ToString(num);
                    break;
                case "Radian[rad]":
                    num = num / 57.2958;
                    toTextAngle.Text = Convert.ToString(num);
                    break;
                case "Grad[^g]":
                    num = num / 0.9;
                    toTextAngle.Text = Convert.ToString(num);
                    break;
                case "Minute[']":
                    num = num * 60;
                    toTextAngle.Text = Convert.ToString(num);
                    break;
                case "Second['']":
                    num = num * 3600;
                    toTextAngle.Text = Convert.ToString(num);
                    break;

            }
        }

        private void VolumeConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextVol.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxVol.SelectedItem)
            {
                case "Cubic meter[m³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 1000;
                    break;
                case "Cubic centimeter[cm³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num / 1000;
                    break;
                case "Cubic milimeter[mm³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num / 1000000;
                    break;
                case "Cubic decimeter[dm³]":
                    double.TryParse(fromTextVol.Text, out num);
                    break;
                case "Liter[L,l]":
                    double.TryParse(fromTextVol.Text, out num);
                    break;
                case "Milliliter[ml]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num / 1000;
                    break;
                case "Gallon[gal]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 3.785;
                    break;
                case "Quart[qt]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 0.95;
                    break;
                case "Pint[pt]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 0.473176473;
                    break;
                case "Cubic yard[yd³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 764.555;
                    break;
                case "Cubic foot[ft³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 28.3168;
                    break;
                case "Cubic inch[in³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 0.0163871;
                    break;
                case "Cubic kilometer[km³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 1e+12;
                    break;
                case "Cubic mile[mi³]":
                    double.TryParse(fromTextVol.Text, out num);
                    num = num * 4.168e+12;
                    break;



            }


            switch (toBoxVol.SelectedItem)
            {
                case "Cubic meter[m³]":
                    num = num / 1000;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic centimeter[cm³]":
                    num = num * 1000;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic milimeter[mm³]":
                    num = num * 1000000;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic decimeter[dm³]":
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Liter[L,l]":
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Milliliter[ml]":
                    num = num * 1000;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Gallon[gal]":
                    num = num / 3.785;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Quart[qt]":
                    num = num / 0.95;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Pint[pt]":
                    num = num / 0.473176473;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic yard[yd³]":
                    num = num / 764.555;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic foot[ft³]":
                    num = num / 28.3168;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic inch[in³]":
                    num = num / 0.0163871;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic kilometer[km³]":
                    num = num / 1e+12;
                    toTextVol.Text = Convert.ToString(num);
                    break;
                case "Cubic mile[mi³]":
                    num = num / 4.168e+12;
                    toTextVol.Text = Convert.ToString(num);
                    break;

            }
        }

        private void PressureConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextPressure.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxPressure.SelectedItem)
            {
                case "Pascal[Pa]":
                    double.TryParse(fromTextPressure.Text, out num);

                    break;
                case "Kilopascal[kPa]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num *1000;
                    break;
                case "bar[bar]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 100000;
                    break;
                case "atm[atm]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 101325;
                    break;
                case "Psi[psi]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 6894.76;
                    break;
                case "Ksi[ksi]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 6.895e+6;
                    break;
                case "Gigapascal[GPa]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 1e+9;
                    break;
                case "Megapascal[MPa]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 1000000;
                    break;
                case "Millipascal[mPa]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 0.001;
                    break;
                case "Millibar[mbar]":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 100;
                    break;
                case "Newton/Square meter":
                    double.TryParse(fromTextPressure.Text, out num);
                    break;
                case "Newton/Square millimeter":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 1000000;
                    break;
                case "Kilogram-force/Square meter":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 9.80665;
                    break;
                case "Kilogram-force/Square millimeter":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 9806650;
                    break;
                case "Pound-force/Square foot":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 47.88025898;
                    break;
                case "Pound-force/Square inch":
                    double.TryParse(fromTextPressure.Text, out num);
                    num = num * 6894.7572932;
                    break;
            }

            switch (toBoxPressure.SelectedItem)
            {
                case "Pascal[Pa]":
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Kilopascal[kPa]":
                    num = num / 1000;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "bar[bar]":
                    num = num / 100000;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "atm[atm]":
                    num = num / 101325;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Psi[psi]":
                    num = num / 6894.76;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Ksi[ksi]":
                    num = num / 6.895e+6;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Gigapascal[GPa]":
                    num = num / 1e+9;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Megapascal[MPa]":
                    num = num / 1000000;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Millipascal[mPa]":
                    num = num / 0.001;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Millibar[mbar]":
                    num = num / 100;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Newton/Square meter":
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Newton/Square millimeter":
                    num = num / 1000000;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Kilogram-force/Square meter":
                    num = num / 9.80665;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Kilogram-force/Square millimeter":
                    num = num / 9806650;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Pound-force/Square foot":
                    num = num / 47.88025898;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
                case "Pound-force/Square inch":
                    num = num / 6894.7572932;
                    toTextPressure.Text = Convert.ToString(num);
                    break;
            }
        }

        private void ForceConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextForce.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxForce.SelectedItem)
            {
                case "Newton[N]":
                    double.TryParse(fromTextForce.Text, out num);
                    break;
                case "Kilonewton[kN]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 1000;
                    break;
                case "Kilogram-force[kgf]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 9.80665;
                    break;
                case "Dekanewton[daN]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 10;
                    break;
                case "Gram-force[gf]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 0.00980665;
                    break;
                case "Ton-force[tf]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 9806.65;
                    break;
                case "Giganewton[GN]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 1000000000;
                    break;
                case "Meganewton[MN]":
                    double.TryParse(fromTextForce.Text, out num);
                    num = num * 1000000;
                    break;
                case "Joule/meter[J/m]":
                    double.TryParse(fromTextForce.Text, out num);
                    break;
            }

            switch (toBoxForce.SelectedItem)
            {
                case "Newton[N]":
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Kilonewton[kN]":
                    num = num / 1000;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Kilogram-force[kgf]":
                    num = num / 9.80665;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Dekanewton[daN]":
                    num = num / 10;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Gram-force[gf]":
                    num = num / 0.00980665;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Ton-force[tf]":
                    num = num / 9806.65;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Giganewton[GN]":
                    num = num / 1000000000;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Meganewton[MN]":
                    num = num / 1000000;
                    toTextForce.Text = Convert.ToString(num);
                    break;
                case "Joule/meter[J/m]":
                    toTextForce.Text = Convert.ToString(num);
                    break;
            }
        }

        private void EnergyConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextEnergy.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxEnergy.SelectedItem)
            {
                case "Joule[J]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    break;
                case "Kilojoule[kJ]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 1000;
                    break;
                case "Kilowatt-hour[kW*h]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 3600000;
                    break;
                case "Watt-hour[W*h]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 3600;
                    break;
                case "Horsepower-hour[hp*h]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 2684519.5369;
                    break;
                case "Gigajoule[GJ]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 1000000000;
                    break;
                case "Megajoule[MJ]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 1000000;
                    break;
                case "Gigawatt-hour[GW*h]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 3600000000000;
                    break;
                case "Megawatt-hour[MW*h]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 3600000000;
                    break;
                case "Kilowatt-second[kW*s]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 1000;
                    break;
                case "Watt-second[W*s]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    break;
                case "Newton-meter[N*m]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    break;
                case "Kilocalorie[kcal]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 4186.8;
                    break;
                case "Calorie[cal]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 4.1868;
                    break;
                case "Kilogram-force meter[kgf*m]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 9.8066499997;
                    break;
                case "Pound-force foot[lbf*ft]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 1.3558179483;
                    break;
                case "Pound-force inch[lbf*in]":
                    double.TryParse(fromTextEnergy.Text, out num);
                    num = num * 0.112984829;
                    break;
            }
            switch (toBoxEnergy.SelectedItem)
            {
                case "Joule[J]":
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Kilojoule[kJ]":
                    num = num / 1000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Kilowatt-hour[kW*h]":
                    num = num / 3600000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Watt-hour[W*h]":
                    num = num / 3600;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Horsepower-hour[hp*h]":
                    num = num / 2684519.5369;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Gigajoule[GJ]":
                    num = num / 1000000000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Megajoule[MJ]":
                    num = num / 1000000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Gigawatt-hour[GW*h]":
                    num = num / 3600000000000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Megawatt-hour[MW*h]":
                    num = num / 3600000000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Kilowatt-second[kW*s]":
                    num = num / 1000;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Watt-second[W*s]":
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Newton-meter[N*m]":
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Kilocalorie[kcal]":
                    num = num / 4186.8;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Calorie[cal]":
                    num = num / 4.1868;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Kilogram-force meter[kgf*m]":
                    num = num / 9.8066499997;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Pound-force foot[lbf*ft]":
                    num = num / 1.3558179483;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;
                case "Pound-force inch[lbf*in]":
                    num = num / 0.112984829;
                    toTextEnergy.Text = Convert.ToString(num);
                    break;



            }
        }

        private void SpeedConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextSpeed.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            switch (fromBoxSpeed.SelectedItem)
            {
                case "Meter/second[m/s]":
                    double.TryParse(fromTextSpeed.Text, out num);
                    break;
                case "Kilometer/hour[km/h]":
                    double.TryParse(fromTextSpeed.Text, out num);
                    num = num * 0.2777777778;
                    break;
                case "Mile/hour[mi/h]":
                    double.TryParse(fromTextSpeed.Text, out num);
                    num = num * 0.44704;
                    break;
                case "Knot[kt,kn]":
                    double.TryParse(fromTextSpeed.Text, out num);
                    num = num * 0.5144444444;
                    break;
                case "Mach":
                    double.TryParse(fromTextSpeed.Text, out num);
                    num = num * 295.0464;
                    break;
            }
            switch (toBoxSpeed.SelectedItem)
            {
                case "Meter/second[m/s]":
                    toTextSpeed.Text = Convert.ToString(num);
                    break;
                case "Kilometer/hour[km/h]":
                    num = num / 0.2777777778;
                    toTextSpeed.Text = Convert.ToString(num);
                    break;
                case "Mile/hour[mi/h]":
                    num = num / 0.44704;
                    toTextSpeed.Text = Convert.ToString(num);
                    break;
                case "Knot[kt,kn]":
                    num = num / 0.5144444444;
                    toTextSpeed.Text = Convert.ToString(num);
                    break;
                case "Mach":
                    num = num / 295.0464;
                    toTextSpeed.Text = Convert.ToString(num);
                    break;
            }
        }

        private void fromText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromText.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromText.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

 

        private void fromTextWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextWeight.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextWeight.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextTemp.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextTemp.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextAngle.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextAngle.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextVol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextVol.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextVol.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextPressure.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextPressure.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextForce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextForce.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextForce.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextEnergy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextEnergy.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextEnergy.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void fromTextSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (fromTextSpeed.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && fromTextSpeed.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black ,10);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 263, 127, 263, 77);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toBoxVol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
