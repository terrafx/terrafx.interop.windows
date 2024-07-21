// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2"]/*' />
[Guid("6054509B-8EBE-4FEB-9C1E-75E69DE54B84")]
[NativeTypeName("struct IDataPackagePropertySetView2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackagePropertySetView2 : IDataPackagePropertySetView2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackagePropertySetView2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, uint>)(lpVtbl[1]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, uint>)(lpVtbl[2]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, HSTRING*, int>)(lpVtbl[4]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2.get_PackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, HSTRING*, int>)(lpVtbl[6]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2.get_ContentSourceWebLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentSourceWebLink([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, IUriRuntimeClass**, int>)(lpVtbl[7]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2.get_ContentSourceApplicationLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentSourceApplicationLink([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, IUriRuntimeClass**, int>)(lpVtbl[8]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2.get_Square30x30Logo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Square30x30Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, IRandomAccessStreamReference**, int>)(lpVtbl[9]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView2.xml' path='doc/member[@name="IDataPackagePropertySetView2.get_LogoBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView2*, Color*, int>)(lpVtbl[10]))((IDataPackagePropertySetView2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentSourceWebLink([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(8)]
        HRESULT get_ContentSourceApplicationLink([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(9)]
        HRESULT get_Square30x30Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(10)]
        HRESULT get_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ContentSourceWebLink;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ContentSourceApplicationLink;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Square30x30Logo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_LogoBackgroundColor;
    }
}
