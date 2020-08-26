// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93014887-242D-4068-8A15-CF5E93B90FE3")]
    [NativeTypeName("struct IAudioStreamVolume : IUnknown")]
    public unsafe partial struct IAudioStreamVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint>)(lpVtbl[1]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint>)(lpVtbl[2]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint*, int>)(lpVtbl[3]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint, float, int>)(lpVtbl[4]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[5]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[6]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("float *")] float* pfVolumes)
        {
            return ((delegate* stdcall<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[7]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }
    }
}
