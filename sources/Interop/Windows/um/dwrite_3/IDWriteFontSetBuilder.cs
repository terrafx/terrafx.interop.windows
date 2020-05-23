// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F642AFE-9C68-4F40-B8BE-457401AFCB3D")]
    public unsafe partial struct IDWriteFontSetBuilder
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontSetBuilder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontSetBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontSetBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFaceReference(IDWriteFontSetBuilder* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontFaceReference1(IDWriteFontSetBuilder* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFontSet(IDWriteFontSetBuilder* pThis, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontSet(IDWriteFontSetBuilder* pThis, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFaceReference>(lpVtbl->AddFontFaceReference)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontFaceReference1>(lpVtbl->AddFontFaceReference1)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFontSet>(lpVtbl->AddFontSet)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontSet>(lpVtbl->CreateFontSet)((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
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
        }
    }
}
