// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextLayoutRequest.xml' path='doc/member[@name="ICoreTextLayoutRequest"]/*' />
[Guid("2555A8CC-51FD-4F03-98BF-AC78174D68E0")]
[NativeTypeName("struct ICoreTextLayoutRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextLayoutRequest : ICoreTextLayoutRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreTextLayoutRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, uint>)(lpVtbl[1]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, uint>)(lpVtbl[2]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextLayoutRequest.xml' path='doc/member[@name="ICoreTextLayoutRequest.get_Range"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, CoreTextRange*, int>)(lpVtbl[6]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutRequest.xml' path='doc/member[@name="ICoreTextLayoutRequest.get_LayoutBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LayoutBounds([NativeTypeName("ABI::Windows::UI::Text::Core::ICoreTextLayoutBounds **")] ICoreTextLayoutBounds** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, ICoreTextLayoutBounds**, int>)(lpVtbl[7]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutRequest.xml' path='doc/member[@name="ICoreTextLayoutRequest.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, byte*, int>)(lpVtbl[8]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextLayoutRequest.xml' path='doc/member[@name="ICoreTextLayoutRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextLayoutRequest*, IDeferral**, int>)(lpVtbl[9]))((ICoreTextLayoutRequest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);

        [VtblIndex(7)]
        HRESULT get_LayoutBounds([NativeTypeName("ABI::Windows::UI::Text::Core::ICoreTextLayoutBounds **")] ICoreTextLayoutBounds** value);

        [VtblIndex(8)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::ICoreTextLayoutBounds **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreTextLayoutBounds**, int> get_LayoutBounds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
