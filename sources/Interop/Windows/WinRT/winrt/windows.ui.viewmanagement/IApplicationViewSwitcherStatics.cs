// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics"]/*' />
[Guid("975F2F1E-E656-4C5E-A0A1-717C6FFA7D64")]
[NativeTypeName("struct IApplicationViewSwitcherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationViewSwitcherStatics : IApplicationViewSwitcherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationViewSwitcherStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, uint>)(lpVtbl[1]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, uint>)(lpVtbl[2]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, HSTRING*, int>)(lpVtbl[4]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.DisableShowingMainViewOnActivation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DisableShowingMainViewOnActivation()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int>)(lpVtbl[6]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.TryShowAsStandaloneAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryShowAsStandaloneAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), viewId, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.TryShowAsStandaloneWithSizePreferenceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryShowAsStandaloneWithSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, ViewSizePreference, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), viewId, sizePreference, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference anchorSizePreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, ViewSizePreference, int, ViewSizePreference, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), viewId, sizePreference, anchorViewId, anchorSizePreference, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.SwitchAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SwitchAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, IAsyncAction**, int>)(lpVtbl[10]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), viewId, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.SwitchFromViewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SwitchFromViewAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, int, IAsyncAction**, int>)(lpVtbl[11]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), toViewId, fromViewId, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.SwitchFromViewWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SwitchFromViewWithOptionsAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions")] ApplicationViewSwitchingOptions options, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, int, ApplicationViewSwitchingOptions, IAsyncAction**, int>)(lpVtbl[12]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), toViewId, fromViewId, options, operation);
    }

    /// <include file='IApplicationViewSwitcherStatics.xml' path='doc/member[@name="IApplicationViewSwitcherStatics.PrepareForCustomAnimatedSwitchAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PrepareForCustomAnimatedSwitchAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions")] ApplicationViewSwitchingOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationViewSwitcherStatics*, int, int, ApplicationViewSwitchingOptions, IAsyncOperation<bool>**, int>)(lpVtbl[13]))((IApplicationViewSwitcherStatics*)Unsafe.AsPointer(ref this), toViewId, fromViewId, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DisableShowingMainViewOnActivation();

        [VtblIndex(7)]
        HRESULT TryShowAsStandaloneAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT TryShowAsStandaloneWithSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference anchorSizePreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(10)]
        HRESULT SwitchAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(11)]
        HRESULT SwitchFromViewAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(12)]
        HRESULT SwitchFromViewWithOptionsAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions")] ApplicationViewSwitchingOptions options, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(13)]
        HRESULT PrepareForCustomAnimatedSwitchAsync([NativeTypeName("INT32")] int toViewId, [NativeTypeName("INT32")] int fromViewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions")] ApplicationViewSwitchingOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DisableShowingMainViewOnActivation;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IAsyncOperation<bool>**, int> TryShowAsStandaloneAsync;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::UI::ViewManagement::ViewSizePreference, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, ViewSizePreference, IAsyncOperation<bool>**, int> TryShowAsStandaloneWithSizePreferenceAsync;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::UI::ViewManagement::ViewSizePreference, INT32, ABI::Windows::UI::ViewManagement::ViewSizePreference, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, ViewSizePreference, int, ViewSizePreference, IAsyncOperation<bool>**, int> TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IAsyncAction**, int> SwitchAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IAsyncAction**, int> SwitchFromViewAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, ApplicationViewSwitchingOptions, IAsyncAction**, int> SwitchFromViewWithOptionsAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::UI::ViewManagement::ApplicationViewSwitchingOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, ApplicationViewSwitchingOptions, IAsyncOperation<bool>**, int> PrepareForCustomAnimatedSwitchAsync;
    }
}
