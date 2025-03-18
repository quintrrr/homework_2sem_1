using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1.classes
{
    class ImageInfo
    {
        public string Path { get; set; }
        public string Title { get; set; }

        public ImageInfo(string path, string title)
        {
            Path = path;
            Title = title;
        }
    }
}
