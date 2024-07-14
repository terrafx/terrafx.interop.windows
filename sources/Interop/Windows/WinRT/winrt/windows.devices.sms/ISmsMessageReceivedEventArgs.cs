// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageReceivedEventArgs.xml' path='doc/member[@name="ISmsMessageReceivedEventArgs"]/*' />
[Guid("08E80A98-B8E5-41C1-A3D8-D3ABFAE22675")]
[NativeTypeName("struct ISmsMessageReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsMessageReceivedEventArgs : ISmsMessageReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageReceivedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, uint>)(lpVtbl[1]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, uint>)(lpVtbl[2]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsMessageReceivedEventArgs.xml' path='doc/member[@name="ISmsMessageReceivedEventArgs.get_TextMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_TextMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, ISmsTextMessage**, int>)(lpVtbl[6]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageReceivedEventArgs.xml' path='doc/member[@name="ISmsMessageReceivedEventArgs.get_BinaryMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_BinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")] ISmsBinaryMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventArgs*, ISmsBinaryMessage**, int>)(lpVtbl[7]))((ISmsMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_TextMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** value);

        [VtblIndex(7)]
        [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_BinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")] ISmsBinaryMessage** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage **) __attribute__((stdcall))")]
        [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsTextMessage**, int> get_TextMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsBinaryMessage **) __attribute__((stdcall))")]
        [Obsolete("SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsBinaryMessage**, int> get_BinaryMessage;
    }
}
