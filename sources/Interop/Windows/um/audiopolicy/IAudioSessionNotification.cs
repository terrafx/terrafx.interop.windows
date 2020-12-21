// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("641DD20B-4D41-49CC-ABA3-174B9477BB08")]
    [NativeTypeName("struct IAudioSessionNotification : IUnknown")]
    public unsafe partial struct IAudioSessionNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionNotification*, uint>)(lpVtbl[1]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionNotification*, uint>)(lpVtbl[2]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSessionCreated([NativeTypeName("IAudioSessionControl *")] IAudioSessionControl* NewSession)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioSessionNotification*, IAudioSessionControl*, int>)(lpVtbl[3]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), NewSession);
        }
    }
}
