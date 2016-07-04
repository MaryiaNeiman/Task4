using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    class Rectangle
    {

        public int calc (int W, int H, int w, int h)
        {
            return Math.Max(pack(W, H, w, h), pack(W, H, h, w));
        }

        public int pack (int W, int H, int w, int h)
        {
            var n = (W / w | 0) * (H / h | 0);
            if (W % w >= h && H >= w)
            {
                n += pack(W % w, H, h, w);
            }
            else if (H % h >= w && W >= h)
            {
                n += pack(W, H % h, h, w);
            }
            return n;
        }
    }
}
