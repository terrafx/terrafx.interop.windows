// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A99400F4-3D84-4557-94BA-1242FB2CC9A6")]
    [NativeTypeName("struct IPropertyEnumTypeList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyEnumTypeList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, uint>)(lpVtbl[1]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, uint>)(lpVtbl[2]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("UINT *")] uint* pctypes)
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, uint*, int>)(lpVtbl[3]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), pctypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt([NativeTypeName("UINT")] uint itype, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), itype, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetConditionAt([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[5]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), nIndex, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT FindMatchingIndex([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarCmp, [NativeTypeName("UINT *")] uint* pnIndex)
        {
            return ((delegate* unmanaged<IPropertyEnumTypeList*, PROPVARIANT*, uint*, int>)(lpVtbl[6]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), propvarCmp, pnIndex);
        }
    }
}
