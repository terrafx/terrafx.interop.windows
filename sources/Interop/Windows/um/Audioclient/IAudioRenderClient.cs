// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F294ACFC-3146-4483-A7BF-ADDCA7C260E2")]
    public unsafe partial struct IAudioRenderClient
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioRenderClient*, Guid*, void**, int>)(lpVtbl[0]))((IAudioRenderClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioRenderClient*, uint>)(lpVtbl[1]))((IAudioRenderClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioRenderClient*, uint>)(lpVtbl[2]))((IAudioRenderClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT32")] uint NumFramesRequested, [NativeTypeName("BYTE **")] byte** ppData)
        {
            return ((delegate* stdcall<IAudioRenderClient*, uint, byte**, int>)(lpVtbl[3]))((IAudioRenderClient*)Unsafe.AsPointer(ref this), NumFramesRequested, ppData);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesWritten, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IAudioRenderClient*, uint, uint, int>)(lpVtbl[4]))((IAudioRenderClient*)Unsafe.AsPointer(ref this), NumFramesWritten, dwFlags);
        }
    }
}
