// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Enumerator for an ordered collection of color glyph runs.</summary>
    [Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteColorGlyphRunEnumerator1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteColorGlyphRunEnumerator1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteColorGlyphRunEnumerator1* This);

        /// <summary>Advances to the first or next color run. The runs are enumerated in order from back to front.</summary>
        /// <param name="hasRun">Receives TRUE if there is a current run or FALSE if the end of the sequence has been reached.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveNext(IDWriteColorGlyphRunEnumerator1* This, [NativeTypeName("BOOL")] int* hasRun);

        /// <summary>Gets the current color glyph run.</summary>
        /// <param name="colorGlyphRun">Receives a pointer to the color glyph run. The pointer remains valid until the next call to MoveNext or until the interface is released.</param>
        /// <returns> Standard HRESULT error code. An error is returned if there is no current glyph run, i.e., if MoveNext has not yet been called or if the end of the sequence has been reached.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentRun(IDWriteColorGlyphRunEnumerator1* This, DWRITE_COLOR_GLYPH_RUN** colorGlyphRun);

        /// <summary>Gets the current color glyph run.</summary>
        /// <param name="colorGlyphRun">Receives a pointer to the color glyph run. The pointer remains valid until the next call to MoveNext or until the interface is released.</param>
        /// <returns> Standard HRESULT error code. An error is returned if there is no current glyph run, i.e., if MoveNext has not yet been called or if the end of the sequence has been reached.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentRun1(IDWriteColorGlyphRunEnumerator1* This, DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL")] int* hasRun)
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MoveNext>(lpVtbl->MoveNext)(This, hasRun);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun(DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentRun>(lpVtbl->GetCurrentRun)(This, colorGlyphRun);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun1(DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)
        {
            fixed (IDWriteColorGlyphRunEnumerator1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentRun1>(lpVtbl->GetCurrentRun1)(This, colorGlyphRun);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr MoveNext;

            public IntPtr GetCurrentRun;

            public IntPtr GetCurrentRun1;
        }
    }
}
