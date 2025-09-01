// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs"]/*' />
[Guid("D445839F-FE7F-4BD5-8A26-0922C1B3E639")]
[NativeTypeName("struct ICoreTextSelectionUpdatingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextSelectionUpdatingEventArgs : ICoreTextSelectionUpdatingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreTextSelectionUpdatingEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, uint>)(lpVtbl[1]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, uint>)(lpVtbl[2]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs.get_Selection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Selection([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, CoreTextRange*, int>)(lpVtbl[6]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult *")] CoreTextSelectionUpdatingResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, CoreTextSelectionUpdatingResult*, int>)(lpVtbl[7]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs.put_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult")] CoreTextSelectionUpdatingResult value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, CoreTextSelectionUpdatingResult, int>)(lpVtbl[8]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, byte*, int>)(lpVtbl[9]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextSelectionUpdatingEventArgs.xml' path='doc/member[@name="ICoreTextSelectionUpdatingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextSelectionUpdatingEventArgs*, IDeferral**, int>)(lpVtbl[10]))((ICoreTextSelectionUpdatingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Selection([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);

        [VtblIndex(7)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult *")] CoreTextSelectionUpdatingResult* value);

        [VtblIndex(8)]
        HRESULT put_Result([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult")] CoreTextSelectionUpdatingResult value);

        [VtblIndex(9)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
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
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange*, int> get_Selection;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextSelectionUpdatingResult*, int> get_Result;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextSelectionUpdatingResult) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextSelectionUpdatingResult, int> put_Result;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
