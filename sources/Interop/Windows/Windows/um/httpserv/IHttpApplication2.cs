// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpApplication2.xml' path='doc/member[@name="IHttpApplication2"]/*' />
[Guid("311A3B7A-B673-4A1C-8349-2E98A23CADCB")]
[NativeTypeName("struct IHttpApplication2 : IHttpApplication")]
[NativeInheritance("IHttpApplication")]
public unsafe partial struct IHttpApplication2 : IHttpApplication2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpApplication2);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpApplication.GetApplicationPhysicalPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetApplicationPhysicalPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, char*>)(lpVtbl[0]))((IHttpApplication2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpApplication.GetApplicationId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetApplicationId()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, char*>)(lpVtbl[1]))((IHttpApplication2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpApplication.GetAppConfigPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetAppConfigPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, char*>)(lpVtbl[2]))((IHttpApplication2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpApplication.GetModuleContextContainer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, IHttpModuleContextContainer*>)(lpVtbl[3]))((IHttpApplication2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication2.xml' path='doc/member[@name="IHttpApplication2.BeginApplicationWarmup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void BeginApplicationWarmup()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, void>)(lpVtbl[4]))((IHttpApplication2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication2.xml' path='doc/member[@name="IHttpApplication2.EndApplicationWarmup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void EndApplicationWarmup()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, void>)(lpVtbl[5]))((IHttpApplication2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpApplication2.xml' path='doc/member[@name="IHttpApplication2.QueryIsWarmingUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL QueryIsWarmingUp()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpApplication2*, int>)(lpVtbl[6]))((IHttpApplication2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpApplication.Interface
    {
        [VtblIndex(4)]
        void BeginApplicationWarmup();

        [VtblIndex(5)]
        void EndApplicationWarmup();

        [VtblIndex(6)]
        BOOL QueryIsWarmingUp();
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

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> BeginApplicationWarmup;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> EndApplicationWarmup;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> QueryIsWarmingUp;
    }
}
