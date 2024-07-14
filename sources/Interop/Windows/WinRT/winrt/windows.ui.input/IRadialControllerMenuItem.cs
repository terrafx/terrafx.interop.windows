// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem"]/*' />
[Guid("C80FC98D-AD0B-4C9C-8F2F-136A2373A6BA")]
[NativeTypeName("struct IRadialControllerMenuItem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenuItem : IRadialControllerMenuItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerMenuItem));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, uint>)(lpVtbl[1]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, uint>)(lpVtbl[2]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem.get_DisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, HSTRING*, int>)(lpVtbl[6]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Tag(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, IInspectable**, int>)(lpVtbl[7]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem.put_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Tag(IInspectable* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, IInspectable*, int>)(lpVtbl[8]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem.add_Invoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Invoked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialControllerMenuItem_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialControllerMenuItem>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, ITypedEventHandler<Pointer<IRadialControllerMenuItem>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRadialControllerMenuItem.xml' path='doc/member[@name="IRadialControllerMenuItem.remove_Invoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Invoked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItem*, EventRegistrationToken, int>)(lpVtbl[10]))((IRadialControllerMenuItem*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Tag(IInspectable** value);

        [VtblIndex(8)]
        HRESULT put_Tag(IInspectable* value);

        [VtblIndex(9)]
        HRESULT add_Invoked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialControllerMenuItem_IInspectable_t *")] ITypedEventHandler<Pointer<IRadialControllerMenuItem>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Invoked(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayText;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Tag;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> put_Tag;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CRadialControllerMenuItem_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadialControllerMenuItem>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Invoked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Invoked;
    }
}
