// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpFileMonitor.xml' path='doc/member[@name="IHttpFileMonitor"]/*' />
[Guid("985422DA-B0CF-473B-BA9E-8148CEB3E240")]
public unsafe partial struct IHttpFileMonitor : IHttpFileMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpFileMonitor);

    public void** lpVtbl;

    /// <include file='IHttpFileMonitor.xml' path='doc/member[@name="IHttpFileMonitor.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileMonitor*, IHttpModuleContextContainer*>)(lpVtbl[0]))((IHttpFileMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpFileMonitor.xml' path='doc/member[@name="IHttpFileMonitor.DereferenceFileMonitor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void DereferenceFileMonitor()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileMonitor*, void>)(lpVtbl[1]))((IHttpFileMonitor*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(1)]
        void DereferenceFileMonitor();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DereferenceFileMonitor;
    }
}
