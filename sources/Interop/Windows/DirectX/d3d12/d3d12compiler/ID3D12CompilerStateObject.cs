// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12CompilerStateObject.xml' path='doc/member[@name="ID3D12CompilerStateObject"]/*' />
[Guid("5981CCA4-E8AE-44CA-9B92-4FA86F5A3A3A")]
[NativeTypeName("struct ID3D12CompilerStateObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12CompilerStateObject : ID3D12CompilerStateObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12CompilerStateObject);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerStateObject*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12CompilerStateObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerStateObject*, uint>)(lpVtbl[1]))((ID3D12CompilerStateObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerStateObject*, uint>)(lpVtbl[2]))((ID3D12CompilerStateObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CompilerStateObject.xml' path='doc/member[@name="ID3D12CompilerStateObject.GetCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCompiler([NativeTypeName("const IID &")] Guid* riid, void** ppCompiler)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerStateObject*, Guid*, void**, int>)(lpVtbl[3]))((ID3D12CompilerStateObject*)Unsafe.AsPointer(ref this), riid, ppCompiler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCompiler([NativeTypeName("const IID &")] Guid* riid, void** ppCompiler);
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetCompiler;
    }
}
