// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRenderingParametersUpdateHandler.xml' path='doc/member[@name="IRenderingParametersUpdateHandler"]/*' />
[Guid("3A2D9D45-72E9-4311-B46C-27C8BB7E6CB3")]
[NativeTypeName("struct IRenderingParametersUpdateHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRenderingParametersUpdateHandler : IRenderingParametersUpdateHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRenderingParametersUpdateHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRenderingParametersUpdateHandler*, Guid*, void**, int>)(lpVtbl[0]))((IRenderingParametersUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRenderingParametersUpdateHandler*, uint>)(lpVtbl[1]))((IRenderingParametersUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRenderingParametersUpdateHandler*, uint>)(lpVtbl[2]))((IRenderingParametersUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRenderingParametersUpdateHandler.xml' path='doc/member[@name="IRenderingParametersUpdateHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRenderer *")] IMediaRenderer* sender, [NativeTypeName("ABI::Windows::Media::Streaming::RenderingParameters")] RenderingParameters arg)
    {
        return ((delegate* unmanaged[MemberFunction]<IRenderingParametersUpdateHandler*, IMediaRenderer*, RenderingParameters, int>)(lpVtbl[3]))((IRenderingParametersUpdateHandler*)Unsafe.AsPointer(ref this), sender, arg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRenderer *")] IMediaRenderer* sender, [NativeTypeName("ABI::Windows::Media::Streaming::RenderingParameters")] RenderingParameters arg);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IMediaRenderer *, ABI::Windows::Media::Streaming::RenderingParameters) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRenderer*, RenderingParameters, int> Invoke;
    }
}
