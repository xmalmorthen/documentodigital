using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace scanndoc.classes
{
    static class thumbnail
    {
        public static Image getThumbnaiImage(int width, Image img)
        {
            Image thumb = new Bitmap(width, width);
            try
            {
                Image tmp = null;

                if (img.Width < width && img.Height < width)
                {
                    using (Graphics g = Graphics.FromImage(thumb))
                    {
                        int xoffset = (int)((width - img.Width) / 2);
                        int yoffset = (int)((width - img.Height) / 2);
                        g.DrawImage(img, xoffset, yoffset, img.Width, img.Height);
                    }
                }
                else
                {
                    Image.GetThumbnailImageAbort myCallback = new
                        Image.GetThumbnailImageAbort(ThumbnailCallback);

                    if (img.Width == img.Height)
                    {
                        thumb = img.GetThumbnailImage(
                                 width, width,
                                 myCallback, IntPtr.Zero);
                    }
                    else
                    {
                        int k = 0;
                        int xoffset = 0;
                        int yoffset = 0;

                        if (img.Width < img.Height)
                        {
                            k = (int)(width * img.Width / img.Height);
                            tmp = img.GetThumbnailImage(k, width, myCallback, IntPtr.Zero);
                            xoffset = (int)((width - k) / 2);

                        }

                        if (img.Width > img.Height)
                        {
                            k = (int)(width * img.Height / img.Width);
                            tmp = img.GetThumbnailImage(width, k, myCallback, IntPtr.Zero);
                            yoffset = (int)((width - k) / 2);
                        }

                        using (Graphics g = Graphics.FromImage(thumb))
                        {
                            g.FillRectangle(new SolidBrush(Color.White), 0, 0, g.VisibleClipBounds.Size.Width, g.VisibleClipBounds.Size.Height);
                            g.DrawImage(tmp, xoffset, yoffset, tmp.Width, tmp.Height);
                        }
                    }
                }

                using (Graphics g = Graphics.FromImage(thumb))
                {                
                    g.DrawRectangle(Pens.Black, 0, 0, thumb.Width - 1, thumb.Height - 1);
                }
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            return thumb;
        }

        static private bool ThumbnailCallback()
        {
            return true;
        }

        public static Image CreateThumbnail(int width, Image i)
        {
            int dWidth = i.Width;
            int dHeight = i.Height;
            int dMaxSize = width;

            if (dWidth > dMaxSize)
            {
                dHeight = (dHeight * dMaxSize) / dWidth;
                dWidth = dMaxSize;
            }
            if (dHeight > dMaxSize)
            {
                dWidth = (dWidth * dMaxSize) / dHeight;
                dHeight = dMaxSize;
            }

            Image img = null;
            try
            {
                img = i.GetThumbnailImage(dWidth, dHeight, delegate() { return false; }, IntPtr.Zero);

                using (Graphics g = Graphics.FromImage(img))
                {
                    g.DrawRectangle(Pens.Black, 0, 0, img.Width - 1, img.Height - 1);
                }
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            
            return img;
        }
    }
}
