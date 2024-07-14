// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageCatalogStatics.xml' path='doc/member[@name="IPackageCatalogStatics"]/*' />
[Guid("A18C9696-E65B-4634-BA21-5E63EB7244A7")]
[NativeTypeName("struct IPackageCatalogStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageCatalogStatics : IPackageCatalogStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageCatalogStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, uint>)(lpVtbl[1]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, uint>)(lpVtbl[2]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, HSTRING*, int>)(lpVtbl[4]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageCatalogStatics.xml' path='doc/member[@name="IPackageCatalogStatics.OpenForCurrentPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenForCurrentPackage([NativeTypeName("ABI::Windows::ApplicationModel::IPackageCatalog **")] IPackageCatalog** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, IPackageCatalog**, int>)(lpVtbl[6]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageCatalogStatics.xml' path='doc/member[@name="IPackageCatalogStatics.OpenForCurrentUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenForCurrentUser([NativeTypeName("ABI::Windows::ApplicationModel::IPackageCatalog **")] IPackageCatalog** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogStatics*, IPackageCatalog**, int>)(lpVtbl[7]))((IPackageCatalogStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenForCurrentPackage([NativeTypeName("ABI::Windows::ApplicationModel::IPackageCatalog **")] IPackageCatalog** value);

        [VtblIndex(7)]
        HRESULT OpenForCurrentUser([NativeTypeName("ABI::Windows::ApplicationModel::IPackageCatalog **")] IPackageCatalog** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IPackageCatalog **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPackageCatalog**, int> OpenForCurrentPackage;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IPackageCatalog **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPackageCatalog**, int> OpenForCurrentUser;
    }
}
