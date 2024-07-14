// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPropertyStoreFactory.xml' path='doc/member[@name="IPropertyStoreFactory"]/*' />
[Guid("BC110B6D-57E8-4148-A9C6-91015AB2F3A5")]
[NativeTypeName("struct IPropertyStoreFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStoreFactory : IPropertyStoreFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStoreFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyStoreFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyStoreFactory*, uint>)(lpVtbl[1]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyStoreFactory*, uint>)(lpVtbl[2]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyStoreFactory.xml' path='doc/member[@name="IPropertyStoreFactory.GetPropertyStore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, IUnknown* pUnkFactory, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyStoreFactory*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), flags, pUnkFactory, riid, ppv);
    }

    /// <include file='IPropertyStoreFactory.xml' path='doc/member[@name="IPropertyStoreFactory.GetPropertyStoreForKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyStoreFactory*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[4]))((IPropertyStoreFactory*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, IUnknown* pUnkFactory, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(4)]
        HRESULT GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (GETPROPERTYSTOREFLAGS, IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int> GetPropertyStore;

        [NativeTypeName("HRESULT (const PROPERTYKEY *, UINT, GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int> GetPropertyStoreForKeys;
    }
}
