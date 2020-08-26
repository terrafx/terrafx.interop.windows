// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3017056D-9A91-4E90-937D-746C72ABBF4F")]
    [NativeTypeName("struct IPropertyStoreCache : IPropertyStore")]
    public unsafe partial struct IPropertyStoreCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyStoreCache*, uint>)(lpVtbl[1]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyStoreCache*, uint>)(lpVtbl[2]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("DWORD *")] uint* cProps)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, uint*, int>)(lpVtbl[3]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), cProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, uint, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), iProp, pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pv)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IPropertyStoreCache*, int>)(lpVtbl[7]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PSC_STATE *")] PSC_STATE* pstate)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PSC_STATE*, int>)(lpVtbl[8]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, pstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueAndState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar, [NativeTypeName("PSC_STATE *")] PSC_STATE* pstate)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, PSC_STATE*, int>)(lpVtbl[9]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, ppropvar, pstate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PSC_STATE state)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PSC_STATE, int>)(lpVtbl[10]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValueAndState([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppropvar, PSC_STATE state)
        {
            return ((delegate* stdcall<IPropertyStoreCache*, PROPERTYKEY*, PROPVARIANT*, PSC_STATE, int>)(lpVtbl[11]))((IPropertyStoreCache*)Unsafe.AsPointer(ref this), key, ppropvar, state);
        }
    }
}
