// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0020-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIMultiQI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIMultiQI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[1]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[2]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Begin_QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint, MULTI_QI*, int>)(lpVtbl[3]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Finish_QueryMultipleInterfaces(MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, MULTI_QI*, int>)(lpVtbl[4]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), pMQIs);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIMultiQI*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIMultiQI*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIMultiQI*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, MULTI_QI *) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIMultiQI*, uint, MULTI_QI*, int> Begin_QueryMultipleInterfaces;

            [NativeTypeName("HRESULT (MULTI_QI *) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIMultiQI*, MULTI_QI*, int> Finish_QueryMultipleInterfaces;
        }
    }
}
