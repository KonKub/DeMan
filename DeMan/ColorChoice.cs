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
                                                                    "#837E7C", //гранит
                                                                    "#4863A0", //cтальной синий
                                                                    "#0041C2", //голубика голубая
                                                                    "#736AFF", //световой шифер синий
                                                                    "#82CAFF", //день Голубого
                                                                    "#7FFFD4", //аквамарин
                                                                    "#48CCCD", //средняя бирюза
                                                                    "#728C00", //зеленый яд
                                                                    "#387C44", //сосновый зеленый
                                                                    "#B2C248", //авокадо-зеленый
                                                                    "#FFE87C", //солнце
                                                                    "#F7E7CE", //шампанское
                                                                    "#FFDB58", //горчичный
                                                                    "#E9AB17", //пчела Желтая
                                                                    "#C9BE62", //имбирь Браун
                                                                    "#C68E17", //карамель
                                                                    "#C58917", //корица
                                                                    "#493D26", //кофе мокко
                                                                    "#C47451", //оранжевый лосось
                                                                    "#FF7F50", //коралловый
                                                                    "#C5908E", //хаки Роуз
                                                                    "#8E35EF", //пурпурный
                                                                    "#E3E4FA", //лаванда синяя
                                                                    "#8467D7", //средний фиолетовый
                                                                    "#4E387E", //фиолетовый туман
                                                                    "#F778A1", //гвоздика розовая
                                                                    "#EDC9AF" //песок пустыни
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
