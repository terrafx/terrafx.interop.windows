// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACF-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct AsyncIPipeDouble : IUnknown")]
    public unsafe partial struct AsyncIPipeDouble
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, uint>)(lpVtbl[1]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, uint>)(lpVtbl[2]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, uint, int>)(lpVtbl[3]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this), cRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, double*, uint*, int>)(lpVtbl[4]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Push([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, double*, uint, int>)(lpVtbl[5]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return ((delegate* unmanaged<AsyncIPipeDouble*, int>)(lpVtbl[6]))((AsyncIPipeDouble*)Unsafe.AsPointer(ref this));
        }
    }
}
