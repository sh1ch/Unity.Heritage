using System;
using System.Collections.Generic;
using System.Text;

namespace Unity.Heritage.Text
{
    /// <summary>
    /// <see cref="LocalizedText"/> クラスは、ローカライズに対応するテキストを提供するクラスです。
    /// </summary>
    public class LocalizedText
    {
        #region Properties

        /// <summary>
        /// 現在の言語設定に対応したテキストを取得します。
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string Text
        {
            get
            {
                return GetCurrentText();
            }
        }

        /// <summary>
        /// 現在の言語設定を取得または設定します。
        /// </summary>
        public Language CurrentLanguage { get; set; } = Language.Japanese;

        /// <summary>
        /// デフォルトの言語設定を取得または設定します。
        /// </summary>
        public static Language DefaultLanguage { get; set; } = Language.English;

        /// <summary>
        /// 英語のテキストを取得または設定します。
        /// </summary>
        public string En { get; set; }

        /// <summary>
        /// 日本語のテキストを取得または設定します。
        /// </summary>
        public string Jp { get; set; }

        #endregion

        #region Initializes

        /// <summary>
        /// <see cref="LocalizedText"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        public LocalizedText() { }

        /// <summary>
        /// <see cref="LocalizedText"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="jp">日本語のテキスト。</param>
        /// <param name="en">英語のテキスト。</param>
        public LocalizedText(string jp) : this(jp, "", Language.Japanese) { }

        /// <summary>
        /// <see cref="LocalizedText"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="jp">日本語のテキスト。</param>
        /// <param name="en">英語のテキスト。</param>
        /// <param name="current">使用する言語設定。</param>
        public LocalizedText(string jp, string en, Language current)
        {
            Jp = jp;
            En = en;

            CurrentLanguage = current;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 代替テキスト "{x}" を引数で置換したテキストを取得します。
        /// </summary>
        /// <param name="args"></param>
        public void GetText(params string[] args)
        {
            var text = Text;

            for (int i = 0; i < args.Length; i++)
            {
                text.Replace($"{i}", args[i]);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// <see cref="DefaultLanguage"/> に対応するテキストを取得します。（対応しないときは "" を返却します）
        /// </summary>
        /// <returns>デフォルト言語設定に対応したテキスト。</returns>
        private string GetDefaultText()
        {
            var text = "";

            switch (DefaultLanguage)
            {
                case Language.English:
                    text = En;
                    break;
                case Language.Japanese:
                    text = Jp;
                    break;
            }

            return text;
        }

        /// <summary>
        /// 現在の言語設定に対応したテキストを取得します。
        /// <para>
        /// <see cref="CurrentLanguage"/> に対応していないときは、<see cref="DefaultLanguage"/> に対応するテキストを取得します。（どちらにも対応しないときは "" を返却します）
        /// </para>
        /// </summary>
        /// <returns>現在の言語設定に対応したテキスト。</returns>
        private string GetCurrentText()
        {
            var text = "";

            switch (CurrentLanguage)
            {
                case Language.English:
                    text = En;
                    break;
                case Language.Japanese:
                    text = Jp;
                    break;
            }

            if (string.IsNullOrEmpty(text))
            {
                text = GetDefaultText();
            }

            return text;
        }

        #endregion
    }
}
