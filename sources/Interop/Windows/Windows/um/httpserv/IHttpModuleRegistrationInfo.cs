// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo"]/*' />
[Guid("07E5BEB3-B798-459D-A98A-E6C485B2B3BC")]
public unsafe partial struct IHttpModuleRegistrationInfo : IHttpModuleRegistrationInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpModuleRegistrationInfo);

    public void** lpVtbl;

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, char*>)(lpVtbl[0]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.GetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("HTTP_MODULE_ID")]
    public readonly void* GetId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, void*>)(lpVtbl[1]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.SetRequestNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetRequestNotifications(IHttpModuleFactory* pModuleFactory, [NativeTypeName("DWORD")] uint dwRequestNotifications, [NativeTypeName("DWORD")] uint dwPostRequestNotifications)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, IHttpModuleFactory*, uint, uint, int>)(lpVtbl[2]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this), pModuleFactory, dwRequestNotifications, dwPostRequestNotifications);
    }

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.SetGlobalNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGlobalNotifications(CGlobalModule* pGlobalModule, [NativeTypeName("DWORD")] uint dwGlobalNotifications)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, CGlobalModule*, uint, int>)(lpVtbl[3]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this), pGlobalModule, dwGlobalNotifications);
    }

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.SetPriorityForRequestNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPriorityForRequestNotification([NativeTypeName("DWORD")] uint dwRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, uint, char*, int>)(lpVtbl[4]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this), dwRequestNotification, pszPriority);
    }

    /// <include file='IHttpModuleRegistrationInfo.xml' path='doc/member[@name="IHttpModuleRegistrationInfo.SetPriorityForGlobalNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPriorityForGlobalNotification([NativeTypeName("DWORD")] uint dwGlobalNotification, [NativeTypeName("PCWSTR")] char* pszPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleRegistrationInfo*, uint, char*, int>)(lpVtbl[5]))((IHttpModuleRegistrationInfo*)Unsafe.AsPointer(ref this), dwGlobalNotification, pszPriority);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        char* GetName();

        [VtblIndex(1)]
        [return: NativeTypeName("HTTP_MODULE_ID")]
        void* GetId();

        [VtblIndex(2)]
        HRESULT SetRequestNotifications(IHttpModuleFactory* pModuleFactory, [NativeTypeName("DWORD")] uint dwRequestNotifications, [NativeTypeName("DWORD")] uint dwPostRequestNotifications);

        [VtblIndex(3)]
        HRESULT SetGlobalNotifications(CGlobalModule* pGlobalModule, [NativeTypeName("DWORD")] uint dwGlobalNotifications);

        [VtblIndex(4)]
        HRESULT SetPriorityForRequestNotification([NativeTypeName("DWORD")] uint dwRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriority);

        [VtblIndex(5)]
        HRESULT SetPriorityForGlobalNotification([NativeTypeName("DWORD")] uint dwGlobalNotification, [NativeTypeName("PCWSTR")] char* pszPriority);
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
    }
}
