// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEE47777-163C-4769-996A-6E9C50AD8F54")]
    [NativeTypeName("struct ITfDisplayAttributeProvider : IUnknown")]
    public unsafe partial struct ITfDisplayAttributeProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, uint>)(lpVtbl[1]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, uint>)(lpVtbl[2]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDisplayAttributeInfo([NativeTypeName("IEnumTfDisplayAttributeInfo **")] IEnumTfDisplayAttributeInfo** ppEnum)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[3]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayAttributeInfo([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITfDisplayAttributeInfo **")] ITfDisplayAttributeInfo** ppInfo)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, ITfDisplayAttributeInfo**, int>)(lpVtbl[4]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), guid, ppInfo);
        }
    }
}
