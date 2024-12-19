// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMetadataInfo.xml' path='doc/member[@name="IMetadataInfo"]/*' />
[Guid("48B10633-825D-495E-93B0-225380053E8E")]
public unsafe partial struct IMetadataInfo : IMetadataInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMetadataInfo));

    public void** lpVtbl;

    /// <include file='IMetadataInfo.xml' path='doc/member[@name="IMetadataInfo.GetMetaPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetMetaPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetadataInfo*, char*>)(lpVtbl[0]))((IMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMetadataInfo.xml' path='doc/member[@name="IMetadataInfo.GetVrPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetVrPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetadataInfo*, char*>)(lpVtbl[1]))((IMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMetadataInfo.xml' path='doc/member[@name="IMetadataInfo.GetVrToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpTokenEntry* GetVrToken()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetadataInfo*, IHttpTokenEntry*>)(lpVtbl[2]))((IMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMetadataInfo.xml' path='doc/member[@name="IMetadataInfo.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IMetadataInfo*, IHttpModuleContextContainer*>)(lpVtbl[3]))((IMetadataInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        char* GetMetaPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetVrPath();

        [VtblIndex(2)]
        IHttpTokenEntry* GetVrToken();

        [VtblIndex(3)]
        IHttpModuleContextContainer* GetModuleContextContainer();
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
    }
}
