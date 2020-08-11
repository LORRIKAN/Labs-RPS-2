using System.Drawing;

namespace Lab4.NestedTable.Images
{
    public static class ImageCompare
    {
        public static bool IsEqual(this Bitmap firstImage, Bitmap secondImage)
        {
            if (firstImage.Width == secondImage.Width && firstImage.Height == secondImage.Height)
            {
                for (int i = 0; i < firstImage.Width; ++i)
                    for (int j = 0; j < firstImage.Height; ++j)
                        if (firstImage.GetPixel(i, j).ToString() != secondImage.GetPixel(i, j).ToString())
                            return false;
                return true;
            }
            else
                return false;
        }
    }
}