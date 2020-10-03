// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F4B1A599-7266-4319-A8CA-E70ACB11E8CD")]
    [NativeTypeName("struct IAudioSessionControl : IUnknown")]
    public unsafe partial struct IAudioSessionControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionControl*, uint>)(lpVtbl[1]))((IAudioSessionControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionControl*, uint>)(lpVtbl[2]))((IAudioSessionControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("AudioSessionState *")] AudioSessionState* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, AudioSessionState*, int>)(lpVtbl[3]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort**, int>)(lpVtbl[4]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayName([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int>)(lpVtbl[5]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort**, int>)(lpVtbl[6]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconPath([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int>)(lpVtbl[7]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingParam([NativeTypeName("GUID *")] Guid* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, int>)(lpVtbl[8]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGroupingParam([NativeTypeName("LPCGUID")] Guid* Override, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, Guid*, int>)(lpVtbl[9]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Override, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterAudioSessionNotification([NativeTypeName("IAudioSessionEvents *")] IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int>)(lpVtbl[10]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), NewNotifications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterAudioSessionNotification([NativeTypeName("IAudioSessionEvents *")] IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int>)(lpVtbl[11]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), NewNotifications);
        }
    }
}
