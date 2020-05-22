// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC102F47-A12D-4B1C-822D-9E117E33043F")]
    public unsafe partial struct IDWriteInMemoryFontFileLoader
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteInMemoryFontFileLoader* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteInMemoryFontFileLoader* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteInMemoryFontFileLoader* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStreamFromKey(IDWriteInMemoryFontFileLoader* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInMemoryFontFileReference(IDWriteInMemoryFontFileLoader* pThis, [NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const void *")] void* fontData, [NativeTypeName("UINT32")] uint fontDataSize, [NativeTypeName("IUnknown *")] IUnknown* ownerObject, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFileCount(IDWriteInMemoryFontFileLoader* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInMemoryFontFileReference([NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const void *")] void* fontData, [NativeTypeName("UINT32")] uint fontDataSize, [NativeTypeName("IUnknown *")] IUnknown* ownerObject, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInMemoryFontFileReference>(lpVtbl->CreateInMemoryFontFileReference)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), factory, fontData, fontDataSize, ownerObject, fontFile);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFileCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileCount>(lpVtbl->GetFileCount)((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateStreamFromKey;

            [NativeTypeName("HRESULT (IDWriteFactory *, const void *, UINT32, IUnknown *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateInMemoryFontFileReference;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFileCount;
        }
    }
}
