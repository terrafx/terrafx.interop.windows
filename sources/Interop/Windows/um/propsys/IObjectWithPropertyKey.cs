// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC0CA0A7-C316-4FD2-9031-3E628E6D4F23")]
    [NativeTypeName("struct IObjectWithPropertyKey : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectWithPropertyKey
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithPropertyKey*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithPropertyKey*, uint>)(lpVtbl[1]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithPropertyKey*, uint>)(lpVtbl[2]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[3]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[4]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), pkey);
        }
    }
}
