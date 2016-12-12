using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoductor.Model
{
    public static class Listado
    {

        private static ObservableCollection<Pista> listado;
        public static ObservableCollection<Pista> lista_canciones()
        {
            listado = new ObservableCollection<Pista>();

            listado.Add(new Pista("Buscando a Dori", "Pixar", "Dibujos", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asdasd", "lkk", "dfg", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("rwer", "lkk", "kasddfg", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asdasd", "lkk", "dgf", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("fs", "lkk", "kasd", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("ad", "lkk", "dgf", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asd", "lkk", "kasd", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asdasd", "lkk", "dfg", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asdasd", "lkk", "kasd", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("dgdfg", "lkk", "gdf", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));
            listado.Add(new Pista("asd", "lkk", "dgf", "http://cdn7.streamcloud.eu:8080/exv74jb7vooax3ptx2uybuxzu6ttikumhm4mpv3ucg4xe2abmep53cdwia/video.mp4"));

            return listado;
        }
    }
}
