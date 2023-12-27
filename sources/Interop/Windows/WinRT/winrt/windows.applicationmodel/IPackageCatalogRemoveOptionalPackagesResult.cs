// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageCatalogRemoveOptionalPackagesResult.xml' path='doc/member[@name="IPackageCatalogRemoveOptionalPackagesResult"]/*' />
[Guid("29D2F97B-D974-4E64-9359-22CADFD79828")]
[NativeTypeName("struct IPackageCatalogRemoveOptionalPackagesResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageCatalogRemoveOptionalPackagesResult : IPackageCatalogRemoveOptionalPackagesResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageCatalogRemoveOptionalPackagesResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, Guid*, void**, int>)(lpVtbl[0]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, uint>)(lpVtbl[1]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, uint>)(lpVtbl[2]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, HSTRING*, int>)(lpVtbl[4]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, TrustLevel*, int>)(lpVtbl[5]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageCatalogRemoveOptionalPackagesResult.xml' path='doc/member[@name="IPackageCatalogRemoveOptionalPackagesResult.get_PackagesRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PackagesRemoved([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CPackage_t **")] IVectorView<Pointer<IPackage>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, IVectorView<Pointer<IPackage>>**, int>)(lpVtbl[6]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageCatalogRemoveOptionalPackagesResult.xml' path='doc/member[@name="IPackageCatalogRemoveOptionalPackagesResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalogRemoveOptionalPackagesResult*, HRESULT*, int>)(lpVtbl[7]))((IPackageCatalogRemoveOptionalPackagesResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PackagesRemoved([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CPackage_t **")] IVectorView<Pointer<IPackage>>** value);

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CPackage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IPackage>>**, int> get_PackagesRemoved;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;
    }
}
