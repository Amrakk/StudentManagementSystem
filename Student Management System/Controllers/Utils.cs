using CsvHelper.Configuration;
using CsvHelper;
using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Student_Management_System.Controllers
{

    public class SystemStudentUtils
    {
        private static readonly string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";
        private static string rootDirectory = "Resources";
        
        public static string SaveAvatars(string email, string selectedPath)
        {
            string imagePath = "";
            string avatarPath = Path.Combine(rootDirectory, email);
            string folderPath = Path.Combine(workingDir, avatarPath);

            try
            {
                Directory.CreateDirectory(folderPath);
                string fileUploadedExtension = Path.GetExtension(selectedPath);
                imagePath = Path.Combine(folderPath, "avatar" + fileUploadedExtension);

                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return imagePath;
        }

        public static List<T> ImportCsvFile<T>(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<T>().ToList();
                return records;
            }
        }

        public static string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password,10);
        }

        public static void ExportCsvFile<T>(string filePath, List<T> list)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(list);
            }
        }

        public static void ExportToExcel<T>(string filePath, List<T> list)
        {
            FileInfo file = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(file))
            {
                if (package.Workbook.Worksheets["Sheet1"] != null)
                    package.Workbook.Worksheets.Delete("Sheet1");

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                Type type = typeof(T);

                var properties = type.GetProperties();
                // Set headers
                for (int col = 1; col <= properties.Length; col++)
                {
                    worksheet.Cells[1, col].Value = properties[col - 1].Name;
                }

                // Set values
                for (int row = 2; row <= list.Count + 1; row++)
                {
                    for (int col = 1; col <= properties.Length; col++)
                    {
                        var propertyValue = properties[col - 1].GetValue(list[row - 2], null);
                        worksheet.Cells[row, col].Value = propertyValue;
                    }
                }

                package.Save();
            }
        }

    }
}