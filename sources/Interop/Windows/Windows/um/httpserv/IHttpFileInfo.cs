// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo"]/*' />
[Guid("71E95595-8C74-44D9-88A9-F5112D5F5900")]
[NativeTypeName("struct IHttpFileInfo : IHttpCacheSpecificData")]
[NativeInheritance("IHttpCacheSpecificData")]
public unsafe partial struct IHttpFileInfo : IHttpFileInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpFileInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpCacheSpecificData.GetCacheKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public readonly IHttpCacheKey* GetCacheKey()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, IHttpCacheKey*>)(lpVtbl[0]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.ReferenceCacheData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void ReferenceCacheData()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void>)(lpVtbl[1]))((IHttpFileInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.DereferenceCacheData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void DereferenceCacheData()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void>)(lpVtbl[2]))((IHttpFileInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.ResetTTL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ResetTTL()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void>)(lpVtbl[3]))((IHttpFileInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.DecrementTTL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementTTL(BOOL* pfTTLExpired)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, BOOL*, void>)(lpVtbl[4]))((IHttpFileInfo*)Unsafe.AsPointer(ref this), pfTTLExpired);
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.SetFlushed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetFlushed()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void>)(lpVtbl[5]))((IHttpFileInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCacheSpecificData.GetFlushed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public readonly BOOL GetFlushed()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, int>)(lpVtbl[6]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetAttributes()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, uint>)(lpVtbl[7]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public readonly void GetSize(ULARGE_INTEGER* pliSize)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, ULARGE_INTEGER*, void>)(lpVtbl[8]))((IHttpFileInfo*)Unsafe.AsPointer(in this), pliSize);
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetFileBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("const BYTE *")]
    public readonly byte* GetFileBuffer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, byte*>)(lpVtbl[9]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetFileHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public readonly HANDLE GetFileHandle()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void*>)(lpVtbl[10]))((IHttpFileInfo*)Unsafe.AsPointer(in this))));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetFilePath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, char*>)(lpVtbl[11]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetETag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetETag(ushort* pcchETag = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, ushort*, sbyte*>)(lpVtbl[12]))((IHttpFileInfo*)Unsafe.AsPointer(in this), pcchETag);
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetLastModifiedTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public readonly void GetLastModifiedTime(FILETIME* pFileTime)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, FILETIME*, void>)(lpVtbl[13]))((IHttpFileInfo*)Unsafe.AsPointer(in this), pFileTime);
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetLastModifiedString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetLastModifiedString()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, sbyte*>)(lpVtbl[14]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetHttpCacheAllowed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public readonly BOOL GetHttpCacheAllowed([NativeTypeName("DWORD *")] uint* pSecondsToLive)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, uint*, int>)(lpVtbl[15]))((IHttpFileInfo*)Unsafe.AsPointer(in this), pSecondsToLive);
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.AccessCheck"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AccessCheck(HANDLE hUserToken, [NativeTypeName("PSID")] void* pUserSid)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, HANDLE, void*, int>)(lpVtbl[16]))((IHttpFileInfo*)Unsafe.AsPointer(ref this), hUserToken, pUserSid);
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetVrToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public readonly HANDLE GetVrToken()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, void*>)(lpVtbl[17]))((IHttpFileInfo*)Unsafe.AsPointer(in this))));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetVrPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetVrPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, char*>)(lpVtbl[18]))((IHttpFileInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, IHttpModuleContextContainer*>)(lpVtbl[19]))((IHttpFileInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpFileInfo.xml' path='doc/member[@name="IHttpFileInfo.CheckIfFileHasChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL CheckIfFileHasChanged(HANDLE hUserToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpFileInfo*, HANDLE, int>)(lpVtbl[20]))((IHttpFileInfo*)Unsafe.AsPointer(ref this), hUserToken);
    }

    public interface Interface : IHttpCacheSpecificData.Interface
    {
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        uint GetAttributes();

        [VtblIndex(8)]
        void GetSize(ULARGE_INTEGER* pliSize);

        [VtblIndex(9)]
        [return: NativeTypeName("const BYTE *")]
        byte* GetFileBuffer();

        [VtblIndex(10)]
        HANDLE GetFileHandle();

        [VtblIndex(11)]
        [return: NativeTypeName("PCWSTR")]
        char* GetFilePath();

        [VtblIndex(12)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetETag(ushort* pcchETag = null);

        [VtblIndex(13)]
        void GetLastModifiedTime(FILETIME* pFileTime);

        [VtblIndex(14)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetLastModifiedString();

        [VtblIndex(15)]
        BOOL GetHttpCacheAllowed([NativeTypeName("DWORD *")] uint* pSecondsToLive);

        [VtblIndex(16)]
        HRESULT AccessCheck(HANDLE hUserToken, [NativeTypeName("PSID")] void* pUserSid);

        [VtblIndex(17)]
        HANDLE GetVrToken();

        [VtblIndex(18)]
        [return: NativeTypeName("PCWSTR")]
        char* GetVrPath();

        [VtblIndex(19)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(20)]
        BOOL CheckIfFileHasChanged(HANDLE hUserToken);
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

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetAttributes;

        [NativeTypeName("void (ULARGE_INTEGER *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER*, void> GetSize;

        [NativeTypeName("const BYTE *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*> GetFileBuffer;

        [NativeTypeName("HANDLE () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetFileHandle;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetFilePath;

        [NativeTypeName("PCSTR (USHORT *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, sbyte*> GetETag;

        [NativeTypeName("void (FILETIME *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FILETIME*, void> GetLastModifiedTime;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetLastModifiedString;

        [NativeTypeName("BOOL (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetHttpCacheAllowed;

        [NativeTypeName("HRESULT (HANDLE, PSID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE, void*, int> AccessCheck;

        [NativeTypeName("HANDLE () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetVrToken;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetVrPath;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("BOOL (HANDLE)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE, int> CheckIfFileHasChanged;
    }
}
