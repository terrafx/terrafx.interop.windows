// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8")]
    [NativeTypeName("struct IAudioSessionEnumerator : IUnknown")]
    public unsafe partial struct IAudioSessionEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionEnumerator*, uint>)(lpVtbl[1]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionEnumerator*, uint>)(lpVtbl[2]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount(int* SessionCount)
        {
            return ((delegate* unmanaged<IAudioSessionEnumerator*, int*, int>)(lpVtbl[3]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSession(int SessionCount, IAudioSessionControl** Session)
        {
            return ((delegate* unmanaged<IAudioSessionEnumerator*, int, IAudioSessionControl**, int>)(lpVtbl[4]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount, Session);
        }
    }
}
