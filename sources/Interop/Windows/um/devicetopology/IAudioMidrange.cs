// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5E54B6D7-B44B-40D9-9A9E-E691D9CE6EDF")]
    [NativeTypeName("struct IAudioMidrange : IPerChannelDbLevel")]
    public unsafe partial struct IAudioMidrange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioMidrange*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMidrange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint>)(lpVtbl[1]))((IAudioMidrange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint>)(lpVtbl[2]))((IAudioMidrange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pcChannels)
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint*, int>)(lpVtbl[3]))((IAudioMidrange*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelRange([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfMinLevelDB, [NativeTypeName("float *")] float* pfMaxLevelDB, [NativeTypeName("float *")] float* pfStepping)
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint, float*, float*, float*, int>)(lpVtbl[4]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevel([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfLevelDB)
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint, float*, int>)(lpVtbl[5]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevel([NativeTypeName("UINT")] uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioMidrange*, uint, float, Guid*, int>)(lpVtbl[6]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioMidrange*, float, Guid*, int>)(lpVtbl[7]))((IAudioMidrange*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevelAllChannels([NativeTypeName("float []")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioMidrange*, float*, uint, Guid*, int>)(lpVtbl[8]))((IAudioMidrange*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
        }
    }
}
