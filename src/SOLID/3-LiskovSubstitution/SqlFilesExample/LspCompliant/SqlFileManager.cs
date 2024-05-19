using src.SOLID._3_LiskovSubstitution.SqlFilesExample.LspComplient.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace src.SOLID._3_LiskovSubstitution.SqlFilesExample.LspComplient
{
    public class SqlFileManager
    {
        /***
                Correctly identifying the abstractions and the responsability separation method and using them in 
            the method signature is essential to make it Liskov compliant.
                The key lies in ensuring that any concrete classes implementing the interfaces behave consistently 
            with the expectations set by the interfaces.
         ***/

        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in aLstReadableFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public string  SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }

            return "Text sucessfully saved.";
        }
    }
}
