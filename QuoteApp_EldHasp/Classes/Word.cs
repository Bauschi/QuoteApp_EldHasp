using Microsoft.Office.Interop.Word;
using QuoteApp_EldHasp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace QuotationApp.Classes
{
    public static class Word
    {




        static Microsoft.Office.Interop.Word.Application WordApp;
        static Document TestApp;
         
          

        #region "Open Word and the two Templates"
       
        #endregion

        public static void GenerateLocalSolution()
        {
            try
            {
         WordApp = new Microsoft.Office.Interop.Word.Application(); 
                TestApp = WordApp.Documents.Open(@"D:\Projects\02_Ongoing_Projects\Tests\QuoteApp_EldHasp\QuoteApp_EldHasp\bin\Debug\Test.docx");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            //Dealer
            if (TestApp.Bookmarks.Exists("Dealer"))
            {
            Bookmark description = TestApp.Bookmarks["Dealer"];
            Range descRange = description.Range;
             descRange.Text = MainWindow.Data.Dealer;
            TestApp.Bookmarks.Add("Dealer", descRange);
            }

           
            //Make the Application Visible, so the user can Save the File whereever he wants
            if (!WordApp.Visible)
            {
                WordApp.Visible = true;
            }

        }

     
    }
}
