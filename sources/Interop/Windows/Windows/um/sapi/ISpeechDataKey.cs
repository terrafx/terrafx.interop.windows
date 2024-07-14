// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey"]/*' />
[Guid("CE17C09B-4EFA-44D5-A4C9-59D9585AB0CD")]
[NativeTypeName("struct ISpeechDataKey : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechDataKey : ISpeechDataKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechDataKey));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, uint>)(lpVtbl[1]))((ISpeechDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, uint>)(lpVtbl[2]))((ISpeechDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, uint*, int>)(lpVtbl[3]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.SetBinaryValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetBinaryValue([NativeTypeName("const BSTR")] char* ValueName, VARIANT Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, VARIANT, int>)(lpVtbl[7]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.GetBinaryValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBinaryValue([NativeTypeName("const BSTR")] char* ValueName, VARIANT* Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, VARIANT*, int>)(lpVtbl[8]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.SetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetStringValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("const BSTR")] char* Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, char*, int>)(lpVtbl[9]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.GetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStringValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("BSTR *")] char** Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, char**, int>)(lpVtbl[10]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.SetLongValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLongValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("long")] int Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, int, int>)(lpVtbl[11]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.GetLongValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLongValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("long *")] int* Value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, int*, int>)(lpVtbl[12]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.OpenKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OpenKey([NativeTypeName("const BSTR")] char* SubKeyName, ISpeechDataKey** SubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, ISpeechDataKey**, int>)(lpVtbl[13]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName, SubKey);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.CreateKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateKey([NativeTypeName("const BSTR")] char* SubKeyName, ISpeechDataKey** SubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, ISpeechDataKey**, int>)(lpVtbl[14]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName, SubKey);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.DeleteKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DeleteKey([NativeTypeName("const BSTR")] char* SubKeyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, int>)(lpVtbl[15]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.DeleteValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DeleteValue([NativeTypeName("const BSTR")] char* ValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, char*, int>)(lpVtbl[16]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.EnumKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnumKeys([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] char** SubKeyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, int, char**, int>)(lpVtbl[17]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), Index, SubKeyName);
    }

    /// <include file='ISpeechDataKey.xml' path='doc/member[@name="ISpeechDataKey.EnumValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumValues([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] char** ValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechDataKey*, int, char**, int>)(lpVtbl[18]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), Index, ValueName);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT SetBinaryValue([NativeTypeName("const BSTR")] char* ValueName, VARIANT Value);

        [VtblIndex(8)]
        HRESULT GetBinaryValue([NativeTypeName("const BSTR")] char* ValueName, VARIANT* Value);

        [VtblIndex(9)]
        HRESULT SetStringValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("const BSTR")] char* Value);

        [VtblIndex(10)]
        HRESULT GetStringValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("BSTR *")] char** Value);

        [VtblIndex(11)]
        HRESULT SetLongValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("long")] int Value);

        [VtblIndex(12)]
        HRESULT GetLongValue([NativeTypeName("const BSTR")] char* ValueName, [NativeTypeName("long *")] int* Value);

        [VtblIndex(13)]
        HRESULT OpenKey([NativeTypeName("const BSTR")] char* SubKeyName, ISpeechDataKey** SubKey);

        [VtblIndex(14)]
        HRESULT CreateKey([NativeTypeName("const BSTR")] char* SubKeyName, ISpeechDataKey** SubKey);

        [VtblIndex(15)]
        HRESULT DeleteKey([NativeTypeName("const BSTR")] char* SubKeyName);

        [VtblIndex(16)]
        HRESULT DeleteValue([NativeTypeName("const BSTR")] char* ValueName);

        [VtblIndex(17)]
        HRESULT EnumKeys([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] char** SubKeyName);

        [VtblIndex(18)]
        HRESULT EnumValues([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] char** ValueName);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (const BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetBinaryValue;

        [NativeTypeName("HRESULT (const BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetBinaryValue;

        [NativeTypeName("HRESULT (const BSTR, const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetStringValue;

        [NativeTypeName("HRESULT (const BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (const BSTR, long) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> SetLongValue;

        [NativeTypeName("HRESULT (const BSTR, long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> GetLongValue;

        [NativeTypeName("HRESULT (const BSTR, ISpeechDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpeechDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (const BSTR, ISpeechDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpeechDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteKey;

        [NativeTypeName("HRESULT (const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteValue;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char**, int> EnumKeys;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char**, int> EnumValues;
    }
}
