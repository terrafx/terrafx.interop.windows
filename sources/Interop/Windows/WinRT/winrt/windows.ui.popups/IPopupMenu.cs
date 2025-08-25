// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPopupMenu.xml' path='doc/member[@name="IPopupMenu"]/*' />
[Guid("4E9BC6DC-880D-47FC-A0A1-72B639E62559")]
[NativeTypeName("struct IPopupMenu : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPopupMenu : IPopupMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPopupMenu);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, Guid*, void**, int>)(lpVtbl[0]))((IPopupMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, uint>)(lpVtbl[1]))((IPopupMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, uint>)(lpVtbl[2]))((IPopupMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, uint*, Guid**, int>)(lpVtbl[3]))((IPopupMenu*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, HSTRING*, int>)(lpVtbl[4]))((IPopupMenu*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, TrustLevel*, int>)(lpVtbl[5]))((IPopupMenu*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPopupMenu.xml' path='doc/member[@name="IPopupMenu.get_Commands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, IVector<Pointer<IUICommand>>**, int>)(lpVtbl[6]))((IPopupMenu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPopupMenu.xml' path='doc/member[@name="IPopupMenu.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::Point")] Point invocationPoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, Point, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[7]))((IPopupMenu*)Unsafe.AsPointer(ref this), invocationPoint, asyncOperation);
    }

    /// <include file='IPopupMenu.xml' path='doc/member[@name="IPopupMenu.ShowAsyncWithRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowAsyncWithRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, Rect, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[8]))((IPopupMenu*)Unsafe.AsPointer(ref this), selection, asyncOperation);
    }

    /// <include file='IPopupMenu.xml' path='doc/member[@name="IPopupMenu.ShowAsyncWithRectAndPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowAsyncWithRectAndPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPopupMenu*, Rect, Placement, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[9]))((IPopupMenu*)Unsafe.AsPointer(ref this), selection, preferredPlacement, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value);

        [VtblIndex(7)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::Point")] Point invocationPoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation);

        [VtblIndex(8)]
        HRESULT ShowAsyncWithRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation);

        [VtblIndex(9)]
        HRESULT ShowAsyncWithRectAndPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncOperation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IUICommand>>**, int> get_Commands;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsyncWithRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, Placement, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsyncWithRectAndPlacement;
    }
}
