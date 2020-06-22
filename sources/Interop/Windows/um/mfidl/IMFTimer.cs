// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E56E4CBD-8F70-49D8-A0F8-EDB3D6AB9BF2")]
    public unsafe partial struct IMFTimer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimer*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimer*, uint>)(lpVtbl[1]))((IMFTimer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimer*, uint>)(lpVtbl[2]))((IMFTimer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimer([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONGLONG")] long llClockTime, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState, [NativeTypeName("IUnknown **")] IUnknown** ppunkKey)
        {
            return ((delegate* stdcall<IMFTimer*, uint, long, IMFAsyncCallback*, IUnknown*, IUnknown**, int>)(lpVtbl[3]))((IMFTimer*)Unsafe.AsPointer(ref this), dwFlags, llClockTime, pCallback, punkState, ppunkKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelTimer([NativeTypeName("IUnknown *")] IUnknown* punkKey)
        {
            return ((delegate* stdcall<IMFTimer*, IUnknown*, int>)(lpVtbl[4]))((IMFTimer*)Unsafe.AsPointer(ref this), punkKey);
        }
    }
}
