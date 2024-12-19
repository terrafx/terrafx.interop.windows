// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IReferencedMetadataInfo.xml' path='doc/member[@name="IReferencedMetadataInfo"]/*' />
[Guid("3FC5C336-9AD7-45EA-AF2F-31B59302C9FE")]
[NativeTypeName("struct IReferencedMetadataInfo : IMetadataInfo")]
[NativeInheritance("IMetadataInfo")]
public unsafe partial struct IReferencedMetadataInfo : IReferencedMetadataInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReferencedMetadataInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IMetadataInfo.GetMetaPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetMetaPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, char*>)(lpVtbl[0]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMetadataInfo.GetVrPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetVrPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, char*>)(lpVtbl[1]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMetadataInfo.GetVrToken" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpTokenEntry* GetVrToken()
    {
        return ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, IHttpTokenEntry*>)(lpVtbl[2]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMetadataInfo.GetModuleContextContainer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, IHttpModuleContextContainer*>)(lpVtbl[3]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IReferencedMetadataInfo.xml' path='doc/member[@name="IReferencedMetadataInfo.ReferenceMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ReferenceMetadata()
    {
        ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, void>)(lpVtbl[4]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IReferencedMetadataInfo.xml' path='doc/member[@name="IReferencedMetadataInfo.DereferenceMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void DereferenceMetadata()
    {
        ((delegate* unmanaged[MemberFunction]<IReferencedMetadataInfo*, void>)(lpVtbl[5]))((IReferencedMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMetadataInfo.Interface
    {
        [VtblIndex(4)]
        void ReferenceMetadata();

        [VtblIndex(5)]
        void DereferenceMetadata();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetMetaPath;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetVrPath;

        [NativeTypeName("IHttpTokenEntry *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTokenEntry*> GetVrToken;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ReferenceMetadata;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DereferenceMetadata;
    }
}
