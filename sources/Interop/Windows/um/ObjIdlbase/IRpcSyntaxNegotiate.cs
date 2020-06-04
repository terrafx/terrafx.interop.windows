// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("58A08519-24C8-4935-B482-3FD823333A4F")]
    public unsafe partial struct IRpcSyntaxNegotiate
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRpcSyntaxNegotiate*, Guid*, void**, int>)(lpVtbl[0]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRpcSyntaxNegotiate*, uint>)(lpVtbl[1]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRpcSyntaxNegotiate*, uint>)(lpVtbl[2]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NegotiateSyntax([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg)
        {
            return ((delegate* stdcall<IRpcSyntaxNegotiate*, RPCOLEMESSAGE*, int>)(lpVtbl[3]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
