// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B71E6052-5AEA-4FA3-832E-F60D431F7E91")]
    [NativeTypeName("struct IDWriteFontDownloadQueue : IUnknown")]
    public unsafe partial struct IDWriteFontDownloadQueue
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, uint>)(lpVtbl[1]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, uint>)(lpVtbl[2]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddListener([NativeTypeName("IDWriteFontDownloadListener *")] IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token)
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)(lpVtbl[3]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveListener([NativeTypeName("UINT32")] uint token)
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, uint, int>)(lpVtbl[4]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmpty()
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, int>)(lpVtbl[5]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("IUnknown *")] IUnknown* context = null)
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, IUnknown*, int>)(lpVtbl[6]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelDownload()
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, int>)(lpVtbl[7]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetGenerationCount()
        {
            return ((delegate* stdcall<IDWriteFontDownloadQueue*, ulong>)(lpVtbl[8]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }
    }
}
