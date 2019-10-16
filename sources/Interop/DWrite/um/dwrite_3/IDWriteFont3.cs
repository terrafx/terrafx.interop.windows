// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29748ED6-8C9C-4A6A-BE0B-D912E8538944")]
    public unsafe partial struct IDWriteFont3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFont3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamily(IDWriteFont3* pThis, [NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_WEIGHT _GetWeight(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STRETCH _GetStretch(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_STYLE _GetStyle(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSymbolFont(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFaceNames(IDWriteFont3* pThis, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInformationalStrings(IDWriteFont3* pThis, DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_SIMULATIONS _GetSimulations(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetMetrics(IDWriteFont3* pThis, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasCharacter(IDWriteFont3* pThis, [NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFont3* pThis, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetMetrics1(IDWriteFont3* pThis, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetPanose(IDWriteFont3* pThis, [NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnicodeRanges(IDWriteFont3* pThis, [NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsMonospacedFont(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsColorFont(IDWriteFont3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace1(IDWriteFont3* pThis, [NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _Equals(IDWriteFont3* pThis, [NativeTypeName("IDWriteFont *")] IDWriteFont* font);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference(IDWriteFont3* pThis, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasCharacter1(IDWriteFont3* pThis, [NativeTypeName("UINT32")] uint unicodeValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_LOCALITY _GetLocality(IDWriteFont3* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFont3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamily>(lpVtbl->GetFontFamily)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFamily);
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWeight>(lpVtbl->GetWeight)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStretch>(lpVtbl->GetStretch)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStyle>(lpVtbl->GetStyle)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSymbolFont>(lpVtbl->IsSymbolFont)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFaceNames>(lpVtbl->GetFaceNames)((IDWriteFont3*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInformationalStrings>(lpVtbl->GetInformationalStrings)((IDWriteFont3*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSimulations>(lpVtbl->GetSimulations)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontMetrics)
        {
            Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasCharacter>(lpVtbl->HasCharacter)((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            Marshal.GetDelegateForFunctionPointer<_GetMetrics1>(lpVtbl->GetMetrics1)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        public void GetPanose([NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose)
        {
            Marshal.GetDelegateForFunctionPointer<_GetPanose>(lpVtbl->GetPanose)((IDWriteFont3*)Unsafe.AsPointer(ref this), panose);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnicodeRanges>(lpVtbl->GetUnicodeRanges)((IDWriteFont3*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsMonospacedFont>(lpVtbl->IsMonospacedFont)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsColorFont>(lpVtbl->IsColorFont)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace1>(lpVtbl->CreateFontFace1)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
        }

        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFont *")] IDWriteFont* font)
        {
            return Marshal.GetDelegateForFunctionPointer<_Equals>(lpVtbl->Equals)((IDWriteFont3*)Unsafe.AsPointer(ref this), font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("BOOL")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasCharacter1>(lpVtbl->HasCharacter1)((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        public DWRITE_LOCALITY GetLocality()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocality>(lpVtbl->GetLocality)((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamily;

            [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetWeight;

            [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStretch;

            [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStyle;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsSymbolFont;

            [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFaceNames;

            [NativeTypeName("HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInformationalStrings;

            [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSimulations;

            [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics;

            [NativeTypeName("HRESULT (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HasCharacter;

            [NativeTypeName("HRESULT (IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace;

            [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics1;

            [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPanose;

            [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetUnicodeRanges;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsMonospacedFont;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsColorFont;

            [NativeTypeName("HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace1;

            [NativeTypeName("BOOL (IDWriteFont *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public new IntPtr Equals;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFaceReference;

            [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HasCharacter1;

            [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocality;
        }
    }
}
