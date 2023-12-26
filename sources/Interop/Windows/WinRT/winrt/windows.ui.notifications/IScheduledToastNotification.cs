// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification"]/*' />
[Guid("79F577F8-0DE7-48CD-9740-9B370490C838")]
[NativeTypeName("struct IScheduledToastNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledToastNotification : IScheduledToastNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledToastNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, uint>)(lpVtbl[1]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, uint>)(lpVtbl[2]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, HSTRING*, int>)(lpVtbl[4]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, IXmlDocument**, int>)(lpVtbl[6]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.get_DeliveryTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeliveryTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, WinRTDateTime*, int>)(lpVtbl[7]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.get_SnoozeInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SnoozeInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.get_MaximumSnoozeCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaximumSnoozeCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, uint*, int>)(lpVtbl[9]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, HSTRING, int>)(lpVtbl[10]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification.xml' path='doc/member[@name="IScheduledToastNotification.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification*, HSTRING*, int>)(lpVtbl[11]))((IScheduledToastNotification*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value);

        [VtblIndex(7)]
        HRESULT get_DeliveryTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT get_SnoozeInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT get_MaximumSnoozeCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Id(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocument**, int> get_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DeliveryTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_SnoozeInterval;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaximumSnoozeCount;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;
    }
}
