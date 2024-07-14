// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView"]/*' />
[Guid("638BB2DB-451D-4661-B099-414F34FFB9F1")]
[NativeTypeName("struct ICoreApplicationView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplicationView : ICoreApplicationView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplicationView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, uint>)(lpVtbl[1]))((ICoreApplicationView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, uint>)(lpVtbl[2]))((ICoreApplicationView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView.get_CoreWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CoreWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow **")] ICoreWindow** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, ICoreWindow**, int>)(lpVtbl[6]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView.add_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CActivation__CIActivatedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IActivatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IActivatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView.remove_Activated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_Activated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView.get_IsMain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsMain([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, byte*, int>)(lpVtbl[9]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationView.xml' path='doc/member[@name="ICoreApplicationView.get_IsHosted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsHosted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView*, byte*, int>)(lpVtbl[10]))((ICoreApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CoreWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow **")] ICoreWindow** value);

        [VtblIndex(7)]
        HRESULT add_Activated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CActivation__CIActivatedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IActivatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_Activated(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT get_IsMain([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsHosted([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreWindow **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreWindow**, int> get_CoreWindow;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CActivation__CIActivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IActivatedEventArgs>>*, EventRegistrationToken*, int> add_Activated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Activated;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMain;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHosted;
    }
}
