// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationBuffer.xml' path='doc/member[@name="IPresentationBuffer"]/*' />
[Guid("2E217D3A-5ABB-4138-9A13-A775593C89CA")]
[NativeTypeName("struct IPresentationBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationBuffer : IPresentationBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationBuffer*, uint>)(lpVtbl[1]))((IPresentationBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationBuffer*, uint>)(lpVtbl[2]))((IPresentationBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationBuffer.xml' path='doc/member[@name="IPresentationBuffer.GetAvailableEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableEvent(HANDLE* availableEventHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationBuffer*, HANDLE*, int>)(lpVtbl[3]))((IPresentationBuffer*)Unsafe.AsPointer(ref this), availableEventHandle);
    }

    /// <include file='IPresentationBuffer.xml' path='doc/member[@name="IPresentationBuffer.IsAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsAvailable([NativeTypeName("boolean *")] byte* isAvailable)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationBuffer*, byte*, int>)(lpVtbl[4]))((IPresentationBuffer*)Unsafe.AsPointer(ref this), isAvailable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAvailableEvent(HANDLE* availableEventHandle);

        [VtblIndex(4)]
        HRESULT IsAvailable([NativeTypeName("boolean *")] byte* isAvailable);
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

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE*, int> GetAvailableEvent;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsAvailable;
    }
}
