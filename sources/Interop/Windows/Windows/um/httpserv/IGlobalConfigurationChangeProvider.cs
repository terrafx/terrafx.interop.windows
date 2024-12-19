// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalConfigurationChangeProvider.xml' path='doc/member[@name="IGlobalConfigurationChangeProvider"]/*' />
[Guid("3405F3B4-B3D6-4B73-B5F5-4D8A3CC642CE")]
[NativeTypeName("struct IGlobalConfigurationChangeProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalConfigurationChangeProvider : IGlobalConfigurationChangeProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalConfigurationChangeProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalConfigurationChangeProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalConfigurationChangeProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalConfigurationChangeProvider.xml' path='doc/member[@name="IGlobalConfigurationChangeProvider.GetChangePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetChangePath()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalConfigurationChangeProvider*, char*>)(lpVtbl[1]))((IGlobalConfigurationChangeProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetChangePath();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetChangePath;
    }
}
