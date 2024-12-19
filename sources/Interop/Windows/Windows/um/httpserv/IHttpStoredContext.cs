// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpStoredContext.xml' path='doc/member[@name="IHttpStoredContext"]/*' />
[Guid("F1927F76-790E-4CCB-A72E-396BDFDAE05D")]
public unsafe partial struct IHttpStoredContext : IHttpStoredContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpStoredContext));

    public void** lpVtbl;

    /// <include file='IHttpStoredContext.xml' path='doc/member[@name="IHttpStoredContext.CleanupStoredContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void CleanupStoredContext()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpStoredContext*, void>)(lpVtbl[0]))((IHttpStoredContext*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void CleanupStoredContext();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> CleanupStoredContext;
    }
}
