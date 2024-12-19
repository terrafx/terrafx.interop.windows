// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpApplication.xml' path='doc/member[@name="IHttpApplication"]/*' />
[Guid("3F75D9E6-1075-422C-AD89-93A85F2D7BDC")]
public unsafe partial struct IHttpApplication : IHttpApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpApplication));

    public void** lpVtbl;

    /// <include file='IHttpApplication.xml' path='doc/member[@name="IHttpApplication.GetApplicationPhysicalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetApplicationPhysicalPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication*, char*>)(lpVtbl[0]))((IHttpApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication.xml' path='doc/member[@name="IHttpApplication.GetApplicationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetApplicationId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication*, char*>)(lpVtbl[1]))((IHttpApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication.xml' path='doc/member[@name="IHttpApplication.GetAppConfigPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetAppConfigPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication*, char*>)(lpVtbl[2]))((IHttpApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication.xml' path='doc/member[@name="IHttpApplication.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication*, IHttpModuleContextContainer*>)(lpVtbl[3]))((IHttpApplication*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        char* GetApplicationPhysicalPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetApplicationId();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        char* GetAppConfigPath();

        [VtblIndex(3)]
        IHttpModuleContextContainer* GetModuleContextContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetApplicationPhysicalPath;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetApplicationId;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetAppConfigPath;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;
    }
}
