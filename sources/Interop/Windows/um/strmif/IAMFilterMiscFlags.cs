// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2DD74950-A890-11D1-ABE8-00A0C905F375")]
    [NativeTypeName("struct IAMFilterMiscFlags : IUnknown")]
    public unsafe partial struct IAMFilterMiscFlags
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMFilterMiscFlags*, Guid*, void**, int>)(lpVtbl[0]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMFilterMiscFlags*, uint>)(lpVtbl[1]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMFilterMiscFlags*, uint>)(lpVtbl[2]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint GetMiscFlags()
        {
            return ((delegate* stdcall<IAMFilterMiscFlags*, uint>)(lpVtbl[3]))((IAMFilterMiscFlags*)Unsafe.AsPointer(ref this));
        }
    }
}
