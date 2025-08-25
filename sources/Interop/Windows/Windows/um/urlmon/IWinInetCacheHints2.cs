// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWinInetCacheHints2.xml' path='doc/member[@name="IWinInetCacheHints2"]/*' />
[Guid("7857AEAC-D31F-49BF-884E-DD46DF36780A")]
[NativeTypeName("struct IWinInetCacheHints2 : IWinInetCacheHints")]
[NativeInheritance("IWinInetCacheHints")]
public unsafe partial struct IWinInetCacheHints2 : IWinInetCacheHints2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWinInetCacheHints2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWinInetCacheHints2*, Guid*, void**, int>)(lpVtbl[0]))((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWinInetCacheHints2*, uint>)(lpVtbl[1]))((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWinInetCacheHints2*, uint>)(lpVtbl[2]))((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWinInetCacheHints.SetCacheExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCacheExtension([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IWinInetCacheHints2*, char*, void*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
    }

    /// <include file='IWinInetCacheHints2.xml' path='doc/member[@name="IWinInetCacheHints2.SetCacheExtension2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCacheExtension2([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("WCHAR *")] char* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IWinInetCacheHints2*, char*, char*, uint*, uint*, uint*, int>)(lpVtbl[4]))((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pwzCacheFile, pcchCacheFile, pdwWinInetError, pdwReserved);
    }

    public interface Interface : IWinInetCacheHints.Interface
    {
        [VtblIndex(4)]
        HRESULT SetCacheExtension2([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("WCHAR *")] char* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*, uint*, uint*, uint*, int> SetCacheExtension;

        [NativeTypeName("HRESULT (LPCWSTR, WCHAR *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, uint*, uint*, int> SetCacheExtension2;
    }
}
