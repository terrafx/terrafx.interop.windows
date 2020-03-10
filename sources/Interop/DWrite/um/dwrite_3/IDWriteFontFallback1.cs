// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2397599D-DD0D-4681-BD6A-F4F31EAADE77")]
    public unsafe partial struct IDWriteFontFallback1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFallback1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFallback1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFallback1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapCharacters(IDWriteFontFallback1* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* baseFontCollection, [NativeTypeName("const wchar_t *")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32 *")] uint* mappedLength, [NativeTypeName("IDWriteFont **")] IDWriteFont** mappedFont, [NativeTypeName("FLOAT *")] float* scale);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapCharacters1(IDWriteFontFallback1* pThis, [NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* baseFontCollection, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("UINT32 *")] uint* mappedLength, [NativeTypeName("FLOAT *")] float* scale, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** mappedFontFace);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontFallback1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontFallback1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MapCharacters([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* baseFontCollection, [NativeTypeName("const wchar_t *")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32 *")] uint* mappedLength, [NativeTypeName("IDWriteFont **")] IDWriteFont** mappedFont, [NativeTypeName("FLOAT *")] float* scale)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapCharacters>(lpVtbl->MapCharacters)((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapCharacters([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* baseFontCollection, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("UINT32 *")] uint* mappedLength, [NativeTypeName("FLOAT *")] float* scale, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** mappedFontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapCharacters1>(lpVtbl->MapCharacters1)((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, fontAxisValues, fontAxisValueCount, mappedLength, scale, mappedFontFace);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteFontCollection *, const wchar_t *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, UINT32 *, IDWriteFont **, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MapCharacters;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteFontCollection *, const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, UINT32 *, FLOAT *, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MapCharacters1;
        }
    }
}
