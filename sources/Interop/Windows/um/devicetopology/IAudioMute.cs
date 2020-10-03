// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF45AEEA-B74A-4B6B-AFAD-2366B6AA012E")]
    [NativeTypeName("struct IAudioMute : IUnknown")]
    public unsafe partial struct IAudioMute
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioMute*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioMute*, uint>)(lpVtbl[1]))((IAudioMute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioMute*, uint>)(lpVtbl[2]))((IAudioMute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("BOOL")] int bMuted, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioMute*, int, Guid*, int>)(lpVtbl[3]))((IAudioMute*)Unsafe.AsPointer(ref this), bMuted, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pbMuted)
        {
            return ((delegate* unmanaged<IAudioMute*, int*, int>)(lpVtbl[4]))((IAudioMute*)Unsafe.AsPointer(ref this), pbMuted);
        }
    }
}
