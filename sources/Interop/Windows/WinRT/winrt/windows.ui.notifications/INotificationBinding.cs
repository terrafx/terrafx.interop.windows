// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding"]/*' />
[Guid("F29E4B85-0370-4AD3-B4EA-DA9E35E7EABF")]
[NativeTypeName("struct INotificationBinding : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INotificationBinding : INotificationBinding.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INotificationBinding);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, Guid*, void**, int>)(lpVtbl[0]))((INotificationBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, uint>)(lpVtbl[1]))((INotificationBinding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, uint>)(lpVtbl[2]))((INotificationBinding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, uint*, Guid**, int>)(lpVtbl[3]))((INotificationBinding*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, HSTRING*, int>)(lpVtbl[4]))((INotificationBinding*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, TrustLevel*, int>)(lpVtbl[5]))((INotificationBinding*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.get_Template"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Template(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, HSTRING*, int>)(lpVtbl[6]))((INotificationBinding*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.put_Template"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Template(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, HSTRING, int>)(lpVtbl[7]))((INotificationBinding*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, HSTRING*, int>)(lpVtbl[8]))((INotificationBinding*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.put_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Language(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, HSTRING, int>)(lpVtbl[9]))((INotificationBinding*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.get_Hints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Hints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[10]))((INotificationBinding*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationBinding.xml' path='doc/member[@name="INotificationBinding.GetTextElements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTextElements([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CAdaptiveNotificationText_t **")] IVectorView<Pointer<IAdaptiveNotificationText>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationBinding*, IVectorView<Pointer<IAdaptiveNotificationText>>**, int>)(lpVtbl[11]))((INotificationBinding*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Template(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Template(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Language(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Hints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);

        [VtblIndex(11)]
        HRESULT GetTextElements([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CAdaptiveNotificationText_t **")] IVectorView<Pointer<IAdaptiveNotificationText>>** result);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Template;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Template;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Language;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Hints;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CAdaptiveNotificationText_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAdaptiveNotificationText>>**, int> GetTextElements;
    }
}
