using MinutesGenerationApp.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace MinutesGenerationApp.Provider
{
    /// <summary>
    /// 音声認識する
    /// </summary>
    public class VoiceRecognitionProvider
    {
        /// <summary>
        /// 音声認識エンジン
        /// </summary>
        SpeechRecognitionEngine SpeechEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ja-JP"));
 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public VoiceRecognitionProvider() 
        {
            var a = SpeechEngine;
        }

        /// <summary>
        /// 音声認識開始
        /// </summary>
        /// <returns>音声認識開始できたか？</returns>
        public string RecStart() 
        {
            try
            {
                return ConstTable.Success;
            }
            catch (Exception e)
            {
                //ログだしたい、エラーメッセージも出したい
                return ConstTable.Failure;
            }
        }

        /// <summary>
        /// 音声認識停止
        /// </summary>
        /// <returns></returns>
        public string RecStop() 
        {
            try
            {
                return "議事録データ";
            }
            catch (Exception)
            {
                //ログだしたい、エラーメッセージも出したい
                return ConstTable.Failure;
            }
        }



    }
}
