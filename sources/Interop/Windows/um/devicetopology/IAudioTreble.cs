// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A717812-694E-4907-B74B-BAFA5CFDCA7B")]
    [NativeTypeName("struct IAudioTreble : IPerChannelDbLevel")]
    public unsafe partial struct IAudioTreble
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioTreble*, Guid*, void**, int>)(lpVtbl[0]))((IAudioTreble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioTreble*, uint>)(lpVtbl[1]))((IAudioTreble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioTreble*, uint>)(lpVtbl[2]))((IAudioTreble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pcChannels)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint*, int>)(lpVtbl[3]))((IAudioTreble*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelRange([NativeTypeName("UINT")] uint nChannel, float* pfMinLevelDB, float* pfMaxLevelDB, float* pfStepping)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float*, float*, float*, int>)(lpVtbl[4]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevel([NativeTypeName("UINT")] uint nChannel, float* pfLevelDB)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float*, int>)(lpVtbl[5]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevel([NativeTypeName("UINT")] uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float, Guid*, int>)(lpVtbl[6]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, float, Guid*, int>)(lpVtbl[7]))((IAudioTreble*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLevelAllChannels([NativeTypeName("float []")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, float*, uint, Guid*, int>)(lpVtbl[8]))((IAudioTreble*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
        }
    }
}
