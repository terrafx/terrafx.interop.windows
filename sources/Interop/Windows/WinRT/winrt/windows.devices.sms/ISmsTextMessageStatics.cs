// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsTextMessageStatics.xml' path='doc/member[@name="ISmsTextMessageStatics"]/*' />
[Guid("7F68C5ED-3CCC-47A3-8C55-380D3B010892")]
[NativeTypeName("struct ISmsTextMessageStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsTextMessageStatics : ISmsTextMessageStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsTextMessageStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, uint>)(lpVtbl[1]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, uint>)(lpVtbl[2]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, HSTRING*, int>)(lpVtbl[4]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsTextMessageStatics.xml' path='doc/member[@name="ISmsTextMessageStatics.FromBinaryMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
    public HRESULT FromBinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage *")] ISmsBinaryMessage* binaryMessage, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** textMessage)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, ISmsBinaryMessage*, ISmsTextMessage**, int>)(lpVtbl[6]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), binaryMessage, textMessage);
    }

    /// <include file='ISmsTextMessageStatics.xml' path='doc/member[@name="ISmsTextMessageStatics.FromBinaryData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
    public HRESULT FromBinaryData([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format, [NativeTypeName("UINT32")] uint valueLength, byte* value, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** textMessage)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessageStatics*, SmsDataFormat, uint, byte*, ISmsTextMessage**, int>)(lpVtbl[7]))((ISmsTextMessageStatics*)Unsafe.AsPointer(ref this), format, valueLength, value, textMessage);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
        HRESULT FromBinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage *")] ISmsBinaryMessage* binaryMessage, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** textMessage);

        [VtblIndex(7)]
        [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
        HRESULT FromBinaryData([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format, [NativeTypeName("UINT32")] uint valueLength, byte* value, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage** textMessage);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsBinaryMessage *, ABI::Windows::Devices::Sms::ISmsTextMessage **) __attribute__((stdcall))")]
        [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsBinaryMessage*, ISmsTextMessage**, int> FromBinaryMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat, UINT32, BYTE *, ABI::Windows::Devices::Sms::ISmsTextMessage **) __attribute__((stdcall))")]
        [Obsolete("ISmsTextMessageStatics may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDataFormat, uint, byte*, ISmsTextMessage**, int> FromBinaryData;
    }
}
