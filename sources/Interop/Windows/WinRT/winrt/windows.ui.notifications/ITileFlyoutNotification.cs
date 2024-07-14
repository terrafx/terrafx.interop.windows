// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileFlyoutNotification.xml' path='doc/member[@name="ITileFlyoutNotification"]/*' />
[Guid("9A53B261-C70C-42BE-B2F3-F42AA97D34E5")]
[NativeTypeName("struct ITileFlyoutNotification : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileFlyoutNotification : ITileFlyoutNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileFlyoutNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, Guid*, void**, int>)(lpVtbl[0]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, uint>)(lpVtbl[1]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, uint>)(lpVtbl[2]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, uint*, Guid**, int>)(lpVtbl[3]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, HSTRING*, int>)(lpVtbl[4]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, TrustLevel*, int>)(lpVtbl[5]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileFlyoutNotification.xml' path='doc/member[@name="ITileFlyoutNotification.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, IXmlDocument**, int>)(lpVtbl[6]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITileFlyoutNotification.xml' path='doc/member[@name="ITileFlyoutNotification.put_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, IReference<DateTime>*, int>)(lpVtbl[7]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITileFlyoutNotification.xml' path='doc/member[@name="ITileFlyoutNotification.get_ExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ExpirationTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileFlyoutNotification*, IReference<DateTime>**, int>)(lpVtbl[8]))((ITileFlyoutNotification*)Unsafe.AsPointer(ref this), value);
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
