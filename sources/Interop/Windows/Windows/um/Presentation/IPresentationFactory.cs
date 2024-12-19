// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationFactory.xml' path='doc/member[@name="IPresentationFactory"]/*' />
[Guid("8FB37B58-1D74-4F64-A49C-1F97A80A2EC0")]
[NativeTypeName("struct IPresentationFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationFactory : IPresentationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, uint>)(lpVtbl[1]))((IPresentationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, uint>)(lpVtbl[2]))((IPresentationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationFactory.xml' path='doc/member[@name="IPresentationFactory.IsPresentationSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("boolean")]
    public byte IsPresentationSupported()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, byte>)(lpVtbl[3]))((IPresentationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationFactory.xml' path='doc/member[@name="IPresentationFactory.IsPresentationSupportedWithIndependentFlip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("boolean")]
    public byte IsPresentationSupportedWithIndependentFlip()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, byte>)(lpVtbl[4]))((IPresentationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationFactory.xml' path='doc/member[@name="IPresentationFactory.CreatePresentationManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreatePresentationManager(IPresentationManager** ppPresentationManager)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationFactory*, IPresentationManager**, int>)(lpVtbl[5]))((IPresentationFactory*)Unsafe.AsPointer(ref this), ppPresentationManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("boolean")]
        byte IsPresentationSupported();

        [VtblIndex(4)]
        [return: NativeTypeName("boolean")]
        byte IsPresentationSupportedWithIndependentFlip();

        [VtblIndex(5)]
        HRESULT CreatePresentationManager(IPresentationManager** ppPresentationManager);
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

        [NativeTypeName("boolean () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte> IsPresentationSupported;

        [NativeTypeName("boolean () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte> IsPresentationSupportedWithIndependentFlip;

        [NativeTypeName("HRESULT (IPresentationManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPresentationManager**, int> CreatePresentationManager;
    }
}
