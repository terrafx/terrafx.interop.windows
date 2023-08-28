// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaLoadCallback2.xml' path='doc/member[@name="IDiaLoadCallback2"]/*' />
[Guid("4688A074-5A4D-4486-AEA8-7B90711D9F7C")]
[NativeTypeName("struct IDiaLoadCallback2 : IDiaLoadCallback")]
[NativeInheritance("IDiaLoadCallback")]
public unsafe partial struct IDiaLoadCallback2 : IDiaLoadCallback2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaLoadCallback2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, uint>)(lpVtbl[1]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, uint>)(lpVtbl[2]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaLoadCallback.NotifyDebugDir" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyDebugDir(BOOL fExecutable, [NativeTypeName("DWORD")] uint cbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, BOOL, uint, byte*, int>)(lpVtbl[3]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), fExecutable, cbData, pbData);
    }

    /// <inheritdoc cref="IDiaLoadCallback.NotifyOpenDBG" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyOpenDBG([NativeTypeName("LPCOLESTR")] char* dbgPath, HRESULT resultCode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, char*, HRESULT, int>)(lpVtbl[4]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), dbgPath, resultCode);
    }

    /// <inheritdoc cref="IDiaLoadCallback.NotifyOpenPDB" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NotifyOpenPDB([NativeTypeName("LPCOLESTR")] char* pdbPath, HRESULT resultCode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, char*, HRESULT, int>)(lpVtbl[5]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), pdbPath, resultCode);
    }

    /// <inheritdoc cref="IDiaLoadCallback.RestrictRegistryAccess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RestrictRegistryAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[6]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaLoadCallback.RestrictSymbolServerAccess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RestrictSymbolServerAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[7]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaLoadCallback2.xml' path='doc/member[@name="IDiaLoadCallback2.RestrictOriginalPathAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RestrictOriginalPathAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[8]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaLoadCallback2.xml' path='doc/member[@name="IDiaLoadCallback2.RestrictReferencePathAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RestrictReferencePathAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[9]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaLoadCallback2.xml' path='doc/member[@name="IDiaLoadCallback2.RestrictDBGAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RestrictDBGAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[10]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaLoadCallback2.xml' path='doc/member[@name="IDiaLoadCallback2.RestrictSystemRootAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RestrictSystemRootAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaLoadCallback2*, int>)(lpVtbl[11]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDiaLoadCallback.Interface
    {
        [VtblIndex(8)]
        HRESULT RestrictOriginalPathAccess();

        [VtblIndex(9)]
        HRESULT RestrictReferencePathAccess();

        [VtblIndex(10)]
        HRESULT RestrictDBGAccess();

        [VtblIndex(11)]
        HRESULT RestrictSystemRootAccess();
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

        [NativeTypeName("HRESULT (BOOL, DWORD, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, uint, byte*, int> NotifyDebugDir;

        [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HRESULT, int> NotifyOpenDBG;

        [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HRESULT, int> NotifyOpenPDB;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictRegistryAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictSymbolServerAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictOriginalPathAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictReferencePathAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictDBGAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestrictSystemRootAccess;
    }
}
