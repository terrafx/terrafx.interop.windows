// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACA-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct IPipeByte : IUnknown")]
    public unsafe partial struct IPipeByte
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPipeByte*, Guid*, void**, int>)(lpVtbl[0]))((IPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPipeByte*, uint>)(lpVtbl[1]))((IPipeByte*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPipeByte*, uint>)(lpVtbl[2]))((IPipeByte*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pull([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* stdcall<IPipeByte*, byte*, uint, uint*, int>)(lpVtbl[3]))((IPipeByte*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Push([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* stdcall<IPipeByte*, byte*, uint, int>)(lpVtbl[4]))((IPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
        }
    }
}
