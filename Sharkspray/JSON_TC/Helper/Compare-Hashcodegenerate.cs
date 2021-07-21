using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using OfficeOpenXml;

namespace Sharkspray.JSON_TC.Helper
{
    class Compare_Hashcodegenerate
    {
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        //public static string _sourcePath = _rootPath + "\\TestFiles";
        public static string _refPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\Reference_files");
        public void Hashcalulation(string refrenece_file)
        {

            MD5 md5 = MD5.Create();
            var parsed = new Dictionary<object, object>
            {

            };
            string ref_file = _refPath + refrenece_file;
            var files = Directory.GetFiles(ref_file, "*.*", SearchOption.AllDirectories)
                                    .OrderBy(p => p).ToList();
            for (int i = 0; i < files.Count; i++)
            {
                string file = files[i];
                if (file.EndsWith(".pdf"))
                {
                    using (var stream = File.OpenRead(file))
                    {
                        parsed[file] = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                    }
                }
                else if (file.EndsWith((".xlsx")))
                {
                    MemoryStream ms = new MemoryStream();
                    using (FileStream fs = File.OpenRead(file))
                    using (ExcelPackage excelPackage = new ExcelPackage(fs))
                    {
                        ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                        ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets["General Info"];
                        excelWorksheet.Cells[3, 52].Value = "";
                        excelWorksheet.Cells[3, 53].Value = "";


                        for (int k = 29; k <= 51; k++)
                        {
                            excelWorksheet.Cells[4, k].Value = "";
                        }
                        excelPackage.SaveAs(ms); // This is the important part.



                        parsed[file] = BitConverter.ToString(md5.ComputeHash(ms)).Replace("-", string.Empty);
                    }
                }
                else
                {
                    // All other files are material data cards
                    // To parse them, skip lines that contain date info or
                    // contain verification code
                    String lines = "";
                    using (System.IO.StreamReader file1 = new System.IO.StreamReader(file))
                    {
                        foreach (var line in file1.ReadLine())
                        {
                            String line1 = line + "";
                            if (!line1.Contains("Verification Code:") && !line1.Contains("Material model exported"))
                            {
                                lines += line1;
                            }
                        }
                        byte[] bytes = Encoding.ASCII.GetBytes(lines);
                        parsed[file] = BitConverter.ToString(md5.ComputeHash(bytes.ToArray<byte>())).Replace("-", string.Empty);
                    }
                }
            }
           // return parsed;

        }
    }
    
}
 










    