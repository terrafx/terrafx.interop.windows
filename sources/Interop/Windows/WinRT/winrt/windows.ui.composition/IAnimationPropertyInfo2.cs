// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAnimationPropertyInfo2.xml' path='doc/member[@name="IAnimationPropertyInfo2"]/*' />
[Guid("591720B4-7472-5218-8B39-DFFE615AE6DA")]
[NativeTypeName("struct IAnimationPropertyInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAnimationPropertyInfo2 : IAnimationPropertyInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAnimationPropertyInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, uint>)(lpVtbl[1]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, uint>)(lpVtbl[2]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, HSTRING*, int>)(lpVtbl[4]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAnimationPropertyInfo2.xml' path='doc/member[@name="IAnimationPropertyInfo2.GetResolvedCompositionObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResolvedCompositionObject([NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject **")] ICompositionObject** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, ICompositionObject**, int>)(lpVtbl[6]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAnimationPropertyInfo2.xml' path='doc/member[@name="IAnimationPropertyInfo2.GetResolvedCompositionObjectProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResolvedCompositionObjectProperty(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationPropertyInfo2*, HSTRING*, int>)(lpVtbl[7]))((IAnimationPropertyInfo2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetResolvedCompositionObject([NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject **")] ICompositionObject** result);

        [VtblIndex(7)]
        HRESULT GetResolvedCompositionObjectProperty(HSTRING* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionObject **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionObject**, int> GetResolvedCompositionObject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetResolvedCompositionObjectProperty;
    }
}
