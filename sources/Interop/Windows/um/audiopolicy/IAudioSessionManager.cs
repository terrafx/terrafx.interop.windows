// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4")]
    [NativeTypeName("struct IAudioSessionManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioSessionManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionManager*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionManager*, uint>)(lpVtbl[1]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionManager*, uint>)(lpVtbl[2]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAudioSessionControl([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, IAudioSessionControl** SessionControl)
        {
            return ((delegate* unmanaged<IAudioSessionManager*, Guid*, uint, IAudioSessionControl**, int>)(lpVtbl[3]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, SessionControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSimpleAudioVolume([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, ISimpleAudioVolume** AudioVolume)
        {
            return ((delegate* unmanaged<IAudioSessionManager*, Guid*, uint, ISimpleAudioVolume**, int>)(lpVtbl[4]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, AudioVolume);
        }
    }
}
