// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser"]/*' />
[Guid("8059E6F8-10CE-4D61-B47E-5A1D8D9A8B67")]
public unsafe partial struct IHttpUser : IHttpUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpUser);

    public void** lpVtbl;

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetRemoteUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetRemoteUserName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, char*>)(lpVtbl[0]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetUserNameW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetUserNameW()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, char*>)(lpVtbl[1]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetAuthenticationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetAuthenticationType()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, char*>)(lpVtbl[2]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetPassword()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, char*>)(lpVtbl[3]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetImpersonationToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HANDLE GetImpersonationToken()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpUser*, void*>)(lpVtbl[4]))((IHttpUser*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetPrimaryToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HANDLE GetPrimaryToken()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpUser*, void*>)(lpVtbl[5]))((IHttpUser*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.ReferenceUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void ReferenceUser()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpUser*, void>)(lpVtbl[6]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.DereferenceUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void DereferenceUser()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpUser*, void>)(lpVtbl[7]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.SupportsIsInRole"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL SupportsIsInRole()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, int>)(lpVtbl[8]))((IHttpUser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.IsInRole"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsInRole([NativeTypeName("PCWSTR")] char* pszRoleName, BOOL* pfInRole)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, char*, BOOL*, int>)(lpVtbl[9]))((IHttpUser*)Unsafe.AsPointer(ref this), pszRoleName, pfInRole);
    }

    /// <include file='IHttpUser.xml' path='doc/member[@name="IHttpUser.GetUserVariable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("PVOID")]
    public void* GetUserVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpUser*, sbyte*, void*>)(lpVtbl[10]))((IHttpUser*)Unsafe.AsPointer(ref this), pszVariableName);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        char* GetRemoteUserName();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetUserNameW();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        char* GetAuthenticationType();

        [VtblIndex(3)]
        [return: NativeTypeName("PCWSTR")]
        char* GetPassword();

        [VtblIndex(4)]
        HANDLE GetImpersonationToken();

        [VtblIndex(5)]
        HANDLE GetPrimaryToken();

        [VtblIndex(6)]
        void ReferenceUser();

        [VtblIndex(7)]
        void DereferenceUser();

        [VtblIndex(8)]
        BOOL SupportsIsInRole();

        [VtblIndex(9)]
        HRESULT IsInRole([NativeTypeName("PCWSTR")] char* pszRoleName, BOOL* pfInRole);

        [VtblIndex(10)]
        [return: NativeTypeName("PVOID")]
        void* GetUserVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetRemoteUserName;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetUserNameW;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetAuthenticationType;

        [NativeTypeName("PCWSTR ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetPassword;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetImpersonationToken;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetPrimaryToken;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ReferenceUser;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DereferenceUser;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SupportsIsInRole;

        [NativeTypeName("HRESULT (PCWSTR, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> IsInRole;

        [NativeTypeName("PVOID (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, void*> GetUserVariable;
    }
}
