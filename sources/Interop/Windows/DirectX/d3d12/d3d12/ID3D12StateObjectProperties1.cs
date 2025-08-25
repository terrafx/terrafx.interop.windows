// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12StateObjectProperties1.xml' path='doc/member[@name="ID3D12StateObjectProperties1"]/*' />
[Guid("460CAAC7-1D24-446A-A184-CA67DB494138")]
[NativeTypeName("struct ID3D12StateObjectProperties1 : ID3D12StateObjectProperties")]
[NativeInheritance("ID3D12StateObjectProperties")]
public unsafe partial struct ID3D12StateObjectProperties1 : ID3D12StateObjectProperties1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12StateObjectProperties1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, uint>)(lpVtbl[1]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, uint>)(lpVtbl[2]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12StateObjectProperties.GetShaderIdentifier" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] char* pExportName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, char*, void*>)(lpVtbl[3]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this), pExportName);
    }

    /// <inheritdoc cref="ID3D12StateObjectProperties.GetShaderStackSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT64")]
    public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] char* pExportName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, char*, ulong>)(lpVtbl[4]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this), pExportName);
    }

    /// <inheritdoc cref="ID3D12StateObjectProperties.GetPipelineStackSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPipelineStackSize()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, ulong>)(lpVtbl[5]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12StateObjectProperties.SetPipelineStackSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, ulong, void>)(lpVtbl[6]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
    }

    /// <include file='ID3D12StateObjectProperties1.xml' path='doc/member[@name="ID3D12StateObjectProperties1.GetProgramIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier([NativeTypeName("LPCWSTR")] char* pProgramName)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectProperties1*, char*, D3D12_PROGRAM_IDENTIFIER>)(lpVtbl[7]))((ID3D12StateObjectProperties1*)Unsafe.AsPointer(ref this), pProgramName);
    }

    public interface Interface : ID3D12StateObjectProperties.Interface
    {
        [VtblIndex(7)]
        D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier([NativeTypeName("LPCWSTR")] char* pProgramName);
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

        [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*> GetShaderIdentifier;

        [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ulong> GetShaderStackSize;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetPipelineStackSize;

        [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, void> SetPipelineStackSize;

        [NativeTypeName("D3D12_PROGRAM_IDENTIFIER (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D3D12_PROGRAM_IDENTIFIER> GetProgramIdentifier;
    }
}
