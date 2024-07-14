// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreAcceleratorKeys.xml' path='doc/member[@name="ICoreAcceleratorKeys"]/*' />
[Guid("9FFDF7F5-B8C9-4EF0-B7D2-1DE626561FC8")]
[NativeTypeName("struct ICoreAcceleratorKeys : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreAcceleratorKeys : ICoreAcceleratorKeys.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreAcceleratorKeys));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, Guid*, void**, int>)(lpVtbl[0]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, uint>)(lpVtbl[1]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, uint>)(lpVtbl[2]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, HSTRING*, int>)(lpVtbl[4]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, TrustLevel*, int>)(lpVtbl[5]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreAcceleratorKeys.xml' path='doc/member[@name="ICoreAcceleratorKeys.add_AcceleratorKeyActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_AcceleratorKeyActivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreDispatcher_Windows__CUI__CCore__CAcceleratorKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreDispatcher>, Pointer<IAcceleratorKeyEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, ITypedEventHandler<Pointer<ICoreDispatcher>, Pointer<IAcceleratorKeyEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreAcceleratorKeys.xml' path='doc/member[@name="ICoreAcceleratorKeys.remove_AcceleratorKeyActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_AcceleratorKeyActivated(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreAcceleratorKeys*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_AcceleratorKeyActivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreDispatcher_Windows__CUI__CCore__CAcceleratorKeyEventArgs_t *")] ITypedEventHandler<Pointer<ICoreDispatcher>, Pointer<IAcceleratorKeyEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(7)]
        HRESULT remove_AcceleratorKeyActivated(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreDispatcher_Windows__CUI__CCore__CAcceleratorKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreDispatcher>, Pointer<IAcceleratorKeyEventArgs>>*, EventRegistrationToken*, int> add_AcceleratorKeyActivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AcceleratorKeyActivated;
    }
}
