// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IObjectWithPackageFullName.xml' path='doc/member[@name="IObjectWithPackageFullName"]/*' />
[Guid("ED2AA515-602F-469C-A130-CE69FD0FA878")]
[NativeTypeName("struct IObjectWithPackageFullName : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithPackageFullName : IObjectWithPackageFullName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IObjectWithPackageFullName);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithPackageFullName*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithPackageFullName*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithPackageFullName*, uint>)(lpVtbl[1]))((IObjectWithPackageFullName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithPackageFullName*, uint>)(lpVtbl[2]))((IObjectWithPackageFullName*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectWithPackageFullName.xml' path='doc/member[@name="IObjectWithPackageFullName.GetPackageFullName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageFullName([NativeTypeName("LPWSTR *")] char** packageFullName)
    {
        return ((delegate* unmanaged[MemberFunction]<IObjectWithPackageFullName*, char**, int>)(lpVtbl[3]))((IObjectWithPackageFullName*)Unsafe.AsPointer(ref this), packageFullName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageFullName([NativeTypeName("LPWSTR *")] char** packageFullName);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPackageFullName;
    }
}
