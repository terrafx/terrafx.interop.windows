// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreFrameworkInputViewStatics.xml' path='doc/member[@name="ICoreFrameworkInputViewStatics"]/*' />
[Guid("6EEBD9B6-EAC2-5F8B-975F-772EE3E42EEB")]
[NativeTypeName("struct ICoreFrameworkInputViewStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreFrameworkInputViewStatics : ICoreFrameworkInputViewStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreFrameworkInputViewStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, uint>)(lpVtbl[1]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, uint>)(lpVtbl[2]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, HSTRING*, int>)(lpVtbl[4]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreFrameworkInputViewStatics.xml' path='doc/member[@name="ICoreFrameworkInputViewStatics.GetForUIContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForUIContext([NativeTypeName("ABI::Windows::UI::IUIContext *")] IUIContext* context, [NativeTypeName("ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **")] ICoreFrameworkInputView** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, IUIContext*, ICoreFrameworkInputView**, int>)(lpVtbl[6]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), context, result);
    }

    /// <include file='ICoreFrameworkInputViewStatics.xml' path='doc/member[@name="ICoreFrameworkInputViewStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **")] ICoreFrameworkInputView** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewStatics*, ICoreFrameworkInputView**, int>)(lpVtbl[7]))((ICoreFrameworkInputViewStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForUIContext([NativeTypeName("ABI::Windows::UI::IUIContext *")] IUIContext* context, [NativeTypeName("ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **")] ICoreFrameworkInputView** result);

        [VtblIndex(7)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **")] ICoreFrameworkInputView** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::IUIContext *, ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUIContext*, ICoreFrameworkInputView**, int> GetForUIContext;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::Core::ICoreFrameworkInputView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreFrameworkInputView**, int> GetForCurrentView;
    }
}
