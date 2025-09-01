// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpSite.xml' path='doc/member[@name="IHttpSite"]/*' />
[Guid("EB16A6EC-BA5D-436F-BF24-3EDE13906450")]
public unsafe partial struct IHttpSite : IHttpSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpSite);

    public void** lpVtbl;

    /// <include file='IHttpSite.xml' path='doc/member[@name="IHttpSite.GetSiteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetSiteId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpSite*, uint>)(lpVtbl[0]))((IHttpSite*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpSite.xml' path='doc/member[@name="IHttpSite.GetSiteName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetSiteName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpSite*, char*>)(lpVtbl[1]))((IHttpSite*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpSite.xml' path='doc/member[@name="IHttpSite.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpSite*, IHttpModuleContextContainer*>)(lpVtbl[2]))((IHttpSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpSite.xml' path='doc/member[@name="IHttpSite.GetPerfCounterInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpSite*, IHttpPerfCounterInfo*>)(lpVtbl[3]))((IHttpSite*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("DWORD")]
        uint GetSiteId();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetSiteName();

        [VtblIndex(2)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(3)]
        IHttpPerfCounterInfo* GetPerfCounterInfo();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetSiteId;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetSiteName;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("IHttpPerfCounterInfo *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpPerfCounterInfo*> GetPerfCounterInfo;
    }
}
