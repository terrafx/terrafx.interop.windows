// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/microsoft/DirectXShaderCompiler/blob/main/projects/dxilconv/include/DxbcConverter.h
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDxbcConverter.xml' path='doc/member[@name="IDxbcConverter"]/*' />
[Guid("5F956ED5-78D1-4B15-8247-F7187614A041")]
[NativeTypeName("struct IDxbcConverter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxbcConverter : IDxbcConverter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDxbcConverter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxbcConverter*, Guid*, void**, int>)(lpVtbl[0]))((IDxbcConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxbcConverter*, uint>)(lpVtbl[1]))((IDxbcConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxbcConverter*, uint>)(lpVtbl[2]))((IDxbcConverter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxbcConverter.xml' path='doc/member[@name="IDxbcConverter.Convert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Convert([NativeTypeName("LPCVOID")] void* pDxbc, [NativeTypeName("UINT32")] uint DxbcSize, [NativeTypeName("LPCWSTR")] char* pExtraOptions, [NativeTypeName("LPVOID *")] void** ppDxil, [NativeTypeName("UINT32 *")] uint* pDxilSize, [NativeTypeName("LPWSTR *")] char** ppDiag)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxbcConverter*, void*, uint, char*, void**, uint*, char**, int>)(lpVtbl[3]))((IDxbcConverter*)Unsafe.AsPointer(ref this), pDxbc, DxbcSize, pExtraOptions, ppDxil, pDxilSize, ppDiag);
    }

    /// <include file='IDxbcConverter.xml' path='doc/member[@name="IDxbcConverter.ConvertInDriver"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConvertInDriver([NativeTypeName("const UINT32 *")] uint* pBytecode, [NativeTypeName("LPCVOID")] void* pInputSignature, [NativeTypeName("UINT32")] uint NumInputSignatureElements, [NativeTypeName("LPCVOID")] void* pOutputSignature, [NativeTypeName("UINT32")] uint NumOutputSignatureElements, [NativeTypeName("LPCVOID")] void* pPatchConstantSignature, [NativeTypeName("UINT32")] uint NumPatchConstantSignatureElements, [NativeTypeName("LPCWSTR")] char* pExtraOptions, IDxcBlob** ppDxilModule, [NativeTypeName("LPWSTR *")] char** ppDiag)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxbcConverter*, uint*, void*, uint, void*, uint, void*, uint, char*, IDxcBlob**, char**, int>)(lpVtbl[4]))((IDxbcConverter*)Unsafe.AsPointer(ref this), pBytecode, pInputSignature, NumInputSignatureElements, pOutputSignature, NumOutputSignatureElements, pPatchConstantSignature, NumPatchConstantSignatureElements, pExtraOptions, ppDxilModule, ppDiag);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Convert([NativeTypeName("LPCVOID")] void* pDxbc, [NativeTypeName("UINT32")] uint DxbcSize, [NativeTypeName("LPCWSTR")] char* pExtraOptions, [NativeTypeName("LPVOID *")] void** ppDxil, [NativeTypeName("UINT32 *")] uint* pDxilSize, [NativeTypeName("LPWSTR *")] char** ppDiag);

        [VtblIndex(4)]
        HRESULT ConvertInDriver([NativeTypeName("const UINT32 *")] uint* pBytecode, [NativeTypeName("LPCVOID")] void* pInputSignature, [NativeTypeName("UINT32")] uint NumInputSignatureElements, [NativeTypeName("LPCVOID")] void* pOutputSignature, [NativeTypeName("UINT32")] uint NumOutputSignatureElements, [NativeTypeName("LPCVOID")] void* pPatchConstantSignature, [NativeTypeName("UINT32")] uint NumPatchConstantSignatureElements, [NativeTypeName("LPCWSTR")] char* pExtraOptions, IDxcBlob** ppDxilModule, [NativeTypeName("LPWSTR *")] char** ppDiag);
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

        [NativeTypeName("HRESULT (LPCVOID, UINT32, LPCWSTR, LPVOID *, UINT32 *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, char*, void**, uint*, char**, int> Convert;

        [NativeTypeName("HRESULT (const UINT32 *, LPCVOID, UINT32, LPCVOID, UINT32, LPCVOID, UINT32, LPCWSTR, IDxcBlob **, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, void*, uint, void*, uint, void*, uint, char*, IDxcBlob**, char**, int> ConvertInDriver;
    }
}
