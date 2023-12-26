// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulatorConnectionDeactivatedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorConnectionDeactivatedEventArgs"]/*' />
[Guid("2186D8D3-C5EB-5262-43DF-62A0A1B55557")]
[NativeTypeName("struct ISmartCardEmulatorConnectionDeactivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorConnectionDeactivatedEventArgs : ISmartCardEmulatorConnectionDeactivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulatorConnectionDeactivatedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, uint>)(lpVtbl[1]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, uint>)(lpVtbl[2]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulatorConnectionDeactivatedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorConnectionDeactivatedEventArgs.get_ConnectionProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConnectionProperties([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **")] ISmartCardEmulatorConnectionProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, ISmartCardEmulatorConnectionProperties**, int>)(lpVtbl[6]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulatorConnectionDeactivatedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorConnectionDeactivatedEventArgs.get_Reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Reason([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionDeactivatedReason *")] SmartCardEmulatorConnectionDeactivatedReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorConnectionDeactivatedEventArgs*, SmartCardEmulatorConnectionDeactivatedReason*, int>)(lpVtbl[7]))((ISmartCardEmulatorConnectionDeactivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConnectionProperties([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **")] ISmartCardEmulatorConnectionProperties** value);

        [VtblIndex(7)]
        HRESULT get_Reason([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionDeactivatedReason *")] SmartCardEmulatorConnectionDeactivatedReason* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardEmulatorConnectionProperties**, int> get_ConnectionProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulatorConnectionDeactivatedReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulatorConnectionDeactivatedReason*, int> get_Reason;
    }
}
