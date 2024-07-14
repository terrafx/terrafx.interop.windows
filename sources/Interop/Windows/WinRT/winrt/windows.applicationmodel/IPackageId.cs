// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageId.xml' path='doc/member[@name="IPackageId"]/*' />
[Guid("1ADB665E-37C7-4790-9980-DD7AE74E8BB2")]
[NativeTypeName("struct IPackageId : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageId : IPackageId.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageId));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, Guid*, void**, int>)(lpVtbl[0]))((IPackageId*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, uint>)(lpVtbl[1]))((IPackageId*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, uint>)(lpVtbl[2]))((IPackageId*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageId*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[4]))((IPackageId*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, TrustLevel*, int>)(lpVtbl[5]))((IPackageId*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[6]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Version([NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")] PackageVersion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, PackageVersion*, int>)(lpVtbl[7]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_Architecture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Architecture([NativeTypeName("ABI::Windows::System::ProcessorArchitecture *")] ProcessorArchitecture* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, ProcessorArchitecture*, int>)(lpVtbl[8]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_ResourceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ResourceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[9]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_Publisher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Publisher(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[10]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_PublisherId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PublisherId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[11]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_FullName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FullName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[12]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageId.xml' path='doc/member[@name="IPackageId.get_FamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageId*, HSTRING*, int>)(lpVtbl[13]))((IPackageId*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Version([NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")] PackageVersion* value);

        [VtblIndex(8)]
        HRESULT get_Architecture([NativeTypeName("ABI::Windows::System::ProcessorArchitecture *")] ProcessorArchitecture* value);

        [VtblIndex(9)]
        HRESULT get_ResourceId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Publisher(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PublisherId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_FullName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_FamilyName(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::PackageVersion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PackageVersion*, int> get_Version;

        [NativeTypeName("HRESULT (ABI::Windows::System::ProcessorArchitecture *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProcessorArchitecture*, int> get_Architecture;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResourceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Publisher;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublisherId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FullName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FamilyName;
    }
}
