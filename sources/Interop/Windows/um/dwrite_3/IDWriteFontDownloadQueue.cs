// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B71E6052-5AEA-4FA3-832E-F60D431F7E91")]
    public unsafe partial struct IDWriteFontDownloadQueue
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontDownloadQueue* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontDownloadQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontDownloadQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddListener(IDWriteFontDownloadQueue* pThis, [NativeTypeName("IDWriteFontDownloadListener *")] IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveListener(IDWriteFontDownloadQueue* pThis, [NativeTypeName("UINT32")] uint token);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsEmpty(IDWriteFontDownloadQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDownload(IDWriteFontDownloadQueue* pThis, [NativeTypeName("IUnknown *")] IUnknown* context = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CancelDownload(IDWriteFontDownloadQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetGenerationCount(IDWriteFontDownloadQueue* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddListener([NativeTypeName("IDWriteFontDownloadListener *")] IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddListener>(lpVtbl->AddListener)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveListener([NativeTypeName("UINT32")] uint token)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveListener>(lpVtbl->RemoveListener)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmpty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEmpty>(lpVtbl->IsEmpty)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("IUnknown *")] IUnknown* context = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginDownload>(lpVtbl->BeginDownload)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelDownload()
        {
            return Marshal.GetDelegateForFunctionPointer<_CancelDownload>(lpVtbl->CancelDownload)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetGenerationCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGenerationCount>(lpVtbl->GetGenerationCount)((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDWriteFontDownloadListener *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddListener;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveListener;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsEmpty;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BeginDownload;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CancelDownload;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGenerationCount;
        }
    }
}
