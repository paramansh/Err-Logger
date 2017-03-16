using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Input;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace ErrorLog.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public static class GlobalString
    {
        // parameterless constructor required for static class
        static GlobalString() { GlobString = ""; } // default value

        // public get, and private set for strict access control
        public static string GlobString { get; private set; }
        public static void SetGlobalString(string newString)
        {
            GlobString = newString;
        }

    }
    public static class GlobalsConc
        {
            // parameterless constructor required for static class
            static GlobalsConc() { GlobalInt = 0; } // default value

            // public get, and private set for strict access control
            public static int GlobalInt { get; private set; }
            public static void SetGlobalInt(int newInt)
            {
                GlobalInt = newInt;
            }

        }
    public static class GlobalsSil
    {
        // parameterless constructor required for static class
        static GlobalsSil() { GlobalInt = 0; } // default value

        // public get, and private set for strict access control
        public static int GlobalInt { get; private set; }
        public static void SetGlobalInt(int newInt)
        {
            GlobalInt = newInt;
        }

    }
    public static class GlobalsOth
    {
        // parameterless constructor required for static class
        static GlobalsOth() { GlobalInt = 0; } // default value

        // public get, and private set for strict access control
        public static int GlobalInt { get; private set; }
        public static void SetGlobalInt(int newInt)
        {
            GlobalInt = newInt;
        }

    }
    public static class GlobalsRcl
    {
        // parameterless constructor required for static class
        static GlobalsRcl() { GlobalInt = 0; } // default value

        // public get, and private set for strict access control
        public static int GlobalInt { get; private set; }
        public static void SetGlobalInt(int newInt)
        {
            GlobalInt = newInt;
        }

    }
    public static class GlobalsTime
    {
        // parameterless constructor required for static class
        static GlobalsTime() { GlobalInt = 0; } // default value

        // public get, and private set for strict access control
        public static int GlobalInt { get; private set; }
        public static void SetGlobalInt(int newInt)
        {
            GlobalInt = newInt;
        }

    }

    public sealed partial class NewEntry : Page
    {
        int conceptualMist = 0;
        int sillyMist = 0;
        int otherMist = 0;
        int recallMist = 0;
        int timeMist = 0;
        string checkString = "";
        string str = "";
        public NewEntry()
        {
            this.InitializeComponent();
        }
        
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Welcome));
        }

        private void submitbutton_Click(object sender, RoutedEventArgs e)
        {
            checkString = textBox.Text;
            str = GlobalString.GlobString;
            str = str + ". " + checkString;
            GlobalString.SetGlobalString(str);
            Frame.Navigate(typeof(NewEntry));
            //textBox.Text = "Enter your Mistake";
           
        }

        private void conceptualcheckBox_Checked(object sender, RoutedEventArgs e)
        {
            conceptualMist = GlobalsConc.GlobalInt;
            conceptualMist++;
            GlobalsConc.SetGlobalInt(conceptualMist++);
        }

        private void othercheckBox_Checked(object sender, RoutedEventArgs e)
        {
            otherMist = GlobalsOth.GlobalInt;
            otherMist++;
            GlobalsOth.SetGlobalInt(otherMist);
        }

        private void graphbutton_Click(object sender, RoutedEventArgs e)
        {
            checkString = textBox.Text;
            str = GlobalString.GlobString;
            str = str + ". " + checkString;
            GlobalString.SetGlobalString(str);
            Frame.Navigate(typeof(BlankPage1));
        }

        private void sillycheckBox_Checked(object sender, RoutedEventArgs e)
        {
            sillyMist=GlobalsSil.GlobalInt;
            sillyMist++;
            GlobalsSil.SetGlobalInt(sillyMist);
        }

        private void recallcheckBox_Checked(object sender, RoutedEventArgs e)
        {
            recallMist = GlobalsRcl.GlobalInt;
            recallMist++;
            GlobalsRcl.SetGlobalInt(recallMist);
        }

        private void timecheckBox_Checked(object sender, RoutedEventArgs e)
        {
            timeMist = GlobalsTime.GlobalInt;
            timeMist++;
            GlobalsTime.SetGlobalInt(timeMist);
        }
    }

}
