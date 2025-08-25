// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxFactory3.xml' path='doc/member[@name="IAppxFactory3"]/*' />
[Guid("776B2C05-E21D-4E24-BA1A-CD529A8BFDBB")]
[NativeTypeName("struct IAppxFactory3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxFactory3 : IAppxFactory3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppxFactory3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, uint>)(lpVtbl[1]))((IAppxFactory3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, uint>)(lpVtbl[2]))((IAppxFactory3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxFactory3.xml' path='doc/member[@name="IAppxFactory3.CreatePackageReader2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreatePackageReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxPackageReader** packageReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, IStream*, char*, IAppxPackageReader**, int>)(lpVtbl[3]))((IAppxFactory3*)Unsafe.AsPointer(ref this), inputStream, expectedDigest, packageReader);
    }

    /// <include file='IAppxFactory3.xml' path='doc/member[@name="IAppxFactory3.CreateManifestReader2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateManifestReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxManifestReader** manifestReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, IStream*, char*, IAppxManifestReader**, int>)(lpVtbl[4]))((IAppxFactory3*)Unsafe.AsPointer(ref this), inputStream, expectedDigest, manifestReader);
    }

    /// <include file='IAppxFactory3.xml' path='doc/member[@name="IAppxFactory3.CreateAppInstallerReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateAppInstallerReader(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxAppInstallerReader** appInstallerReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory3*, IStream*, char*, IAppxAppInstallerReader**, int>)(lpVtbl[5]))((IAppxFactory3*)Unsafe.AsPointer(ref this), inputStream, expectedDigest, appInstallerReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreatePackageReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxPackageReader** packageReader);

        [VtblIndex(4)]
        HRESULT CreateManifestReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxManifestReader** manifestReader);

        [VtblIndex(5)]
        HRESULT CreateAppInstallerReader(IStream* inputStream, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxAppInstallerReader** appInstallerReader);
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

        [NativeTypeName("HRESULT (IStream *, LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, char*, IAppxPackageReader**, int> CreatePackageReader2;

        [NativeTypeName("HRESULT (IStream *, LPCWSTR, IAppxManifestReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, char*, IAppxManifestReader**, int> CreateManifestReader2;

        [NativeTypeName("HRESULT (IStream *, LPCWSTR, IAppxAppInstallerReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, char*, IAppxAppInstallerReader**, int> CreateAppInstallerReader;
    }
}
