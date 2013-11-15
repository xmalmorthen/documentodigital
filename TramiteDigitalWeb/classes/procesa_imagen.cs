using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace TramiteDigitalWeb.classes
{
    public static class procesa_imagen
    {
        public static byte[] toByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
