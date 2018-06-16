using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XF.MVVMBasic.ViewModel;

namespace XF.MVVMBasic.Model
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string RM { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                App.AlunoVM.OnAdicionarAlunoCMD.AdicionarCanExecuteChanged();
            }
        }

        public string Email { get ; set; }
    }

}
