using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


namespace Utilidades
{
    public class Formato
    {
        public static Boolean isNumeric(String cadena)
        {
            if (Regex.IsMatch(cadena, @"/^[0-9]+$/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean isAlfanumerico(String cadena)
        {
            if (Regex.IsMatch(cadena, @"/^[0-9a-zA-Z]+$/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean isUser(String user)
        {
            if (Regex.IsMatch(user, @"[a-zA-Z0-9]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static Boolean fileCorrectFormat(Stream archivo)
        {
            /*
            Boolean fileOK = false;
            String path = Server.MapPath("~/Libros/");
            if (FileUpload1.HasFile)
            {
                String fileExtension =
                    System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(path
                        + FileUpload1.FileName);
                    Label1.Text = "File uploaded!";
                }
                catch (Exception ex)
                {
                    Label1.Text = "File could not be uploaded.";
                }
            }
            else
            {
                Label1.Text = "Cannot accept files of this type.";
            }
            */
            return true;
        }
         

    }
}
