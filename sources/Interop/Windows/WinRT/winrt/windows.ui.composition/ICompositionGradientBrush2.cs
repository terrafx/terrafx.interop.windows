// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGradientBrush2.xml' path='doc/member[@name="ICompositionGradientBrush2"]/*' />
[Guid("899DD5A1-B4C7-4B33-A1B6-264ADDC26D10")]
[NativeTypeName("struct ICompositionGradientBrush2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGradientBrush2 : ICompositionGradientBrush2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionGradientBrush2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, uint>)(lpVtbl[1]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, uint>)(lpVtbl[2]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGradientBrush2.xml' path='doc/member[@name="ICompositionGradientBrush2.get_MappingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MappingMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionMappingMode *")] CompositionMappingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, CompositionMappingMode*, int>)(lpVtbl[6]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGradientBrush2.xml' path='doc/member[@name="ICompositionGradientBrush2.put_MappingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MappingMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionMappingMode")] CompositionMappingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGradientBrush2*, CompositionMappingMode, int>)(lpVtbl[7]))((ICompositionGradientBrush2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MappingMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionMappingMode *")] CompositionMappingMode* value);

        [VtblIndex(7)]
        HRESULT put_MappingMode([NativeTypeName("ABI::Windows::UI::Composition::CompositionMappingMode")] CompositionMappingMode value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionMappingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionMappingMode*, int> get_MappingMode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionMappingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionMappingMode, int> put_MappingMode;
    }
}
