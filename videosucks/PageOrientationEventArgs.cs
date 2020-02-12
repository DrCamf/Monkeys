using System;
using System.Collections.Generic;
using System.Text;

namespace videosucks
{
    public class PageOrientationEventArgs : EventArgs
    {
        public PageOrientationEventArgs(PageOrientation orientation)
        {
            Orientation = orientation;
        }

        public PageOrientation Orientation { get; }
    }

    public enum PageOrientation
    {
        Landscape = 0,
        Portrait = 1,
        Unknown = 2
    }
}
