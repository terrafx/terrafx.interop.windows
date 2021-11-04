// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEE47777-163C-4769-996A-6E9C50AD8F54")]
    [NativeTypeName("struct ITfDisplayAttributeProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfDisplayAttributeProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, uint>)(lpVtbl[1]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, uint>)(lpVtbl[2]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo** ppEnum)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[3]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDisplayAttributeInfo([NativeTypeName("const GUID &")] Guid* guid, ITfDisplayAttributeInfo** ppInfo)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, ITfDisplayAttributeInfo**, int>)(lpVtbl[4]))((ITfDisplayAttributeProvider*)Unsafe.AsPointer(ref this), guid, ppInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfDisplayAttributeProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfDisplayAttributeProvider*, uint> Release;

            [NativeTypeName("HRESULT (IEnumTfDisplayAttributeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfDisplayAttributeProvider*, IEnumTfDisplayAttributeInfo**, int> EnumDisplayAttributeInfo;

            [NativeTypeName("HRESULT (const GUID &, ITfDisplayAttributeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfDisplayAttributeProvider*, Guid*, ITfDisplayAttributeInfo**, int> GetDisplayAttributeInfo;
        }
    }
}
