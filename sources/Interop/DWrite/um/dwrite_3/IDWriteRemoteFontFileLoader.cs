// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68648C83-6EDE-46C0-AB46-20083A887FDE")]
    public unsafe partial struct IDWriteRemoteFontFileLoader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRemoteFontFileLoader* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRemoteFontFileLoader* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRemoteFontFileLoader* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStreamFromKey(IDWriteRemoteFontFileLoader* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRemoteStreamFromKey(IDWriteRemoteFontFileLoader* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteRemoteFontFileStream **")] IDWriteRemoteFontFileStream** fontFileStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocalityFromKey(IDWriteRemoteFontFileLoader* pThis, [NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("DWRITE_LOCALITY *")] DWRITE_LOCALITY* locality);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFileReferenceFromUrl(IDWriteRemoteFontFileLoader* pThis, [NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const WCHAR *")] ushort* baseUrl, [NativeTypeName("const WCHAR *")] ushort* fontFileUrl, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRemoteStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteRemoteFontFileStream **")] IDWriteRemoteFontFileStream** fontFileStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRemoteStreamFromKey>(lpVtbl->CreateRemoteStreamFromKey)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalityFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("DWRITE_LOCALITY *")] DWRITE_LOCALITY* locality)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocalityFromKey>(lpVtbl->GetLocalityFromKey)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, locality);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReferenceFromUrl([NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const WCHAR *")] ushort* baseUrl, [NativeTypeName("const WCHAR *")] ushort* fontFileUrl, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFileReferenceFromUrl>(lpVtbl->CreateFontFileReferenceFromUrl)((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), factory, baseUrl, fontFileUrl, fontFile);
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

            [NativeTypeName("HRESULT (const void *, UINT32, IDWriteRemoteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRemoteStreamFromKey;

            [NativeTypeName("HRESULT (const void *, UINT32, DWRITE_LOCALITY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocalityFromKey;

            [NativeTypeName("HRESULT (IDWriteFactory *, const WCHAR *, const WCHAR *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFileReferenceFromUrl;
        }
    }
}
