// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2")]
    [NativeTypeName("struct IAudioClient : IUnknown")]
    public unsafe partial struct IAudioClient
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioClient*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioClient*, uint>)(lpVtbl[1]))((IAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioClient*, uint>)(lpVtbl[2]))((IAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
        {
            return ((delegate* stdcall<IAudioClient*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int>)(lpVtbl[3]))((IAudioClient*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
        {
            return ((delegate* stdcall<IAudioClient*, uint*, int>)(lpVtbl[4]))((IAudioClient*)Unsafe.AsPointer(ref this), pNumBufferFrames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
        {
            return ((delegate* stdcall<IAudioClient*, long*, int>)(lpVtbl[5]))((IAudioClient*)Unsafe.AsPointer(ref this), phnsLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
        {
            return ((delegate* stdcall<IAudioClient*, uint*, int>)(lpVtbl[6]))((IAudioClient*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppClosestMatch)
        {
            return ((delegate* stdcall<IAudioClient*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[7]))((IAudioClient*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMixFormat([NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppDeviceFormat)
        {
            return ((delegate* stdcall<IAudioClient*, WAVEFORMATEX**, int>)(lpVtbl[8]))((IAudioClient*)Unsafe.AsPointer(ref this), ppDeviceFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
        {
            return ((delegate* stdcall<IAudioClient*, long*, long*, int>)(lpVtbl[9]))((IAudioClient*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
        }

        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* stdcall<IAudioClient*, int>)(lpVtbl[10]))((IAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IAudioClient*, int>)(lpVtbl[11]))((IAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IAudioClient*, int>)(lpVtbl[12]))((IAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventHandle([NativeTypeName("HANDLE")] IntPtr eventHandle)
        {
            return ((delegate* stdcall<IAudioClient*, IntPtr, int>)(lpVtbl[13]))((IAudioClient*)Unsafe.AsPointer(ref this), eventHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IAudioClient*, Guid*, void**, int>)(lpVtbl[14]))((IAudioClient*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
