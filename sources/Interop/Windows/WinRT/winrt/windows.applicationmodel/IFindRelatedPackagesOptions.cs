// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions"]/*' />
[Guid("41DD7EEA-B335-521F-B96C-5EA07F5B7329")]
[NativeTypeName("struct IFindRelatedPackagesOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFindRelatedPackagesOptions : IFindRelatedPackagesOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFindRelatedPackagesOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, Guid*, void**, int>)(lpVtbl[0]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, uint>)(lpVtbl[1]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, uint>)(lpVtbl[2]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, HSTRING*, int>)(lpVtbl[4]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, TrustLevel*, int>)(lpVtbl[5]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.get_Relationship"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Relationship([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship *")] PackageRelationship* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, PackageRelationship*, int>)(lpVtbl[6]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.put_Relationship"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Relationship([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")] PackageRelationship value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, PackageRelationship, int>)(lpVtbl[7]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.get_IncludeFrameworks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IncludeFrameworks([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte*, int>)(lpVtbl[8]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.put_IncludeFrameworks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IncludeFrameworks([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte, int>)(lpVtbl[9]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.get_IncludeHostRuntimes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IncludeHostRuntimes([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte*, int>)(lpVtbl[10]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.put_IncludeHostRuntimes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IncludeHostRuntimes([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte, int>)(lpVtbl[11]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.get_IncludeOptionals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IncludeOptionals([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte*, int>)(lpVtbl[12]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.put_IncludeOptionals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IncludeOptionals([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte, int>)(lpVtbl[13]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.get_IncludeResources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IncludeResources([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte*, int>)(lpVtbl[14]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindRelatedPackagesOptions.xml' path='doc/member[@name="IFindRelatedPackagesOptions.put_IncludeResources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IncludeResources([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindRelatedPackagesOptions*, byte, int>)(lpVtbl[15]))((IFindRelatedPackagesOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Relationship([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship *")] PackageRelationship* value);

        [VtblIndex(7)]
        HRESULT put_Relationship([NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")] PackageRelationship value);

        [VtblIndex(8)]
        HRESULT get_IncludeFrameworks([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IncludeFrameworks([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_IncludeHostRuntimes([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IncludeHostRuntimes([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IncludeOptionals([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IncludeOptionals([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_IncludeResources([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IncludeResources([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::PackageRelationship *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PackageRelationship*, int> get_Relationship;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::PackageRelationship) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PackageRelationship, int> put_Relationship;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeFrameworks;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeFrameworks;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeHostRuntimes;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeHostRuntimes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeOptionals;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeOptionals;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeResources;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeResources;
    }
}
