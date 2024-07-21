// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxBlockMapFile2.xml' path='doc/member[@name="IAppxBlockMapFile2"]/*' />
[Guid("54785F78-40E9-11EE-BE56-0242AC120002")]
[NativeTypeName("struct IAppxBlockMapFile2 : IAppxBlockMapFile")]
[NativeInheritance("IAppxBlockMapFile")]
public unsafe partial struct IAppxBlockMapFile2 : IAppxBlockMapFile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBlockMapFile2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, uint>)(lpVtbl[1]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, uint>)(lpVtbl[2]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAppxBlockMapFile.GetBlocks" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBlocks(IAppxBlockMapBlocksEnumerator** blocks)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, IAppxBlockMapBlocksEnumerator**, int>)(lpVtbl[3]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), blocks);
    }

    /// <inheritdoc cref="IAppxBlockMapFile.GetLocalFileHeaderSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, uint*, int>)(lpVtbl[4]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), lfhSize);
    }

    /// <inheritdoc cref="IAppxBlockMapFile.GetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] char** name)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, char**, int>)(lpVtbl[5]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref="IAppxBlockMapFile.GetUncompressedSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, ulong*, int>)(lpVtbl[6]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), size);
    }

    /// <inheritdoc cref="IAppxBlockMapFile.ValidateFileHash" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateFileHash(IStream* fileStream, BOOL* isValid)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, IStream*, BOOL*, int>)(lpVtbl[7]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), fileStream, isValid);
    }

    /// <include file='IAppxBlockMapFile2.xml' path='doc/member[@name="IAppxBlockMapFile2.GetBlockSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBlockSize([NativeTypeName("UINT64 *")] ulong* blockSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBlockMapFile2*, ulong*, int>)(lpVtbl[8]))((IAppxBlockMapFile2*)Unsafe.AsPointer(ref this), blockSize);
    }

    public interface Interface : IAppxBlockMapFile.Interface
    {
        [VtblIndex(8)]
        HRESULT GetBlockSize([NativeTypeName("UINT64 *")] ulong* blockSize);
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

        [NativeTypeName("HRESULT (IAppxBlockMapBlocksEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppxBlockMapBlocksEnumerator**, int> GetBlocks;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetLocalFileHeaderSize;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetName;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetUncompressedSize;

        [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, BOOL*, int> ValidateFileHash;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetBlockSize;
    }
}
