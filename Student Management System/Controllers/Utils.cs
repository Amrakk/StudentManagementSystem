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
using System.Reflection;

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

        public static List<T> ImportCsvFile<T, K>(string filePath, Func<K, T> convertFunction)
        {
            var resultList = new List<T>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<K>().ToList();

                foreach (var record in records)
                {
                    T convertedRecord = convertFunction(record);
                    resultList.Add(convertedRecord);
                }
            }

            return resultList;
        }

        public static List<T> ImportExcelFile<T, K>(string filePath, Func<K, T> convertFunction)
        {
            var resultList = new List<T>();
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                var columnNames = Enumerable.Range(1, colCount)
                                    .Select(col => worksheet.Cells[1, col].Value.ToString())
                                    .ToList();

                for (int row = 2; row <= rowCount; row++)
                {
                    K obj = Activator.CreateInstance<K>();

                    try
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            string columnName = columnNames[col - 1];
                            object cellValue = worksheet.Cells[row, col].Value;

                            PropertyInfo property = typeof(K).GetProperty(columnName);

                            if (property != null)
                            {
                                Type propertyType = property.PropertyType;

                                if (propertyType == typeof(int) || (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                                {
                                    // Convert double to int or nullable int
                                    if (cellValue != null)
                                    {
                                        if (propertyType == typeof(int))
                                            cellValue = Convert.ToInt32(cellValue);
                                        else if (propertyType == typeof(int?))
                                            cellValue = (int?)Convert.ToInt32(cellValue);
                                    }
                                    else
                                    {
                                        // Handle null values here if needed
                                        cellValue = null;
                                    }
                                }
                                else if (propertyType == typeof(string))
                                {
                                    // Convert other types to string
                                    cellValue = cellValue?.ToString();
                                }

                                // Set the property value
                                property.SetValue(obj, cellValue);
                            }
                        }
                        
                        T targetObj = convertFunction(obj);

                        resultList.Add(targetObj);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error at row {row}: {ex.Message}");
                    }
                }
            }

            return resultList;
        }

        public static string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password,10);
        }

        public static void ExportCsvFile<T>(string filePath, List<T> list, Dictionary<string, string> columnMappings = null)
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

                ExcelWorksheet newWorksheet = package.Workbook.Worksheets.Add("Sheet1");

                Type type = typeof(T);
                var properties = type.GetProperties();

                // Set headers
                for (int col = 1; col <= properties.Length; col++)
                {
                    newWorksheet.Cells[1, col].Value = properties[col - 1].Name;
                }

                // Set values
                for (int row = 2; row <= list.Count + 1; row++)
                {
                    for (int col = 1; col <= properties.Length; col++)
                    {
                        var propertyValue = properties[col - 1].GetValue(list[row - 2], null);
                        newWorksheet.Cells[row, col].Value = propertyValue;
                    }
                }

                try { package.Save(); }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static DateTime? ParseDate(string dateString)
        {
            if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                return null;
            }
        }

        public static List<T> ReadWorksheet<T>(ExcelWorksheet worksheet, Func<ExcelRange, T> mapFunction)
        {
            var resultList = new List<T>();

            if (worksheet != null)
            {
                int startRow = worksheet.Dimension.Start.Row;
                int endRow = worksheet.Dimension.End.Row;

                for (int row = startRow + 1; row <= endRow; row++)
                {
                    var rowRange = worksheet.Cells[row, worksheet.Dimension.Start.Column, row, worksheet.Dimension.End.Column];
                    T mappedRow = mapFunction(rowRange);
                    resultList.Add(mappedRow);
                }
            }
            else
            {
                Console.WriteLine("Worksheet is null.");
            }

            return resultList;
        }
    }
}