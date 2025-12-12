// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties"]/*' />
[Guid("065ACF71-F863-4B89-82F4-02E4D5886757")]
[NativeTypeName("struct ID3D12WorkGraphProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12WorkGraphProperties : ID3D12WorkGraphProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12WorkGraphProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[1]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[2]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumWorkGraphs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetNumWorkGraphs()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[3]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetProgramName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("LPCWSTR")]
    public char* GetProgramName(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, char*>)(lpVtbl[4]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] char* pProgramName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, char*, uint>)(lpVtbl[5]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), pProgramName);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetNumNodes(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint>)(lpVtbl[6]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, D3D12_NODE_ID>)(lpVtbl[7]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, D3D12_NODE_ID, uint>)(lpVtbl[8]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNodeLocalRootArgumentsTableIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[9]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetNumEntrypoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public uint GetNumEntrypoints(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint>)(lpVtbl[10]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, D3D12_NODE_ID>)(lpVtbl[11]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, D3D12_NODE_ID, uint>)(lpVtbl[12]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[13]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetWorkGraphMemoryRequirements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS* pWorkGraphMemoryRequirements)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS*, void>)(lpVtbl[14]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, pWorkGraphMemoryRequirements);
    }

    /// <include file='ID3D12WorkGraphProperties.xml' path='doc/member[@name="ID3D12WorkGraphProperties.GetEntrypointRecordAlignmentInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[15]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint GetNumWorkGraphs();

        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        char* GetProgramName(uint WorkGraphIndex);

        [VtblIndex(5)]
        uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] char* pProgramName);

        [VtblIndex(6)]
        uint GetNumNodes(uint WorkGraphIndex);

        [VtblIndex(7)]
        D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex);

        [VtblIndex(8)]
        uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);

        [VtblIndex(9)]
        uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);

        [VtblIndex(10)]
        uint GetNumEntrypoints(uint WorkGraphIndex);

        [VtblIndex(11)]
        D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);

        [VtblIndex(12)]
        uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);

        [VtblIndex(13)]
        uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);

        [VtblIndex(14)]
        void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS* pWorkGraphMemoryRequirements);

        [VtblIndex(15)]
        uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex);
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetNumWorkGraphs;

        [NativeTypeName("LPCWSTR (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*> GetProgramName;

        [NativeTypeName("UINT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint> GetWorkGraphIndex;

        [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> GetNumNodes;

        [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3D12_NODE_ID> GetNodeID;

        [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_NODE_ID, uint> GetNodeIndex;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint> GetNodeLocalRootArgumentsTableIndex;

        [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> GetNumEntrypoints;

        [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3D12_NODE_ID> GetEntrypointID;

        [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_NODE_ID, uint> GetEntrypointIndex;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint> GetEntrypointRecordSizeInBytes;

        [NativeTypeName("void (UINT, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS*, void> GetWorkGraphMemoryRequirements;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint> GetEntrypointRecordAlignmentInBytes;
    }
}
