// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext"]/*' />
[Guid("BF6608AF-4041-47C3-B263-A918EB5EAEF2")]
[NativeTypeName("struct ICoreTextEditContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextEditContext : ICoreTextEditContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreTextEditContext);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, uint>)(lpVtbl[1]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, uint>)(lpVtbl[2]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, HSTRING*, int>)(lpVtbl[6]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, HSTRING, int>)(lpVtbl[7]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.get_InputScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")] CoreTextInputScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextInputScope*, int>)(lpVtbl[8]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.put_InputScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")] CoreTextInputScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextInputScope, int>)(lpVtbl[9]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.get_IsReadOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, byte*, int>)(lpVtbl[10]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.put_IsReadOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsReadOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, byte, int>)(lpVtbl[11]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.get_InputPaneDisplayPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InputPaneDisplayPolicy([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *")] CoreTextInputPaneDisplayPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextInputPaneDisplayPolicy*, int>)(lpVtbl[12]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.put_InputPaneDisplayPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_InputPaneDisplayPolicy([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy")] CoreTextInputPaneDisplayPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextInputPaneDisplayPolicy, int>)(lpVtbl[13]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_TextRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_TextRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextRequestedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_TextRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_TextRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[15]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_SelectionRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_SelectionRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionRequestedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_SelectionRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_SelectionRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[17]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_LayoutRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_LayoutRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextLayoutRequestedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextLayoutRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_LayoutRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_LayoutRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[19]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_TextUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_TextUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextUpdatingEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextUpdatingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_TextUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_TextUpdating(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[21]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_SelectionUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_SelectionUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionUpdatingEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionUpdatingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[22]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_SelectionUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_SelectionUpdating(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[23]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_FormatUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_FormatUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextFormatUpdatingEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextFormatUpdatingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[24]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_FormatUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_FormatUpdating(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[25]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_CompositionStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_CompositionStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionStartedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[26]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_CompositionStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_CompositionStarted(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[27]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_CompositionCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT add_CompositionCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionCompletedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[28]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_CompositionCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT remove_CompositionCompleted(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[29]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.add_FocusRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT add_FocusRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[30]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.remove_FocusRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT remove_FocusRemoved(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, EventRegistrationToken, int>)(lpVtbl[31]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.NotifyFocusEnter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT NotifyFocusEnter()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, int>)(lpVtbl[32]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.NotifyFocusLeave"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT NotifyFocusLeave()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, int>)(lpVtbl[33]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.NotifyTextChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT NotifyTextChanged([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange modifiedRange, [NativeTypeName("INT32")] int newLength, [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange newSelection)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextRange, int, CoreTextRange, int>)(lpVtbl[34]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), modifiedRange, newLength, newSelection);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.NotifySelectionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT NotifySelectionChanged([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange selection)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, CoreTextRange, int>)(lpVtbl[35]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this), selection);
    }

    /// <include file='ICoreTextEditContext.xml' path='doc/member[@name="ICoreTextEditContext.NotifyLayoutChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT NotifyLayoutChanged()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextEditContext*, int>)(lpVtbl[36]))((ICoreTextEditContext*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")] CoreTextInputScope* value);

        [VtblIndex(9)]
        HRESULT put_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")] CoreTextInputScope value);

        [VtblIndex(10)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsReadOnly([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_InputPaneDisplayPolicy([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *")] CoreTextInputPaneDisplayPolicy* value);

        [VtblIndex(13)]
        HRESULT put_InputPaneDisplayPolicy([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy")] CoreTextInputPaneDisplayPolicy value);

        [VtblIndex(14)]
        HRESULT add_TextRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextRequestedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(15)]
        HRESULT remove_TextRequested(EventRegistrationToken cookie);

        [VtblIndex(16)]
        HRESULT add_SelectionRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionRequestedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(17)]
        HRESULT remove_SelectionRequested(EventRegistrationToken cookie);

        [VtblIndex(18)]
        HRESULT add_LayoutRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextLayoutRequestedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(19)]
        HRESULT remove_LayoutRequested(EventRegistrationToken cookie);

        [VtblIndex(20)]
        HRESULT add_TextUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextUpdatingEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(21)]
        HRESULT remove_TextUpdating(EventRegistrationToken cookie);

        [VtblIndex(22)]
        HRESULT add_SelectionUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionUpdatingEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(23)]
        HRESULT remove_SelectionUpdating(EventRegistrationToken cookie);

        [VtblIndex(24)]
        HRESULT add_FormatUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextFormatUpdatingEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(25)]
        HRESULT remove_FormatUpdating(EventRegistrationToken cookie);

        [VtblIndex(26)]
        HRESULT add_CompositionStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionStartedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(27)]
        HRESULT remove_CompositionStarted(EventRegistrationToken cookie);

        [VtblIndex(28)]
        HRESULT add_CompositionCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionCompletedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(29)]
        HRESULT remove_CompositionCompleted(EventRegistrationToken cookie);

        [VtblIndex(30)]
        HRESULT add_FocusRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(31)]
        HRESULT remove_FocusRemoved(EventRegistrationToken cookie);

        [VtblIndex(32)]
        HRESULT NotifyFocusEnter();

        [VtblIndex(33)]
        HRESULT NotifyFocusLeave();

        [VtblIndex(34)]
        HRESULT NotifyTextChanged([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange modifiedRange, [NativeTypeName("INT32")] int newLength, [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange newSelection);

        [VtblIndex(35)]
        HRESULT NotifySelectionChanged([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange selection);

        [VtblIndex(36)]
        HRESULT NotifyLayoutChanged();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputScope*, int> get_InputScope;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputScope, int> put_InputScope;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsReadOnly;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputPaneDisplayPolicy*, int> get_InputPaneDisplayPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputPaneDisplayPolicy, int> put_InputPaneDisplayPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextRequestedEventArgs>>*, EventRegistrationToken*, int> add_TextRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TextRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionRequestedEventArgs>>*, EventRegistrationToken*, int> add_SelectionRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SelectionRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextLayoutRequestedEventArgs>>*, EventRegistrationToken*, int> add_LayoutRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LayoutRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextTextUpdatingEventArgs>>*, EventRegistrationToken*, int> add_TextUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TextUpdating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextSelectionUpdatingEventArgs>>*, EventRegistrationToken*, int> add_SelectionUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SelectionUpdating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextFormatUpdatingEventArgs>>*, EventRegistrationToken*, int> add_FormatUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FormatUpdating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionStartedEventArgs>>*, EventRegistrationToken*, int> add_CompositionStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CompositionStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<ICoreTextCompositionCompletedEventArgs>>*, EventRegistrationToken*, int> add_CompositionCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CompositionCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreTextEditContext>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_FocusRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FocusRemoved;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyFocusEnter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyFocusLeave;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange, INT32, ABI::Windows::UI::Text::Core::CoreTextRange) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange, int, CoreTextRange, int> NotifyTextChanged;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange, int> NotifySelectionChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyLayoutChanged;
    }
}
