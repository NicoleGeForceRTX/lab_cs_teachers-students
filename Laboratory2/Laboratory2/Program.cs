using System;
using System.IO;
using System.Windows.Forms;
using Laboratory2.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;
using Newtonsoft.Json;

namespace Laboratory2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm(
                StudentRepositoryImpl.GetInstance(), 
                TeachersRepositoryImpl.GetInstance(),
                SubjectsRepositoryImpl.GetInstance()));
            
            SubjectsRepositoryImpl.SaveInstance();
            StudentRepositoryImpl.SaveInstance();
            TeachersRepositoryImpl.SaveInstance();

        }

    }
}