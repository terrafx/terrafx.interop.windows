// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4"]/*' />
[Guid("15E5CBEC-9E0F-46B5-BC3F-9BF653E74B5E")]
[NativeTypeName("struct IApplicationView4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView4 : IApplicationView4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationView4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationView4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, uint>)(lpVtbl[1]))((IApplicationView4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, uint>)(lpVtbl[2]))((IApplicationView4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationView4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, HSTRING*, int>)(lpVtbl[4]))((IApplicationView4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationView4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4.get_ViewMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ViewMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode *")] ApplicationViewMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, ApplicationViewMode*, int>)(lpVtbl[6]))((IApplicationView4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4.IsViewModeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsViewModeSupported([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("boolean *")] byte* isViewModeSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, ApplicationViewMode, byte*, int>)(lpVtbl[7]))((IApplicationView4*)Unsafe.AsPointer(ref this), viewMode, isViewModeSupported);
    }

    /// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4.TryEnterViewModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryEnterViewModeAsync([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, ApplicationViewMode, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IApplicationView4*)Unsafe.AsPointer(ref this), viewMode, operation);
    }

    /// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4.TryEnterViewModeWithPreferencesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryEnterViewModeWithPreferencesAsync([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences *")] IViewModePreferences* viewModePreferences, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, ApplicationViewMode, IViewModePreferences*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IApplicationView4*)Unsafe.AsPointer(ref this), viewMode, viewModePreferences, operation);
    }

    /// <include file='IApplicationView4.xml' path='doc/member[@name="IApplicationView4.TryConsolidateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryConsolidateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView4*, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IApplicationView4*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ViewMode([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode *")] ApplicationViewMode* value);

        [VtblIndex(7)]
        HRESULT IsViewModeSupported([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("boolean *")] byte* isViewModeSupported);

        [VtblIndex(8)]
        HRESULT TryEnterViewModeAsync([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT TryEnterViewModeWithPreferencesAsync([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")] ApplicationViewMode viewMode, [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences *")] IViewModePreferences* viewModePreferences, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(10)]
        HRESULT TryConsolidateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewMode*, int> get_ViewMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewMode, byte*, int> IsViewModeSupported;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewMode, IAsyncOperation<bool>**, int> TryEnterViewModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::UI::ViewManagement::IViewModePreferences *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewMode, IViewModePreferences*, IAsyncOperation<bool>**, int> TryEnterViewModeWithPreferencesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> TryConsolidateAsync;
    }
}
