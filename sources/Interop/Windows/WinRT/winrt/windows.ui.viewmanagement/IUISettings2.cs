// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUISettings2.xml' path='doc/member[@name="IUISettings2"]/*' />
[Guid("BAD82401-2721-44F9-BB91-2BB228BE442F")]
[NativeTypeName("struct IUISettings2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettings2 : IUISettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUISettings2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, Guid*, void**, int>)(lpVtbl[0]))((IUISettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, uint>)(lpVtbl[1]))((IUISettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, uint>)(lpVtbl[2]))((IUISettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, uint*, Guid**, int>)(lpVtbl[3]))((IUISettings2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, HSTRING*, int>)(lpVtbl[4]))((IUISettings2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, TrustLevel*, int>)(lpVtbl[5]))((IUISettings2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUISettings2.xml' path='doc/member[@name="IUISettings2.get_TextScaleFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextScaleFactor(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, double*, int>)(lpVtbl[6]))((IUISettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUISettings2.xml' path='doc/member[@name="IUISettings2.add_TextScaleFactorChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_TextScaleFactorChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUISettings2*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IUISettings2.xml' path='doc/member[@name="IUISettings2.remove_TextScaleFactorChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_TextScaleFactorChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings2*, EventRegistrationToken, int>)(lpVtbl[8]))((IUISettings2*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextScaleFactor(double* value);

        [VtblIndex(7)]
        HRESULT add_TextScaleFactorChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(8)]
        HRESULT remove_TextScaleFactorChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_TextScaleFactor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_TextScaleFactorChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TextScaleFactorChanged;
    }
}
