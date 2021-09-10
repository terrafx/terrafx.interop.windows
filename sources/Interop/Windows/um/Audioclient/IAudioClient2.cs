// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("726778CD-F60A-4EDA-82DE-E47610CD78AA")]
    [NativeTypeName("struct IAudioClient2 : IAudioClient")]
    [NativeInheritance("IAudioClient")]
    public unsafe partial struct IAudioClient2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClient2*, uint>)(lpVtbl[1]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClient2*, uint>)(lpVtbl[2]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int>)(lpVtbl[3]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
        {
            return ((delegate* unmanaged<IAudioClient2*, uint*, int>)(lpVtbl[4]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumBufferFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
        {
            return ((delegate* unmanaged<IAudioClient2*, long*, int>)(lpVtbl[5]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
        {
            return ((delegate* unmanaged<IAudioClient2*, uint*, int>)(lpVtbl[6]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, WAVEFORMATEX** ppClosestMatch)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[7]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetMixFormat(WAVEFORMATEX** ppDeviceFormat)
        {
            return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX**, int>)(lpVtbl[8]))((IAudioClient2*)Unsafe.AsPointer(ref this), ppDeviceFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
        {
            return ((delegate* unmanaged<IAudioClient2*, long*, long*, int>)(lpVtbl[9]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[10]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[11]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[12]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetEventHandle([NativeTypeName("HANDLE")] IntPtr eventHandle)
        {
            return ((delegate* unmanaged<IAudioClient2*, IntPtr, int>)(lpVtbl[13]))((IAudioClient2*)Unsafe.AsPointer(ref this), eventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int>)(lpVtbl[14]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, [NativeTypeName("BOOL *")] int* pbOffloadCapable)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDIO_STREAM_CATEGORY, int*, int>)(lpVtbl[15]))((IAudioClient2*)Unsafe.AsPointer(ref this), Category, pbOffloadCapable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientProperties([NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties)
        {
            return ((delegate* unmanaged<IAudioClient2*, AudioClientProperties*, int>)(lpVtbl[16]))((IAudioClient2*)Unsafe.AsPointer(ref this), pProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferSizeLimits([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("BOOL")] int bEventDriven, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration, [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration)
        {
            return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX*, int, long*, long*, int>)(lpVtbl[17]))((IAudioClient2*)Unsafe.AsPointer(ref this), pFormat, bEventDriven, phnsMinBufferDuration, phnsMaxBufferDuration);
        }
    }
}
