using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg_2782_Project_1
{
    class Filehandler
    {
        string thePath = @"D:\Prg 281 test2\Userlist.txt";
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        List<LoginDataClass> Employees = new List<LoginDataClass>();
        internal List<LoginDataClass> fromTextFile = new List<LoginDataClass>();

        public void writeRedgister(string username, string password)
        {
            string aLogin= $"{username},{password}";
            try
            {
                using (fs = new FileStream(thePath, FileMode.Append, FileAccess.Write))
                {
                    using (sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(aLogin);
                        Employees.Add(new LoginDataClass(username, password));
                    }

                }
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
       
            
        
    }
}
