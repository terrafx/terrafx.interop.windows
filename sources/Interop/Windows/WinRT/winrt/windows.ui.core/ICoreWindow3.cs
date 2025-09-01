// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindow3.xml' path='doc/member[@name="ICoreWindow3"]/*' />
[Guid("32C20DD8-FAEF-4375-A2AB-32640E4815C7")]
[NativeTypeName("struct ICoreWindow3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindow3 : ICoreWindow3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreWindow3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, uint>)(lpVtbl[1]))((ICoreWindow3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, uint>)(lpVtbl[2]))((ICoreWindow3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindow3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindow3.xml' path='doc/member[@name="ICoreWindow3.add_ClosestInteractiveBoundsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ClosestInteractiveBoundsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindow3*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreWindow3.xml' path='doc/member[@name="ICoreWindow3.remove_ClosestInteractiveBoundsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ClosestInteractiveBoundsRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindow3*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindow3.xml' path='doc/member[@name="ICoreWindow3.GetCurrentKeyEventDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentKeyEventDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindow3*, HSTRING*, int>)(lpVtbl[8]))((ICoreWindow3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ClosestInteractiveBoundsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(7)]
        HRESULT remove_ClosestInteractiveBoundsRequested(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT GetCurrentKeyEventDeviceId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>*, EventRegistrationToken*, int> add_ClosestInteractiveBoundsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ClosestInteractiveBoundsRequested;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetCurrentKeyEventDeviceId;
    }
}
