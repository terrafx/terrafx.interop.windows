// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs"]/*' />
[Guid("04DE169F-BA02-4850-8B55-D82D03BA6D7F")]
[NativeTypeName("struct ICoreInputViewTransferringXYFocusEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputViewTransferringXYFocusEventArgs : ICoreInputViewTransferringXYFocusEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputViewTransferringXYFocusEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, uint>)(lpVtbl[1]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, uint>)(lpVtbl[2]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.get_Origin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Origin([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, Rect*, int>)(lpVtbl[6]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.get_Direction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Direction([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *")] CoreInputViewXYFocusTransferDirection* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, CoreInputViewXYFocusTransferDirection*, int>)(lpVtbl[7]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.put_TransferHandled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TransferHandled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, byte, int>)(lpVtbl[8]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.get_TransferHandled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TransferHandled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, byte*, int>)(lpVtbl[9]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.put_KeepPrimaryViewVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_KeepPrimaryViewVisible([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, byte, int>)(lpVtbl[10]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewTransferringXYFocusEventArgs.xml' path='doc/member[@name="ICoreInputViewTransferringXYFocusEventArgs.get_KeepPrimaryViewVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_KeepPrimaryViewVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewTransferringXYFocusEventArgs*, byte*, int>)(lpVtbl[11]))((ICoreInputViewTransferringXYFocusEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Origin([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT get_Direction([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *")] CoreInputViewXYFocusTransferDirection* value);

        [VtblIndex(8)]
        HRESULT put_TransferHandled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_TransferHandled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_KeepPrimaryViewVisible([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_KeepPrimaryViewVisible([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_Origin;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreInputViewXYFocusTransferDirection*, int> get_Direction;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_TransferHandled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TransferHandled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeepPrimaryViewVisible;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeepPrimaryViewVisible;
    }
}
