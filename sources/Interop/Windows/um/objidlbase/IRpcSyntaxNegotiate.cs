// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("58A08519-24C8-4935-B482-3FD823333A4F")]
    [NativeTypeName("struct IRpcSyntaxNegotiate : IUnknown")]
    public unsafe partial struct IRpcSyntaxNegotiate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcSyntaxNegotiate*, Guid*, void**, int>)(lpVtbl[0]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcSyntaxNegotiate*, uint>)(lpVtbl[1]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcSyntaxNegotiate*, uint>)(lpVtbl[2]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateSyntax(RPCOLEMESSAGE* pMsg)
        {
            return ((delegate* unmanaged<IRpcSyntaxNegotiate*, RPCOLEMESSAGE*, int>)(lpVtbl[3]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
