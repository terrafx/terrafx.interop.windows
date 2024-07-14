// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage"]/*' />
[Guid("D61C904C-A495-487F-9A6F-971548C5BC9F")]
[NativeTypeName("struct ISmsTextMessage : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
public unsafe partial struct ISmsTextMessage : ISmsTextMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsTextMessage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, Guid*, void**, int>)(lpVtbl[0]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint>)(lpVtbl[1]))((ISmsTextMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint>)(lpVtbl[2]))((ISmsTextMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING*, int>)(lpVtbl[4]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, TrustLevel*, int>)(lpVtbl[5]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, WinRTDateTime*, int>)(lpVtbl[6]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_PartReferenceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_PartReferenceId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint*, int>)(lpVtbl[7]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_PartNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_PartNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint*, int>)(lpVtbl[8]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_PartCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_PartCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, uint*, int>)(lpVtbl[9]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_To(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING*, int>)(lpVtbl[10]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.put_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT put_To(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING, int>)(lpVtbl[11]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING*, int>)(lpVtbl[12]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.put_From"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT put_From(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING, int>)(lpVtbl[13]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING*, int>)(lpVtbl[14]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.put_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, HSTRING, int>)(lpVtbl[15]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.get_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, SmsEncoding*, int>)(lpVtbl[16]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.put_Encoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, SmsEncoding, int>)(lpVtbl[17]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsTextMessage.xml' path='doc/member[@name="ISmsTextMessage.ToBinaryMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
    public HRESULT ToBinaryMessages([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **")] IVectorView<Pointer<ISmsBinaryMessage>>** messages)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsTextMessage*, SmsDataFormat, IVectorView<Pointer<ISmsBinaryMessage>>**, int>)(lpVtbl[18]))((ISmsTextMessage*)Unsafe.AsPointer(ref this), format, messages);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_PartReferenceId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_PartNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_PartCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_To(HSTRING* value);

        [VtblIndex(11)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT put_To(HSTRING value);

        [VtblIndex(12)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(13)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT put_From(HSTRING value);

        [VtblIndex(14)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(15)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT put_Body(HSTRING value);

        [VtblIndex(16)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT get_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding *")] SmsEncoding* value);

        [VtblIndex(17)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT put_Encoding([NativeTypeName("ABI::Windows::Devices::Sms::SmsEncoding")] SmsEncoding value);

        [VtblIndex(18)]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        HRESULT ToBinaryMessages([NativeTypeName("ABI::Windows::Devices::Sms::SmsDataFormat")] SmsDataFormat format, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **")] IVectorView<Pointer<ISmsBinaryMessage>>** messages);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PartReferenceId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PartNumber;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PartCount;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_To;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_To;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_From;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Body;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding *) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding*, int> get_Encoding;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsEncoding) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsEncoding, int> put_Encoding;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsDataFormat, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSms__CISmsBinaryMessage_t **) __attribute__((stdcall))")]
        [Obsolete("SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsDataFormat, IVectorView<Pointer<ISmsBinaryMessage>>**, int> ToBinaryMessages;
    }
}
