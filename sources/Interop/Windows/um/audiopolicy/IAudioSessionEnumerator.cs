// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8")]
    public unsafe partial struct IAudioSessionEnumerator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioSessionEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioSessionEnumerator*, uint>)(lpVtbl[1]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioSessionEnumerator*, uint>)(lpVtbl[2]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("int *")] int* SessionCount)
        {
            return ((delegate* stdcall<IAudioSessionEnumerator*, int*, int>)(lpVtbl[3]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSession(int SessionCount, [NativeTypeName("IAudioSessionControl **")] IAudioSessionControl** Session)
        {
            return ((delegate* stdcall<IAudioSessionEnumerator*, int, IAudioSessionControl**, int>)(lpVtbl[4]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount, Session);
        }
    }
}
