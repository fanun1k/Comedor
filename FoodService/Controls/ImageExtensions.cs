using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodService.Controls
{
    public static class ImageExtensions
    {
        public static Image ToImage(this byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
