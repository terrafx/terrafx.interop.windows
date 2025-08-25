// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalThreadCleanupProvider.xml' path='doc/member[@name="IGlobalThreadCleanupProvider"]/*' />
[Guid("6B36A149-8620-45A0-8197-00814A706E2E")]
[NativeTypeName("struct IGlobalThreadCleanupProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalThreadCleanupProvider : IGlobalThreadCleanupProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGlobalThreadCleanupProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalThreadCleanupProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalThreadCleanupProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalThreadCleanupProvider.xml' path='doc/member[@name="IGlobalThreadCleanupProvider.GetApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalThreadCleanupProvider*, IHttpApplication*>)(lpVtbl[1]))((IGlobalThreadCleanupProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        IHttpApplication* GetApplication();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("IHttpApplication *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplication*> GetApplication;
    }
}
