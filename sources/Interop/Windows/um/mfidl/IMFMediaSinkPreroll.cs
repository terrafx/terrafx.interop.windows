// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5DFD4B2A-7674-4110-A4E6-8A68FD5F3688")]
    public unsafe partial struct IMFMediaSinkPreroll
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSinkPreroll*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSinkPreroll*, uint>)(lpVtbl[1]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSinkPreroll*, uint>)(lpVtbl[2]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyPreroll([NativeTypeName("MFTIME")] long hnsUpcomingStartTime)
        {
            return ((delegate* stdcall<IMFMediaSinkPreroll*, long, int>)(lpVtbl[3]))((IMFMediaSinkPreroll*)Unsafe.AsPointer(ref this), hnsUpcomingStartTime);
        }
    }
}
