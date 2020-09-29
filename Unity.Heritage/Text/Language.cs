using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.Heritage.Text
{
    /// <summary>
    /// <see cref="Language"/> 列挙型は、言語を示す識別子を表します。
    /// </summary>
    public enum Language : int
    {
        /// <summary>
        /// 英語。
        /// </summary>
        English,
        /// <summary>
        /// 日本語。
        /// </summary>
        Japanese,
    }

    public static class LanguageExtension
    {
        /// <summary>
        /// ISO 639-1 code を表すテキストを取得します。
        /// </summary>
        /// <param name="lang">言語。</param>
        /// <returns>639-1 文字コード。</returns>
        public static string GetCode1(this Language lang)
        {
            var text = "";

            switch (lang)
            {
                case Language.English: text = "en"; break;
                case Language.Japanese: text = "jp"; break;
            }

            return text;
        }

        /// <summary>
        /// ISO 639-2 code(T) を表すテキストを取得します。
        /// </summary>
        /// <param name="lang">言語。</param>
        /// <returns>639-2 code(T) 文字コード。</returns>
        public static string GetCode2(this Language lang)
        {
            var text = "";

            switch (lang)
            {
                case Language.English: text = "eng"; break;
                case Language.Japanese: text = "jpn"; break;
            }

            return text;
        }
    }
}
