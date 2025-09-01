// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpApplicationProvider.xml' path='doc/member[@name="IHttpApplicationProvider"]/*' />
[Guid("1DE2C71C-C126-4512-AED3-F4F885E14997")]
[NativeTypeName("struct IHttpApplicationProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IHttpApplicationProvider : IHttpApplicationProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpApplicationProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpApplicationProvider*, HRESULT, void>)(lpVtbl[0]))((IHttpApplicationProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IHttpApplicationProvider.xml' path='doc/member[@name="IHttpApplicationProvider.GetApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplicationProvider*, IHttpApplication*>)(lpVtbl[1]))((IHttpApplicationProvider*)Unsafe.AsPointer(ref this));
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
