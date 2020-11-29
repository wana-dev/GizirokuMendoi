using MinutesGenerationApp.Provider;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesGenerationApp.ViewModel
{
    /// <summary>
    /// MV
    /// </summary>
    public class MainViewModel : BindableBase
    {
        #region BindProperty

        /// <summary>
        /// 表示する議事録
        /// </summary>
        private string _MinutesText;

        /// <summary>
        /// 表示する議事録のプロパティ
        /// </summary>
        public string MinutesText
        {
            get { return _MinutesText; }
            set { SetProperty(ref _MinutesText, value); }
        }
        #endregion

        #region Command

        /// <summary>
        /// UIの「はじめ」ボタン
        /// </summary>
        public DelegateCommand StartCommand { get; set; }

        /// <summary>
        /// UIの「とめる」ボタン
        /// </summary>
        public DelegateCommand StopCommand { get; set; }

        /// <summary>
        /// UIの「しゅつりょく」ボタン
        /// </summary>
        public DelegateCommand OutputCommand { get; set; }

        #endregion

        #region インスタンス

        VoiceRecognitionProvider recognitionProvider = new VoiceRecognitionProvider();
        #endregion

        /// <summary>
        /// VMのコンストラクタ
        /// </summary>
        public MainViewModel() 
        {
            //はじめボタン押下時の処理
            StartCommand = new DelegateCommand( () => Start(), () => true);      // コマンドの実行可否(trueで実行可))

            //とめるボタン押下時の処理
            StopCommand = new DelegateCommand(() => Stop(), () => true);

            //しゅつりょくボタン押下時の処理
            OutputCommand = new DelegateCommand(() => OutputText(), () => true);
        }

        #region 内部処理

        /// <summary>
        /// 議事録作成スタート
        /// </summary>
        private void Start() 
        {
        }

        /// <summary>
        /// 議事録作成ストップ
        /// </summary>
        private void Stop() 
        {

        }

        /// <summary>
        /// テキストファイルに出力
        /// </summary>
        private void OutputText()
        {

        }
        #endregion
    }
}
