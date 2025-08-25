// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWbemLocator.xml' path='doc/member[@name="IWbemLocator"]/*' />
[Guid("DC12A687-737F-11CF-884D-00AA004B2E24")]
[NativeTypeName("struct IWbemLocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemLocator : IWbemLocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWbemLocator);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWbemLocator*, Guid*, void**, int>)(lpVtbl[0]))((IWbemLocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWbemLocator*, uint>)(lpVtbl[1]))((IWbemLocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWbemLocator*, uint>)(lpVtbl[2]))((IWbemLocator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemLocator.xml' path='doc/member[@name="IWbemLocator.ConnectServer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ConnectServer([NativeTypeName("const BSTR")] char* strNetworkResource, [NativeTypeName("const BSTR")] char* strUser, [NativeTypeName("const BSTR")] char* strPassword, [NativeTypeName("const BSTR")] char* strLocale, [NativeTypeName("long")] int lSecurityFlags, [NativeTypeName("const BSTR")] char* strAuthority, IWbemContext* pCtx, IWbemServices** ppNamespace)
    {
        return ((delegate* unmanaged[MemberFunction]<IWbemLocator*, char*, char*, char*, char*, int, char*, IWbemContext*, IWbemServices**, int>)(lpVtbl[3]))((IWbemLocator*)Unsafe.AsPointer(ref this), strNetworkResource, strUser, strPassword, strLocale, lSecurityFlags, strAuthority, pCtx, ppNamespace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ConnectServer([NativeTypeName("const BSTR")] char* strNetworkResource, [NativeTypeName("const BSTR")] char* strUser, [NativeTypeName("const BSTR")] char* strPassword, [NativeTypeName("const BSTR")] char* strLocale, [NativeTypeName("long")] int lSecurityFlags, [NativeTypeName("const BSTR")] char* strAuthority, IWbemContext* pCtx, IWbemServices** ppNamespace);
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

        [NativeTypeName("HRESULT (const BSTR, const BSTR, const BSTR, const BSTR, long, const BSTR, IWbemContext *, IWbemServices **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, char*, int, char*, IWbemContext*, IWbemServices**, int> ConnectServer;
    }
}
