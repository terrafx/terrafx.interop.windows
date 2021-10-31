// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CDF2C82-841E-4546-9722-0CF74078229A")]
    [NativeTypeName("struct IAudioEndpointVolume : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioEndpointVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint>)(lpVtbl[1]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint>)(lpVtbl[2]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterControlChangeNotify(IAudioEndpointVolumeCallback* pNotify)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[3]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterControlChangeNotify(IAudioEndpointVolumeCallback* pNotify)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[4]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pnChannelCount)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint*, int>)(lpVtbl[5]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pnChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolumeLevel(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, float, Guid*, int>)(lpVtbl[6]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolumeLevelScalar(float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, float, Guid*, int>)(lpVtbl[7]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), fLevel, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolumeLevel(float* pfLevelDB)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, float*, int>)(lpVtbl[8]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pfLevelDB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolumeLevelScalar(float* pfLevel)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, float*, int>)(lpVtbl[9]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumeLevel([NativeTypeName("UINT")] uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint, float, Guid*, int>)(lpVtbl[10]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumeLevelScalar([NativeTypeName("UINT")] uint nChannel, float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint, float, Guid*, int>)(lpVtbl[11]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), nChannel, fLevel, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolumeLevel([NativeTypeName("UINT")] uint nChannel, float* pfLevelDB)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint, float*, int>)(lpVtbl[12]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolumeLevelScalar([NativeTypeName("UINT")] uint nChannel, float* pfLevel)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint, float*, int>)(lpVtbl[13]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), nChannel, pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute(BOOL bMute, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, BOOL, Guid*, int>)(lpVtbl[14]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), bMute, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute(BOOL* pbMute)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, BOOL*, int>)(lpVtbl[15]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pbMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolumeStepInfo([NativeTypeName("UINT *")] uint* pnStep, [NativeTypeName("UINT *")] uint* pnStepCount)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint*, uint*, int>)(lpVtbl[16]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pnStep, pnStepCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int VolumeStepUp([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, Guid*, int>)(lpVtbl[17]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int VolumeStepDown([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, Guid*, int>)(lpVtbl[18]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, uint*, int>)(lpVtbl[19]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolumeRange(float* pflVolumeMindB, float* pflVolumeMaxdB, float* pflVolumeIncrementdB)
        {
            return ((delegate* unmanaged<IAudioEndpointVolume*, float*, float*, float*, int>)(lpVtbl[20]))((IAudioEndpointVolume*)Unsafe.AsPointer(ref this), pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
        }
    }
}
