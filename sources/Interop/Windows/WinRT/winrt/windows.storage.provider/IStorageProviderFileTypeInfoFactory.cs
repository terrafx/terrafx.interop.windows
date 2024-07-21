// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderFileTypeInfoFactory.xml' path='doc/member[@name="IStorageProviderFileTypeInfoFactory"]/*' />
[Guid("3FA12C6F-CCE6-5D5D-80B1-389E7CF92DBF")]
[NativeTypeName("struct IStorageProviderFileTypeInfoFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderFileTypeInfoFactory : IStorageProviderFileTypeInfoFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderFileTypeInfoFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, uint>)(lpVtbl[1]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, uint>)(lpVtbl[2]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderFileTypeInfoFactory.xml' path='doc/member[@name="IStorageProviderFileTypeInfoFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance(HSTRING fileExtension, HSTRING iconResource, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderFileTypeInfo **")] IStorageProviderFileTypeInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderFileTypeInfoFactory*, HSTRING, HSTRING, IStorageProviderFileTypeInfo**, int>)(lpVtbl[6]))((IStorageProviderFileTypeInfoFactory*)Unsafe.AsPointer(ref this), fileExtension, iconResource, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance(HSTRING fileExtension, HSTRING iconResource, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderFileTypeInfo **")] IStorageProviderFileTypeInfo** value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Provider::IStorageProviderFileTypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IStorageProviderFileTypeInfo**, int> CreateInstance;
    }
}
