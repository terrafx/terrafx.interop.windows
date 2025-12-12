// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12Compiler.xml' path='doc/member[@name="ID3D12Compiler"]/*' />
[Guid("8C403C12-993B-4583-80F1-6824138FA68E")]
[NativeTypeName("struct ID3D12Compiler : ID3D12CompilerFactoryChild")]
[NativeInheritance("ID3D12CompilerFactoryChild")]
public unsafe partial struct ID3D12Compiler : ID3D12Compiler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12Compiler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, uint>)(lpVtbl[1]))((ID3D12Compiler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, uint>)(lpVtbl[2]))((ID3D12Compiler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12CompilerFactoryChild.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppCompilerFactory)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, Guid*, void**, int>)(lpVtbl[3]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), riid, ppCompilerFactory);
    }

    /// <include file='ID3D12Compiler.xml' path='doc/member[@name="ID3D12Compiler.CompilePipelineState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CompilePipelineState([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int>)(lpVtbl[4]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), pGroupKey, GroupVersion, pDesc);
    }

    /// <include file='ID3D12Compiler.xml' path='doc/member[@name="ID3D12Compiler.CompileStateObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompileStateObject([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCompilerStateObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int>)(lpVtbl[5]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), pGroupKey, GroupVersion, pDesc, riid, ppCompilerStateObject);
    }

    /// <include file='ID3D12Compiler.xml' path='doc/member[@name="ID3D12Compiler.CompileAddToStateObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CompileAddToStateObject([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, void** ppNewCompilerStateObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_STATE_OBJECT_DESC*, ID3D12CompilerStateObject*, Guid*, void**, int>)(lpVtbl[6]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObject);
    }

    /// <include file='ID3D12Compiler.xml' path='doc/member[@name="ID3D12Compiler.GetCacheSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCacheSession([NativeTypeName("const IID &")] Guid* riid, void** ppCompilerCacheSession)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Compiler*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Compiler*)Unsafe.AsPointer(ref this), riid, ppCompilerCacheSession);
    }

    public interface Interface : ID3D12CompilerFactoryChild.Interface
    {
        [VtblIndex(4)]
        HRESULT CompilePipelineState([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc);

        [VtblIndex(5)]
        HRESULT CompileStateObject([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCompilerStateObject);

        [VtblIndex(6)]
        HRESULT CompileAddToStateObject([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, void** ppNewCompilerStateObject);

        [VtblIndex(7)]
        HRESULT GetCacheSession([NativeTypeName("const IID &")] Guid* riid, void** ppCompilerCacheSession);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetFactory;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, UINT, const D3D12_PIPELINE_STATE_STREAM_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_PIPELINE_STATE_STREAM_DESC*, int> CompilePipelineState;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, UINT, const D3D12_STATE_OBJECT_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int> CompileStateObject;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, UINT, const D3D12_STATE_OBJECT_DESC *, ID3D12CompilerStateObject *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_STATE_OBJECT_DESC*, ID3D12CompilerStateObject*, Guid*, void**, int> CompileAddToStateObject;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetCacheSession;
    }
}
