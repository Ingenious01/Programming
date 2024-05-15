using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Input;
using System.ComponentModel;
using System.Drawing;
using System.Collections.ObjectModel;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для записи и считывания контактов из файла.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь до папки.
        /// </summary>
        private static string _directoryPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Путь до файла.
        /// </summary>
        private static string _filePath = Path.Combine(_directoryPath, "Contacts.json");        

        /// <summary>
        /// Проверка на наличия папки и файла.
        /// </summary>
        public static void IsCreateFolderAndFile()
        {
            if (Directory.Exists(_directoryPath) == false)
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (File.Exists(_filePath) == false)
            {
                using (FileStream fstream = new FileStream(_filePath, FileMode.Create))
                {
                    var text = "[]";
                    var buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// Считывает данные файла и возвращает их список. 
        /// </summary>
        public static ObservableCollection<Contact> GetData()
        {            
            using (FileStream fstream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<ObservableCollection<Contact>>(fstream);
            }
        }

        /// <summary>
        /// Записывает новые данные в файл.
        /// </summary>
        /// <param name="data">Новые данные.</param>
        public static void UpdateData(ObservableCollection<Contact> data)
        {
            string newDate = JsonSerializer.Serialize(data);
            using (FileStream fstream = new FileStream(_filePath, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(newDate);

                fstream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
