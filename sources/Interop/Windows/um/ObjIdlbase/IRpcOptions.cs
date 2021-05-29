// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000144-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRpcOptions : IUnknown")]
    public unsafe partial struct IRpcOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcOptions*, Guid*, void**, int>)(lpVtbl[0]))((IRpcOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcOptions*, uint>)(lpVtbl[1]))((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcOptions*, uint>)(lpVtbl[2]))((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Set(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
        {
            return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint, int>)(lpVtbl[3]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Query(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
        {
            return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int>)(lpVtbl[4]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, pdwValue);
        }
    }
}
