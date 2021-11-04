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
    [NativeInheritance("IPerChannelDbLevel")]
    public unsafe partial struct IAudioTreble
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioTreble*, Guid*, void**, int>)(lpVtbl[0]))((IAudioTreble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioTreble*, uint>)(lpVtbl[1]))((IAudioTreble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioTreble*, uint>)(lpVtbl[2]))((IAudioTreble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetChannelCount(uint* pcChannels)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint*, int>)(lpVtbl[3]))((IAudioTreble*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLevelRange(uint nChannel, float* pfMinLevelDB, float* pfMaxLevelDB, float* pfStepping)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float*, float*, float*, int>)(lpVtbl[4]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetLevel(uint nChannel, float* pfLevelDB)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float*, int>)(lpVtbl[5]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetLevel(uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, uint, float, Guid*, int>)(lpVtbl[6]))((IAudioTreble*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, float, Guid*, int>)(lpVtbl[7]))((IAudioTreble*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetLevelAllChannels([NativeTypeName("float []")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioTreble*, float*, uint, Guid*, int>)(lpVtbl[8]))((IAudioTreble*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint*, int> GetChannelCount;

            [NativeTypeName("HRESULT (UINT, float *, float *, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint, float*, float*, float*, int> GetLevelRange;

            [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint, float*, int> GetLevel;

            [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, uint, float, Guid*, int> SetLevel;

            [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, float, Guid*, int> SetLevelUniform;

            [NativeTypeName("HRESULT (float *, ULONG, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioTreble*, float*, uint, Guid*, int> SetLevelAllChannels;
        }
    }
}
