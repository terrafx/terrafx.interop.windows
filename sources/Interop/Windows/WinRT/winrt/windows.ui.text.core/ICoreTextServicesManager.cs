// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextServicesManager.xml' path='doc/member[@name="ICoreTextServicesManager"]/*' />
[Guid("C2507D83-6E0A-4A8A-BDF8-1948874854BA")]
[NativeTypeName("struct ICoreTextServicesManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextServicesManager : ICoreTextServicesManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextServicesManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, uint>)(lpVtbl[1]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, uint>)(lpVtbl[2]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextServicesManager.xml' path='doc/member[@name="ICoreTextServicesManager.get_InputLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InputLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, ILanguage**, int>)(lpVtbl[6]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextServicesManager.xml' path='doc/member[@name="ICoreTextServicesManager.add_InputLanguageChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_InputLanguageChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextServicesManager_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreTextServicesManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, ITypedEventHandler<Pointer<ICoreTextServicesManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextServicesManager.xml' path='doc/member[@name="ICoreTextServicesManager.remove_InputLanguageChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_InputLanguageChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, EventRegistrationToken, int>)(lpVtbl[8]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextServicesManager.xml' path='doc/member[@name="ICoreTextServicesManager.CreateEditContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateEditContext([NativeTypeName("ABI::Windows::UI::Text::Core::ICoreTextEditContext **")] ICoreTextEditContext** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextServicesManager*, ICoreTextEditContext**, int>)(lpVtbl[9]))((ICoreTextServicesManager*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InputLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** value);

        [VtblIndex(7)]
        HRESULT add_InputLanguageChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextServicesManager_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreTextServicesManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(8)]
        HRESULT remove_InputLanguageChanged(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT CreateEditContext([NativeTypeName("ABI::Windows::UI::Text::Core::ICoreTextEditContext **")] ICoreTextEditContext** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Globalization::ILanguage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanguage**, int> get_InputLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextServicesManager_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextServicesManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_InputLanguageChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_InputLanguageChanged;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::ICoreTextEditContext **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreTextEditContext**, int> CreateEditContext;
    }
}
