// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACB-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct AsyncIPipeByte
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<AsyncIPipeByte*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<AsyncIPipeByte*, uint>)(lpVtbl[1]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<AsyncIPipeByte*, uint>)(lpVtbl[2]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return ((delegate* stdcall<AsyncIPipeByte*, uint, int>)(lpVtbl[3]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), cRequest);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* stdcall<AsyncIPipeByte*, byte*, uint*, int>)(lpVtbl[4]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Push([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* stdcall<AsyncIPipeByte*, byte*, uint, int>)(lpVtbl[5]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return ((delegate* stdcall<AsyncIPipeByte*, int>)(lpVtbl[6]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }
    }
}
