// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B06FE5B9-43EC-4393-881B-DBE4DC72FDA7")]
    public unsafe partial struct IDWriteFontDownloadListener
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
        }

        public void DownloadCompleted([NativeTypeName("IDWriteFontDownloadQueue *")] IDWriteFontDownloadQueue* downloadQueue, [NativeTypeName("IUnknown *")] IUnknown* context, [NativeTypeName("HRESULT")] int downloadResult)
        {
            lpVtbl->DownloadCompleted((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), downloadQueue, context, downloadResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadListener*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadListener*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadListener*, uint> Release;

            [NativeTypeName("void (IDWriteFontDownloadQueue *, IUnknown *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, IUnknown*, int, void> DownloadCompleted;
        }
    }
}
