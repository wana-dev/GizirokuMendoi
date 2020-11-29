using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesGenerationApp.Provider
{
    /// <summary>
    /// テキストデータに吐き出す
    /// </summary>
    public static class TextOutputProvider
    {
        /// <summary>
        /// Folder作成 
        /// </summary>
        public static void CreateFolder(string FolderPath = @"C:\Users\fluwa\Documents\議事録") 
        {
            try
            {
                //フォルダが存在していたら作らない
                if (FolderCheck())
                {
                    return;
                }

                ///Folderを作成
                Directory.CreateDirectory(FolderPath);
            }
            catch (Exception e)
            {
                //エラーコードをエラーログとして出したい！
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="fileName"></param>
        /// <param name="FolderPath"></param>
        public static void CreateTextFile(string minutes, string fileName, string FolderPath = @"C:\Users\fluwa\Documents\議事録") 
        {
            try
            {
                File.AppendAllText(FolderPath + fileName, minutes);
            }
            catch (Exception e)
            {
                //エラーコードをエラーログとして出したい！
                throw;
            }
        }

        /// <summary>
        /// Folderが存在してるかチェック
        /// </summary>
        /// <param name="FolderPath">Folderパス</param>
        /// <returns>そのディレクトリが存在してたらture</returns>
        private static bool FolderCheck(string FolderPath = @"C:\Users\fluwa\Documents\議事録") 
        {
            if (Directory.Exists(FolderPath))
            {
                return true;
            }
            return false;
        }
    }
}
