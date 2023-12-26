// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFindRelatedPackagesOptionsFactory.xml' path='doc/member[@name="IFindRelatedPackagesOptionsFactory"]/*' />
[Guid("D7D17254-A4FD-55C4-98CF-F2710B7D8BE2")]
[NativeTypeName("struct IFindRelatedPackagesOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFindRelatedPackagesOptionsFactory : IFindRelatedPackagesOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFindRelatedPackagesOptionsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, uint>)(lpVtbl[1]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, uint>)(lpVtbl[2]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, HSTRING*, int>)(lpVtbl[4]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFindRelatedPackagesOptionsFactory.xml' path='doc/member[@name="IFindRelatedPackagesOptionsFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")] PackageRelationship Relationship, [NativeTypeName("ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions **")] IFindRelatedPackagesOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptionsFactory*, PackageRelationship, IFindRelatedPackagesOptions**, int>)(lpVtbl[6]))((IFindRelatedPackagesOptionsFactory*)Unsafe.AsPointer(ref this), Relationship, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")] PackageRelationship Relationship, [NativeTypeName("ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions **")] IFindRelatedPackagesOptions** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::PackageRelationship, ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PackageRelationship, IFindRelatedPackagesOptions**, int> CreateInstance;
    }
}
