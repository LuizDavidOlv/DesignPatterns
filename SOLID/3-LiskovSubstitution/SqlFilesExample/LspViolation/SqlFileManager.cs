using System.Collections.Generic;
using System.Text;

namespace src.SOLID._3_LiskovSubstitution.SqlFilesExample.LspViolation
{
    /***
        If it is necessary to skip read-only files, we need to modify the SaveTextIntoFiles() method to
        avoid calling the SaveText() method on ReadOnlySqlFile instances.

        It it not possible to use the Liskov Substitution Principle in this case.
        It is not possible to use ReadOnlySqlFile as a substitute for SqlFile.
    ***/
    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                objFile.SaveText();

                //if (objFile is not ReadOnlySqlFile)
                //{
                //    objFile.SaveText();
                //}
            }
        }
    }
}
