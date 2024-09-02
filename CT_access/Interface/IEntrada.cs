using CT_access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_access.Interface
{
    //Interface Entrada Caminhão
    public interface IEntrada
    {
        List<Caminhao> ObterCaminhao();
        void AdcionarCaminhao(Caminhao caminhao);
        void DeleterCaminhao(int id);
        void AtualizarCaminhao(Caminhao caminhao);
        List<Caminhao>DiaCamihao();
        bool Validaruser(Usuario usuario);
    }
}
