using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_CaiDat
    {
        public BLL_CaiDat()
        {

        }
        public string GetImagesPath()
        {
            return DAL_BLL.Properties.Settings.Default.ImagesPath;
        }
        public void SaveImagesPath(string imagesPath)
        {
            DAL_BLL.Properties.Settings.Default.ImagesPath = imagesPath;
            DAL_BLL.Properties.Settings.Default.Save();
        }
        public Color SelectThemeColor(string color)
        {
            return ColorTranslator.FromHtml(color);
        }
        public string GetThemeColor()
        {
            return DAL_BLL.Properties.Settings.Default.ThemeColor;
        }
        public void SaveThemeColor(string hexcolor)
        {
            DAL_BLL.Properties.Settings.Default.ThemeColor = hexcolor;
            DAL_BLL.Properties.Settings.Default.Save();
        }
    }
}
