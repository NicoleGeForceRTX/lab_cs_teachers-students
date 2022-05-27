using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Laboratory2.Models;
using Newtonsoft.Json;

namespace Laboratory2.Repositories
{
    public class StudentRepositoryImpl : IStudentsRepository
    {
        private const string FileName = "students.json";

        private static StudentRepositoryImpl _instance;
        
        [JsonProperty] private List<Student> _students = new List<Student>();
        
        [JsonProperty] private int _nextStudentId;
        private int NextStudentId => _nextStudentId++;

        public static IStudentsRepository GetInstance()
        {
            if (_instance != null) return _instance;
            if (!File.Exists(FileName))
            {
                _instance = new StudentRepositoryImpl();
            }
            else
            {
                var jsonText = File.ReadAllText(FileName);
                try
                {
                    _instance = JsonConvert.DeserializeObject<StudentRepositoryImpl>(jsonText);
                }
                catch (Exception)
                {
                    _instance = new StudentRepositoryImpl();
                }
            }

            return _instance;
        }

        public static void SaveInstance()
        {
            var jsonText = JsonConvert.SerializeObject(_instance);
            File.WriteAllText(FileName, jsonText);
        }

        private StudentRepositoryImpl()
        {
        }

        public void AddOrUpdate(Student student)
        {
            var index = _students.FindIndex(studentItem => studentItem.Id == student.Id);
            if (index == -1)
            {
                if (student.Id == -1)
                {
                    student.Id = NextStudentId;
                }
                _students.Add(student);
            }
            else
            {
                _students[index] = student;
            }
        }

        public void Delete(Student student)
        {
            _students.Remove(student);
        }

        public void DeleteById(int id)
        {
            var index = _students.FindIndex(studentItem => studentItem.Id == id);
            if (index == -1) return;
            _students.RemoveAt(index);
        }

        public void DeleteAll()
        {
            _students.Clear();
        }

        public List<Student> All() => _students;

        public List<Student> BySubjectId(int subjectId) => _students
            .Where(student => student.SubjectGrades.Any(subjectGrade => subjectGrade.SubjectId == subjectId))
            .ToList();

        public Student ById(int studentId) => _students.Find(student => student.Id == studentId);
    }
}