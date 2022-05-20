using System.Collections.Generic;
namespace CADASTRO_ALUNO_MVC.Models
{

    public static class ListaAluno
    {
            private static List<Aluno> listaAlunos;
            static ListaAluno()
            {
                listaAlunos=new List<Aluno>();
            }
            public static List<Aluno> ListarALunos()
            {
                return listaAlunos;
            }
            public static void IncluirAluno(Aluno aluno)
            {
                listaAlunos.Add(aluno);
            }
    }
}