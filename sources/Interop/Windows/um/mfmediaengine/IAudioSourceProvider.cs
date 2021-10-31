// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EBBAF249-AFC2-4582-91C6-B60DF2E84954")]
    [NativeTypeName("struct IAudioSourceProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioSourceProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSourceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSourceProvider*, uint>)(lpVtbl[1]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSourceProvider*, uint>)(lpVtbl[2]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ProvideInput([NativeTypeName("DWORD")] uint dwSampleCount, [NativeTypeName("DWORD *")] uint* pdwChannelCount, float* pInterleavedAudioData)
        {
            return ((delegate* unmanaged<IAudioSourceProvider*, uint, uint*, float*, int>)(lpVtbl[3]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this), dwSampleCount, pdwChannelCount, pInterleavedAudioData);
        }
    }
}
