// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog"]/*' />
[Guid("33F59B01-5325-43AB-9AB3-BDAE440E4121")]
[NativeTypeName("struct IMessageDialog : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageDialog : IMessageDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageDialog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, Guid*, void**, int>)(lpVtbl[0]))((IMessageDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint>)(lpVtbl[1]))((IMessageDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint>)(lpVtbl[2]))((IMessageDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageDialog*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, HSTRING*, int>)(lpVtbl[4]))((IMessageDialog*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, TrustLevel*, int>)(lpVtbl[5]))((IMessageDialog*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, HSTRING*, int>)(lpVtbl[6]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, HSTRING, int>)(lpVtbl[7]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_Commands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, IVector<Pointer<IUICommand>>**, int>)(lpVtbl[8]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint*, int>)(lpVtbl[9]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.put_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint, int>)(lpVtbl[10]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_CancelCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint*, int>)(lpVtbl[11]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.put_CancelCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, uint, int>)(lpVtbl[12]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Content(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, HSTRING*, int>)(lpVtbl[13]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.put_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Content(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, HSTRING, int>)(lpVtbl[14]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** messageDialogAsyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[15]))((IMessageDialog*)Unsafe.AsPointer(ref this), messageDialogAsyncOperation);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.get_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions *")] MessageDialogOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, MessageDialogOptions*, int>)(lpVtbl[16]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageDialog.xml' path='doc/member[@name="IMessageDialog.put_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions")] MessageDialogOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialog*, MessageDialogOptions, int>)(lpVtbl[17]))((IMessageDialog*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value);

        [VtblIndex(9)]
        HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_Content(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Content(HSTRING value);

        [VtblIndex(15)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** messageDialogAsyncOperation);

        [VtblIndex(16)]
        HRESULT get_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions *")] MessageDialogOptions* value);

        [VtblIndex(17)]
        HRESULT put_Options([NativeTypeName("ABI::Windows::UI::Popups::MessageDialogOptions")] MessageDialogOptions value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IUICommand>>**, int> get_Commands;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CancelCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_CancelCommandIndex;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Content;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::MessageDialogOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MessageDialogOptions*, int> get_Options;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::MessageDialogOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MessageDialogOptions, int> put_Options;
    }
}
