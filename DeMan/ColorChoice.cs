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
                                                                    "#726E6D" ,//гранит
                                                                    "#4863A0", //Steel Blue
                                                                    "#0041C2", //Blueberry Blue
                                                                    "#736AFF", //Light Slate Blue
                                                                    "#48CCCD", //Medium Turquoise
                                                                    "#728C00", //Venom Green
                                                                    "#387C44", //Pine Green
                                                                    "#C9BE62", //имбирь Браун
                                                                    "#C68E17", //Caramel
                                                                    "#C58917", //Cinnamon
                                                                    "#493D26", //Mocha
                                                                    "#C47451", //Orange Salmon
                                                                    "#9E7BFF", //Purple
                                                                    "#4E387E", //Purple Haze
                                                                    "#98AFC7"
        };


        public static List<string> ColorListRow = new List<string> {
                                                                    "#D3D3D3",
                                                                    "#C9DFEC",
                                                                    "#C9DFEC",
                                                                    "#CCCCFF",
                                                                    "#DBF9DB",
                                                                    "#DBF9DB",
                                                                    "#DBF9DB",
                                                                    "#EDE6D6",
                                                                    "#EDE6D6",
                                                                    "#EDE6D6",
                                                                    "#E5E4E2",
                                                                    "#FFDDCA",
                                                                    "#DCD0FF",
                                                                    "#CCCCFF",
                                                                    "#DCDCDC"

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
