// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken"]/*' />
[Guid("C74A3ADC-B727-4500-A84A-B526721C8B8C")]
[NativeTypeName("struct ISpeechObjectToken : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechObjectToken : ISpeechObjectToken.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpeechObjectToken);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, uint>)(lpVtbl[1]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, uint>)(lpVtbl[2]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, uint*, int>)(lpVtbl[3]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Id([NativeTypeName("BSTR *")] char** ObjectId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char**, int>)(lpVtbl[7]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectId);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_DataKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DataKey(ISpeechDataKey** DataKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, ISpeechDataKey**, int>)(lpVtbl[8]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), DataKey);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_Category"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Category(ISpeechObjectTokenCategory** Category)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, ISpeechObjectTokenCategory**, int>)(lpVtbl[9]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Category);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] char** Description)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, int, char**, int>)(lpVtbl[10]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Locale, Description);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.SetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetId([NativeTypeName("BSTR")] char* Id, [NativeTypeName("BSTR")] char* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, char*, short, int>)(lpVtbl[11]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Id, CategoryID, CreateIfNotExist);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttribute([NativeTypeName("BSTR")] char* AttributeName, [NativeTypeName("BSTR *")] char** AttributeValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, char**, int>)(lpVtbl[12]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), AttributeName, AttributeValue);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, SpeechTokenContext ClsContext, IUnknown** Object)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, IUnknown*, SpeechTokenContext, IUnknown**, int>)(lpVtbl[13]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, ClsContext, Object);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Remove([NativeTypeName("BSTR")] char* ObjectStorageCLSID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, int>)(lpVtbl[14]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetStorageFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStorageFileName([NativeTypeName("BSTR")] char* ObjectStorageCLSID, [NativeTypeName("BSTR")] char* KeyName, [NativeTypeName("BSTR")] char* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] char** FilePath)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, char*, char*, SpeechTokenShellFolder, char**, int>)(lpVtbl[15]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, FileName, Folder, FilePath);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.RemoveStorageFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveStorageFileName([NativeTypeName("BSTR")] char* ObjectStorageCLSID, [NativeTypeName("BSTR")] char* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, char*, short, int>)(lpVtbl[16]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, DeleteFile);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.IsUISupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsUISupported([NativeTypeName("const BSTR")] char* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, VARIANT*, IUnknown*, short*, int>)(lpVtbl[17]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Object, Supported);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.DisplayUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] char* Title, [NativeTypeName("const BSTR")] char* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, IUnknown* Object = null)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, int, char*, char*, VARIANT*, IUnknown*, int>)(lpVtbl[18]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), hWnd, Title, TypeOfUI, ExtraData, Object);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.MatchesAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MatchesAttributes([NativeTypeName("BSTR")] char* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechObjectToken*, char*, short*, int>)(lpVtbl[19]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Attributes, Matches);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Id([NativeTypeName("BSTR *")] char** ObjectId);

        [VtblIndex(8)]
        HRESULT get_DataKey(ISpeechDataKey** DataKey);

        [VtblIndex(9)]
        HRESULT get_Category(ISpeechObjectTokenCategory** Category);

        [VtblIndex(10)]
        HRESULT GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] char** Description);

        [VtblIndex(11)]
        HRESULT SetId([NativeTypeName("BSTR")] char* Id, [NativeTypeName("BSTR")] char* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0);

        [VtblIndex(12)]
        HRESULT GetAttribute([NativeTypeName("BSTR")] char* AttributeName, [NativeTypeName("BSTR *")] char** AttributeValue);

        [VtblIndex(13)]
        HRESULT CreateInstance(IUnknown* pUnkOuter, SpeechTokenContext ClsContext, IUnknown** Object);

        [VtblIndex(14)]
        HRESULT Remove([NativeTypeName("BSTR")] char* ObjectStorageCLSID);

        [VtblIndex(15)]
        HRESULT GetStorageFileName([NativeTypeName("BSTR")] char* ObjectStorageCLSID, [NativeTypeName("BSTR")] char* KeyName, [NativeTypeName("BSTR")] char* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] char** FilePath);

        [VtblIndex(16)]
        HRESULT RemoveStorageFileName([NativeTypeName("BSTR")] char* ObjectStorageCLSID, [NativeTypeName("BSTR")] char* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile);

        [VtblIndex(17)]
        HRESULT IsUISupported([NativeTypeName("const BSTR")] char* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported);

        [VtblIndex(18)]
        HRESULT DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] char* Title, [NativeTypeName("const BSTR")] char* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, IUnknown* Object = null);

        [VtblIndex(19)]
        HRESULT MatchesAttributes([NativeTypeName("BSTR")] char* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Id;

        [NativeTypeName("HRESULT (ISpeechDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechDataKey**, int> get_DataKey;

        [NativeTypeName("HRESULT (ISpeechObjectTokenCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechObjectTokenCategory**, int> get_Category;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char**, int> GetDescription;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, short, int> SetId;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetAttribute;

        [NativeTypeName("HRESULT (IUnknown *, SpeechTokenContext, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, SpeechTokenContext, IUnknown**, int> CreateInstance;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> Remove;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, SpeechTokenShellFolder, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, SpeechTokenShellFolder, char**, int> GetStorageFileName;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, short, int> RemoveStorageFileName;

        [NativeTypeName("HRESULT (const BSTR, const VARIANT *, IUnknown *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, IUnknown*, short*, int> IsUISupported;

        [NativeTypeName("HRESULT (long, BSTR, const BSTR, const VARIANT *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, char*, VARIANT*, IUnknown*, int> DisplayUI;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> MatchesAttributes;
    }
}
