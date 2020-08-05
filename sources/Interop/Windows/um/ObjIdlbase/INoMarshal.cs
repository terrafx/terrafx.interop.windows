// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ECC8691B-C1DB-4DC0-855E-65F6C551AF49")]
    [NativeTypeName("struct INoMarshal : IUnknown")]
    public unsafe partial struct INoMarshal
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<INoMarshal*, Guid*, void**, int>)(lpVtbl[0]))((INoMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<INoMarshal*, uint>)(lpVtbl[1]))((INoMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<INoMarshal*, uint>)(lpVtbl[2]))((INoMarshal*)Unsafe.AsPointer(ref this));
        }
    }
}
