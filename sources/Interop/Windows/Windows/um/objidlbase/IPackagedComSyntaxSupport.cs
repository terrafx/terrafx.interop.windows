// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPackagedComSyntaxSupport.xml' path='doc/member[@name="IPackagedComSyntaxSupport"]/*' />
[Guid("8F146474-B228-48FB-A58C-105EBB273ABC")]
[NativeTypeName("struct IPackagedComSyntaxSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPackagedComSyntaxSupport : IPackagedComSyntaxSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPackagedComSyntaxSupport);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackagedComSyntaxSupport*, Guid*, void**, int>)(lpVtbl[0]))((IPackagedComSyntaxSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackagedComSyntaxSupport*, uint>)(lpVtbl[1]))((IPackagedComSyntaxSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackagedComSyntaxSupport*, uint>)(lpVtbl[2]))((IPackagedComSyntaxSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPackagedComSyntaxSupport.xml' path='doc/member[@name="IPackagedComSyntaxSupport.GetSupportedVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSupportedVersion([NativeTypeName("UINT32 *")] uint* supportedVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackagedComSyntaxSupport*, uint*, int>)(lpVtbl[3]))((IPackagedComSyntaxSupport*)Unsafe.AsPointer(ref this), supportedVersion);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSupportedVersion([NativeTypeName("UINT32 *")] uint* supportedVersion);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSupportedVersion;
    }
}
