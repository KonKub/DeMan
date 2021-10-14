using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeMan
{
    public static class ColorChoice
    {
        public static List<string> ColorList = new List<string> {
                                                                    "#726E6D", //гранит
                                                                    "#4863A0", //Steel Blue
                                                                    "#0041C2", //Blueberry Blue
                                                                    "#736AFF", //Light Slate Blue
                                                                    "#82CAFF", //день Голубого
                                                                    "#50EBEC", //Celeste
                                                                    "#48CCCD", //Medium Turquoise
                                                                    "#728C00", //Venom Green
                                                                    "#387C44", //Pine Green
                                                                    "#C9BE62", //имбирь Браун
                                                                    "#C68E17", //Caramel
                                                                    "#C58917", //Cinnamon
                                                                    "#493D26", //Mocha
                                                                    "#C47451", //Orange Salmon
                                                                    "#8E35EF", //Purple
                                                                    "#8467D7", //Medium Purple
                                                                    "#4E387E" //Purple Haze
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = correctionFactor + 1;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
