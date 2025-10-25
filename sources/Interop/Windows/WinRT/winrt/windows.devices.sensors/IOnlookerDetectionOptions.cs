// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOnlookerDetectionOptions.xml' path='doc/member[@name="IOnlookerDetectionOptions"]/*' />
[Guid("0412B36F-36E6-51E2-876E-65197CC53C12")]
[NativeTypeName("struct IOnlookerDetectionOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOnlookerDetectionOptions : IOnlookerDetectionOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IOnlookerDetectionOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, Guid*, void**, int>)(lpVtbl[0]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, uint>)(lpVtbl[1]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, uint>)(lpVtbl[2]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, HSTRING*, int>)(lpVtbl[4]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, TrustLevel*, int>)(lpVtbl[5]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOnlookerDetectionOptions.xml' path='doc/member[@name="IOnlookerDetectionOptions.get_Action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Action([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionAction *")] OnlookerDetectionAction* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, OnlookerDetectionAction*, int>)(lpVtbl[6]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOnlookerDetectionOptions.xml' path='doc/member[@name="IOnlookerDetectionOptions.put_Action"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Action([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionAction")] OnlookerDetectionAction value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, OnlookerDetectionAction, int>)(lpVtbl[7]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOnlookerDetectionOptions.xml' path='doc/member[@name="IOnlookerDetectionOptions.get_BackOnMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackOnMode([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode *")] OnlookerDetectionBackOnMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, OnlookerDetectionBackOnMode*, int>)(lpVtbl[8]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOnlookerDetectionOptions.xml' path='doc/member[@name="IOnlookerDetectionOptions.put_BackOnMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackOnMode([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode")] OnlookerDetectionBackOnMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOnlookerDetectionOptions*, OnlookerDetectionBackOnMode, int>)(lpVtbl[9]))((IOnlookerDetectionOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Action([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionAction *")] OnlookerDetectionAction* value);

        [VtblIndex(7)]
        HRESULT put_Action([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionAction")] OnlookerDetectionAction value);

        [VtblIndex(8)]
        HRESULT get_BackOnMode([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode *")] OnlookerDetectionBackOnMode* value);

        [VtblIndex(9)]
        HRESULT put_BackOnMode([NativeTypeName("ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode")] OnlookerDetectionBackOnMode value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::OnlookerDetectionAction *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, OnlookerDetectionAction*, int> get_Action;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::OnlookerDetectionAction) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, OnlookerDetectionAction, int> put_Action;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, OnlookerDetectionBackOnMode*, int> get_BackOnMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::OnlookerDetectionBackOnMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, OnlookerDetectionBackOnMode, int> put_BackOnMode;
    }
}
