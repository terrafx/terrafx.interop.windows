// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController"]/*' />
[Guid("59B893A9-73BC-52B5-BA41-82511B2CB46C")]
[NativeTypeName("struct ISystemButtonEventController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemButtonEventController : ISystemButtonEventController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemButtonEventController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, Guid*, void**, int>)(lpVtbl[0]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, uint>)(lpVtbl[1]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, uint>)(lpVtbl[2]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, HSTRING*, int>)(lpVtbl[4]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, TrustLevel*, int>)(lpVtbl[5]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.add_SystemFunctionButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SystemFunctionButtonPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.remove_SystemFunctionButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SystemFunctionButtonPressed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[7]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.add_SystemFunctionButtonReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_SystemFunctionButtonReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.remove_SystemFunctionButtonReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_SystemFunctionButtonReleased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[9]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.add_SystemFunctionLockChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_SystemFunctionLockChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.remove_SystemFunctionLockChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_SystemFunctionLockChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[11]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.add_SystemFunctionLockIndicatorChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_SystemFunctionLockIndicatorChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockIndicatorChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemButtonEventController.xml' path='doc/member[@name="ISystemButtonEventController.remove_SystemFunctionLockIndicatorChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_SystemFunctionLockIndicatorChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemButtonEventController*, EventRegistrationToken, int>)(lpVtbl[13]))((ISystemButtonEventController*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SystemFunctionButtonPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SystemFunctionButtonPressed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_SystemFunctionButtonReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_SystemFunctionButtonReleased(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_SystemFunctionLockChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_SystemFunctionLockChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_SystemFunctionLockIndicatorChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockIndicatorChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_SystemFunctionLockIndicatorChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SystemFunctionButtonPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SystemFunctionButtonPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionButtonEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SystemFunctionButtonReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SystemFunctionButtonReleased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SystemFunctionLockChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SystemFunctionLockChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CSystemButtonEventController_Windows__CUI__CInput__CSystemFunctionLockIndicatorChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SystemFunctionLockIndicatorChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SystemFunctionLockIndicatorChanged;
    }
}
