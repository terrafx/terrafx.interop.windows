// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel"]/*' />
[Guid("41BF1265-D2EE-4B97-A80A-7D8D64CCA6F5")]
[NativeTypeName("struct IContactPanel : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPanel : IContactPanel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPanel));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, Guid*, void**, int>)(lpVtbl[0]))((IContactPanel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, uint>)(lpVtbl[1]))((IContactPanel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, uint>)(lpVtbl[2]))((IContactPanel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, uint*, Guid**, int>)(lpVtbl[3]))((IContactPanel*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, HSTRING*, int>)(lpVtbl[4]))((IContactPanel*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, TrustLevel*, int>)(lpVtbl[5]))((IContactPanel*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.ClosePanel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ClosePanel()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, int>)(lpVtbl[6]))((IContactPanel*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.get_HeaderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, IReference<Color>**, int>)(lpVtbl[7]))((IContactPanel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.put_HeaderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, IReference<Color>*, int>)(lpVtbl[8]))((IContactPanel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.add_LaunchFullAppRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_LaunchFullAppRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelLaunchFullAppRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelLaunchFullAppRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelLaunchFullAppRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IContactPanel*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.remove_LaunchFullAppRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_LaunchFullAppRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, EventRegistrationToken, int>)(lpVtbl[10]))((IContactPanel*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.add_Closing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Closing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelClosingEventArgs_t *")] ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelClosingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelClosingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IContactPanel*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IContactPanel.xml' path='doc/member[@name="IContactPanel.remove_Closing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Closing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPanel*, EventRegistrationToken, int>)(lpVtbl[12]))((IContactPanel*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ClosePanel();

        [VtblIndex(7)]
        HRESULT get_HeaderColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(8)]
        HRESULT put_HeaderColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(9)]
        HRESULT add_LaunchFullAppRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelLaunchFullAppRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelLaunchFullAppRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_LaunchFullAppRequested(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Closing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelClosingEventArgs_t *")] ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelClosingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Closing(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClosePanel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_HeaderColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelLaunchFullAppRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelLaunchFullAppRequestedEventArgs>>*, EventRegistrationToken*, int> add_LaunchFullAppRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LaunchFullAppRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactPanel_Windows__CApplicationModel__CContacts__CContactPanelClosingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IContactPanel>, Pointer<IContactPanelClosingEventArgs>>*, EventRegistrationToken*, int> add_Closing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closing;
    }
}
