// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteColorGlyphRunEnumerator1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteColorGlyphRunEnumerator1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteColorGlyphRunEnumerator1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveNext(IDWriteColorGlyphRunEnumerator1* pThis, [NativeTypeName("BOOL *")] int* hasRun);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentRun(IDWriteColorGlyphRunEnumerator1* pThis, [NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentRun1(IDWriteColorGlyphRunEnumerator1* pThis, [NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasRun)
        {
            return Marshal.GetDelegateForFunctionPointer<_MoveNext>(lpVtbl->MoveNext)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), hasRun);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentRun>(lpVtbl->GetCurrentRun)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentRun1>(lpVtbl->GetCurrentRun1)((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MoveNext;

            [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCurrentRun;

            [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCurrentRun1;
        }
    }
}
