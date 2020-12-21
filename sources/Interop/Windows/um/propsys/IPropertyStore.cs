// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
    [NativeTypeName("struct IPropertyStore : IUnknown")]
    public unsafe partial struct IPropertyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyStore*, uint>)(lpVtbl[1]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyStore*, uint>)(lpVtbl[2]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("DWORD *")] uint* cProps)
        {
            return ((delegate* unmanaged<IPropertyStore*, uint*, int>)(lpVtbl[3]))((IPropertyStore*)Unsafe.AsPointer(ref this), cProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyStore*, uint, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyStore*)Unsafe.AsPointer(ref this), iProp, pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pv)
        {
            return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IPropertyStore*, int>)(lpVtbl[7]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }
    }
}
