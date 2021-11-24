// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("BBA65864-965F-4A5F-855F-F074BDBF3A7B")]
[NativeTypeName("struct IAppxBundleFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleFactory : IAppxBundleFactory.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, uint>)(lpVtbl[1]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, uint>)(lpVtbl[2]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBundleWriter(IStream* outputStream, [NativeTypeName("UINT64")] ulong bundleVersion, IAppxBundleWriter** bundleWriter)
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, IStream*, ulong, IAppxBundleWriter**, int>)(lpVtbl[3]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this), outputStream, bundleVersion, bundleWriter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateBundleReader(IStream* inputStream, IAppxBundleReader** bundleReader)
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, IStream*, IAppxBundleReader**, int>)(lpVtbl[4]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this), inputStream, bundleReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBundleManifestReader(IStream* inputStream, IAppxBundleManifestReader** manifestReader)
    {
        return ((delegate* unmanaged<IAppxBundleFactory*, IStream*, IAppxBundleManifestReader**, int>)(lpVtbl[5]))((IAppxBundleFactory*)Unsafe.AsPointer(ref this), inputStream, manifestReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBundleWriter(IStream* outputStream, [NativeTypeName("UINT64")] ulong bundleVersion, IAppxBundleWriter** bundleWriter);

        [VtblIndex(4)]
        HRESULT CreateBundleReader(IStream* inputStream, IAppxBundleReader** bundleReader);

        [VtblIndex(5)]
        HRESULT CreateBundleManifestReader(IStream* inputStream, IAppxBundleManifestReader** manifestReader);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, uint> Release;

        [NativeTypeName("HRESULT (IStream *, UINT64, IAppxBundleWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, IStream*, ulong, IAppxBundleWriter**, int> CreateBundleWriter;

        [NativeTypeName("HRESULT (IStream *, IAppxBundleReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, IStream*, IAppxBundleReader**, int> CreateBundleReader;

        [NativeTypeName("HRESULT (IStream *, IAppxBundleManifestReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleFactory*, IStream*, IAppxBundleManifestReader**, int> CreateBundleManifestReader;
    }
}
