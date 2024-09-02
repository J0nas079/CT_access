using CT_access.Models;
using System.Data;

namespace CT_access.Interface
{
    interface  IctEmpresa
    {
        void SetVeiculos(CtVeiuloEmp ctVeiuloEmp);
        List<CtVeiuloEmp> GetVeiculos();
        void Getdados(int id);
        void DelDado(int id);
        void updateDados(CtVeiuloEmp ctVeiuloEmp);

    }
}
