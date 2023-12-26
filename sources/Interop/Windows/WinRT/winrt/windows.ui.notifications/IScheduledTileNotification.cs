// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification"]/*' />
[Guid("0ABCA6D5-99DC-4C78-A11C-C9E7F86D7EF7")]
[NativeTypeName("struct IScheduledTileNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledTileNotification : IScheduledTileNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledTileNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, uint>)(lpVtbl[1]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, uint>)(lpVtbl[2]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, HSTRING*, int>)(lpVtbl[4]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, IXmlDocument**, int>)(lpVtbl[6]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.get_DeliveryTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeliveryTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, WinRTDateTime*, int>)(lpVtbl[7]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.put_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, IReference<DateTime>*, int>)(lpVtbl[8]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.get_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, IReference<DateTime>**, int>)(lpVtbl[9]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.put_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Tag(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, HSTRING, int>)(lpVtbl[10]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, HSTRING*, int>)(lpVtbl[11]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, HSTRING, int>)(lpVtbl[12]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledTileNotification.xml' path='doc/member[@name="IScheduledTileNotification.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledTileNotification*, HSTRING*, int>)(lpVtbl[13]))((IScheduledTileNotification*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value);

        [VtblIndex(7)]
        HRESULT get_DeliveryTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(9)]
        HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(10)]
        HRESULT put_Tag(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Tag(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_ExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_ExpirationTime;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Tag;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;
    }
}
