// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EE5BA612-B131-463C-8F4F-3189B9401E45")]
    public unsafe partial struct IDWriteFontSetBuilder2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontSetBuilder2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontSetBuilder2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontSetBuilder2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFaceReference(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFaceReference1(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontSet(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontSet(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFile(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFont(IDWriteFontSetBuilder2* pThis, [NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFile1(IDWriteFontSetBuilder2* pThis, [NativeTypeName("const WCHAR *")] ushort* filePath);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFaceReference>(lpVtbl->AddFontFaceReference)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFaceReference1>(lpVtbl->AddFontFaceReference1)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontSet>(lpVtbl->AddFontSet)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontSet>(lpVtbl->CreateFontSet)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFile([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFile>(lpVtbl->AddFontFile)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFont([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFont>(lpVtbl->AddFont)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFile([NativeTypeName("const WCHAR *")] ushort* filePath)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFile1>(lpVtbl->AddFontFile1)((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), filePath);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFontFaceReference;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference *, const DWRITE_FONT_PROPERTY *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFontFaceReference1;

            [NativeTypeName("HRESULT (IDWriteFontSet *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFontSet;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontSet;

            [NativeTypeName("HRESULT (IDWriteFontFile *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFontFile;

            [NativeTypeName("HRESULT (IDWriteFontFile *, UINT32, DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, const DWRITE_FONT_AXIS_RANGE *, UINT32, const DWRITE_FONT_PROPERTY *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFont;

            [NativeTypeName("HRESULT (const WCHAR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddFontFile1;
        }
    }
}
