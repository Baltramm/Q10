using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IMailer, IReader, IWriter
    {
        void IReader.Read()
        {
            
        }

        void IMailer.SendEmail()
        {
            
        }

        void IWriter.Write()
        {
            
        }
    }

}
