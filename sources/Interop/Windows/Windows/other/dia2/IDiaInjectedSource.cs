// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource"]/*' />
[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
[NativeTypeName("struct IDiaInjectedSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaInjectedSource : IDiaInjectedSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaInjectedSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, Guid*, void**, int>)(lpVtbl[0]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, uint>)(lpVtbl[1]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, uint>)(lpVtbl[2]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_crc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, uint*, int>)(lpVtbl[3]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, ulong*, int>)(lpVtbl[4]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_filename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_filename([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, char**, int>)(lpVtbl[5]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_objectFilename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_objectFilename([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, char**, int>)(lpVtbl[6]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_virtualFilename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_virtualFilename([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, char**, int>)(lpVtbl[7]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_sourceCompression"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, uint*, int>)(lpVtbl[8]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaInjectedSource.xml' path='doc/member[@name="IDiaInjectedSource.get_source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_source([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaInjectedSource*, uint, uint*, byte*, int>)(lpVtbl[9]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(5)]
        HRESULT get_filename([NativeTypeName("BSTR *")] char** pRetVal);

        [VtblIndex(6)]
        HRESULT get_objectFilename([NativeTypeName("BSTR *")] char** pRetVal);

        [VtblIndex(7)]
        HRESULT get_virtualFilename([NativeTypeName("BSTR *")] char** pRetVal);

        [VtblIndex(8)]
        HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(9)]
        HRESULT get_source([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_crc;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_length;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_filename;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_objectFilename;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_virtualFilename;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_sourceCompression;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> get_source;
    }
}
