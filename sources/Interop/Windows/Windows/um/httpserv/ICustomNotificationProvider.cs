// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICustomNotificationProvider.xml' path='doc/member[@name="ICustomNotificationProvider"]/*' />
[Guid("671E6D34-9380-4DF4-B453-91129DF02B24")]
[NativeTypeName("struct ICustomNotificationProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct ICustomNotificationProvider : ICustomNotificationProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICustomNotificationProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<ICustomNotificationProvider*, HRESULT, void>)(lpVtbl[0]))((ICustomNotificationProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='ICustomNotificationProvider.xml' path='doc/member[@name="ICustomNotificationProvider.QueryNotificationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* QueryNotificationType()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomNotificationProvider*, char*>)(lpVtbl[1]))((ICustomNotificationProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* QueryNotificationType();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> QueryNotificationType;
    }
}
