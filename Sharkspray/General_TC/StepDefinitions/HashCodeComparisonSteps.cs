using NUnit.Framework;
using OpenQA.Selenium;
using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    public class HashCodeComparisonSteps
    {
        public static string[] filePaths_Ref = null;
        public static string[] filePaths_Test = null;
        public static string _File1 = null;
        public static string _File2 = null;
        public static string _HashCode1 = null;
        public static string _HashCode2 = null;
        public static string[] ReferenceFiles = null;
        public static string[] TestFiles = null;
        public static string _RefFile = null;
        public static string _TestFile = null;
        public static readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\HASH_CODE");
        
        [Given(@"I Check whether directories are available or not")]
        public void GivenICheckWhetherDirectoriesAreAvailableOrNot()
        {
            if (Directory.Exists(_rootPath + @"\ReferenceFiles\Zipped"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\ReferenceFiles\Zipped");
            }

            if (Directory.Exists(_rootPath + @"\ReferenceFiles\UnZipped"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\ReferenceFiles\UnZipped");
            }
            if (Directory.Exists(_rootPath + @"\ReferenceFiles\HASHCODES"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\ReferenceFiles\HASHCODES");
            }


            if (Directory.Exists(_rootPath + @"\TestFiles\Zipped"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\TestFiles\Zipped");
            }

            if (Directory.Exists(_rootPath + @"\TestFiles\UnZipped"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\TestFiles\UnZipped");
            }
            if (Directory.Exists(_rootPath + @"\TestFiles\HASHCODES"))
            {
                Console.WriteLine("Directory Available");
            }
            else
            {
                Directory.CreateDirectory(_rootPath + @"\TestFiles\HASHCODES");
            }
        }

        [When(@"I Unzip the file")]
        public void WhenIUnzipTheFile()
        {
            string ReferenceZipPath = _rootPath + @"\ReferenceFiles\Zipped\rheology_xlsx_ModelFiles.zip";
            string ReferenceExtractPath = _rootPath + @"\ReferenceFiles\UnZipped";
            ZipFile.ExtractToDirectory(ReferenceZipPath, ReferenceExtractPath);

            string TestZipPath = _rootPath + @"\TestFiles\Zipped\rheology_ModelFiles.zip";
            string TestExtractPath = _rootPath + @"\TestFiles\UnZipped";
            ZipFile.ExtractToDirectory(TestZipPath, TestExtractPath);
        }

        [When(@"I Calculate hash code of the files")]
        public void WhenICalculateHashCodeOfTheFiles()
        {
            filePaths_Ref = Directory.GetFiles(_rootPath + @"\ReferenceFiles\UnZipped\", "*",
                                        SearchOption.AllDirectories);


            foreach (string file_Ref in filePaths_Ref)
            {
                string output;
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(file_Ref))
                    {
                        byte[] checksum = md5.ComputeHash(stream);
                        output = BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
                        _File1 = file_Ref.Replace(_rootPath + @"\ReferenceFiles\UnZipped\", "");
                        _HashCode1 = output;
                        //Console.WriteLine("HASH CODE of " + _File1 + " = " + _HashCode1);
                        File.WriteAllText(_rootPath + @"\ReferenceFiles\HASHCODES\" + _File1.Replace(@"\", "_") + "__" + _HashCode1 + ".txt", _HashCode1);

                    }

                }
            }

            filePaths_Test = Directory.GetFiles(_rootPath + @"\TestFiles\UnZipped\", "*",
                                        SearchOption.AllDirectories);


            foreach (string file_Test in filePaths_Test)
            {
                string output2;
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(file_Test))
                    {
                        byte[] checksum = md5.ComputeHash(stream);
                        output2 = BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();

                        _File2 = file_Test.Replace(_rootPath + @"\TestFiles\UnZipped\", "");
                        _HashCode2 = output2;
                        //Console.WriteLine("HASH CODE of " + _File2 + " = " + _HashCode2);
                        File.WriteAllText(_rootPath + @"\TestFiles\HASHCODES\" + _File2.Replace(@"\", "_") + "__" + _HashCode2 + ".txt", _HashCode2);

                    }

                }

            }
        }
        
        [Then(@"I Compare the hash codes")]
        public void ThenICompareTheHashCodes()
        {

            ReferenceFiles = Directory.GetFiles(_rootPath + @"\ReferenceFiles\HASHCODES\", "*",
                                         SearchOption.AllDirectories);

            List<string> ReferenceComparisionFiles = new List<string>();

            foreach (string files_reff in ReferenceFiles)
            {
                _RefFile = files_reff.Replace(_rootPath + @"\ReferenceFiles\HASHCODES\", "");
                ReferenceComparisionFiles.Add(_RefFile);
                //Console.WriteLine(_RefFile);

            }


            TestFiles = Directory.GetFiles(_rootPath + @"\TestFiles\HASHCODES\", "*",
                                         SearchOption.AllDirectories);

            List<string> TestComparisionFiles = new List<string>();


            foreach (string files_test in TestFiles)
            {
                _TestFile = files_test.Replace(_rootPath + @"\TestFiles\HASHCODES\", "");
                TestComparisionFiles.Add(_TestFile);
                // Console.WriteLine(_TestFile);

            }



            IEnumerable<string> list3;
            list3 = ReferenceComparisionFiles.Except(TestComparisionFiles);
            foreach (string value in list3)
            {
                string ext = value.Substring(0, value.LastIndexOf("__") + 1);
                Console.WriteLine("Hash Code Not Matched for : " + ext);
            }
        }
    }
}
