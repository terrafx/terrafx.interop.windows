// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("74ABBC19-B1CC-4E41-BB8B-9D9B86A8F6CA")]
    [NativeTypeName("struct IMFMuxStreamSampleManager : IUnknown")]
    public unsafe partial struct IMFMuxStreamSampleManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint>)(lpVtbl[1]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint>)(lpVtbl[2]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, [NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint, IMFSample**, int>)(lpVtbl[4]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONGLONG")]
        public ulong GetStreamConfiguration()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, ulong>)(lpVtbl[5]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }
    }
}
