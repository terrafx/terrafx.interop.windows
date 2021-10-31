// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C74A3ADC-B727-4500-A84A-B526721C8B8C")]
    [NativeTypeName("struct ISpeechObjectToken : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechObjectToken
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, uint>)(lpVtbl[1]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, uint>)(lpVtbl[2]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, uint*, int>)(lpVtbl[3]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Id([NativeTypeName("BSTR *")] ushort** ObjectId)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort**, int>)(lpVtbl[7]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_DataKey(ISpeechDataKey** DataKey)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ISpeechDataKey**, int>)(lpVtbl[8]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), DataKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Category(ISpeechObjectTokenCategory** Category)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ISpeechObjectTokenCategory**, int>)(lpVtbl[9]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] ushort** Description)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, int, ushort**, int>)(lpVtbl[10]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Locale, Description);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetId([NativeTypeName("BSTR")] ushort* Id, [NativeTypeName("BSTR")] ushort* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, short, int>)(lpVtbl[11]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Id, CategoryID, CreateIfNotExist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetAttribute([NativeTypeName("BSTR")] ushort* AttributeName, [NativeTypeName("BSTR *")] ushort** AttributeValue)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort**, int>)(lpVtbl[12]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), AttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateInstance(IUnknown* pUnkOuter, SpeechTokenContext ClsContext, IUnknown** Object)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, IUnknown*, SpeechTokenContext, IUnknown**, int>)(lpVtbl[13]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, ClsContext, Object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, int>)(lpVtbl[14]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("BSTR")] ushort* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] ushort** FilePath)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, ushort*, SpeechTokenShellFolder, ushort**, int>)(lpVtbl[15]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, FileName, Folder, FilePath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT RemoveStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, short, int>)(lpVtbl[16]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, DeleteFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, VARIANT*, IUnknown*, short*, int>)(lpVtbl[17]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Object, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, IUnknown* Object = null)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, int, ushort*, ushort*, VARIANT*, IUnknown*, int>)(lpVtbl[18]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), hWnd, Title, TypeOfUI, ExtraData, Object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT MatchesAttributes([NativeTypeName("BSTR")] ushort* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches)
        {
            return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, short*, int>)(lpVtbl[19]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Attributes, Matches);
        }
    }
}
