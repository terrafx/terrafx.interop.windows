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
    public unsafe partial struct IPropertyChange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyChange*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyChange*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, PROPVARIANT* ppropvarOut)
        {
            return ((delegate* unmanaged<IPropertyChange*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyChange*)Unsafe.AsPointer(ref this), propvarIn, ppropvarOut);
        }
    }
}
