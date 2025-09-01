// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDropShadow2.xml' path='doc/member[@name="IDropShadow2"]/*' />
[Guid("6C4218BC-15B9-4C2D-8D4A-0767DF11977A")]
[NativeTypeName("struct IDropShadow2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDropShadow2 : IDropShadow2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDropShadow2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, Guid*, void**, int>)(lpVtbl[0]))((IDropShadow2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, uint>)(lpVtbl[1]))((IDropShadow2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, uint>)(lpVtbl[2]))((IDropShadow2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, uint*, Guid**, int>)(lpVtbl[3]))((IDropShadow2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, HSTRING*, int>)(lpVtbl[4]))((IDropShadow2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, TrustLevel*, int>)(lpVtbl[5]))((IDropShadow2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDropShadow2.xml' path='doc/member[@name="IDropShadow2.get_SourcePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourcePolicy([NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *")] CompositionDropShadowSourcePolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, CompositionDropShadowSourcePolicy*, int>)(lpVtbl[6]))((IDropShadow2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDropShadow2.xml' path='doc/member[@name="IDropShadow2.put_SourcePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourcePolicy([NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy")] CompositionDropShadowSourcePolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDropShadow2*, CompositionDropShadowSourcePolicy, int>)(lpVtbl[7]))((IDropShadow2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourcePolicy([NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *")] CompositionDropShadowSourcePolicy* value);

        [VtblIndex(7)]
        HRESULT put_SourcePolicy([NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy")] CompositionDropShadowSourcePolicy value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionDropShadowSourcePolicy*, int> get_SourcePolicy;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionDropShadowSourcePolicy, int> put_SourcePolicy;
    }
}
