// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IReadEntityProvider.xml' path='doc/member[@name="IReadEntityProvider"]/*' />
[Guid("FE6D905A-99B8-49FD-B389-CFC809562B81")]
[NativeTypeName("struct IReadEntityProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IReadEntityProvider : IReadEntityProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReadEntityProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IReadEntityProvider*, HRESULT, void>)(lpVtbl[0]))((IReadEntityProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IReadEntityProvider.xml' path='doc/member[@name="IReadEntityProvider.GetEntity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void GetEntity([NativeTypeName("PVOID *")] void** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("DWORD *")] uint* pcbBuffer)
    {
        ((delegate* unmanaged[MemberFunction]<IReadEntityProvider*, void**, uint*, uint*, void>)(lpVtbl[1]))((IReadEntityProvider*)Unsafe.AsPointer(ref this), ppBuffer, pcbData, pcbBuffer);
    }

    /// <include file='IReadEntityProvider.xml' path='doc/member[@name="IReadEntityProvider.SetEntity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void SetEntity([NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint cbBuffer)
    {
        ((delegate* unmanaged[MemberFunction]<IReadEntityProvider*, void*, uint, uint, void>)(lpVtbl[2]))((IReadEntityProvider*)Unsafe.AsPointer(ref this), pBuffer, cbData, cbBuffer);
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        void GetEntity([NativeTypeName("PVOID *")] void** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("DWORD *")] uint* pcbBuffer);

        [VtblIndex(2)]
        void SetEntity([NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint cbBuffer);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("void (PVOID *, DWORD *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void**, uint*, uint*, void> GetEntity;

        [NativeTypeName("void (PVOID, DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint, void> SetEntity;
    }
}
