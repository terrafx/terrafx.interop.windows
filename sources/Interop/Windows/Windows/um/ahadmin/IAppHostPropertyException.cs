// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPropertyException.xml' path='doc/member[@name="IAppHostPropertyException"]/*' />
[Guid("EAFE4895-A929-41EA-B14D-613E23F62B71")]
[NativeTypeName("struct IAppHostPropertyException : IAppHostConfigException")]
[NativeInheritance("IAppHostConfigException")]
public unsafe partial struct IAppHostPropertyException : IAppHostPropertyException.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostPropertyException);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, uint>)(lpVtbl[1]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, uint>)(lpVtbl[2]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAppHostConfigException.get_LineNumber" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_LineNumber([NativeTypeName("ULONG *")] uint* pcLineNumber)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, uint*, int>)(lpVtbl[3]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pcLineNumber);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_FileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FileName([NativeTypeName("BSTR *")] char** pbstrFileName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[4]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrFileName);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_ConfigPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_ConfigPath([NativeTypeName("BSTR *")] char** pbstrConfigPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[5]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrConfigPath);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_ErrorLine" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ErrorLine([NativeTypeName("BSTR *")] char** pbstrErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[6]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrErrorLine);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_PreErrorLine" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreErrorLine([NativeTypeName("BSTR *")] char** pbstrPreErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[7]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrPreErrorLine);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_PostErrorLine" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PostErrorLine([NativeTypeName("BSTR *")] char** pbstrPostErrorLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[8]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrPostErrorLine);
    }

    /// <inheritdoc cref="IAppHostConfigException.get_ErrorString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ErrorString([NativeTypeName("BSTR *")] char** pbstrErrorString)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[9]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrErrorString);
    }

    /// <include file='IAppHostPropertyException.xml' path='doc/member[@name="IAppHostPropertyException.get_InvalidValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InvalidValue([NativeTypeName("BSTR *")] char** pbstrValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[10]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrValue);
    }

    /// <include file='IAppHostPropertyException.xml' path='doc/member[@name="IAppHostPropertyException.get_ValidationFailureReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ValidationFailureReason([NativeTypeName("BSTR *")] char** pbstrValidationReason)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, char**, int>)(lpVtbl[11]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pbstrValidationReason);
    }

    /// <include file='IAppHostPropertyException.xml' path='doc/member[@name="IAppHostPropertyException.get_ValidationFailureParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ValidationFailureParameters(SAFEARRAY** pParameterArray)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyException*, SAFEARRAY**, int>)(lpVtbl[12]))((IAppHostPropertyException*)Unsafe.AsPointer(ref this), pParameterArray);
    }

    public interface Interface : IAppHostConfigException.Interface
    {
        [VtblIndex(10)]
        HRESULT get_InvalidValue([NativeTypeName("BSTR *")] char** pbstrValue);

        [VtblIndex(11)]
        HRESULT get_ValidationFailureReason([NativeTypeName("BSTR *")] char** pbstrValidationReason);

        [VtblIndex(12)]
        HRESULT get_ValidationFailureParameters(SAFEARRAY** pParameterArray);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_InvalidValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ValidationFailureReason;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SAFEARRAY**, int> get_ValidationFailureParameters;
    }
}
