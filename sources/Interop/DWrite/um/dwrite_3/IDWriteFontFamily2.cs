// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3ED49E77-A398-4261-B9CF-C126C2131EF3")]
    public unsafe partial struct IDWriteFontFamily2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFamily2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFamily2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFamily2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteFontFamily2* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontCount(IDWriteFontFamily2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont(IDWriteFontFamily2* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFont **")] IDWriteFont** font);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFamilyNames(IDWriteFontFamily2* pThis, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFirstMatchingFont(IDWriteFontFamily2* pThis, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFont **")] IDWriteFont** matchingFont);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts(IDWriteFontFamily2* pThis, DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFontList **")] IDWriteFontList** matchingFonts);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetFontLocality(IDWriteFontFamily2* pThis, [NativeTypeName("UINT32")] uint listIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFont1(IDWriteFontFamily2* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFont3 **")] IDWriteFont3** font);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference(IDWriteFontFamily2* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts1(IDWriteFontFamily2* pThis, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontList2 **")] IDWriteFontList2** matchingFonts);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSet(IDWriteFontFamily2* pThis, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFont>(lpVtbl->GetFont)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), index, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFamilyNames>(lpVtbl->GetFamilyNames)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFont **")] IDWriteFont** matchingFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFirstMatchingFont>(lpVtbl->GetFirstMatchingFont)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFontList **")] IDWriteFontList** matchingFonts)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFonts);
        }

        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontLocality>(lpVtbl->GetFontLocality)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFont3 **")] IDWriteFont3** font)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFont1>(lpVtbl->GetFont1)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontList2 **")] IDWriteFontList2** matchingFonts)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts1>(lpVtbl->GetMatchingFonts1)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount, matchingFonts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet([NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSet>(lpVtbl->GetFontSet)((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontSet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCollection;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCount;

            [NativeTypeName("HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFont;

            [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFamilyNames;

            [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFirstMatchingFont;

            [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts;

            [NativeTypeName("DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontLocality;

            [NativeTypeName("HRESULT (UINT32, IDWriteFont3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFont1;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFaceReference;

            [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts1;

            [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSet;
        }
    }
}
