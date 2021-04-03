// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0020-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIMultiQI : IUnknown")]
    public unsafe partial struct AsyncIMultiQI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[1]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[2]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint, MULTI_QI*, int>)(lpVtbl[3]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryMultipleInterfaces(MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, MULTI_QI*, int>)(lpVtbl[4]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), pMQIs);
        }
    }
}
