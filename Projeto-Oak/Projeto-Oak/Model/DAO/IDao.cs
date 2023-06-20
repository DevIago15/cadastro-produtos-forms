using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Oak.Model.DAO
{
    public interface IDao
    {
        // bool consultar(object objeto);
        bool excluir(object objeto);
        DataTable consultar1(object objeto);
        int inserir1(object objeto);
        List<Object> consultar(string sql);
    }
}
