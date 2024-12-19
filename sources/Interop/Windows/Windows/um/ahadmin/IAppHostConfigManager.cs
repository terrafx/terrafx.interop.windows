// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConfigManager.xml' path='doc/member[@name="IAppHostConfigManager"]/*' />
[Guid("8F6D760F-F0CB-4D69-B5F6-848B33E9BDC6")]
[NativeTypeName("struct IAppHostConfigManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigManager : IAppHostConfigManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConfigManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConfigManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigManager*, uint>)(lpVtbl[1]))((IAppHostConfigManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigManager*, uint>)(lpVtbl[2]))((IAppHostConfigManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigManager.xml' path='doc/member[@name="IAppHostConfigManager.GetConfigFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConfigFile([NativeTypeName("BSTR")] char* bstrConfigPath, IAppHostConfigFile** ppConfigFile)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigManager*, char*, IAppHostConfigFile**, int>)(lpVtbl[3]))((IAppHostConfigManager*)Unsafe.AsPointer(ref this), bstrConfigPath, ppConfigFile);
    }

    /// <include file='IAppHostConfigManager.xml' path='doc/member[@name="IAppHostConfigManager.GetUniqueConfigPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUniqueConfigPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR *")] char** pbstrUniquePath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigManager*, char*, char**, int>)(lpVtbl[4]))((IAppHostConfigManager*)Unsafe.AsPointer(ref this), bstrConfigPath, pbstrUniquePath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetConfigFile([NativeTypeName("BSTR")] char* bstrConfigPath, IAppHostConfigFile** ppConfigFile);

        [VtblIndex(4)]
        HRESULT GetUniqueConfigPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR *")] char** pbstrUniquePath);
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

        [NativeTypeName("HRESULT (BSTR, IAppHostConfigFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostConfigFile**, int> GetConfigFile;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetUniqueConfigPath;
    }
}
