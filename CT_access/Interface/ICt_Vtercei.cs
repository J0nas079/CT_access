using CT_access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_access.Interface
{
    interface ICt_Vtercei
    {
        void SetvTerceiro(Ct_VeiculosTer ctVeiculosTercei);
        void UpdateDados(Ct_VeiculosTer ctVeiculosTercei);
        List<CtVeiculosTercei> GetCtVeiculosTerceis();
        void DeletarVter(Ct_VeiculosTer ctVeiculosTercei);
        List<Ct_VeiculosTer> PesquisaId(int id);
    }
}
