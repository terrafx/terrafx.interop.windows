// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("639CFAD8-0FB4-4B21-A58A-067920120009")]
    public unsafe partial struct IDWriteTextAnalysisSource1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextAnalysisSource1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextAnalysisSource1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextAtPosition(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTextBeforePosition(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_READING_DIRECTION _GetParagraphReadingDirection(IDWriteTextAnalysisSource1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("const WCHAR **")] ushort** localeName);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNumberSubstitution(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVerticalGlyphOrientation(IDWriteTextAnalysisSource1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION *")] DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8 *")] byte* bidiLevel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextAtPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextAtPosition>(lpVtbl->GetTextAtPosition)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextBeforePosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextBeforePosition>(lpVtbl->GetTextBeforePosition)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParagraphReadingDirection>(lpVtbl->GetParagraphReadingDirection)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("const WCHAR **")] ushort** localeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, localeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumberSubstitution>(lpVtbl->GetNumberSubstitution)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION *")] DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8 *")] byte* bidiLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVerticalGlyphOrientation>(lpVtbl->GetVerticalGlyphOrientation)((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientation, bidiLevel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32, const WCHAR **, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextAtPosition;

            [NativeTypeName("HRESULT (UINT32, const WCHAR **, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextBeforePosition;

            [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParagraphReadingDirection;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, const WCHAR **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, IDWriteNumberSubstitution **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNumberSubstitution;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_VERTICAL_GLYPH_ORIENTATION *, UINT8 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVerticalGlyphOrientation;
        }
    }
}
