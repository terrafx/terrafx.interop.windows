// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView"]/*' />
[Guid("C770CD7A-7001-4C32-BF94-25C1F554CBF1")]
[NativeTypeName("struct ICoreInputView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputView : ICoreInputView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, uint>)(lpVtbl[1]))((ICoreInputView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, uint>)(lpVtbl[2]))((ICoreInputView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView.add_OcclusionsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_OcclusionsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusionsChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewOcclusionsChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewOcclusionsChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreInputView*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView.remove_OcclusionsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_OcclusionsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreInputView*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView.GetCoreInputViewOcclusions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCoreInputViewOcclusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<Pointer<ICoreInputViewOcclusion>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, IVectorView<Pointer<ICoreInputViewOcclusion>>**, int>)(lpVtbl[8]))((ICoreInputView*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView.TryShowPrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryShowPrimaryView([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, byte*, int>)(lpVtbl[9]))((ICoreInputView*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICoreInputView.xml' path='doc/member[@name="ICoreInputView.TryHidePrimaryView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryHidePrimaryView([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputView*, byte*, int>)(lpVtbl[10]))((ICoreInputView*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_OcclusionsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusionsChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewOcclusionsChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_OcclusionsChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetCoreInputViewOcclusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<Pointer<ICoreInputViewOcclusion>>** result);

        [VtblIndex(9)]
        HRESULT TryShowPrimaryView([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(10)]
        HRESULT TryHidePrimaryView([NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CCore__CCoreInputView_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusionsChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreInputView>, Pointer<ICoreInputViewOcclusionsChangedEventArgs>>*, EventRegistrationToken*, int> add_OcclusionsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OcclusionsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICoreInputViewOcclusion>>**, int> GetCoreInputViewOcclusions;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryShowPrimaryView;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryHidePrimaryView;
    }
}
