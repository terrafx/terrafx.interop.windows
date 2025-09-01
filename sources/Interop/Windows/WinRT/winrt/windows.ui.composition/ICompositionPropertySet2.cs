// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionPropertySet2.xml' path='doc/member[@name="ICompositionPropertySet2"]/*' />
[Guid("DE80731E-A211-4455-8880-7D0F3F6A44FD")]
[NativeTypeName("struct ICompositionPropertySet2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionPropertySet2 : ICompositionPropertySet2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionPropertySet2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, uint>)(lpVtbl[1]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, uint>)(lpVtbl[2]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, HSTRING*, int>)(lpVtbl[4]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionPropertySet2.xml' path='doc/member[@name="ICompositionPropertySet2.InsertBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertBoolean(HSTRING propertyName, [NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, HSTRING, byte, int>)(lpVtbl[6]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet2.xml' path='doc/member[@name="ICompositionPropertySet2.TryGetBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetBoolean(HSTRING propertyName, [NativeTypeName("boolean *")] byte* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet2*, HSTRING, byte*, CompositionGetValueStatus*, int>)(lpVtbl[7]))((ICompositionPropertySet2*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertBoolean(HSTRING propertyName, [NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT TryGetBoolean(HSTRING propertyName, [NativeTypeName("boolean *")] byte* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);
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

        [NativeTypeName("HRESULT (HSTRING, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, int> InsertBoolean;

        [NativeTypeName("HRESULT (HSTRING, boolean *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, CompositionGetValueStatus*, int> TryGetBoolean;
    }
}
