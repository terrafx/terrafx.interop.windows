// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFB7FF88-7239-4FC9-8FA2-07C950BE9C6D")]
    [NativeTypeName("struct IAudioSessionControl2 : IAudioSessionControl")]
    [NativeInheritance("IAudioSessionControl")]
    public unsafe partial struct IAudioSessionControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, uint>)(lpVtbl[1]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, uint>)(lpVtbl[2]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetState(AudioSessionState* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, AudioSessionState*, int>)(lpVtbl[3]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int>)(lpVtbl[4]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort*, Guid*, int>)(lpVtbl[5]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int>)(lpVtbl[6]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort*, Guid*, int>)(lpVtbl[7]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetGroupingParam(Guid* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, int>)(lpVtbl[8]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGroupingParam([NativeTypeName("LPCGUID")] Guid* Override, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, Guid*, int>)(lpVtbl[9]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Override, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RegisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, IAudioSessionEvents*, int>)(lpVtbl[10]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), NewNotifications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, IAudioSessionEvents*, int>)(lpVtbl[11]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), NewNotifications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetSessionIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int>)(lpVtbl[12]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetSessionInstanceIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int>)(lpVtbl[13]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetProcessId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, uint*, int>)(lpVtbl[14]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsSystemSoundsSession()
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, int>)(lpVtbl[15]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetDuckingPreference(BOOL optOut)
        {
            return ((delegate* unmanaged<IAudioSessionControl2*, BOOL, int>)(lpVtbl[16]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), optOut);
        }
    }
}
