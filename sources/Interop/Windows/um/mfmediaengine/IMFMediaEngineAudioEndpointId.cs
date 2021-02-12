// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A3BAC98-0E76-49FB-8C20-8A86FD98EAF2")]
    [NativeTypeName("struct IMFMediaEngineAudioEndpointId : IUnknown")]
    public unsafe partial struct IMFMediaEngineAudioEndpointId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint>)(lpVtbl[1]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint>)(lpVtbl[2]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioEndpointId([NativeTypeName("LPCWSTR")] ushort* pszEndpointId)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort*, int>)(lpVtbl[3]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), pszEndpointId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioEndpointId([NativeTypeName("LPWSTR *")] ushort** ppszEndpointId)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort**, int>)(lpVtbl[4]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), ppszEndpointId);
        }
    }
}
