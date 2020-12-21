// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4")]
    [NativeTypeName("struct IAudioSessionManager : IUnknown")]
    public unsafe partial struct IAudioSessionManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionManager*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionManager*, uint>)(lpVtbl[1]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionManager*, uint>)(lpVtbl[2]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioSessionControl([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("IAudioSessionControl **")] IAudioSessionControl** SessionControl)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionManager*, Guid*, uint, IAudioSessionControl**, int>)(lpVtbl[3]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, SessionControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSimpleAudioVolume([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("ISimpleAudioVolume **")] ISimpleAudioVolume** AudioVolume)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionManager*, Guid*, uint, ISimpleAudioVolume**, int>)(lpVtbl[4]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, AudioVolume);
        }
    }
}
