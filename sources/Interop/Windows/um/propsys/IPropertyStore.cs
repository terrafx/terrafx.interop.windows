// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
    [NativeTypeName("struct IPropertyStore : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyStore*, uint>)(lpVtbl[1]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyStore*, uint>)(lpVtbl[2]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("DWORD *")] uint* cProps)
        {
            return ((delegate* unmanaged<IPropertyStore*, uint*, int>)(lpVtbl[3]))((IPropertyStore*)Unsafe.AsPointer(ref this), cProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyStore*, uint, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyStore*)Unsafe.AsPointer(ref this), iProp, pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* pv)
        {
            return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged<IPropertyStore*, int>)(lpVtbl[7]))((IPropertyStore*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (DWORD, PROPERTYKEY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, uint, PROPERTYKEY*, int> GetAt;

            [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (const PROPERTYKEY &, const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int> SetValue;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyStore*, int> Commit;
        }
    }
}
