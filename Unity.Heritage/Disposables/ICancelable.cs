using System;
using System.Collections.Generic;
using System.Text;

namespace Unity.Heritage.Disposables
{
    /// <summary>
    /// <see cref="ICancelable"/> インターフェースは、廃棄状態を調べるプロパティを定義します。
    /// </summary>
    public interface ICancelable : IDisposable
    {
        /// <summary>
        /// オブジェクトが破棄されているかどうかを示す値を取得します。
        /// </summary>
        bool IsDisposed { get; }
    }
}
