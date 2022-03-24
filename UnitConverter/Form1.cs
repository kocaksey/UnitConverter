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
            else if (fromBox.SelectedItem == null || toBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow1.Visible = true;
                switch (fromBox.SelectedItem)
                {

                    case "Meter                                      [m]":
                        //double.TryParse(fromText.Text, out num);
                        double.TryParse(fromText.Text, out num);
                        unitLen1.Text = "[m]";
                        break;
                    case "Milimeter                              [mm]":
                        double.TryParse(fromText.Text, out num);
                        num = num / 1000;
                        unitLen1.Text = "[mm]";
                        break;
                    case "Centimeter                            [cm]":
                        double.TryParse(fromText.Text, out num);
                        num = num / 100;
                        unitLen1.Text = "[cm]";
                        break;
                    case "Inch                                      [in\"]":
                        double.TryParse(fromText.Text, out num);
                        num = num * 0.0254;
                        unitLen1.Text = "[In\"]";
                        break;
                    case "Foot                                      [Ft']":
                        double.TryParse(fromText.Text, out num);
                        num = num / 3.2808;
                        unitLen1.Text = "[Ft']";
                        break;
                    case "Kilometer                              [km]":
                        double.TryParse(fromText.Text, out num);
                        num = num * 1000;
                        unitLen1.Text = "[km]";
                        break;
                    case "Nanometer                           [nm]":
                        double.TryParse(fromText.Text, out num);
                        num = num / 1000000000;
                        unitLen1.Text = "[nm]";
                        break;
                    case "Micrometer                           [μm]":
                        double.TryParse(fromText.Text, out num);
                        num = num / 1000000;
                        unitLen1.Text = "[μm]";
                        break;
                    case "Mile                                      [mi.]":
                        double.TryParse(fromText.Text, out num);
                        num = num * 1609.34;
                        unitLen1.Text = "[mi.]";
                        break;
                    case "Yard                                      [yd]":
                        double.TryParse(fromText.Text, out num);
                        num = num * 0.9144;
                        unitLen1.Text = "[yd]";
                        break;
                    case "Light Year                               [ly]":
                        double.TryParse(fromText.Text, out num);
                        num = num * 9.461E+15;
                        unitLen1.Text = "[ly]";
                        break;
                }
                //asdas
                switch (toBox.SelectedItem)
                {
                    case "Milimeter                              [mm]":
                        num = num * 1000;
                        num = Math.Round(num, 3);
                        unitLen2.Text = "[mm]";
                        lbLen2.Text = Convert.ToString(num);
                        toText.Text = Convert.ToString(num);


                        break;
                    case "Centimeter                            [cm]":
                        num = num * 100;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[cm]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Meter                                      [m]":
                        num = num * 1;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[m]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Inch                                      [in\"]":
                        num = num / 0.0254;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[In\"]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Foot                                      [Ft']":
                        num = num * 3.2808;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[Ft']";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Kilometer                              [km]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[km]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Nanometer                           [nm]":
                        num = num * 1000000000;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[nm]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Micrometer                           [μm]":
                        num = num * 1000000;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[μm]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Mile                                      [mi.]":
                        num = num / 1609.34;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[mi.]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Yard                                      [yd]":
                        num = num / 0.9144;
                        num = Math.Round(num, 3);
                        toText.Text = Convert.ToString(num);
                        unitLen2.Text = "[yd]";
                        lbLen2.Text = Convert.ToString(num);
                        break;
                    case "Light Year                               [ly]":
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

        }


        private void WeightConverButton_Click(object sender, EventArgs e)
        {
            if (fromTextWeight.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxWeight.SelectedItem == null || toBoxWeight.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow2.Visible = true;
                switch (fromBoxWeight.SelectedItem)
                {
                    case "Kilogram                                [kg]":
                        double.TryParse(fromTextWeight.Text, out num);
                        lb22.Text = "[kg]";
                        break;
                    case "Ton                                          [t]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num * 1000;
                        lb22.Text = "[t]";
                        break;
                    case "Gram                                       [g]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num / 1000;
                        lb22.Text = "[g]";
                        break;
                    case "Miligram                                [mg]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num / 1000000;
                        lb22.Text = "[mg]";
                        break;
                    case "Pound                                   [lbs]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num * 0.453592;
                        lb22.Text = "[lbs]";
                        break;
                    case "Ounce                                   [oz]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num * 0.0283495;
                        lb22.Text = "[oz]";
                        break;
                    case "Carat                               [car, ct]":
                        double.TryParse(fromTextWeight.Text, out num);
                        num = num * 0.0002;
                        lb22.Text = "[car, ct]";
                        break;

                }
                switch (toBoxWeight.SelectedItem)
                {
                    case "Kilogram                                [kg]":
                        num = Math.Round(num, 3);
                        lb24.Text = "[kg]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Ton                                          [t]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb24.Text = "[t]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Gram                                       [g]":
                        num = num * 1000;
                        num = Math.Round(num, 3);
                        lb24.Text = "[g]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Miligram                                [mg]":
                        num = num * 1000000;
                        num = Math.Round(num, 3);
                        lb24.Text = "[mg]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Pound                                   [lbs]":
                        num = num / 0.453592;
                        num = Math.Round(num, 3);
                        lb24.Text = "[lbs]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Ounce                                   [oz]":
                        num = num / 0.0283495;
                        num = Math.Round(num, 3);
                        lb24.Text = "[oz]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                    case "Carat                               [car, ct]":
                        num = num / 0.0002;
                        num = Math.Round(num, 3);
                        lb24.Text = "[car, ct]";
                        lb23.Text = Convert.ToString(num);
                        toTextWeight.Text = Convert.ToString(num);
                        break;
                }
                lb21.Text = fromTextWeight.Text;
                lb23.Text = toTextWeight.Text;
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
            else if (fromBoxTemp.SelectedItem == null || toBoxTemp.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow3.Visible = true;
                switch (fromBoxTemp.SelectedItem)
                {
                    case "Kelvin                                     [K]":
                        double.TryParse(fromTextTemp.Text, out num);
                        lb32.Text = "[K]";
                        break;
                    case "Celsius                                   [°C]":
                        double.TryParse(fromTextTemp.Text, out num);
                        num = num + 273.15;
                        lb32.Text = "[°C]";
                        break;
                    case "Fahrenheit                             [°F]":
                        double.TryParse(fromTextTemp.Text, out num);
                        num = ((((num - 32) * 5) / 9) + 273.15);
                        lb32.Text = "[°F]";
                        break;
                    case "Rankine                                [°R]":
                        double.TryParse(fromTextTemp.Text, out num);
                        num = (num * 5) / 9;
                        lb32.Text = "[°R]";
                        break;
                    case "Reaumur                                 [°r]":
                        double.TryParse(fromTextTemp.Text, out num);
                        num = (num / (0.8)) + 273.15;
                        lb32.Text = "[°r]";
                        break;

                }
                switch (toBoxTemp.SelectedItem)
                {
                    case "Kelvin                                     [K]":
                        num = Math.Round(num, 3);
                        lb34.Text = "[K]";
                        lb33.Text = Convert.ToString(num);
                        toTextTemp.Text = Convert.ToString(num);
                        break;
                    case "Celsius                                   [°C]":
                        num = num - 273.15;
                        num = Math.Round(num, 3);
                        lb34.Text = "[°C]";
                        lb33.Text = Convert.ToString(num);
                        toTextTemp.Text = Convert.ToString(num);
                        break;
                    case "Fahrenheit                             [°F]":
                        num = ((((num - 273.15) * 9) / 5) + 32);
                        num = Math.Round(num, 3);
                        lb34.Text = "[°F]";
                        lb33.Text = Convert.ToString(num);
                        toTextTemp.Text = Convert.ToString(num);
                        break;
                    case "Rankine                                [°R]":
                        num = num * 1.8;
                        num = Math.Round(num, 3);
                        lb34.Text = "[°R]";
                        lb33.Text = Convert.ToString(num);
                        toTextTemp.Text = Convert.ToString(num);
                        break;
                    case "Reaumur                                 [°r]":
                        num = (num - 273.15) * 0.8;
                        num = Math.Round(num, 3);
                        lb34.Text = "[°r]";
                        lb33.Text = Convert.ToString(num);
                        toTextTemp.Text = Convert.ToString(num);
                        break;

                }
                lb31.Text = fromTextTemp.Text;
                lb33.Text = toTextTemp.Text;

            }
        }

        private void AngleConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextAngle.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxAngle.SelectedItem == null || toBoxAngle.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow4.Visible = true;

                switch (fromBoxAngle.SelectedItem)
                {
                    case "Degree                                    [°]":
                        double.TryParse(fromTextAngle.Text, out num);
                        lb42.Text = "[°]";
                        break;
                    case "Radian                                 [rad]":
                        double.TryParse(fromTextAngle.Text, out num);
                        num = num * 57.2958;
                        lb42.Text = "[rad]";
                        break;
                    case "Grad                                      [^g]":
                        double.TryParse(fromTextAngle.Text, out num);
                        num = num * 0.9;
                        lb42.Text = "[^g]";
                        break;
                    case "Minute                                      [']":
                        double.TryParse(fromTextAngle.Text, out num);
                        num = num / 60;
                        lb42.Text = "[']";
                        break;
                    case "Second                                    ['']":
                        double.TryParse(fromTextAngle.Text, out num);
                        num = num / 3600;
                        lb42.Text = "['']";
                        break;

                }
                switch (toBoxAngle.SelectedItem)
                {
                    case "Degree                                    [°]":
                        num = Math.Round(num, 3);
                        lb44.Text = "[°]";
                        lb43.Text = Convert.ToString(num);
                        toTextAngle.Text = Convert.ToString(num);
                        break;
                    case "Radian                                 [rad]":
                        num = num / 57.2958;
                        num = Math.Round(num, 3);
                        lb44.Text = "[rad]";
                        lb43.Text = Convert.ToString(num);
                        toTextAngle.Text = Convert.ToString(num);
                        break;
                    case "Grad                                      [^g]":
                        num = num / 0.9;
                        num = Math.Round(num, 3);
                        lb44.Text = "[^g]";
                        lb43.Text = Convert.ToString(num);
                        toTextAngle.Text = Convert.ToString(num);
                        break;
                    case "Minute                                      [']":
                        num = num * 60;
                        num = Math.Round(num, 3);
                        lb44.Text = "[']";
                        lb43.Text = Convert.ToString(num);
                        toTextAngle.Text = Convert.ToString(num);
                        break;
                    case "Second                                    ['']":
                        num = num * 3600;
                        num = Math.Round(num, 3);
                        lb44.Text = "['']";
                        lb43.Text = Convert.ToString(num);
                        toTextAngle.Text = Convert.ToString(num);
                        break;

                }
                lb41.Text = fromTextAngle.Text;
                lb43.Text = toTextAngle.Text;
            }
        }

        private void VolumeConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextVol.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxVol.SelectedItem == null || toBoxVol.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow5.Visible = true;
                switch (fromBoxVol.SelectedItem)
                {
                    case "Cubic meter                           [m³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 1000;
                        lb52.Text = "[m³]";
                        break;
                    case "Cubic centimeter                 [cm³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num / 1000;
                        lb52.Text = "[cm³]";
                        break;
                    case "Cubic milimeter                    [mm³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num / 1000000;
                        lb52.Text = "[mm³]";
                        break;
                    case "Cubic decimeter                  [dm³]":
                        double.TryParse(fromTextVol.Text, out num);
                        lb52.Text = "[dm³]";
                        break;
                    case "Liter                                       [L,l]":
                        double.TryParse(fromTextVol.Text, out num);
                        lb52.Text = "[L,l]";
                        break;
                    case "Milliliter                                   [ml]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num / 1000;
                        lb52.Text = "[ml]";
                        break;
                    case "Gallon                                   [gal]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 3.785;
                        lb52.Text = "[gal]";
                        break;
                    case "Quart                                      [qt]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 0.95;
                        lb52.Text = "[qt]";
                        break;
                    case "Pint                                        [pt]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 0.473176473;
                        lb52.Text = "[pt]";
                        break;
                    case "Cubic yard                            [yd³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 764.555;
                        lb52.Text = "[yd³]";
                        break;
                    case "Cubic foot                              [ft³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 28.3168;
                        lb52.Text = "[ft³]";
                        break;
                    case "Cubic inch                             [in³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 0.0163871;
                        lb52.Text = "[in³]";
                        break;
                    case "Cubic kilometer                    [km³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 1e+12;
                        lb52.Text = "[km³]";
                        break;
                    case "Cubic mile                             [mi³]":
                        double.TryParse(fromTextVol.Text, out num);
                        num = num * 4.168e+12;
                        lb52.Text = "[mi³]";
                        break;
                }


                switch (toBoxVol.SelectedItem)
                {
                    case "Cubic meter                           [m³]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb54.Text = "[m³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic centimeter                 [cm³]":
                        num = num * 1000;
                        num = Math.Round(num, 3);
                        lb54.Text = "[cm³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic milimeter                    [mm³]":
                        num = num * 1000000;
                        num = Math.Round(num, 3);
                        lb54.Text = "[mm³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic decimeter                  [dm³]":
                        num = Math.Round(num, 3);
                        lb54.Text = "[dm³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Liter                                       [L,l]":
                        num = Math.Round(num, 3);
                        lb54.Text = "[L,l]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Milliliter                                   [ml]":
                        num = num * 1000;
                        num = Math.Round(num, 3);
                        lb54.Text = "[ml]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Gallon                                   [gal]":
                        num = num / 3.785;
                        num = Math.Round(num, 3);
                        lb54.Text = "[gal]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Quart                                      [qt]":
                        num = num / 0.95;
                        num = Math.Round(num, 3);
                        lb54.Text = "[qt]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Pint                                        [pt]":
                        num = num / 0.473176473;
                        num = Math.Round(num, 3);
                        lb54.Text = "[pt]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic yard                            [yd³]":
                        num = num / 764.555;
                        num = Math.Round(num, 3);
                        lb54.Text = "[yd³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic foot                              [ft³]":
                        num = num / 28.3168;
                        num = Math.Round(num, 3);
                        lb54.Text = "[ft³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic inch                             [in³]":
                        num = num / 0.0163871;
                        num = Math.Round(num, 3);
                        lb54.Text = "[mmmads]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic kilometer                    [km³]":
                        num = num / 1e+12;
                        num = Math.Round(num, 3);
                        lb54.Text = "[km³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;
                    case "Cubic mile                             [mi³]":
                        num = num / 4.168e+12;
                        num = Math.Round(num, 3);
                        lb54.Text = "[mi³]";
                        lb53.Text = Convert.ToString(num);
                        toTextVol.Text = Convert.ToString(num);
                        break;

                }
                lb51.Text = fromTextVol.Text;
                lb53.Text = toTextVol.Text;
            }
        }

        private void PressureConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextPressure.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxPressure.SelectedItem == null || toBoxPressure.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow6.Visible = true;
                switch (fromBoxPressure.SelectedItem)
                {
                    case "Pascal	                              [Pa]":
                        double.TryParse(fromTextPressure.Text, out num);
                        lb62.Text = "[Pa]";

                        break;
                    case "Kilopascal                           [kPa]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 1000;
                        lb62.Text = "[Pa]";
                        break;
                    case "bar	                             [bar]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 100000;
                        lb62.Text = "[bar]";
                        break;
                    case "atm	                            [atm]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 101325;
                        lb62.Text = "[atm]";
                        break;
                    case "Psi	                              [psi]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 6894.76;
                        lb62.Text = "[psi]";
                        break;
                    case "Ksi                                        [ksi]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 6.895e+6;
                        lb62.Text = "[ksi]";
                        break;
                    case "Gigapascal                         [GPa]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 1e+9;
                        lb62.Text = "[GPa]";
                        break;
                    case "Megapascal                       [MPa]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 1000000;
                        lb62.Text = "[MPa]";
                        break;
                    case "Millipascal                          [mPa]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 0.001;
                        lb62.Text = "[mPa]";
                        break;
                    case "Millibar                               [mbar]":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 100;
                        lb62.Text = "[mbar]";
                        break;
                    case "Newton/Square meter":
                        double.TryParse(fromTextPressure.Text, out num);
                        lb62.Text = "Newton/Square meter";
                        break;
                    case "Newton/Square millimeter":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 1000000;
                        lb62.Text = "Newton/Square millimeter";
                        break;
                    case "Kilogram-force/Square meter":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 9.80665;
                        lb62.Text = "Kilogram-force/Square meter";
                        break;
                    case "Kilogram-force/Square millimeter":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 9806650;
                        lb62.Text = "Kilogram-force/Square millimeter";
                        break;
                    case "Pound-force/Square foot":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 47.88025898;
                        lb62.Text = "Pound-force/Square foot";
                        break;
                    case "Pound-force/Square inch":
                        double.TryParse(fromTextPressure.Text, out num);
                        num = num * 6894.7572932;
                        lb62.Text = "Pound-force/Square inch";
                        break;
                }

                switch (toBoxPressure.SelectedItem)
                {
                    case "Pascal	                              [Pa]":
                        num = Math.Round(num, 3);
                        lb64.Text = "[Pa]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Kilopascal                           [kPa]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb64.Text = "[kPa]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "bar	                             [bar]":
                        num = num / 100000;
                        num = Math.Round(num, 3);
                        lb64.Text = "[bar]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "atm	                            [atm]":
                        num = num / 101325;
                        num = Math.Round(num, 3);
                        lb64.Text = "[atm]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Psi	                              [psi]":
                        num = num / 6894.76;
                        num = Math.Round(num, 3);
                        lb64.Text = "[psi]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Ksi                                        [ksi]":
                        num = num / 6.895e+6;
                        num = Math.Round(num, 3);
                        lb64.Text = "[ksi]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Gigapascal                         [GPa]":
                        num = num / 1e+9;
                        num = Math.Round(num, 3);
                        lb64.Text = "[GPa]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Megapascal                       [MPa]":
                        num = num / 1000000;
                        num = Math.Round(num, 3);
                        lb64.Text = "[MPa]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Millipascal                          [mPa]":
                        num = num / 0.001;
                        num = Math.Round(num, 3);
                        lb64.Text = "[mPa]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Millibar                               [mbar]":
                        num = num / 100;
                        num = Math.Round(num, 3);
                        lb64.Text = "[mbar]";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Newton/Square meter":
                        num = Math.Round(num, 3);
                        lb64.Text = "Newton/Square meter";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Newton/Square millimeter":
                        num = num / 1000000;
                        num = Math.Round(num, 3);
                        lb64.Text = "Newton/Square millimeter";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Kilogram-force/Square meter":
                        num = num / 9.80665;
                        num = Math.Round(num, 3);
                        lb64.Text = "Kilogram-force/Square meter";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Kilogram-force/Square millimeter":
                        num = num / 9806650;
                        num = Math.Round(num, 3);
                        lb64.Text = "Kilogram-force/Square millimeter";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Pound-force/Square foot":
                        num = num / 47.88025898;
                        num = Math.Round(num, 3);
                        lb64.Text = "Pound-force/Square foot";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                    case "Pound-force/Square inch":
                        num = num / 6894.7572932;
                        num = Math.Round(num, 3);
                        lb64.Text = "Pound-force/Square inch";
                        lb63.Text = Convert.ToString(num);
                        toTextPressure.Text = Convert.ToString(num);
                        break;
                }
                lb61.Text = fromTextPressure.Text;
                lb63.Text = toTextPressure.Text;
            }
        }

        private void ForceConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextForce.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxForce.SelectedItem == null || toBoxForce.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow7.Visible = true;
                switch (fromBoxForce.SelectedItem)
                {
                    case "Newton                                  [N]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[N]";
                        break;
                    case "Kilonewton                           [kN]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[kN]";
                        num = num * 1000;
                        break;
                    case "Kilogram-force                      [kgf]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[kgf]";
                        num = num * 9.80665;
                        break;
                    case "Dekanewton                      [daN]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[daN]";
                        num = num * 10;
                        break;
                    case "Gram-force                             [gf]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[gf]";
                        num = num * 0.00980665;
                        break;
                    case "Ton-force                                [tf]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[tf]";
                        num = num * 9806.65;
                        break;
                    case "Giganewton                         [GN]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[GN]";
                        num = num * 1000000000;
                        break;
                    case "Meganewton                       [MN]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[MN]";
                        num = num * 1000000;
                        break;
                    case "Joule/meter                         [J/m]":
                        double.TryParse(fromTextForce.Text, out num);
                        lb72.Text = "[J/m]";
                        break;
                }

                switch (toBoxForce.SelectedItem)
                {
                    case "Newton                                  [N]":
                        num = Math.Round(num, 3);
                        lb74.Text = "[N]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Kilonewton                           [kN]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb74.Text = "[kN]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Kilogram-force                      [kgf]":
                        num = num / 9.80665;
                        num = Math.Round(num, 3);
                        lb74.Text = "[kgf]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Dekanewton                      [daN]":
                        num = num / 10;
                        num = Math.Round(num, 3);
                        lb74.Text = "[daN]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Gram-force                             [gf]":
                        num = num / 0.00980665;
                        num = Math.Round(num, 3);
                        lb74.Text = "[gf]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Ton-force                                [tf]":
                        num = num / 9806.65;
                        num = Math.Round(num, 3);
                        lb74.Text = "[tf]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Giganewton                         [GN]":
                        num = num / 1000000000;
                        num = Math.Round(num, 3);
                        lb74.Text = "[GN]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Meganewton                       [MN]":
                        num = num / 1000000;
                        num = Math.Round(num, 3);
                        lb74.Text = "[MN]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                    case "Joule/meter                         [J/m]":
                        num = Math.Round(num, 3);
                        lb74.Text = "[J/m]";
                        lb73.Text = Convert.ToString(num);
                        toTextForce.Text = Convert.ToString(num);
                        break;
                }
                lb71.Text = fromTextForce.Text;
                lb73.Text = toTextForce.Text;
            }
        }

        private void EnergyConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextEnergy.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxEnergy.SelectedItem == null || toBoxEnergy.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow8.Visible = true;
                switch (fromBoxEnergy.SelectedItem)
                {
                    case "Joule                                       [J]":
                        lb82.Text = "[J]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        break;
                    case "Kilojoule	                              [kJ]":
                        lb82.Text = "[kJ]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 1000;
                        break;
                    case "Kilowatt-hour                    [kW*h]":
                        lb82.Text = "[kW*h]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 3600000;
                        break;
                    case "Watt-hour                           [W*h]":
                        lb82.Text = "[W*h]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 3600;
                        break;
                    case "Horsepower-hour               [hp*h]":
                        lb82.Text = "[hp*h]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 2684519.5369;
                        break;
                    case "Gigajoule                              [GJ]":
                        lb82.Text = "[GJ]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 1000000000;
                        break;
                    case "Megajoule                            [MJ]":
                        lb82.Text = "[MJ]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 1000000;
                        break;
                    case "Gigawatt-hour	        [GW*h]":
                        lb82.Text = "[GW*h]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 3600000000000;
                        break;
                    case "Megawatt-hour                [MW*h]":
                        lb82.Text = "[MW*h]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 3600000000;
                        break;
                    case "Kilowatt-second                [kW*s]":
                        lb82.Text = "[kW*s]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 1000;
                        break;
                    case "Watt-second                      [W*s]":
                        lb82.Text = "[W*s]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        break;
                    case "Newton-meter                     [N*m]":
                        lb82.Text = "[N*m]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        break;
                    case "Kilocalorie                           [kcal]":
                        lb82.Text = "[kcal]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 4186.8;
                        break;
                    case "Calorie		             [cal]":
                        lb82.Text = "[cal]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 4.1868;
                        break;
                    case "Kilogram-force meter        [kgf*m]":
                        lb82.Text = "[kgf*m]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 9.8066499997;
                        break;
                    case "Pound-force foot                [lbf*ft]":
                        lb82.Text = "[lbf*ft]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 1.3558179483;
                        break;
                    case "Pound-force inch               [lbf*in]":
                        lb82.Text = "[lbf*in]";
                        double.TryParse(fromTextEnergy.Text, out num);
                        num = num * 0.112984829;
                        break;
                }
                switch (toBoxEnergy.SelectedItem)
                {
                    case "Joule                                       [J]":
                        num = Math.Round(num, 3);
                        lb84.Text = "[J]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Kilojoule	                              [kJ]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[kJ]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Kilowatt-hour                    [kW*h]":
                        num = num / 3600000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[kW*h]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Watt-hour                           [W*h]":
                        num = num / 3600;
                        num = Math.Round(num, 3);
                        lb84.Text = "[W*h]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Horsepower-hour               [hp*h]":
                        num = num / 2684519.5369;
                        num = Math.Round(num, 3);
                        lb84.Text = "[hp*h]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Gigajoule                              [GJ]":
                        num = num / 1000000000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[GJ]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Megajoule                            [MJ]":
                        num = num / 1000000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[MJ]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Gigawatt-hour	        [GW*h]":
                        num = num / 3600000000000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[GW*h]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Megawatt-hour                [MW*h]":
                        num = num / 3600000000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[MW*h]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Kilowatt-second                [kW*s]":
                        num = num / 1000;
                        num = Math.Round(num, 3);
                        lb84.Text = "[kW*s]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Watt-second                      [W*s]":
                        num = Math.Round(num, 3);
                        lb84.Text = "[W*s]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Newton-meter                     [N*m]":
                        num = Math.Round(num, 3);
                        lb84.Text = "[N*m]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Kilocalorie                           [kcal]":
                        num = num / 4186.8;
                        num = Math.Round(num, 3);
                        lb84.Text = "[kcal]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Calorie		             [cal]":
                        num = num / 4.1868;
                        num = Math.Round(num, 3);
                        lb84.Text = "[cal]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Kilogram-force meter        [kgf*m]":
                        num = num / 9.8066499997;
                        num = Math.Round(num, 3);
                        lb84.Text = "[kgf*m]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Pound-force foot                [lbf*ft]":
                        num = num / 1.3558179483;
                        num = Math.Round(num, 3);
                        lb84.Text = "[lbf*ft]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                    case "Pound-force inch               [lbf*in]":
                        num = num / 0.112984829;
                        num = Math.Round(num, 3);
                        lb84.Text = "[lbf*in]";
                        lb83.Text = Convert.ToString(num);
                        toTextEnergy.Text = Convert.ToString(num);
                        break;
                }
                lb81.Text = fromTextEnergy.Text;
                lb83.Text = toTextEnergy.Text;
            
            }
        }

        private void SpeedConvertButton_Click(object sender, EventArgs e)
        {
            if (fromTextSpeed.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Warning!");
            }
            else if (fromBoxSpeed.SelectedItem == null || toBoxSpeed.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit!", "Warning!");
            }
            else
            {
                arrow9.Visible = true;
                switch (fromBoxSpeed.SelectedItem)
                {
                    case "Meter/second                     [m/s]":
                        lb92.Text = "[m/s]";
                        double.TryParse(fromTextSpeed.Text, out num);
                        break;
                    case "Kilometer/hour                  [km/h]":
                        lb92.Text = "[km/h]";
                        double.TryParse(fromTextSpeed.Text, out num);
                        num = num * 0.2777777778;
                        break;
                    case "Mile/hour                           [mi/h]":
                        lb92.Text = "[mi/h]";
                        double.TryParse(fromTextSpeed.Text, out num);
                        num = num * 0.44704;
                        break;
                    case "Knot                                  [kt,kn]":
                        lb92.Text = "[kt,kn]";
                        double.TryParse(fromTextSpeed.Text, out num);
                        num = num * 0.5144444444;
                        break;
                    case "Mach":
                        lb92.Text = "Mach";
                        double.TryParse(fromTextSpeed.Text, out num);
                        num = num * 295.0464;
                        break;
                }
                switch (toBoxSpeed.SelectedItem)
                {
                    case "Meter/second                     [m/s]":
                        num = Math.Round(num, 3);
                        lb94.Text = "[m/s]";
                        lb93.Text = Convert.ToString(num);
                        toTextSpeed.Text = Convert.ToString(num);
                        break;
                    case "Kilometer/hour                  [km/h]":
                        num = num / 0.2777777778;
                        num = Math.Round(num, 3);
                        lb94.Text = "[km/h]";
                        lb93.Text = Convert.ToString(num);
                        toTextSpeed.Text = Convert.ToString(num);
                        break;
                    case "Mile/hour                           [mi/h]":
                        num = num / 0.44704;
                        num = Math.Round(num, 3);
                        lb94.Text = "[mi/h]";
                        lb93.Text = Convert.ToString(num);
                        toTextSpeed.Text = Convert.ToString(num);
                        break;
                    case "Knot                                  [kt,kn]":
                        num = num / 0.5144444444;
                        num = Math.Round(num, 3);
                        lb94.Text = "[kt,kn]";
                        lb93.Text = Convert.ToString(num);
                        toTextSpeed.Text = Convert.ToString(num);
                        break;
                    case "Mach":
                        num = num / 295.0464;
                        num = Math.Round(num, 3);
                        lb94.Text = "Mach";
                        lb93.Text = Convert.ToString(num);
                        toTextSpeed.Text = Convert.ToString(num);
                        break;
                }
                lb91.Text = fromTextSpeed.Text;
                lb93.Text = toTextSpeed.Text;
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

        private void Units_MouseClick(object sender, MouseEventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow5.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            arrow8.Visible = false;
            arrow9.Visible = false;
            lbLen1.Text = "";
            lbLen2.Text = "";
            unitLen1.Text = "";
            unitLen2.Text = "";
            lb21.Text = "";
            lb22.Text = "";
            lb23.Text = "";
            lb24.Text = "";

            lb31.Text = "";
            lb32.Text = "";
            lb33.Text = "";
            lb34.Text = "";

            lb41.Text = "";
            lb42.Text = "";
            lb43.Text = "";
            lb44.Text = "";

            lb51.Text = "";
            lb52.Text = "";
            lb53.Text = "";
            lb54.Text = "";

            lb61.Text = "";
            lb62.Text = "";
            lb63.Text = "";
            lb64.Text = "";

            lb71.Text = "";
            lb72.Text = "";
            lb73.Text = "";
            lb74.Text = "";

            lb81.Text = "";
            lb82.Text = "";
            lb83.Text = "";
            lb84.Text = "";

            lb91.Text = "";
            lb92.Text = "";
            lb93.Text = "";
            lb94.Text = "";

            fromBox.SelectedItem = null;
            toBox.SelectedItem = null;
            fromBoxWeight.SelectedItem = null;
            fromBoxSpeed.SelectedItem = null;
            fromBoxAngle.SelectedItem = null;
            fromBoxVol.SelectedItem = null;
            fromBoxEnergy.SelectedItem = null;
            fromBoxPressure.SelectedItem = null;
            fromBoxForce.SelectedItem = null;
            fromBoxTemp.SelectedItem = null;
            toBoxWeight.SelectedItem = null;
            toBoxSpeed.SelectedItem = null;
            toBoxAngle.SelectedItem = null;
            toBoxVol.SelectedItem = null;
            toBoxEnergy.SelectedItem = null;
            toBoxPressure.SelectedItem = null;
            toBoxForce.SelectedItem = null;
            toBoxTemp.SelectedItem = null;


        }

        private void fromText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertButton_Click(sender, e);
            }
        }

        private void fromTextWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WeightConverButton_Click(sender, e);
            }
        }

        private void fromTextTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TempConverButton_Click(sender, e);
            }
        }

        private void fromTextAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AngleConvertButton_Click(sender, e);
            }
        }

        private void fromTextVol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VolumeConvertButton_Click(sender, e);
            }
        }

        private void fromTextPressure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PressureConvertButton_Click(sender, e);
            }
        }

        private void fromTextForce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ForceConvertButton_Click(sender, e);
            }
        }

        private void fromTextEnergy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnergyConvertButton_Click(sender, e);
            }
        }

        private void fromTextSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SpeedConvertButton_Click(sender, e);
            }
        }
    }
}
