// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C789D381-A28C-4168-B28F-D3A837924DC3")]
    [NativeTypeName("struct IAudioClientDuckingControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioClientDuckingControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClientDuckingControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClientDuckingControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClientDuckingControl*, uint>)(lpVtbl[1]))((IAudioClientDuckingControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClientDuckingControl*, uint>)(lpVtbl[2]))((IAudioClientDuckingControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDuckingOptionsForCurrentStream(AUDIO_DUCKING_OPTIONS options)
        {
            return ((delegate* unmanaged<IAudioClientDuckingControl*, AUDIO_DUCKING_OPTIONS, int>)(lpVtbl[3]))((IAudioClientDuckingControl*)Unsafe.AsPointer(ref this), options);
        }
    }
}
