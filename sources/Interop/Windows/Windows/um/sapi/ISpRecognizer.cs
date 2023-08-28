// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer"]/*' />
[Guid("C2B5F241-DAA0-4507-9E16-5A1EAA2B7A5C")]
[NativeTypeName("struct ISpRecognizer : ISpProperties")]
[NativeInheritance("ISpProperties")]
public unsafe partial struct ISpRecognizer : ISpRecognizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecognizer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, uint>)(lpVtbl[1]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, uint>)(lpVtbl[2]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpProperties.SetPropertyNum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyNum([NativeTypeName("LPCWSTR")] char* pName, [NativeTypeName("LONG")] int lValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, char*, int, int>)(lpVtbl[3]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, lValue);
    }

    /// <inheritdoc cref="ISpProperties.GetPropertyNum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyNum([NativeTypeName("LPCWSTR")] char* pName, [NativeTypeName("LONG *")] int* plValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, char*, int*, int>)(lpVtbl[4]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, plValue);
    }

    /// <inheritdoc cref="ISpProperties.SetPropertyString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPropertyString([NativeTypeName("LPCWSTR")] char* pName, [NativeTypeName("LPCWSTR")] char* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, char*, char*, int>)(lpVtbl[5]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, pValue);
    }

    /// <inheritdoc cref="ISpProperties.GetPropertyString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyString([NativeTypeName("LPCWSTR")] char* pName, [NativeTypeName("LPWSTR *")] char** ppCoMemValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, char*, char**, int>)(lpVtbl[6]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, ppCoMemValue);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.SetRecognizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRecognizer(ISpObjectToken* pRecognizer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[7]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pRecognizer);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetRecognizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRecognizer(ISpObjectToken** ppRecognizer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[8]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppRecognizer);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.SetInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetInput(IUnknown* pUnkInput, BOOL fAllowFormatChanges)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, IUnknown*, BOOL, int>)(lpVtbl[9]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pUnkInput, fAllowFormatChanges);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetInputObjectToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInputObjectToken(ISpObjectToken** ppToken)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[10]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetInputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInputStream(ISpStreamFormat** ppStream)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpStreamFormat**, int>)(lpVtbl[11]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppStream);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.CreateRecoContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateRecoContext(ISpRecoContext** ppNewCtxt)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpRecoContext**, int>)(lpVtbl[12]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppNewCtxt);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetRecoProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRecoProfile(ISpObjectToken** ppToken)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[13]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.SetRecoProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetRecoProfile(ISpObjectToken* pToken)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[14]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pToken);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.IsSharedInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsSharedInstance()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, int>)(lpVtbl[15]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetRecoState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetRecoState(SPRECOSTATE* pState)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, SPRECOSTATE*, int>)(lpVtbl[16]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pState);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.SetRecoState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetRecoState(SPRECOSTATE NewState)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, SPRECOSTATE, int>)(lpVtbl[17]))((ISpRecognizer*)Unsafe.AsPointer(ref this), NewState);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetStatus(SPRECOGNIZERSTATUS* pStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, SPRECOGNIZERSTATUS*, int>)(lpVtbl[18]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.GetFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, Guid* pFormatId, WAVEFORMATEX** ppCoMemWFEX)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, SPSTREAMFORMATTYPE, Guid*, WAVEFORMATEX**, int>)(lpVtbl[19]))((ISpRecognizer*)Unsafe.AsPointer(ref this), WaveFormatType, pFormatId, ppCoMemWFEX);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.IsUISupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, char*, void*, uint, BOOL*, int>)(lpVtbl[20]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.DisplayUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, HWND, char*, char*, void*, uint, int>)(lpVtbl[21]))((ISpRecognizer*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
    }

    /// <include file='ISpRecognizer.xml' path='doc/member[@name="ISpRecognizer.EmulateRecognition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EmulateRecognition(ISpPhrase* pPhrase)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecognizer*, ISpPhrase*, int>)(lpVtbl[22]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pPhrase);
    }

    public interface Interface : ISpProperties.Interface
    {
        [VtblIndex(7)]
        HRESULT SetRecognizer(ISpObjectToken* pRecognizer);

        [VtblIndex(8)]
        HRESULT GetRecognizer(ISpObjectToken** ppRecognizer);

        [VtblIndex(9)]
        HRESULT SetInput(IUnknown* pUnkInput, BOOL fAllowFormatChanges);

        [VtblIndex(10)]
        HRESULT GetInputObjectToken(ISpObjectToken** ppToken);

        [VtblIndex(11)]
        HRESULT GetInputStream(ISpStreamFormat** ppStream);

        [VtblIndex(12)]
        HRESULT CreateRecoContext(ISpRecoContext** ppNewCtxt);

        [VtblIndex(13)]
        HRESULT GetRecoProfile(ISpObjectToken** ppToken);

        [VtblIndex(14)]
        HRESULT SetRecoProfile(ISpObjectToken* pToken);

        [VtblIndex(15)]
        HRESULT IsSharedInstance();

        [VtblIndex(16)]
        HRESULT GetRecoState(SPRECOSTATE* pState);

        [VtblIndex(17)]
        HRESULT SetRecoState(SPRECOSTATE NewState);

        [VtblIndex(18)]
        HRESULT GetStatus(SPRECOGNIZERSTATUS* pStatus);

        [VtblIndex(19)]
        HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, Guid* pFormatId, WAVEFORMATEX** ppCoMemWFEX);

        [VtblIndex(20)]
        HRESULT IsUISupported([NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported);

        [VtblIndex(21)]
        HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData);

        [VtblIndex(22)]
        HRESULT EmulateRecognition(ISpPhrase* pPhrase);
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

        [NativeTypeName("HRESULT (LPCWSTR, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int, int> SetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> GetPropertyNum;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetPropertyString;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetPropertyString;

        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectToken*, int> SetRecognizer;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectToken**, int> GetRecognizer;

        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, BOOL, int> SetInput;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectToken**, int> GetInputObjectToken;

        [NativeTypeName("HRESULT (ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpStreamFormat**, int> GetInputStream;

        [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpRecoContext**, int> CreateRecoContext;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectToken**, int> GetRecoProfile;

        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpObjectToken*, int> SetRecoProfile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsSharedInstance;

        [NativeTypeName("HRESULT (SPRECOSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPRECOSTATE*, int> GetRecoState;

        [NativeTypeName("HRESULT (SPRECOSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPRECOSTATE, int> SetRecoState;

        [NativeTypeName("HRESULT (SPRECOGNIZERSTATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPRECOGNIZERSTATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (SPSTREAMFORMATTYPE, GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPSTREAMFORMATTYPE, Guid*, WAVEFORMATEX**, int> GetFormat;

        [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*, uint, BOOL*, int> IsUISupported;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, char*, char*, void*, uint, int> DisplayUI;

        [NativeTypeName("HRESULT (ISpPhrase *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpPhrase*, int> EmulateRecognition;
    }
}
