// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties"]/*' />
[Guid("4734FC3D-AB21-4424-B735-F4353A56C8FC")]
[NativeTypeName("struct ISystemPhotoProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemPhotoProperties : ISystemPhotoProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemPhotoProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, uint>)(lpVtbl[1]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, uint>)(lpVtbl[2]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[4]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties.get_CameraManufacturer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CameraManufacturer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[6]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties.get_CameraModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CameraModel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[7]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties.get_DateTaken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DateTaken(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[8]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Orientation(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[9]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemPhotoProperties.xml' path='doc/member[@name="ISystemPhotoProperties.get_PeopleNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PeopleNames(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemPhotoProperties*, HSTRING*, int>)(lpVtbl[10]))((ISystemPhotoProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CameraManufacturer(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CameraModel(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DateTaken(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Orientation(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_PeopleNames(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CameraManufacturer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CameraModel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DateTaken;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Orientation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PeopleNames;
    }
}
