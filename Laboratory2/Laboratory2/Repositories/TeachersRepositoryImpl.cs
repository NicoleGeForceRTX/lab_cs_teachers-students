using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Laboratory2.Models;
using Newtonsoft.Json;

namespace Laboratory2.Repositories
{
    public class TeachersRepositoryImpl : ITeachersRepository
    {

        private const string FileName = "teacher.json";

        private static TeachersRepositoryImpl _instance;

        [JsonProperty] private List<Teacher> _teachers = new List<Teacher>();
        
        [JsonProperty] private int _nextTeacherId;
        private int NextTeacherId => _nextTeacherId++;

        public static ITeachersRepository GetInstance()
        {
            if (_instance != null) return _instance;
            if (!File.Exists(FileName))
            {
                _instance = new TeachersRepositoryImpl();
            }
            else
            {
                var jsonText = File.ReadAllText(FileName);
                try
                {
                    _instance = JsonConvert.DeserializeObject<TeachersRepositoryImpl>(jsonText);
                }
                catch (Exception)
                {
                    _instance = new TeachersRepositoryImpl();
                }
            }
            return _instance;
        }
        
        public static void SaveInstance()
        {
            var jsonText = JsonConvert.SerializeObject(_instance);
            File.WriteAllText(FileName, jsonText);
        }

        public void AddOrUpdate(Teacher teacher)
        {
            var index = _teachers.FindIndex(teacherItem => teacherItem.Id == teacher.Id);
            if (index == -1)
            {
                if (teacher.Id == -1)
                {
                    teacher.Id = NextTeacherId;
                }
                _teachers.Add(teacher);
            }
            else
            {
                _teachers[index] = teacher;
            }
        }

        public void Delete(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public void DeleteById(int id)
        {
            var index = _teachers.FindIndex(subjectItem => subjectItem.Id == id);
            if (index == -1) return;
            _teachers.RemoveAt(index);
        }

        public void DeleteAll()
        {
            _teachers.Clear();
        }

        public List<Teacher> All() => _teachers;

        public List<Teacher> BySubjectId(int subjectId) => _teachers
            .Where(teacher => teacher.SubjectsId.Any(id => id == subjectId))
            .ToList();

        public Teacher ById(int teacherId) => _teachers.Find(teacher => teacher.Id == teacherId);
    }
}