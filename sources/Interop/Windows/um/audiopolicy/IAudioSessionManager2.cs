// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F")]
    [NativeTypeName("struct IAudioSessionManager2 : IAudioSessionManager")]
    public unsafe partial struct IAudioSessionManager2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, uint>)(lpVtbl[1]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, uint>)(lpVtbl[2]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioSessionControl([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, IAudioSessionControl** SessionControl)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, Guid*, uint, IAudioSessionControl**, int>)(lpVtbl[3]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, SessionControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSimpleAudioVolume([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, ISimpleAudioVolume** AudioVolume)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, Guid*, uint, ISimpleAudioVolume**, int>)(lpVtbl[4]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, AudioVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSessionEnumerator(IAudioSessionEnumerator** SessionEnum)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, IAudioSessionEnumerator**, int>)(lpVtbl[5]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), SessionEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterSessionNotification(IAudioSessionNotification* SessionNotification)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, IAudioSessionNotification*, int>)(lpVtbl[6]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), SessionNotification);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterSessionNotification(IAudioSessionNotification* SessionNotification)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, IAudioSessionNotification*, int>)(lpVtbl[7]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), SessionNotification);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterDuckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID, IAudioVolumeDuckNotification* duckNotification)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, ushort*, IAudioVolumeDuckNotification*, int>)(lpVtbl[8]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), sessionID, duckNotification);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterDuckNotification(IAudioVolumeDuckNotification* duckNotification)
        {
            return ((delegate* unmanaged<IAudioSessionManager2*, IAudioVolumeDuckNotification*, int>)(lpVtbl[9]))((IAudioSessionManager2*)Unsafe.AsPointer(ref this), duckNotification);
        }
    }
}
