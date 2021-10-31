// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACE-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct IPipeDouble : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPipeDouble
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPipeDouble*, Guid*, void**, int>)(lpVtbl[0]))((IPipeDouble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPipeDouble*, uint>)(lpVtbl[1]))((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPipeDouble*, uint>)(lpVtbl[2]))((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Pull(double* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* unmanaged<IPipeDouble*, double*, uint, uint*, int>)(lpVtbl[3]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Push(double* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* unmanaged<IPipeDouble*, double*, uint, int>)(lpVtbl[4]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cSent);
        }
    }
}
