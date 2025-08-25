// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositorWithProjectedShadow.xml' path='doc/member[@name="ICompositorWithProjectedShadow"]/*' />
[Guid("A2E6330E-8A60-5A38-BB85-B44EA901677C")]
[NativeTypeName("struct ICompositorWithProjectedShadow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositorWithProjectedShadow : ICompositorWithProjectedShadow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositorWithProjectedShadow);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, uint>)(lpVtbl[1]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, uint>)(lpVtbl[2]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, HSTRING*, int>)(lpVtbl[4]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, TrustLevel*, int>)(lpVtbl[5]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositorWithProjectedShadow.xml' path='doc/member[@name="ICompositorWithProjectedShadow.CreateProjectedShadowCaster"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateProjectedShadowCaster([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **")] ICompositionProjectedShadowCaster** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, ICompositionProjectedShadowCaster**, int>)(lpVtbl[6]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositorWithProjectedShadow.xml' path='doc/member[@name="ICompositorWithProjectedShadow.CreateProjectedShadow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateProjectedShadow([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadow **")] ICompositionProjectedShadow** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, ICompositionProjectedShadow**, int>)(lpVtbl[7]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositorWithProjectedShadow.xml' path='doc/member[@name="ICompositorWithProjectedShadow.CreateProjectedShadowReceiver"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateProjectedShadowReceiver([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **")] ICompositionProjectedShadowReceiver** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorWithProjectedShadow*, ICompositionProjectedShadowReceiver**, int>)(lpVtbl[8]))((ICompositorWithProjectedShadow*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateProjectedShadowCaster([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **")] ICompositionProjectedShadowCaster** result);

        [VtblIndex(7)]
        HRESULT CreateProjectedShadow([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadow **")] ICompositionProjectedShadow** result);

        [VtblIndex(8)]
        HRESULT CreateProjectedShadowReceiver([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **")] ICompositionProjectedShadowReceiver** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster**, int> CreateProjectedShadowCaster;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadow **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadow**, int> CreateProjectedShadow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowReceiver**, int> CreateProjectedShadowReceiver;
    }
}
