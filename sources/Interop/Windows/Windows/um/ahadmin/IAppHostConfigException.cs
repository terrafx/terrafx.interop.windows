// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException"]/*' />
[Guid("4DFA1DF3-8900-4BC7-BBB5-D1A458C52410")]
[NativeTypeName("struct IAppHostConfigException : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigException : IAppHostConfigException.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConfigException));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, uint>)(lpVtbl[1]))((IAppHostConfigException*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, uint>)(lpVtbl[2]))((IAppHostConfigException*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_LineNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_LineNumber([NativeTypeName("ULONG *")] uint* pcLineNumber)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, uint*, int>)(lpVtbl[3]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pcLineNumber);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_FileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FileName([NativeTypeName("BSTR *")] char** pbstrFileName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[4]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrFileName);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_ConfigPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_ConfigPath([NativeTypeName("BSTR *")] char** pbstrConfigPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[5]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrConfigPath);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_ErrorLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ErrorLine([NativeTypeName("BSTR *")] char** pbstrErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[6]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrErrorLine);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_PreErrorLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreErrorLine([NativeTypeName("BSTR *")] char** pbstrPreErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[7]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrPreErrorLine);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_PostErrorLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PostErrorLine([NativeTypeName("BSTR *")] char** pbstrPostErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[8]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrPostErrorLine);
    }

    /// <include file='IAppHostConfigException.xml' path='doc/member[@name="IAppHostConfigException.get_ErrorString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ErrorString([NativeTypeName("BSTR *")] char** pbstrErrorString)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigException*, char**, int>)(lpVtbl[9]))((IAppHostConfigException*)Unsafe.AsPointer(ref this), pbstrErrorString);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_LineNumber([NativeTypeName("ULONG *")] uint* pcLineNumber);

        [VtblIndex(4)]
        HRESULT get_FileName([NativeTypeName("BSTR *")] char** pbstrFileName);

        [VtblIndex(5)]
        HRESULT get_ConfigPath([NativeTypeName("BSTR *")] char** pbstrConfigPath);

        [VtblIndex(6)]
        HRESULT get_ErrorLine([NativeTypeName("BSTR *")] char** pbstrErrorLine);

        [VtblIndex(7)]
        HRESULT get_PreErrorLine([NativeTypeName("BSTR *")] char** pbstrPreErrorLine);

        [VtblIndex(8)]
        HRESULT get_PostErrorLine([NativeTypeName("BSTR *")] char** pbstrPostErrorLine);

        [VtblIndex(9)]
        HRESULT get_ErrorString([NativeTypeName("BSTR *")] char** pbstrErrorString);
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_LineNumber;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_FileName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ConfigPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_PreErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_PostErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ErrorString;
    }
}
