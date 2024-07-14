// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPageConfigurationSettings.xml' path='doc/member[@name="IPageConfigurationSettings"]/*' />
[Guid("B6FC1E02-5331-54FF-95A0-1FCB76BB97A9")]
[NativeTypeName("struct IPageConfigurationSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPageConfigurationSettings : IPageConfigurationSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPageConfigurationSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, uint>)(lpVtbl[1]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, uint>)(lpVtbl[2]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, HSTRING*, int>)(lpVtbl[4]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, TrustLevel*, int>)(lpVtbl[5]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPageConfigurationSettings.xml' path='doc/member[@name="IPageConfigurationSettings.get_OrientationSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OrientationSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource *")] PageConfigurationSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, PageConfigurationSource*, int>)(lpVtbl[6]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPageConfigurationSettings.xml' path='doc/member[@name="IPageConfigurationSettings.put_OrientationSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OrientationSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource")] PageConfigurationSource value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, PageConfigurationSource, int>)(lpVtbl[7]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPageConfigurationSettings.xml' path='doc/member[@name="IPageConfigurationSettings.get_SizeSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SizeSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource *")] PageConfigurationSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, PageConfigurationSource*, int>)(lpVtbl[8]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPageConfigurationSettings.xml' path='doc/member[@name="IPageConfigurationSettings.put_SizeSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SizeSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource")] PageConfigurationSource value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPageConfigurationSettings*, PageConfigurationSource, int>)(lpVtbl[9]))((IPageConfigurationSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OrientationSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource *")] PageConfigurationSource* value);

        [VtblIndex(7)]
        HRESULT put_OrientationSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource")] PageConfigurationSource value);

        [VtblIndex(8)]
        HRESULT get_SizeSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource *")] PageConfigurationSource* value);

        [VtblIndex(9)]
        HRESULT put_SizeSource([NativeTypeName("ABI::Windows::Devices::Printers::PageConfigurationSource")] PageConfigurationSource value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::PageConfigurationSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PageConfigurationSource*, int> get_OrientationSource;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::PageConfigurationSource) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PageConfigurationSource, int> put_OrientationSource;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::PageConfigurationSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PageConfigurationSource*, int> get_SizeSource;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::PageConfigurationSource) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PageConfigurationSource, int> put_SizeSource;
    }
}
