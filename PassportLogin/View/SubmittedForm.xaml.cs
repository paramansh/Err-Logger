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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ErrorLog.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubmittedForm : Page
    {
        public SubmittedForm()
        {
            this.InitializeComponent();
        }

        private void Conceptual_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "Conceptual Shortcoming --- Remedial Measures  : \nStep 1 : Revise class notes\nStep 2 : Create flow chart of concept for mind - mapping and relations\nSolve additional problems\nTry to resolve the questions in which errors were committed in this test ";
        }

        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "Calculation Error ---- Remedial Measures : \nBefore each test, prime yourself for intensive mental calculations by adding and multiplying any two random numbers\nFind out if the error was due to wrong calculation or because of misrecognition of digits due to untidy work";
        }

        private void Careless_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "Careless Oversight --- Remedial Measures : \nDraw the mindmap / flowchart of the problem to analyse at which step the error occurred\nIdentify if the error was the result of skipping over some vital piece of information, if yes,start underlining the important words in the question paper\nIf you missed a term in your expression, start dividing your workspace into different columns, one question per column";
        }

        private void Recall_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "Shortcoming in recall --- Remedial Measures :\nStart using improvised memory techniques like mnemonics and wall / desktop charts\nTry to create a mindmap/ flowchart of the entire chapter/ topic.This will enable you to link concepts and facilitate in easier recall and ad hoc derivation if necessary.";
        }

        private void Time_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "Time Constraint --- Remedial Measures\nIdentify if the shortage of time cropped up due to repeated calculation errors or incorrect application for the same question.\nIf yes, learn to prioritize questions and be confident of leaving a question midway if it is making you commit errors\nIf the error was due to a lot of time taken to formulate the approach to a question, refer to the section of Conceptual Shortcoming\nCompute the difference in the time taken to solve a question in the test and the time taken to solve the same question at home.\nIf the difference is turning out to be arbitrarily large and you could solve the question at home without a lot of difficulty(provided you did not work on the question after the test), relax…. You can put it down to nerves";
        }
    }
}
