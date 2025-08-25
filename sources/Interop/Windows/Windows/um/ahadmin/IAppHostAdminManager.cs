// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostAdminManager.xml' path='doc/member[@name="IAppHostAdminManager"]/*' />
[Guid("9BE77978-73ED-4A9A-87FD-13F09FEC1B13")]
[NativeTypeName("struct IAppHostAdminManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostAdminManager : IAppHostAdminManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostAdminManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, uint>)(lpVtbl[1]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, uint>)(lpVtbl[2]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostAdminManager.xml' path='doc/member[@name="IAppHostAdminManager.GetAdminSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdminSection([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrPath, IAppHostElement** ppAdminSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, char*, char*, IAppHostElement**, int>)(lpVtbl[3]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this), bstrSectionName, bstrPath, ppAdminSection);
    }

    /// <include file='IAppHostAdminManager.xml' path='doc/member[@name="IAppHostAdminManager.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, char*, VARIANT*, int>)(lpVtbl[4]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostAdminManager.xml' path='doc/member[@name="IAppHostAdminManager.SetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, char*, VARIANT, int>)(lpVtbl[5]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    /// <include file='IAppHostAdminManager.xml' path='doc/member[@name="IAppHostAdminManager.get_ConfigManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConfigManager(IAppHostConfigManager** ppConfigManager)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostAdminManager*, IAppHostConfigManager**, int>)(lpVtbl[6]))((IAppHostAdminManager*)Unsafe.AsPointer(ref this), ppConfigManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdminSection([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrPath, IAppHostElement** ppAdminSection);

        [VtblIndex(4)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(5)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value);

        [VtblIndex(6)]
        HRESULT get_ConfigManager(IAppHostConfigManager** ppConfigManager);
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
    }
}
