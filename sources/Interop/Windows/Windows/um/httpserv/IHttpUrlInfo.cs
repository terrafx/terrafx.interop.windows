// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpUrlInfo.xml' path='doc/member[@name="IHttpUrlInfo"]/*' />
[Guid("7E0E6167-0094-49A1-8287-ECF6DC6E73A6")]
public unsafe partial struct IHttpUrlInfo : IHttpUrlInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpUrlInfo));

    public void** lpVtbl;

    /// <include file='IHttpUrlInfo.xml' path='doc/member[@name="IHttpUrlInfo.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUrlInfo*, IHttpModuleContextContainer*>)(lpVtbl[0]))((IHttpUrlInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUrlInfo.xml' path='doc/member[@name="IHttpUrlInfo.IsFrequentlyHit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public BOOL IsFrequentlyHit()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUrlInfo*, int>)(lpVtbl[1]))((IHttpUrlInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(1)]
        BOOL IsFrequentlyHit();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsFrequentlyHit;
    }
}
