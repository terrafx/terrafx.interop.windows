// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs"]/*' />
[Guid("7310BD33-B4A8-43B1-B37B-0724D4ACA7AB")]
[NativeTypeName("struct ICoreTextFormatUpdatingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextFormatUpdatingEventArgs : ICoreTextFormatUpdatingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextFormatUpdatingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, uint>)(lpVtbl[1]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, uint>)(lpVtbl[2]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_Range"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, CoreTextRange*, int>)(lpVtbl[6]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_TextColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TextColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, IReference<UIElementType>**, int>)(lpVtbl[7]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, IReference<UIElementType>**, int>)(lpVtbl[8]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_UnderlineColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UnderlineColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, IReference<UIElementType>**, int>)(lpVtbl[9]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_UnderlineType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UnderlineType([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **")] IReference<UnderlineType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, IReference<UnderlineType>**, int>)(lpVtbl[10]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_Reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Reason([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *")] CoreTextFormatUpdatingReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, CoreTextFormatUpdatingReason*, int>)(lpVtbl[11]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *")] CoreTextFormatUpdatingResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, CoreTextFormatUpdatingResult*, int>)(lpVtbl[12]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.put_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult")] CoreTextFormatUpdatingResult value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, CoreTextFormatUpdatingResult, int>)(lpVtbl[13]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, byte*, int>)(lpVtbl[14]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextFormatUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextFormatUpdatingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextFormatUpdatingEventArgs*, IDeferral**, int>)(lpVtbl[15]))((ICoreTextFormatUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);

        [VtblIndex(7)]
        HRESULT get_TextColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value);

        [VtblIndex(8)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value);

        [VtblIndex(9)]
        HRESULT get_UnderlineColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **")] IReference<UIElementType>** value);

        [VtblIndex(10)]
        HRESULT get_UnderlineType([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **")] IReference<UnderlineType>** value);

        [VtblIndex(11)]
        HRESULT get_Reason([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *")] CoreTextFormatUpdatingReason* value);

        [VtblIndex(12)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *")] CoreTextFormatUpdatingResult* value);

        [VtblIndex(13)]
        HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult")] CoreTextFormatUpdatingResult value);

        [VtblIndex(14)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange*, int> get_Range;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<UIElementType>**, int> get_TextColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<UIElementType>**, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<UIElementType>**, int> get_UnderlineColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<UnderlineType>**, int> get_UnderlineType;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextFormatUpdatingReason*, int> get_Reason;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextFormatUpdatingResult*, int> get_Result;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextFormatUpdatingResult, int> put_Result;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
