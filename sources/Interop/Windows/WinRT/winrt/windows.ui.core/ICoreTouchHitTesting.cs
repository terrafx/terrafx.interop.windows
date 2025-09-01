// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTouchHitTesting.xml' path='doc/member[@name="ICoreTouchHitTesting"]/*' />
[Guid("B1D8A289-3ACF-4124-9FA3-EA8ABA353C21")]
[NativeTypeName("struct ICoreTouchHitTesting : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTouchHitTesting : ICoreTouchHitTesting.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreTouchHitTesting);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, uint>)(lpVtbl[1]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, uint>)(lpVtbl[2]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, HSTRING*, int>)(lpVtbl[4]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTouchHitTesting.xml' path='doc/member[@name="ICoreTouchHitTesting.add_TouchHitTesting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ITouchHitTestingEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ITouchHitTestingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreTouchHitTesting.xml' path='doc/member[@name="ICoreTouchHitTesting.remove_TouchHitTesting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_TouchHitTesting(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTouchHitTesting*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreTouchHitTesting*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_TouchHitTesting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<ITouchHitTestingEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(7)]
        HRESULT remove_TouchHitTesting(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CTouchHitTestingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<ITouchHitTestingEventArgs>>*, EventRegistrationToken*, int> add_TouchHitTesting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TouchHitTesting;
    }
}
