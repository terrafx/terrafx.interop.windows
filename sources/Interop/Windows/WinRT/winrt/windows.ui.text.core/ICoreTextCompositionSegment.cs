// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreTextCompositionSegment.xml' path='doc/member[@name="ICoreTextCompositionSegment"]/*' />
[Guid("776C6BD9-4EAD-4DA7-8F47-3A88B523CC34")]
[NativeTypeName("struct ICoreTextCompositionSegment : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextCompositionSegment : ICoreTextCompositionSegment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICoreTextCompositionSegment);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, Guid*, void**, int>)(lpVtbl[0]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, uint>)(lpVtbl[1]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, uint>)(lpVtbl[2]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, HSTRING*, int>)(lpVtbl[4]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, TrustLevel*, int>)(lpVtbl[5]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreTextCompositionSegment.xml' path='doc/member[@name="ICoreTextCompositionSegment.get_PreconversionString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PreconversionString(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, HSTRING*, int>)(lpVtbl[6]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreTextCompositionSegment.xml' path='doc/member[@name="ICoreTextCompositionSegment.get_Range"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreTextCompositionSegment*, CoreTextRange*, int>)(lpVtbl[7]))((ICoreTextCompositionSegment*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PreconversionString(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Range([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PreconversionString;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextRange*, int> get_Range;
    }
}
