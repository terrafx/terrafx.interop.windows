// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpModuleRegistrationInfo2.xml' path='doc/member[@name="IHttpModuleRegistrationInfo2"]/*' />
[Guid("4FD11CBF-8CC5-418E-8000-C9E765F88533")]
[NativeTypeName("struct IHttpModuleRegistrationInfo2 : IHttpModuleRegistrationInfo")]
[NativeInheritance("IHttpModuleRegistrationInfo")]
public unsafe partial struct IHttpModuleRegistrationInfo2 : IHttpModuleRegistrationInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpModuleRegistrationInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.GetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, char*>)(lpVtbl[0]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.GetId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_MODULE_ID")]
    public void* GetId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, void*>)(lpVtbl[1]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.SetRequestNotifications" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetRequestNotifications(IHttpModuleFactory* pModuleFactory, [NativeTypeName("DWORD")] uint dwRequestNotifications, [NativeTypeName("DWORD")] uint dwPostRequestNotifications)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, IHttpModuleFactory*, uint, uint, int>)(lpVtbl[2]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this), pModuleFactory, dwRequestNotifications, dwPostRequestNotifications);
    }

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.SetGlobalNotifications" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGlobalNotifications(CGlobalModule* pGlobalModule, [NativeTypeName("DWORD")] uint dwGlobalNotifications)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, CGlobalModule*, uint, int>)(lpVtbl[3]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this), pGlobalModule, dwGlobalNotifications);
    }

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.SetPriorityForRequestNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPriorityForRequestNotification([NativeTypeName("DWORD")] uint dwRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, uint, char*, int>)(lpVtbl[4]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this), dwRequestNotification, pszPriority);
    }

    /// <inheritdoc cref="IHttpModuleRegistrationInfo.SetPriorityForGlobalNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPriorityForGlobalNotification([NativeTypeName("DWORD")] uint dwGlobalNotification, [NativeTypeName("PCWSTR")] char* pszPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, uint, char*, int>)(lpVtbl[5]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this), dwGlobalNotification, pszPriority);
    }

    /// <include file='IHttpModuleRegistrationInfo2.xml' path='doc/member[@name="IHttpModuleRegistrationInfo2.SetPriorityForPostRequestNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPriorityForPostRequestNotification([NativeTypeName("DWORD")] uint dwPostRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo2*, uint, char*, int>)(lpVtbl[6]))((IHttpModuleRegistrationInfo2*)Unsafe.AsPointer(ref this), dwPostRequestNotification, pszPriority);
    }

    public interface Interface : IHttpModuleRegistrationInfo.Interface
    {
        [VtblIndex(6)]
        HRESULT SetPriorityForPostRequestNotification([NativeTypeName("DWORD")] uint dwPostRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriority);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetName;

        [NativeTypeName("HTTP_MODULE_ID () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetId;

        [NativeTypeName("HRESULT (IHttpModuleFactory *, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleFactory*, uint, uint, int> SetRequestNotifications;

        [NativeTypeName("HRESULT (CGlobalModule *, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CGlobalModule*, uint, int> SetGlobalNotifications;

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetPriorityForRequestNotification;

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetPriorityForGlobalNotification;

        [NativeTypeName("HRESULT (DWORD, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetPriorityForPostRequestNotification;
    }
}
