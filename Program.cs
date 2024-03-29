﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCP.Source.UI;
using VCP.Source.Manager;

using System.Security.Principal;
using System.Diagnostics;

namespace VCP
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (TaskManager.Instance.Init(System.Threading.Thread.CurrentThread.ManagedThreadId))
            {

                FormSplash formSplash = new FormSplash();
                Application.Run(formSplash);
                Application.Run(new FormMain());
            }

            //if (IsAdministrator() == false) // 관리자 권한으로 실행되지 않는 경우라면 ..
            //{
            //    try
            //    {
            //        ProcessStartInfo procInfo = new ProcessStartInfo();
            //        procInfo.UseShellExecute = true;
            //        procInfo.FileName = Application.ExecutablePath;
            //        procInfo.WorkingDirectory = Environment.CurrentDirectory;
            //        procInfo.Verb = "runas";
            //        Process.Start(procInfo);
            //    }
            //    catch (Exception ex)
            //    {
            //        // 사용자가 프로그램을 관리자 권한으로 실행하기를 원하지 않을 경우에 대한 처리
            //        MessageBox.Show(ex.Message);
            //        return;
            //    }
            //}
            //else
            //{ // 처음부터 프로그램은 관리자 권한으로 실행되고 있는 경우라면 ..
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    if (TaskManager.Instance.Init(System.Threading.Thread.CurrentThread.ManagedThreadId))
            //    {

            //        FormSplash formSplash = new FormSplash();
            //        Application.Run(formSplash);
            //        Application.Run(new FormMain());
            //    }
            //}
        }

        //public static bool IsAdministrator()
        //{
        //    WindowsIdentity identity = WindowsIdentity.GetCurrent();

        //    if (identity != null)
        //    {
        //        WindowsPrincipal principal = new WindowsPrincipal(identity);
        //        return principal.IsInRole(WindowsBuiltInRole.Administrator);
        //    }
        //    return false;
        //}
    }
}
