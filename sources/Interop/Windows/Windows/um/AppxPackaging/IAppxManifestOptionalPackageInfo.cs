// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0")]
[Guid("2634847D-5B5D-4FE5-A243-002FF95EDC7E")]
[NativeTypeName("struct IAppxManifestOptionalPackageInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestOptionalPackageInfo : IAppxManifestOptionalPackageInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestOptionalPackageInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestOptionalPackageInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestOptionalPackageInfo*, uint>)(lpVtbl[1]))((IAppxManifestOptionalPackageInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestOptionalPackageInfo*, uint>)(lpVtbl[2]))((IAppxManifestOptionalPackageInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsOptionalPackage(BOOL* isOptionalPackage)
    {
        return ((delegate* unmanaged<IAppxManifestOptionalPackageInfo*, BOOL*, int>)(lpVtbl[3]))((IAppxManifestOptionalPackageInfo*)Unsafe.AsPointer(ref this), isOptionalPackage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMainPackageName([NativeTypeName("LPWSTR *")] ushort** mainPackageName)
    {
        return ((delegate* unmanaged<IAppxManifestOptionalPackageInfo*, ushort**, int>)(lpVtbl[4]))((IAppxManifestOptionalPackageInfo*)Unsafe.AsPointer(ref this), mainPackageName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsOptionalPackage(BOOL* isOptionalPackage);

        [VtblIndex(4)]
        HRESULT GetMainPackageName([NativeTypeName("LPWSTR *")] ushort** mainPackageName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestOptionalPackageInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestOptionalPackageInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestOptionalPackageInfo*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestOptionalPackageInfo*, BOOL*, int> GetIsOptionalPackage;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestOptionalPackageInfo*, ushort**, int> GetMainPackageName;
    }
}
