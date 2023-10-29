using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

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

    }
}
