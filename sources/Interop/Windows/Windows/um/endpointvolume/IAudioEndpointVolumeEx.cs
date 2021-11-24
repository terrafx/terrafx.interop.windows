// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("66E11784-F695-4F28-A505-A7080081A78F")]
[NativeTypeName("struct IAudioEndpointVolumeEx : IAudioEndpointVolume")]
[NativeInheritance("IAudioEndpointVolume")]
public unsafe partial struct IAudioEndpointVolumeEx : IAudioEndpointVolumeEx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint>)(lpVtbl[1]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint>)(lpVtbl[2]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterControlChangeNotify(IAudioEndpointVolumeCallback* pNotify)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[3]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterControlChangeNotify(IAudioEndpointVolumeCallback* pNotify)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[4]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelCount(uint* pnChannelCount)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, int>)(lpVtbl[5]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pnChannelCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMasterVolumeLevel(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, float, Guid*, int>)(lpVtbl[6]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMasterVolumeLevelScalar(float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, float, Guid*, int>)(lpVtbl[7]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), fLevel, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMasterVolumeLevel(float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, float*, int>)(lpVtbl[8]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pfLevelDB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMasterVolumeLevelScalar(float* pfLevel)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, float*, int>)(lpVtbl[9]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pfLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetChannelVolumeLevel(uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float, Guid*, int>)(lpVtbl[10]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetChannelVolumeLevelScalar(uint nChannel, float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float, Guid*, int>)(lpVtbl[11]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, fLevel, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetChannelVolumeLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, int>)(lpVtbl[12]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetChannelVolumeLevelScalar(uint nChannel, float* pfLevel)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, int>)(lpVtbl[13]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, pfLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMute(BOOL bMute, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, BOOL, Guid*, int>)(lpVtbl[14]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), bMute, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetMute(BOOL* pbMute)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, BOOL*, int>)(lpVtbl[15]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pbMute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetVolumeStepInfo(uint* pnStep, uint* pnStepCount)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, uint*, int>)(lpVtbl[16]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pnStep, pnStepCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT VolumeStepUp([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, int>)(lpVtbl[17]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT VolumeStepDown([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, int>)(lpVtbl[18]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, int>)(lpVtbl[19]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetVolumeRange(float* pflVolumeMindB, float* pflVolumeMaxdB, float* pflVolumeIncrementdB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, float*, float*, float*, int>)(lpVtbl[20]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetVolumeRangeChannel(uint iChannel, float* pflVolumeMindB, float* pflVolumeMaxdB, float* pflVolumeIncrementdB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, float*, float*, int>)(lpVtbl[21]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), iChannel, pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
    }

    public interface Interface : IAudioEndpointVolume.Interface
    {
        [VtblIndex(21)]
        HRESULT GetVolumeRangeChannel(uint iChannel, float* pflVolumeMindB, float* pflVolumeMaxdB, float* pflVolumeIncrementdB);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint> Release;

        [NativeTypeName("HRESULT (IAudioEndpointVolumeCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int> RegisterControlChangeNotify;

        [NativeTypeName("HRESULT (IAudioEndpointVolumeCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int> UnregisterControlChangeNotify;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, float, Guid*, int> SetMasterVolumeLevel;

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, float, Guid*, int> SetMasterVolumeLevelScalar;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, float*, int> GetMasterVolumeLevel;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, float*, int> GetMasterVolumeLevelScalar;

        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float, Guid*, int> SetChannelVolumeLevel;

        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float, Guid*, int> SetChannelVolumeLevelScalar;

        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, int> GetChannelVolumeLevel;

        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, int> GetChannelVolumeLevelScalar;

        [NativeTypeName("HRESULT (BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, BOOL, Guid*, int> SetMute;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, BOOL*, int> GetMute;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, uint*, int> GetVolumeStepInfo;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, int> VolumeStepUp;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, Guid*, int> VolumeStepDown;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint*, int> QueryHardwareSupport;

        [NativeTypeName("HRESULT (float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, float*, float*, float*, int> GetVolumeRange;

        [NativeTypeName("HRESULT (UINT, float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioEndpointVolumeEx*, uint, float*, float*, float*, int> GetVolumeRangeChannel;
    }
}
