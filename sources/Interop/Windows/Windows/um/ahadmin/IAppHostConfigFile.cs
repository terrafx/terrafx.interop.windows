// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile"]/*' />
[Guid("ADA4E6FB-E025-401E-A5D0-C3134A281F07")]
[NativeTypeName("struct IAppHostConfigFile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigFile : IAppHostConfigFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostConfigFile);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, uint>)(lpVtbl[1]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, uint>)(lpVtbl[2]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.get_ConfigPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_ConfigPath([NativeTypeName("BSTR *")] char** pbstrConfigPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, char**, int>)(lpVtbl[3]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), pbstrConfigPath);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.get_FilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FilePath([NativeTypeName("BSTR *")] char** pbstrFilePath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, char**, int>)(lpVtbl[4]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), pbstrFilePath);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.get_Locations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Locations(IAppHostConfigLocationCollection** ppLocations)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, IAppHostConfigLocationCollection**, int>)(lpVtbl[5]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), ppLocations);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.GetAdminSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAdminSection([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrPath, IAppHostElement** ppAdminSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, char*, char*, IAppHostElement**, int>)(lpVtbl[6]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), bstrSectionName, bstrPath, ppAdminSection);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, char*, VARIANT*, int>)(lpVtbl[7]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.SetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, char*, VARIANT, int>)(lpVtbl[8]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.ClearInvalidSections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearInvalidSections()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, int>)(lpVtbl[9]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigFile.xml' path='doc/member[@name="IAppHostConfigFile.get_RootSectionGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RootSectionGroup(IAppHostSectionGroup** ppSectionGroups)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigFile*, IAppHostSectionGroup**, int>)(lpVtbl[10]))((IAppHostConfigFile*)Unsafe.AsPointer(ref this), ppSectionGroups);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_ConfigPath([NativeTypeName("BSTR *")] char** pbstrConfigPath);

        [VtblIndex(4)]
        HRESULT get_FilePath([NativeTypeName("BSTR *")] char** pbstrFilePath);

        [VtblIndex(5)]
        HRESULT get_Locations(IAppHostConfigLocationCollection** ppLocations);

        [VtblIndex(6)]
        HRESULT GetAdminSection([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrPath, IAppHostElement** ppAdminSection);

        [VtblIndex(7)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(8)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value);

        [VtblIndex(9)]
        HRESULT ClearInvalidSections();

        [VtblIndex(10)]
        HRESULT get_RootSectionGroup(IAppHostSectionGroup** ppSectionGroups);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ConfigPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_FilePath;

        [NativeTypeName("HRESULT (IAppHostConfigLocationCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostConfigLocationCollection**, int> get_Locations;

        [NativeTypeName("HRESULT (BSTR, BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IAppHostElement**, int> GetAdminSection;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearInvalidSections;

        [NativeTypeName("HRESULT (IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostSectionGroup**, int> get_RootSectionGroup;
    }
}
