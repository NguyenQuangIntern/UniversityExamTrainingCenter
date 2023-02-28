using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10_NguyenMinhQuang
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddStudentToClass());
            StartProgram();
        }
        static void StartProgram()
        {
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            if (loginForm.DialogResult == DialogResult.OK)
            { 
                ManagementForm managementForm = new ManagementForm();
                loginForm.DialogResult = DialogResult.Cancel;
                Application.Run(managementForm);
                if (managementForm.DialogResult == DialogResult.Abort)
                {
                    StartProgram();
                }
            }
        }
    }
}
