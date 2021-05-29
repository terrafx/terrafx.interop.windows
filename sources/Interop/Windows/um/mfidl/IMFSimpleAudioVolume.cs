// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("089EDF13-CF71-4338-8D13-9E569DBDC319")]
    [NativeTypeName("struct IMFSimpleAudioVolume : IUnknown")]
    public unsafe partial struct IMFSimpleAudioVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, Guid*, void**, int>)(lpVtbl[0]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, uint>)(lpVtbl[1]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, uint>)(lpVtbl[2]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolume(float fLevel)
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, float, int>)(lpVtbl[3]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), fLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolume(float* pfLevel)
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, float*, int>)(lpVtbl[4]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("const BOOL")] int bMute)
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, int, int>)(lpVtbl[5]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), bMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pbMute)
        {
            return ((delegate* unmanaged<IMFSimpleAudioVolume*, int*, int>)(lpVtbl[6]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), pbMute);
        }
    }
}
