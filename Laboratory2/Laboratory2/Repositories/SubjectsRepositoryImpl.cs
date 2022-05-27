using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Laboratory2.Models;
using Newtonsoft.Json;

namespace Laboratory2.Repositories
{
    public class SubjectsRepositoryImpl : ISubjectsRepository
    {
        private const string FileName = "subjects.json";

        private static SubjectsRepositoryImpl _instance;

        [JsonProperty] private List<Subject> _subjects = new List<Subject>();
        
        [JsonProperty] private int _nextSubjectId;
        private int NextSubjectId => _nextSubjectId++;

        public static ISubjectsRepository GetInstance()
        {
            if (_instance != null) return _instance;
            if (!File.Exists(FileName))
            {
                _instance = new SubjectsRepositoryImpl();
            }
            else
            {
                var jsonText = File.ReadAllText(FileName);
                try
                {
                    _instance = JsonConvert.DeserializeObject<SubjectsRepositoryImpl>(jsonText);
                }
                catch (Exception)
                {
                    _instance = new SubjectsRepositoryImpl();
                }
            }
            return _instance;
        }

        public static void SaveInstance()
        {
            var jsonText = JsonConvert.SerializeObject(_instance);
            File.WriteAllText(FileName, jsonText);
        }

        public void AddOrUpdate(Subject subject)
        {
            var index = _subjects.FindIndex(subjectItem => subjectItem.Id == subject.Id);
            if (index == -1)
            {
                if (subject.Id == -1)
                {
                    subject.Id = NextSubjectId;
                }
                _subjects.Add(subject);
            }
            else
            {
                _subjects[index] = subject;
            }
        }

        public void Delete(Subject subject)
        {
            _subjects.Remove(subject);
        }

        public void DeleteById(int id)
        {
            var index = _subjects.FindIndex(subjectItem => subjectItem.Id == id);
            if (index == -1) return;
            _subjects.RemoveAt(index);
        }

        public void DeleteAll()
        {
            _subjects.Clear();
        }

        public List<Subject> All() => _subjects;
        
        public Subject ById(int subjectId) => _subjects.Find(subject => subject.Id == subjectId);
    }
}