// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveNotificationContent.xml' path='doc/member[@name="IAdaptiveNotificationContent"]/*' />
[Guid("EB0DBE66-7448-448D-9DB8-D78ACD2ABBA9")]
[NativeTypeName("struct IAdaptiveNotificationContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveNotificationContent : IAdaptiveNotificationContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveNotificationContent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, uint>)(lpVtbl[1]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, uint>)(lpVtbl[2]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveNotificationContent.xml' path='doc/member[@name="IAdaptiveNotificationContent.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::UI::Notifications::AdaptiveNotificationContentKind *")] AdaptiveNotificationContentKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, AdaptiveNotificationContentKind*, int>)(lpVtbl[6]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveNotificationContent.xml' path='doc/member[@name="IAdaptiveNotificationContent.get_Hints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Hints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveNotificationContent*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[7]))((IAdaptiveNotificationContent*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::UI::Notifications::AdaptiveNotificationContentKind *")] AdaptiveNotificationContentKind* value);

        [VtblIndex(7)]
        HRESULT get_Hints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::AdaptiveNotificationContentKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdaptiveNotificationContentKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Hints;
    }
}
