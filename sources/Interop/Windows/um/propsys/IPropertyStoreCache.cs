// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3017056D-9A91-4E90-937D-746C72ABBF4F")]
    [NativeTypeName("struct IPropertyStoreCache : IPropertyStore")]
    [NativeInheritance("IPropertyStore")]
    public unsafe partial struct IPropertyStoreCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, uint>)(lpVtbl[1]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, uint>)(lpVtbl[2]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("DWORD *")] uint* cProps)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, uint*, int>)(lpVtbl[3]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), cProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, uint, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), iProp, pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* pv)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, int>)(lpVtbl[7]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PSC_STATE* pstate)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PSC_STATE*, int>)(lpVtbl[8]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, pstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueAndState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* ppropvar, PSC_STATE* pstate)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, PSC_STATE*, int>)(lpVtbl[9]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, ppropvar, pstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PSC_STATE state)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PSC_STATE, int>)(lpVtbl[10]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetValueAndState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppropvar, PSC_STATE state)
        {
            return ((delegate* unmanaged<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, PSC_STATE, int>)(lpVtbl[11]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, ppropvar, state);
        }
    }
}
