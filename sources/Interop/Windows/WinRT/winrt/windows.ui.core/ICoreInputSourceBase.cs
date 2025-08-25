// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase"]/*' />
[Guid("9F488807-4580-4BE8-BE68-92A9311713BB")]
[NativeTypeName("struct ICoreInputSourceBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputSourceBase : ICoreInputSourceBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreInputSourceBase);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, uint>)(lpVtbl[1]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, uint>)(lpVtbl[2]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase.get_Dispatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, ICoreDispatcher**, int>)(lpVtbl[6]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase.get_IsInputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsInputEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, byte*, int>)(lpVtbl[7]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase.put_IsInputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsInputEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, byte, int>)(lpVtbl[8]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase.add_InputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IInputEnabledEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IInputEnabledEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreInputSourceBase.xml' path='doc/member[@name="ICoreInputSourceBase.remove_InputEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_InputEnabled(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputSourceBase*, EventRegistrationToken, int>)(lpVtbl[10]))((ICoreInputSourceBase*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value);

        [VtblIndex(7)]
        HRESULT get_IsInputEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsInputEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT add_InputEnabled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CInputEnabledEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IInputEnabledEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(10)]
        HRESULT remove_InputEnabled(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreDispatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreDispatcher**, int> get_Dispatcher;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInputEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsInputEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CInputEnabledEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IInputEnabledEventArgs>>*, EventRegistrationToken*, int> add_InputEnabled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_InputEnabled;
    }
}
