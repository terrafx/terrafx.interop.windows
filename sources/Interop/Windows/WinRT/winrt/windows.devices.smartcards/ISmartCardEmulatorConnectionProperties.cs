// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulatorConnectionProperties.xml' path='doc/member[@name="ISmartCardEmulatorConnectionProperties"]/*' />
[Guid("4E2CA5EE-F969-507D-6CF9-34E2D18DF311")]
[NativeTypeName("struct ISmartCardEmulatorConnectionProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorConnectionProperties : ISmartCardEmulatorConnectionProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardEmulatorConnectionProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, uint>)(lpVtbl[1]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, uint>)(lpVtbl[2]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulatorConnectionProperties.xml' path='doc/member[@name="ISmartCardEmulatorConnectionProperties.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, Guid*, int>)(lpVtbl[6]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulatorConnectionProperties.xml' path='doc/member[@name="ISmartCardEmulatorConnectionProperties.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionSource *")] SmartCardEmulatorConnectionSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionProperties*, SmartCardEmulatorConnectionSource*, int>)(lpVtbl[7]))((ISmartCardEmulatorConnectionProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionSource *")] SmartCardEmulatorConnectionSource* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulatorConnectionSource*, int> get_Source;
    }
}
