// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostWritableAdminManager.xml' path='doc/member[@name="IAppHostWritableAdminManager"]/*' />
[Guid("FA7660F6-7B3F-4237-A8BF-ED0AD0DCBBD9")]
[NativeTypeName("struct IAppHostWritableAdminManager : IAppHostAdminManager")]
[NativeInheritance("IAppHostAdminManager")]
public unsafe partial struct IAppHostWritableAdminManager : IAppHostWritableAdminManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostWritableAdminManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, uint>)(lpVtbl[1]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, uint>)(lpVtbl[2]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAppHostAdminManager.GetAdminSection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdminSection([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrPath, IAppHostElement** ppAdminSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, char*, char*, IAppHostElement**, int>)(lpVtbl[3]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), bstrSectionName, bstrPath, ppAdminSection);
    }

    /// <inheritdoc cref="IAppHostAdminManager.GetMetadata" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, char*, VARIANT*, int>)(lpVtbl[4]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <inheritdoc cref="IAppHostAdminManager.SetMetadata" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, char*, VARIANT, int>)(lpVtbl[5]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    /// <inheritdoc cref="IAppHostAdminManager.get_ConfigManager" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConfigManager(IAppHostConfigManager** ppConfigManager)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, IAppHostConfigManager**, int>)(lpVtbl[6]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), ppConfigManager);
    }

    /// <include file='IAppHostWritableAdminManager.xml' path='doc/member[@name="IAppHostWritableAdminManager.CommitChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CommitChanges()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, int>)(lpVtbl[7]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostWritableAdminManager.xml' path='doc/member[@name="IAppHostWritableAdminManager.get_CommitPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CommitPath([NativeTypeName("BSTR *")] char** pbstrCommitPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, char**, int>)(lpVtbl[8]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), pbstrCommitPath);
    }

    /// <include file='IAppHostWritableAdminManager.xml' path='doc/member[@name="IAppHostWritableAdminManager.put_CommitPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CommitPath([NativeTypeName("BSTR")] char* bstrCommitPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostWritableAdminManager*, char*, int>)(lpVtbl[9]))((IAppHostWritableAdminManager*)Unsafe.AsPointer(ref this), bstrCommitPath);
    }

    public interface Interface : IAppHostAdminManager.Interface
    {
        [VtblIndex(7)]
        HRESULT CommitChanges();

        [VtblIndex(8)]
        HRESULT get_CommitPath([NativeTypeName("BSTR *")] char** pbstrCommitPath);

        [VtblIndex(9)]
        HRESULT put_CommitPath([NativeTypeName("BSTR")] char* bstrCommitPath);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IAppHostElement**, int> GetAdminSection;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostConfigManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostConfigManager**, int> get_ConfigManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CommitChanges;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommitPath;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_CommitPath;
    }
}
