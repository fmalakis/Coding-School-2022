using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityLogic
{
    public class ProfessorManager
    {
        public List<Professor> Professors { get; set; }

        public ProfessorManager()
        {
            Professors = new List<Professor>();
        }

        public void Add(Professor professor)
        {
            if (professor == null)
                throw new ArgumentNullException();

            Professors.Add(professor);
        }

        public void Remove(Professor professor)
        {
            Professors.Remove(professor);
        }

        public void Update(Professor professor)
        {
            Professor prf = Professors.FirstOrDefault(x => x.ID == professor.ID);

            if (prf == null)
                return;

            prf = professor;
        }
    }
}
