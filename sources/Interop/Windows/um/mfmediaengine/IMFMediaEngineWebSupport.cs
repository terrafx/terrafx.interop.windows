// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BA2743A1-07E0-48EF-84B6-9A2ED023CA6C")]
    [NativeTypeName("struct IMFMediaEngineWebSupport : IUnknown")]
    public unsafe partial struct IMFMediaEngineWebSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, uint>)(lpVtbl[1]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, uint>)(lpVtbl[2]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int ShouldDelayTheLoadEvent()
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, int>)(lpVtbl[3]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectWebAudio([NativeTypeName("DWORD")] uint dwSampleRate, [NativeTypeName("IAudioSourceProvider **")] IAudioSourceProvider** ppSourceProvider)
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, uint, IAudioSourceProvider**, int>)(lpVtbl[4]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this), dwSampleRate, ppSourceProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisconnectWebAudio()
        {
            return ((delegate* stdcall<IMFMediaEngineWebSupport*, int>)(lpVtbl[5]))((IMFMediaEngineWebSupport*)Unsafe.AsPointer(ref this));
        }
    }
}
