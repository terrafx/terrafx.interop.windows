// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("B71E6052-5AEA-4FA3-832E-F60D431F7E91")]
    [NativeTypeName("struct IDWriteFontDownloadQueue : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontDownloadQueue : IDWriteFontDownloadQueue.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint>)(lpVtbl[1]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint>)(lpVtbl[2]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddListener(IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token)
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)(lpVtbl[3]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RemoveListener([NativeTypeName("UINT32")] uint token)
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint, int>)(lpVtbl[4]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public BOOL IsEmpty()
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, int>)(lpVtbl[5]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BeginDownload(IUnknown* context = null)
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, IUnknown*, int>)(lpVtbl[6]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CancelDownload()
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, int>)(lpVtbl[7]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        public ulong GetGenerationCount()
        {
            return ((delegate* unmanaged<IDWriteFontDownloadQueue*, ulong>)(lpVtbl[8]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddListener(IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token);

            [VtblIndex(4)]
            HRESULT RemoveListener([NativeTypeName("UINT32")] uint token);

            [VtblIndex(5)]
            BOOL IsEmpty();

            [VtblIndex(6)]
            HRESULT BeginDownload(IUnknown* context = null);

            [VtblIndex(7)]
            HRESULT CancelDownload();

            [VtblIndex(8)]
            [return: NativeTypeName("UINT64")]
            ulong GetGenerationCount();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteFontDownloadListener *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int> AddListener;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, uint, int> RemoveListener;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, int> IsEmpty;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, IUnknown*, int> BeginDownload;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, int> CancelDownload;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontDownloadQueue*, ulong> GetGenerationCount;
        }
    }
}
