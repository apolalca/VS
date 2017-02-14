using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public class Sonido
    {
        public string Name { get; set; }
        public string AudioFile { get; set; }
        public string ImgFile { get; set; }
        public CategoryAnim categoria { get; set; }


        public Sonido(String name, CategoryAnim categ)
        {
            Name = name;
            categoria = categ;
            AudioFile = String.Format("Assets/Audio/{0}/{1}.wav", categ, name);
            ImgFile = String.Format("Assets/img/{0}/{1}.png", categ, name);
        }
    }
}
