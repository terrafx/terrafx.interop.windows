// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpApplicationResolveModulesProvider.xml' path='doc/member[@name="IHttpApplicationResolveModulesProvider"]/*' />
[Guid("0617D9B9-E20F-4A9F-94F9-35403B3BE01E")]
[NativeTypeName("struct IHttpApplicationResolveModulesProvider : IHttpApplicationProvider")]
[NativeInheritance("IHttpApplicationProvider")]
public unsafe partial struct IHttpApplicationResolveModulesProvider : IHttpApplicationResolveModulesProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpApplicationResolveModulesProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpApplicationResolveModulesProvider*, HRESULT, void>)(lpVtbl[0]))((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <inheritdoc cref="IHttpApplicationProvider.GetApplication" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplicationResolveModulesProvider*, IHttpApplication*>)(lpVtbl[1]))((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplicationResolveModulesProvider.xml' path='doc/member[@name="IHttpApplicationResolveModulesProvider.RegisterModule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT RegisterModule([NativeTypeName("HTTP_MODULE_ID")] void* parentModuleId, IHttpModuleFactory* pModuleFactory, [NativeTypeName("PCWSTR")] char* pszModuleName, [NativeTypeName("PCWSTR")] char* pszModuleType, [NativeTypeName("PCWSTR")] char* pszModulePreCondition, [NativeTypeName("DWORD")] uint dwRequestNotifications, [NativeTypeName("DWORD")] uint dwPostRequestNotifications)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplicationResolveModulesProvider*, void*, IHttpModuleFactory*, char*, char*, char*, uint, uint, int>)(lpVtbl[2]))((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this), parentModuleId, pModuleFactory, pszModuleName, pszModuleType, pszModulePreCondition, dwRequestNotifications, dwPostRequestNotifications);
    }

    /// <include file='IHttpApplicationResolveModulesProvider.xml' path='doc/member[@name="IHttpApplicationResolveModulesProvider.SetPriorityForRequestNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPriorityForRequestNotification([NativeTypeName("PCWSTR")] char* pszModuleName, [NativeTypeName("DWORD")] uint dwRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriorityAlias)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplicationResolveModulesProvider*, char*, uint, char*, int>)(lpVtbl[3]))((IHttpApplicationResolveModulesProvider*)Unsafe.AsPointer(ref this), pszModuleName, dwRequestNotification, pszPriorityAlias);
    }

    public interface Interface : IHttpApplicationProvider.Interface
    {
        [VtblIndex(2)]
        HRESULT RegisterModule([NativeTypeName("HTTP_MODULE_ID")] void* parentModuleId, IHttpModuleFactory* pModuleFactory, [NativeTypeName("PCWSTR")] char* pszModuleName, [NativeTypeName("PCWSTR")] char* pszModuleType, [NativeTypeName("PCWSTR")] char* pszModulePreCondition, [NativeTypeName("DWORD")] uint dwRequestNotifications, [NativeTypeName("DWORD")] uint dwPostRequestNotifications);

        [VtblIndex(3)]
        HRESULT SetPriorityForRequestNotification([NativeTypeName("PCWSTR")] char* pszModuleName, [NativeTypeName("DWORD")] uint dwRequestNotification, [NativeTypeName("PCWSTR")] char* pszPriorityAlias);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("IHttpApplication *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplication*> GetApplication;

        [NativeTypeName("HRESULT (HTTP_MODULE_ID, IHttpModuleFactory *, PCWSTR, PCWSTR, PCWSTR, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, IHttpModuleFactory*, char*, char*, char*, uint, uint, int> RegisterModule;

        [NativeTypeName("HRESULT (PCWSTR, DWORD, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, char*, int> SetPriorityForRequestNotification;
    }
}
