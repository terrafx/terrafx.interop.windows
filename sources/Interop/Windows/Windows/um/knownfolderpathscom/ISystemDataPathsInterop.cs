// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/knownfolderpathscom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop"]/*' />
[Guid("864D0B26-3A37-4251-9A02-B231198DE060")]
[NativeTypeName("struct ISystemDataPathsInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISystemDataPathsInterop : ISystemDataPathsInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemDataPathsInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, uint>)(lpVtbl[1]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, uint>)(lpVtbl[2]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonAdminTools"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_CommonAdminTools([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[3]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonOemLinks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_CommonOemLinks([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[4]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonPrograms"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_CommonPrograms([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[5]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonStartMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommonStartMenu([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[6]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonStartup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CommonStartup([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[7]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_CommonTemplates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CommonTemplates([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[8]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_LocalizedResources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LocalizedResources([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[9]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProgramFiles([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[10]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesCommon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ProgramFilesCommon([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[11]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesCommonHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ProgramFilesCommonHost([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[12]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesCommonX64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ProgramFilesCommonX64([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[13]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesCommonX86"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProgramFilesCommonX86([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[14]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesCommonArm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ProgramFilesCommonArm([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[15]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ProgramFilesHost([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[16]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesX64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ProgramFilesX64([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[17]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesX86"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ProgramFilesX86([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[18]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_ProgramFilesArm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ProgramFilesArm([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[19]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPathsInterop.xml' path='doc/member[@name="ISystemDataPathsInterop.get_Resource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Resource([NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPathsInterop*, char**, int>)(lpVtbl[20]))((ISystemDataPathsInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_CommonAdminTools([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(4)]
        HRESULT get_CommonOemLinks([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(5)]
        HRESULT get_CommonPrograms([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(6)]
        HRESULT get_CommonStartMenu([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(7)]
        HRESULT get_CommonStartup([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(8)]
        HRESULT get_CommonTemplates([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(9)]
        HRESULT get_LocalizedResources([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(10)]
        HRESULT get_ProgramFiles([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(11)]
        HRESULT get_ProgramFilesCommon([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(12)]
        HRESULT get_ProgramFilesCommonHost([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(13)]
        HRESULT get_ProgramFilesCommonX64([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(14)]
        HRESULT get_ProgramFilesCommonX86([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(15)]
        HRESULT get_ProgramFilesCommonArm([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(16)]
        HRESULT get_ProgramFilesHost([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(17)]
        HRESULT get_ProgramFilesX64([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(18)]
        HRESULT get_ProgramFilesX86([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(19)]
        HRESULT get_ProgramFilesArm([NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(20)]
        HRESULT get_Resource([NativeTypeName("LPWSTR *")] char** value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonAdminTools;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonOemLinks;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonPrograms;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonStartMenu;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonStartup;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_CommonTemplates;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_LocalizedResources;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFiles;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesCommon;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesCommonHost;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesCommonX64;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesCommonX86;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesCommonArm;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesHost;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesX64;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesX86;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ProgramFilesArm;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Resource;
    }
}
