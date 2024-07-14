// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBadgeNotification.xml' path='doc/member[@name="IBadgeNotification"]/*' />
[Guid("075CB4CA-D08A-4E2F-9233-7E289C1F7722")]
[NativeTypeName("struct IBadgeNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBadgeNotification : IBadgeNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBadgeNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, Guid*, void**, int>)(lpVtbl[0]))((IBadgeNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, uint>)(lpVtbl[1]))((IBadgeNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, uint>)(lpVtbl[2]))((IBadgeNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, uint*, Guid**, int>)(lpVtbl[3]))((IBadgeNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, HSTRING*, int>)(lpVtbl[4]))((IBadgeNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, TrustLevel*, int>)(lpVtbl[5]))((IBadgeNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBadgeNotification.xml' path='doc/member[@name="IBadgeNotification.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, IXmlDocument**, int>)(lpVtbl[6]))((IBadgeNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBadgeNotification.xml' path='doc/member[@name="IBadgeNotification.put_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, IReference<DateTime>*, int>)(lpVtbl[7]))((IBadgeNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBadgeNotification.xml' path='doc/member[@name="IBadgeNotification.get_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBadgeNotification*, IReference<DateTime>**, int>)(lpVtbl[8]))((IBadgeNotification*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value);

        [VtblIndex(7)]
        HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(8)]
        HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_ExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_ExpirationTime;
    }
}
