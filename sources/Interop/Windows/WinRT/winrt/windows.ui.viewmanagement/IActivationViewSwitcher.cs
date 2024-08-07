// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivationViewSwitcher.xml' path='doc/member[@name="IActivationViewSwitcher"]/*' />
[Guid("DCA71BB6-7350-492B-AAC7-C8A13D7224AD")]
[NativeTypeName("struct IActivationViewSwitcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivationViewSwitcher : IActivationViewSwitcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivationViewSwitcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, Guid*, void**, int>)(lpVtbl[0]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, uint>)(lpVtbl[1]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, uint>)(lpVtbl[2]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, uint*, Guid**, int>)(lpVtbl[3]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, HSTRING*, int>)(lpVtbl[4]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, TrustLevel*, int>)(lpVtbl[5]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivationViewSwitcher.xml' path='doc/member[@name="IActivationViewSwitcher.ShowAsStandaloneAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAsStandaloneAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, int, IAsyncAction**, int>)(lpVtbl[6]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), viewId, operation);
    }

    /// <include file='IActivationViewSwitcher.xml' path='doc/member[@name="IActivationViewSwitcher.ShowAsStandaloneWithSizePreferenceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAsStandaloneWithSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, int, ViewSizePreference, IAsyncAction**, int>)(lpVtbl[7]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), viewId, sizePreference, operation);
    }

    /// <include file='IActivationViewSwitcher.xml' path='doc/member[@name="IActivationViewSwitcher.IsViewPresentedOnActivationVirtualDesktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsViewPresentedOnActivationVirtualDesktop([NativeTypeName("INT32")] int viewId, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivationViewSwitcher*, int, byte*, int>)(lpVtbl[8]))((IActivationViewSwitcher*)Unsafe.AsPointer(ref this), viewId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAsStandaloneAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT ShowAsStandaloneWithSizePreferenceAsync([NativeTypeName("INT32")] int viewId, [NativeTypeName("ABI::Windows::UI::ViewManagement::ViewSizePreference")] ViewSizePreference sizePreference, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT IsViewPresentedOnActivationVirtualDesktop([NativeTypeName("INT32")] int viewId, [NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IAsyncAction**, int> ShowAsStandaloneAsync;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::UI::ViewManagement::ViewSizePreference, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, ViewSizePreference, IAsyncAction**, int> ShowAsStandaloneWithSizePreferenceAsync;

        [NativeTypeName("HRESULT (INT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, byte*, int> IsViewPresentedOnActivationVirtualDesktop;
    }
}
