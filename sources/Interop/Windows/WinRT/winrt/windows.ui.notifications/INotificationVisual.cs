// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INotificationVisual.xml' path='doc/member[@name="INotificationVisual"]/*' />
[Guid("68835B8E-AA56-4E11-86D3-5F9A6957BC5B")]
[NativeTypeName("struct INotificationVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INotificationVisual : INotificationVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INotificationVisual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, Guid*, void**, int>)(lpVtbl[0]))((INotificationVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, uint>)(lpVtbl[1]))((INotificationVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, uint>)(lpVtbl[2]))((INotificationVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, uint*, Guid**, int>)(lpVtbl[3]))((INotificationVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, HSTRING*, int>)(lpVtbl[4]))((INotificationVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, TrustLevel*, int>)(lpVtbl[5]))((INotificationVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INotificationVisual.xml' path='doc/member[@name="INotificationVisual.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, HSTRING*, int>)(lpVtbl[6]))((INotificationVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationVisual.xml' path='doc/member[@name="INotificationVisual.put_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Language(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, HSTRING, int>)(lpVtbl[7]))((INotificationVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationVisual.xml' path='doc/member[@name="INotificationVisual.get_Bindings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Bindings([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CNotifications__CNotificationBinding_t **")] IVector<Pointer<INotificationBinding>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, IVector<Pointer<INotificationBinding>>**, int>)(lpVtbl[8]))((INotificationVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INotificationVisual.xml' path='doc/member[@name="INotificationVisual.GetBinding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBinding(HSTRING templateName, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationBinding **")] INotificationBinding** result)
    {
        return ((delegate* unmanaged[MemberFunction]<INotificationVisual*, HSTRING, INotificationBinding**, int>)(lpVtbl[9]))((INotificationVisual*)Unsafe.AsPointer(ref this), templateName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Language(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Bindings([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CNotifications__CNotificationBinding_t **")] IVector<Pointer<INotificationBinding>>** value);

        [VtblIndex(9)]
        HRESULT GetBinding(HSTRING templateName, [NativeTypeName("ABI::Windows::UI::Notifications::INotificationBinding **")] INotificationBinding** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Language;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CNotifications__CNotificationBinding_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<INotificationBinding>>**, int> get_Bindings;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::INotificationBinding **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, INotificationBinding**, int> GetBinding;
    }
}
