// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2456BD58-C067-4513-84FE-8D0C88FFDC61")]
    [NativeTypeName("struct IMFSinkWriterCallback2 : IMFSinkWriterCallback")]
    public unsafe partial struct IMFSinkWriterCallback2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, uint>)(lpVtbl[1]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, uint>)(lpVtbl[2]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFinalize([NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, int, int>)(lpVtbl[3]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, uint, void*, int>)(lpVtbl[4]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTransformChange()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, int>)(lpVtbl[5]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSinkWriterCallback2*, uint, int, int>)(lpVtbl[6]))((IMFSinkWriterCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, hrStatus);
        }
    }
}
