using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.App_Code;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
        {
            Aluno aluno = InicializarAluno();
            Professor professor = InicializarProfessor();

            InitializeComponent();

            painelAluno.BindingContext = aluno;
            painelProfessor.BindingContext = professor;
        }

        private static Aluno InicializarAluno()
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "João Silva",
                Email = "joao@fiap.com"
            };
        }

        private static Professor InicializarProfessor()
        {
            return new Professor()
            {
                Nome = "Maria",
                Curso = "Xamarin"
            };
        }
    }
}