// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs"]/*' />
[Guid("EEA7918D-CC2B-4F03-8FF6-02FD217DB450")]
[NativeTypeName("struct ICoreTextTextUpdatingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextTextUpdatingEventArgs : ICoreTextTextUpdatingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextTextUpdatingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, uint>)(lpVtbl[1]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, uint>)(lpVtbl[2]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_Range"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, CoreTextRange*, int>)(lpVtbl[6]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, HSTRING*, int>)(lpVtbl[7]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_NewSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NewSelection([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, CoreTextRange*, int>)(lpVtbl[8]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_InputLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InputLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, ILanguage**, int>)(lpVtbl[9]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *")] CoreTextTextUpdatingResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, CoreTextTextUpdatingResult*, int>)(lpVtbl[10]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.put_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult")] CoreTextTextUpdatingResult value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, CoreTextTextUpdatingResult, int>)(lpVtbl[11]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, byte*, int>)(lpVtbl[12]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextTextUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextTextUpdatingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextTextUpdatingEventArgs*, IDeferral**, int>)(lpVtbl[13]))((ICoreTextTextUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);

        [VtblIndex(7)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_NewSelection([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);

        [VtblIndex(9)]
        HRESULT get_InputLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** value);

        [VtblIndex(10)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *")] CoreTextTextUpdatingResult* value);

        [VtblIndex(11)]
        HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult")] CoreTextTextUpdatingResult value);

        [VtblIndex(12)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange*, int> get_NewSelection;

        [NativeTypeName("HRESULT (ABI::Windows::Globalization::ILanguage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanguage**, int> get_InputLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextTextUpdatingResult*, int> get_Result;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextTextUpdatingResult, int> put_Result;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
