// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D5F1C0C-BD75-4B08-9478-3B11FEA2586C")]
    [NativeTypeName("struct ISpeechRecognizer : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechRecognizer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, uint>)(lpVtbl[1]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, uint>)(lpVtbl[2]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, uint*, int>)(lpVtbl[3]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_Recognizer(ISpeechObjectToken* Recognizer)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[7]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Recognizer(ISpeechObjectToken** Recognizer)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[8]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_AllowAudioInputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, short, int>)(lpVtbl[9]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_AllowAudioInputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* Allow)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, short*, int>)(lpVtbl[10]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_AudioInput(ISpeechObjectToken* AudioInput = null)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[11]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_AudioInput(ISpeechObjectToken** AudioInput)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[12]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_AudioInputStream(ISpeechBaseStream* AudioInputStream = null)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechBaseStream*, int>)(lpVtbl[13]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_AudioInputStream(ISpeechBaseStream** AudioInputStream)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechBaseStream**, int>)(lpVtbl[14]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_IsShared([NativeTypeName("VARIANT_BOOL *")] short* Shared)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, short*, int>)(lpVtbl[15]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_State(SpeechRecognizerState State)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, SpeechRecognizerState, int>)(lpVtbl[16]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_State(SpeechRecognizerState* State)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, SpeechRecognizerState*, int>)(lpVtbl[17]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_Status(ISpeechRecognizerStatus** Status)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechRecognizerStatus**, int>)(lpVtbl[18]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT putref_Profile(ISpeechObjectToken* Profile = null)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[19]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Profile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Profile(ISpeechObjectToken** Profile)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[20]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Profile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT EmulateRecognition(VARIANT TextElements, VARIANT* ElementDisplayAttributes = null, [NativeTypeName("long")] int LanguageId = 0)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, VARIANT, VARIANT*, int, int>)(lpVtbl[21]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), TextElements, ElementDisplayAttributes, LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT CreateRecoContext(ISpeechRecoContext** NewContext)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ISpeechRecoContext**, int>)(lpVtbl[22]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), NewContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetFormat(SpeechFormatType Type, ISpeechAudioFormat** Format)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, SpeechFormatType, ISpeechAudioFormat**, int>)(lpVtbl[23]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Type, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetPropertyNumber([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("long")] int Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, int, short*, int>)(lpVtbl[24]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetPropertyNumber([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("long *")] int* Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, int*, short*, int>)(lpVtbl[25]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetPropertyString([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("const BSTR")] ushort* Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, ushort*, short*, int>)(lpVtbl[26]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetPropertyString([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("BSTR *")] ushort** Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, ushort**, short*, int>)(lpVtbl[27]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, VARIANT*, short*, int>)(lpVtbl[28]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT DisplayUI([NativeTypeName("long")] int hWndParent, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, int, ushort*, ushort*, VARIANT*, int>)(lpVtbl[29]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), hWndParent, Title, TypeOfUI, ExtraData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetRecognizers([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[30]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetAudioInputs([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[31]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetProfiles([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* unmanaged<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[32]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }
    }
}
