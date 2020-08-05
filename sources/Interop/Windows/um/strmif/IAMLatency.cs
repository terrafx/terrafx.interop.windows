// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62EA93BA-EC62-11D2-B770-00C04FB6BD3D")]
    [NativeTypeName("struct IAMLatency : IUnknown")]
    public unsafe partial struct IAMLatency
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMLatency*, Guid*, void**, int>)(lpVtbl[0]))((IAMLatency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMLatency*, uint>)(lpVtbl[1]))((IAMLatency*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMLatency*, uint>)(lpVtbl[2]))((IAMLatency*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
        {
            return ((delegate* stdcall<IAMLatency*, long*, int>)(lpVtbl[3]))((IAMLatency*)Unsafe.AsPointer(ref this), prtLatency);
        }
    }
}
