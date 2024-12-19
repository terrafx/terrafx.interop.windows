// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMapPathProvider.xml' path='doc/member[@name="IMapPathProvider"]/*' />
[Guid("8EFDF557-A8F1-4BC9-B462-6DF3B038A59A")]
[NativeTypeName("struct IMapPathProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IMapPathProvider : IMapPathProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMapPathProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IMapPathProvider*, HRESULT, void>)(lpVtbl[0]))((IMapPathProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IMapPathProvider.xml' path='doc/member[@name="IMapPathProvider.GetUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetUrl()
    {
        return ((delegate* unmanaged[MemberFunction]<IMapPathProvider*, char*>)(lpVtbl[1]))((IMapPathProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMapPathProvider.xml' path='doc/member[@name="IMapPathProvider.GetPhysicalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetPhysicalPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IMapPathProvider*, char*>)(lpVtbl[2]))((IMapPathProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMapPathProvider.xml' path='doc/member[@name="IMapPathProvider.SetPhysicalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPhysicalPath([NativeTypeName("PCWSTR")] char* pszPhysicalPath, [NativeTypeName("DWORD")] uint cchPhysicalPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IMapPathProvider*, char*, uint, int>)(lpVtbl[3]))((IMapPathProvider*)Unsafe.AsPointer(ref this), pszPhysicalPath, cchPhysicalPath);
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetUrl();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        char* GetPhysicalPath();

        [VtblIndex(3)]
        HRESULT SetPhysicalPath([NativeTypeName("PCWSTR")] char* pszPhysicalPath, [NativeTypeName("DWORD")] uint cchPhysicalPath);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetUrl;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetPhysicalPath;

        [NativeTypeName("HRESULT (PCWSTR, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetPhysicalPath;
    }
}
