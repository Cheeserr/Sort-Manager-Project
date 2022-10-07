using SortManagerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerController
{
    public abstract class SortFactory
    {
        public abstract ISortable ChooseSort(int choosenSort);
    }
}
