using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI_Models
{

  public class AlunoDisciplina
  {
    public AlunoDisciplina() { }
    public AlunoDisciplina(int alunoId, int DisciplinaId)
    {
      this.AlunoId = alunoId;
      this.DisciplinaId = DisciplinaId;
    }
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }
    public int DisciplinaId { get; set; }
    public Disciplina Disciplina { get; set; }
  }
}