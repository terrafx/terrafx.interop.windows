// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A99400F4-3D84-4557-94BA-1242FB2CC9A6")]
    [NativeTypeName("struct IPropertyEnumTypeList : IUnknown")]
    public unsafe partial struct IPropertyEnumTypeList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, uint>)(lpVtbl[1]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, uint>)(lpVtbl[2]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pctypes)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, uint*, int>)(lpVtbl[3]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), pctypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("UINT")] uint itype, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), itype, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionAt([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[5]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), nIndex, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindMatchingIndex([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarCmp, [NativeTypeName("UINT *")] uint* pnIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumTypeList*, PROPVARIANT*, uint*, int>)(lpVtbl[6]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), propvarCmp, pnIndex);
        }
    }
}
