// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A5645D2-43BD-47FD-87B7-DCD24CC7D692")]
    [NativeTypeName("struct IMFCdmSuspendNotify : IUnknown")]
    public unsafe partial struct IMFCdmSuspendNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCdmSuspendNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFCdmSuspendNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCdmSuspendNotify*, uint>)(lpVtbl[1]))((IMFCdmSuspendNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCdmSuspendNotify*, uint>)(lpVtbl[2]))((IMFCdmSuspendNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin()
        {
            return ((delegate* stdcall<IMFCdmSuspendNotify*, int>)(lpVtbl[3]))((IMFCdmSuspendNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int End()
        {
            return ((delegate* stdcall<IMFCdmSuspendNotify*, int>)(lpVtbl[4]))((IMFCdmSuspendNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
