// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxFile2.xml' path='doc/member[@name="IAppxFile2"]/*' />
[Guid("0C830B3C-40E9-11EE-BE56-0242AC120002")]
[NativeTypeName("struct IAppxFile2 : IAppxFile")]
[NativeInheritance("IAppxFile")]
public unsafe partial struct IAppxFile2 : IAppxFile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxFile2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, uint>)(lpVtbl[1]))((IAppxFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, uint>)(lpVtbl[2]))((IAppxFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAppxFile.GetCompressionOption" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCompressionOption(APPX_COMPRESSION_OPTION* compressionOption)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, APPX_COMPRESSION_OPTION*, int>)(lpVtbl[3]))((IAppxFile2*)Unsafe.AsPointer(ref this), compressionOption);
    }

    /// <inheritdoc cref="IAppxFile.GetContentType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetContentType([NativeTypeName("LPWSTR *")] char** contentType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, char**, int>)(lpVtbl[4]))((IAppxFile2*)Unsafe.AsPointer(ref this), contentType);
    }

    /// <inheritdoc cref="IAppxFile.GetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] char** fileName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, char**, int>)(lpVtbl[5]))((IAppxFile2*)Unsafe.AsPointer(ref this), fileName);
    }

    /// <inheritdoc cref="IAppxFile.GetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, ulong*, int>)(lpVtbl[6]))((IAppxFile2*)Unsafe.AsPointer(ref this), size);
    }

    /// <inheritdoc cref="IAppxFile.GetStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStream(IStream** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, IStream**, int>)(lpVtbl[7]))((IAppxFile2*)Unsafe.AsPointer(ref this), stream);
    }

    /// <include file='IAppxFile2.xml' path='doc/member[@name="IAppxFile2.GetBlockSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBlockSize([NativeTypeName("UINT64 *")] ulong* blockSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFile2*, ulong*, int>)(lpVtbl[8]))((IAppxFile2*)Unsafe.AsPointer(ref this), blockSize);
    }

    public interface Interface : IAppxFile.Interface
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

        [NativeTypeName("HRESULT (APPX_COMPRESSION_OPTION *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, APPX_COMPRESSION_OPTION*, int> GetCompressionOption;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetContentType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetName;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetSize;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream**, int> GetStream;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetBlockSize;
    }
}
