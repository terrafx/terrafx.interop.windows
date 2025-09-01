// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalFileChangeProvider.xml' path='doc/member[@name="IGlobalFileChangeProvider"]/*' />
[Guid("ECE31EE5-0486-4FB0-A875-6739A2D7DAF5")]
[NativeTypeName("struct IGlobalFileChangeProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalFileChangeProvider : IGlobalFileChangeProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGlobalFileChangeProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalFileChangeProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalFileChangeProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalFileChangeProvider.xml' path='doc/member[@name="IGlobalFileChangeProvider.GetFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetFileName()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalFileChangeProvider*, char*>)(lpVtbl[1]))((IGlobalFileChangeProvider*)Unsafe.AsPointer(in this));
    }

    /// <include file='IGlobalFileChangeProvider.xml' path='doc/member[@name="IGlobalFileChangeProvider.GetFileMonitor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpFileMonitor* GetFileMonitor()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalFileChangeProvider*, IHttpFileMonitor*>)(lpVtbl[2]))((IGlobalFileChangeProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetFileName();

        [VtblIndex(2)]
        IHttpFileMonitor* GetFileMonitor();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetFileName;

        [NativeTypeName("IHttpFileMonitor *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpFileMonitor*> GetFileMonitor;
    }
}
