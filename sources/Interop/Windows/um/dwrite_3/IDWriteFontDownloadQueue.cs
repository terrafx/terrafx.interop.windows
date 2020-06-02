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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddListener([NativeTypeName("IDWriteFontDownloadListener *")] IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token)
        {
            return lpVtbl->AddListener((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveListener([NativeTypeName("UINT32")] uint token)
        {
            return lpVtbl->RemoveListener((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmpty()
        {
            return lpVtbl->IsEmpty((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("IUnknown *")] IUnknown* context = null)
        {
            return lpVtbl->BeginDownload((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelDownload()
        {
            return lpVtbl->CancelDownload((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetGenerationCount()
        {
            return lpVtbl->GetGenerationCount((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteFontDownloadListener *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int> AddListener;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, uint, int> RemoveListener;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, int> IsEmpty;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, IUnknown*, int> BeginDownload;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, int> CancelDownload;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadQueue*, ulong> GetGenerationCount;
        }
    }
}
