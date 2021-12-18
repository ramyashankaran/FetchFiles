using System;

namespace FetchFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AWSFileDownload.Class1 awsS3Helper = new AWSFileDownload.Class1();


            //Upload
            string filePath = @"C:\Users\rshan\Downloads\GoogleBooksAPI.docx";
            awsS3Helper.UploadFile(filePath);


            awsS3Helper.GetS3Files();

        }
    }
}
