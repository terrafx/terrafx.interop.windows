// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
[Guid("B43BBCF9-65A6-42DD-BAC0-8C6741E7F5A4")]
[NativeTypeName("struct IAppxManifestPackageDependenciesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestPackageDependenciesEnumerator : IAppxManifestPackageDependenciesEnumerator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestPackageDependency** dependency)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, IAppxManifestPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), dependency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestPackageDependency** dependency);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint> Release;

        [NativeTypeName("HRESULT (IAppxManifestPackageDependency **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, IAppxManifestPackageDependency**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, BOOL*, int> MoveNext;
    }
}
