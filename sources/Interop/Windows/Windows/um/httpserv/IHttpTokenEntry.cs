// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpTokenEntry.xml' path='doc/member[@name="IHttpTokenEntry"]/*' />
[Guid("FD86E6DE-FB0E-47DD-820A-E0DA12BE46E9")]
[NativeTypeName("struct IHttpTokenEntry : IHttpCacheSpecificData")]
[NativeInheritance("IHttpCacheSpecificData")]
public unsafe partial struct IHttpTokenEntry : IHttpTokenEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpTokenEntry));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpCacheSpecificData.GetCacheKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, IHttpCacheKey*>)(lpVtbl[0]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.ReferenceCacheData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void ReferenceCacheData()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void>)(lpVtbl[1]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.DereferenceCacheData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void DereferenceCacheData()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void>)(lpVtbl[2]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.ResetTTL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ResetTTL()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void>)(lpVtbl[3]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.DecrementTTL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementTTL(BOOL* pfTTLExpired)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, BOOL*, void>)(lpVtbl[4]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this), pfTTLExpired);
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.SetFlushed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetFlushed()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void>)(lpVtbl[5]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.GetFlushed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetFlushed()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, int>)(lpVtbl[6]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpTokenEntry.xml' path='doc/member[@name="IHttpTokenEntry.GetImpersonationToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HANDLE GetImpersonationToken()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void*>)(lpVtbl[7]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IHttpTokenEntry.xml' path='doc/member[@name="IHttpTokenEntry.GetPrimaryToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HANDLE GetPrimaryToken()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void*>)(lpVtbl[8]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IHttpTokenEntry.xml' path='doc/member[@name="IHttpTokenEntry.GetSid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("PSID")]
    public void* GetSid()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTokenEntry*, void*>)(lpVtbl[9]))((IHttpTokenEntry*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpCacheSpecificData.Interface
    {
        [VtblIndex(7)]
        HANDLE GetImpersonationToken();

        [VtblIndex(8)]
        HANDLE GetPrimaryToken();

        [VtblIndex(9)]
        [return: NativeTypeName("PSID")]
        void* GetSid();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpCacheKey *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCacheKey*> GetCacheKey;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ReferenceCacheData;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DereferenceCacheData;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ResetTTL;

        [NativeTypeName("void (BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, void> DecrementTTL;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetFlushed;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetFlushed;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetImpersonationToken;

        [NativeTypeName("HANDLE ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetPrimaryToken;

        [NativeTypeName("PSID ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetSid;
    }
}
