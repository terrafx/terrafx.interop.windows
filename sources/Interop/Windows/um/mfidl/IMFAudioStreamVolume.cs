// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("76B1BBDB-4EC8-4F36-B106-70A9316DF593")]
    [NativeTypeName("struct IMFAudioStreamVolume : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFAudioStreamVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint>)(lpVtbl[1]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint>)(lpVtbl[2]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint*, int>)(lpVtbl[3]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint, float, int>)(lpVtbl[4]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[5]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[6]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes)
        {
            return ((delegate* unmanaged<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[7]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }
    }
}
