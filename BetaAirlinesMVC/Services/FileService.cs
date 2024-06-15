using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BetaAirlinesMVC.Services
{
    public class FileService
    {
        public string ReadFile(string path, string body)
        {
            using (StreamReader stream = new StreamReader(path))
            {
                body = stream.ReadToEnd();
            }
            return body;
        }
    }
}