// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("666F76DE-33D2-41B9-A458-29ED0A972C58")]
    [NativeTypeName("struct IMFSinkWriterCallback : IUnknown")]
    public unsafe partial struct IMFSinkWriterCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSinkWriterCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSinkWriterCallback*, uint>)(lpVtbl[1]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSinkWriterCallback*, uint>)(lpVtbl[2]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFinalize([NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* unmanaged<IMFSinkWriterCallback*, int, int>)(lpVtbl[3]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
        {
            return ((delegate* unmanaged<IMFSinkWriterCallback*, uint, void*, int>)(lpVtbl[4]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
        }
    }
}
