// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo"]/*' />
[Guid("D7FE3D77-68BC-4D4A-851F-EEC9FB68017C")]
public unsafe partial struct IScriptMapInfo : IScriptMapInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IScriptMapInfo);

    public void** lpVtbl;

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetPath()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, char*>)(lpVtbl[0]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetAllowedVerbs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetAllowedVerbs()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, sbyte*>)(lpVtbl[1]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetModules"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetModules([NativeTypeName("DWORD *")] uint* pcchModules = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint*, char*>)(lpVtbl[2]))((IScriptMapInfo*)Unsafe.AsPointer(in this), pcchModules);
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetScriptProcessor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetScriptProcessor([NativeTypeName("DWORD *")] uint* pcchScriptProcessor = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint*, char*>)(lpVtbl[3]))((IScriptMapInfo*)Unsafe.AsPointer(in this), pcchScriptProcessor);
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetManagedType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetManagedType([NativeTypeName("DWORD *")] uint* pcchManagedType = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint*, char*>)(lpVtbl[4]))((IScriptMapInfo*)Unsafe.AsPointer(in this), pcchManagedType);
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetAllowPathInfoForScriptMappings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public readonly BOOL GetAllowPathInfoForScriptMappings()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, int>)(lpVtbl[5]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetRequiredAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetRequiredAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint>)(lpVtbl[6]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetResourceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetResourceType()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint>)(lpVtbl[7]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetIsStarScriptMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public readonly BOOL GetIsStarScriptMap()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, int>)(lpVtbl[8]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetResponseBufferLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetResponseBufferLimit()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, uint>)(lpVtbl[9]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    /// <include file='IScriptMapInfo.xml' path='doc/member[@name="IScriptMapInfo.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetName()
    {
        return ((delegate* unmanaged[MemberFunction]<IScriptMapInfo*, char*>)(lpVtbl[10]))((IScriptMapInfo*)Unsafe.AsPointer(in this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        char* GetPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetAllowedVerbs();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        char* GetModules([NativeTypeName("DWORD *")] uint* pcchModules = null);

        [VtblIndex(3)]
        [return: NativeTypeName("PCWSTR")]
        char* GetScriptProcessor([NativeTypeName("DWORD *")] uint* pcchScriptProcessor = null);

        [VtblIndex(4)]
        [return: NativeTypeName("PCWSTR")]
        char* GetManagedType([NativeTypeName("DWORD *")] uint* pcchManagedType = null);

        [VtblIndex(5)]
        BOOL GetAllowPathInfoForScriptMappings();

        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        uint GetRequiredAccess();

        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        uint GetResourceType();

        [VtblIndex(8)]
        BOOL GetIsStarScriptMap();

        [VtblIndex(9)]
        [return: NativeTypeName("DWORD")]
        uint GetResponseBufferLimit();

        [VtblIndex(10)]
        [return: NativeTypeName("PCWSTR")]
        char* GetName();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetPath;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetAllowedVerbs;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetModules;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetScriptProcessor;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetManagedType;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetAllowPathInfoForScriptMappings;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetRequiredAccess;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetResourceType;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetIsStarScriptMap;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetResponseBufferLimit;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetName;
    }
}
