// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7ED4EE07-8E67-4CD4-8C1A-2B7A5987AD42")]
    [NativeTypeName("struct IAudioClient3 : IAudioClient2")]
    public unsafe partial struct IAudioClient3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClient3*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClient3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClient3*, uint>)(lpVtbl[1]))((IAudioClient3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClient3*, uint>)(lpVtbl[2]))((IAudioClient3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
        {
            return ((delegate* unmanaged<IAudioClient3*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int>)(lpVtbl[3]))((IAudioClient3*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
        {
            return ((delegate* unmanaged<IAudioClient3*, uint*, int>)(lpVtbl[4]))((IAudioClient3*)Unsafe.AsPointer(ref this), pNumBufferFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
        {
            return ((delegate* unmanaged<IAudioClient3*, long*, int>)(lpVtbl[5]))((IAudioClient3*)Unsafe.AsPointer(ref this), phnsLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
        {
            return ((delegate* unmanaged<IAudioClient3*, uint*, int>)(lpVtbl[6]))((IAudioClient3*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppClosestMatch)
        {
            return ((delegate* unmanaged<IAudioClient3*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[7]))((IAudioClient3*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMixFormat([NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppDeviceFormat)
        {
            return ((delegate* unmanaged<IAudioClient3*, WAVEFORMATEX**, int>)(lpVtbl[8]))((IAudioClient3*)Unsafe.AsPointer(ref this), ppDeviceFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
        {
            return ((delegate* unmanaged<IAudioClient3*, long*, long*, int>)(lpVtbl[9]))((IAudioClient3*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IAudioClient3*, int>)(lpVtbl[10]))((IAudioClient3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IAudioClient3*, int>)(lpVtbl[11]))((IAudioClient3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IAudioClient3*, int>)(lpVtbl[12]))((IAudioClient3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEventHandle([NativeTypeName("HANDLE")] IntPtr eventHandle)
        {
            return ((delegate* unmanaged<IAudioClient3*, IntPtr, int>)(lpVtbl[13]))((IAudioClient3*)Unsafe.AsPointer(ref this), eventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged<IAudioClient3*, Guid*, void**, int>)(lpVtbl[14]))((IAudioClient3*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, [NativeTypeName("BOOL *")] int* pbOffloadCapable)
        {
            return ((delegate* unmanaged<IAudioClient3*, AUDIO_STREAM_CATEGORY, int*, int>)(lpVtbl[15]))((IAudioClient3*)Unsafe.AsPointer(ref this), Category, pbOffloadCapable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientProperties([NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties)
        {
            return ((delegate* unmanaged<IAudioClient3*, AudioClientProperties*, int>)(lpVtbl[16]))((IAudioClient3*)Unsafe.AsPointer(ref this), pProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferSizeLimits([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("BOOL")] int bEventDriven, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration, [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration)
        {
            return ((delegate* unmanaged<IAudioClient3*, WAVEFORMATEX*, int, long*, long*, int>)(lpVtbl[17]))((IAudioClient3*)Unsafe.AsPointer(ref this), pFormat, bEventDriven, phnsMinBufferDuration, phnsMaxBufferDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSharedModeEnginePeriod([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("UINT32 *")] uint* pDefaultPeriodInFrames, [NativeTypeName("UINT32 *")] uint* pFundamentalPeriodInFrames, [NativeTypeName("UINT32 *")] uint* pMinPeriodInFrames, [NativeTypeName("UINT32 *")] uint* pMaxPeriodInFrames)
        {
            return ((delegate* unmanaged<IAudioClient3*, WAVEFORMATEX*, uint*, uint*, uint*, uint*, int>)(lpVtbl[18]))((IAudioClient3*)Unsafe.AsPointer(ref this), pFormat, pDefaultPeriodInFrames, pFundamentalPeriodInFrames, pMinPeriodInFrames, pMaxPeriodInFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSharedModeEnginePeriod([NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppFormat, [NativeTypeName("UINT32 *")] uint* pCurrentPeriodInFrames)
        {
            return ((delegate* unmanaged<IAudioClient3*, WAVEFORMATEX**, uint*, int>)(lpVtbl[19]))((IAudioClient3*)Unsafe.AsPointer(ref this), ppFormat, pCurrentPeriodInFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeSharedAudioStream([NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("UINT32")] uint PeriodInFrames, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
        {
            return ((delegate* unmanaged<IAudioClient3*, uint, uint, WAVEFORMATEX*, Guid*, int>)(lpVtbl[20]))((IAudioClient3*)Unsafe.AsPointer(ref this), StreamFlags, PeriodInFrames, pFormat, AudioSessionGuid);
        }
    }
}
