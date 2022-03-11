using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace UniversityLogic
{
    public static class DataLoader
    {
        private static string STUDENTS_JSON = "students.json";
        private static string PROFESSOR_JSON = "professors.json";
        private static string COURSES_JSON = "courses.json";

        private static string parseJson(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static bool FetchStudents(out List<Student> students)
        {
            if (!File.Exists(STUDENTS_JSON))
            {
                students = null;
                return false;
            }
                
            students = JsonConvert.DeserializeObject<List<Student>>(parseJson(STUDENTS_JSON));
            return true;
        }

        public static void SaveStudents(List<Student> students)
        {
            string studentJson = JsonConvert.SerializeObject(students);
            File.WriteAllText(STUDENTS_JSON, studentJson);
        }

        public static bool FetchProfessors(out List<Professor> professors)
        {
            if (!File.Exists(PROFESSOR_JSON))
            {
                professors = null;
                return false;
            }

            professors = JsonConvert.DeserializeObject<List<Professor>>(parseJson(PROFESSOR_JSON));
            return true;
        }

        public static void SaveProfessors(List<Professor> professors)
        {
            string profJson = JsonConvert.SerializeObject(professors);
            File.WriteAllText(PROFESSOR_JSON, profJson);
        }

        public static bool FetchCourses(out List<Course> courses)
        {
            if (!File.Exists(COURSES_JSON))
            {
                courses = null;
                return false;
            }

            courses = JsonConvert.DeserializeObject<List<Course>>(parseJson(COURSES_JSON));
            return true;
        }

        public static void SaveCourses(List<Course> courses)
        {
            string courseJson = JsonConvert.SerializeObject(courses);
            File.WriteAllText(COURSES_JSON, courseJson);
        }

    }
}
