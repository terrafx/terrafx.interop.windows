// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpConnection.xml' path='doc/member[@name="IHttpConnection"]/*' />
[Guid("D9A5DE00-3346-4599-9826-FE88565E1226")]
public unsafe partial struct IHttpConnection : IHttpConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpConnection);

    public void** lpVtbl;

    /// <include file='IHttpConnection.xml' path='doc/member[@name="IHttpConnection.IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public readonly BOOL IsConnected()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnection*, int>)(lpVtbl[0]))((IHttpConnection*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpConnection.xml' path='doc/member[@name="IHttpConnection.AllocateMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnection*, uint, void*>)(lpVtbl[1]))((IHttpConnection*)Unsafe.AsPointer(ref this), cbAllocation);
    }

    /// <include file='IHttpConnection.xml' path='doc/member[@name="IHttpConnection.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpConnectionModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnection*, IHttpConnectionModuleContextContainer*>)(lpVtbl[2]))((IHttpConnection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsConnected();

        [VtblIndex(1)]
        void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation);

        [VtblIndex(2)]
        IHttpConnectionModuleContextContainer* GetModuleContextContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsConnected;

        [NativeTypeName("void *(DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*> AllocateMemory;

        [NativeTypeName("IHttpConnectionModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpConnectionModuleContextContainer*> GetModuleContextContainer;
    }
}
