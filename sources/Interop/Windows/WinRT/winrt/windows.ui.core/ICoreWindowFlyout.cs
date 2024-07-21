// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout"]/*' />
[Guid("E89D854D-2050-40BB-B344-F6F355EEB314")]
[NativeTypeName("struct ICoreWindowFlyout : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowFlyout : ICoreWindowFlyout.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowFlyout));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, uint>)(lpVtbl[1]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, uint>)(lpVtbl[2]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.add_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.remove_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Showing(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_MaxSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, Size*, int>)(lpVtbl[8]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_MinSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, Size*, int>)(lpVtbl[9]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, HSTRING*, int>)(lpVtbl[10]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, HSTRING, int>)(lpVtbl[11]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_IsInteractionDelayed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, int*, int>)(lpVtbl[12]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.put_IsInteractionDelayed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, int, int>)(lpVtbl[13]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_Commands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, IVector<Pointer<IUICommand>>**, int>)(lpVtbl[14]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, uint*, int>)(lpVtbl[15]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.put_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, uint, int>)(lpVtbl[16]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.get_BackButtonCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, IUICommandInvokedHandler**, int>)(lpVtbl[17]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.put_BackButtonCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, IUICommandInvokedHandler*, int>)(lpVtbl[18]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowFlyout.xml' path='doc/member[@name="ICoreWindowFlyout.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowFlyout*, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[19]))((ICoreWindowFlyout*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        HRESULT remove_Showing(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value);

        [VtblIndex(15)]
        HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value);

        [VtblIndex(18)]
        HRESULT put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value);

        [VtblIndex(19)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>*, EventRegistrationToken*, int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_MaxSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_MinSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_IsInteractionDelayed;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_IsInteractionDelayed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IUICommand>>**, int> get_Commands;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DefaultCommandIndex;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler**, int> get_BackButtonCommand;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler*, int> put_BackButtonCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsync;
    }
}
