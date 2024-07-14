// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsBinaryMessage.xml' path='doc/member[@name="ISmsBinaryMessage"]/*' />
[Guid("5BF4E813-3B53-4C6E-B61A-D86A63755650")]
[NativeTypeName("struct ISmsBinaryMessage : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
public unsafe partial struct ISmsBinaryMessage : ISmsBinaryMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsBinaryMessage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, Guid*, void**, int>)(lpVtbl[0]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, uint>)(lpVtbl[1]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, uint>)(lpVtbl[2]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, HSTRING*, int>)(lpVtbl[4]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, TrustLevel*, int>)(lpVtbl[5]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsBinaryMessage.xml' path='doc/member[@name="ISmsBinaryMessage.get_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
    public HRESULT get_Format([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat *")] SmsDataFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, SmsDataFormat*, int>)(lpVtbl[6]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBinaryMessage.xml' path='doc/member[@name="ISmsBinaryMessage.put_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
    public HRESULT put_Format([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, SmsDataFormat, int>)(lpVtbl[7]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsBinaryMessage.xml' path='doc/member[@name="ISmsBinaryMessage.GetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
    public HRESULT GetData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, uint*, byte**, int>)(lpVtbl[8]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ISmsBinaryMessage.xml' path='doc/member[@name="ISmsBinaryMessage.SetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
    public HRESULT SetData([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsBinaryMessage*, uint, byte*, int>)(lpVtbl[9]))((ISmsBinaryMessage*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        HRESULT get_Format([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat *")] SmsDataFormat* value);

        [VtblIndex(7)]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        HRESULT put_Format([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat value);

        [VtblIndex(8)]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        HRESULT GetData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(9)]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        HRESULT SetData([NativeTypeName("UINT32")] uint valueLength, byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat *) __attribute__((stdcall))")]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDataFormat*, int> get_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat) __attribute__((stdcall))")]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDataFormat, int> put_Format;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetData;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        [Obsolete("SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> SetData;
    }
}
