// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile"]/*' />
[Guid("3BFE56B0-390C-4863-9430-1F3D083B7684")]
[NativeTypeName("struct IDiaInputAssemblyFile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaInputAssemblyFile : IDiaInputAssemblyFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaInputAssemblyFile);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, Guid*, void**, int>)(lpVtbl[0]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint>)(lpVtbl[1]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint>)(lpVtbl[2]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_uniqueId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[3]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_index"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_index([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[4]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_timestamp([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[5]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_pdbAvailableAtILMerge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_pdbAvailableAtILMerge(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, BOOL*, int>)(lpVtbl[6]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_fileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_fileName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, char**, int>)(lpVtbl[7]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInputAssemblyFile.xml' path='doc/member[@name="IDiaInputAssemblyFile.get_version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_version([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInputAssemblyFile*, uint, uint*, byte*, int>)(lpVtbl[8]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_index([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(5)]
        HRESULT get_timestamp([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_pdbAvailableAtILMerge(BOOL* pRetVal);

        [VtblIndex(7)]
        HRESULT get_fileName([NativeTypeName("BSTR *")] char** pRetVal);

        [VtblIndex(8)]
        HRESULT get_version([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_uniqueId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_index;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_timestamp;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_pdbAvailableAtILMerge;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_fileName;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> get_version;
    }
}
