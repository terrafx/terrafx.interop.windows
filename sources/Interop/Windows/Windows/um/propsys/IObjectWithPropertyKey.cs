// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("FC0CA0A7-C316-4FD2-9031-3E628E6D4F23")]
[NativeTypeName("struct IObjectWithPropertyKey : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithPropertyKey : IObjectWithPropertyKey.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[3]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int>)(lpVtbl[4]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), pkey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);

        [VtblIndex(4)]
        HRESULT GetPropertyKey(PROPERTYKEY* pkey);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithPropertyKey*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithPropertyKey*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithPropertyKey*, uint> Release;

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int> SetPropertyKey;

        [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int> GetPropertyKey;
    }
}
