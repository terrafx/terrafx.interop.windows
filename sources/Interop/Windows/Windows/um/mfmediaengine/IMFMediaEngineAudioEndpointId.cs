// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("7A3BAC98-0E76-49FB-8C20-8A86FD98EAF2")]
    [NativeTypeName("struct IMFMediaEngineAudioEndpointId : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineAudioEndpointId : IMFMediaEngineAudioEndpointId.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint>)(lpVtbl[1]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint>)(lpVtbl[2]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAudioEndpointId([NativeTypeName("LPCWSTR")] ushort* pszEndpointId)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort*, int>)(lpVtbl[3]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), pszEndpointId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAudioEndpointId([NativeTypeName("LPWSTR *")] ushort** ppszEndpointId)
        {
            return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort**, int>)(lpVtbl[4]))((IMFMediaEngineAudioEndpointId*)Unsafe.AsPointer(ref this), ppszEndpointId);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAudioEndpointId([NativeTypeName("LPCWSTR")] ushort* pszEndpointId);

            [VtblIndex(4)]
            HRESULT GetAudioEndpointId([NativeTypeName("LPWSTR *")] ushort** ppszEndpointId);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineAudioEndpointId*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineAudioEndpointId*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort*, int> SetAudioEndpointId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineAudioEndpointId*, ushort**, int> GetAudioEndpointId;
        }
    }
}
