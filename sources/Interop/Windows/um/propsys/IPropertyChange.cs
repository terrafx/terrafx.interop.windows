// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F917BC8A-1BBA-4478-A245-1BDE03EB9431")]
    [NativeTypeName("struct IPropertyChange : IObjectWithPropertyKey")]
    [NativeInheritance("IObjectWithPropertyKey")]
    public unsafe partial struct IPropertyChange : IPropertyChange.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyChange*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyChange*, uint>)(lpVtbl[1]))((IPropertyChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyChange*, uint>)(lpVtbl[2]))((IPropertyChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyChange*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyChange*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, PROPVARIANT* ppropvarOut)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyChange*)Unsafe.AsPointer(ref this), propvarIn, ppropvarOut);
        }

        public interface Interface : IObjectWithPropertyKey.Interface
        {
            [VtblIndex(5)]
            HRESULT ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, PROPVARIANT* ppropvarOut);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, uint> Release;

            [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int> SetPropertyKey;

            [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int> GetPropertyKey;

            [NativeTypeName("HRESULT (const PROPVARIANT &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyChange*, PROPVARIANT*, PROPVARIANT*, int> ApplyToPropVariant;
        }
    }
}
