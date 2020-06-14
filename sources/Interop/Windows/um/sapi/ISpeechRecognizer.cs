// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D5F1C0C-BD75-4B08-9478-3B11FEA2586C")]
    public unsafe partial struct ISpeechRecognizer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechRecognizer*, uint>)(lpVtbl[1]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechRecognizer*, uint>)(lpVtbl[2]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, uint*, int>)(lpVtbl[3]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_Recognizer([NativeTypeName("ISpeechObjectToken *")] ISpeechObjectToken* Recognizer)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[7]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Recognizer([NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** Recognizer)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[8]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_AllowAudioInputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, short, int>)(lpVtbl[9]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Allow);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AllowAudioInputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* Allow)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, short*, int>)(lpVtbl[10]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Allow);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_AudioInput([NativeTypeName("ISpeechObjectToken *")] ISpeechObjectToken* AudioInput = null)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[11]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInput);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioInput([NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** AudioInput)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[12]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInput);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_AudioInputStream([NativeTypeName("ISpeechBaseStream *")] ISpeechBaseStream* AudioInputStream = null)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechBaseStream*, int>)(lpVtbl[13]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInputStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioInputStream([NativeTypeName("ISpeechBaseStream **")] ISpeechBaseStream** AudioInputStream)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechBaseStream**, int>)(lpVtbl[14]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), AudioInputStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_IsShared([NativeTypeName("VARIANT_BOOL *")] short* Shared)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, short*, int>)(lpVtbl[15]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Shared);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_State(SpeechRecognizerState State)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, SpeechRecognizerState, int>)(lpVtbl[16]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("SpeechRecognizerState *")] SpeechRecognizerState* State)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, SpeechRecognizerState*, int>)(lpVtbl[17]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ISpeechRecognizerStatus **")] ISpeechRecognizerStatus** Status)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechRecognizerStatus**, int>)(lpVtbl[18]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Status);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_Profile([NativeTypeName("ISpeechObjectToken *")] ISpeechObjectToken* Profile = null)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken*, int>)(lpVtbl[19]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Profile);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Profile([NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** Profile)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechObjectToken**, int>)(lpVtbl[20]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Profile);
        }

        [return: NativeTypeName("HRESULT")]
        public int EmulateRecognition(VARIANT TextElements, [NativeTypeName("VARIANT *")] VARIANT* ElementDisplayAttributes = null, [NativeTypeName("long")] int LanguageId = 0)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, VARIANT, VARIANT*, int, int>)(lpVtbl[21]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), TextElements, ElementDisplayAttributes, LanguageId);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRecoContext([NativeTypeName("ISpeechRecoContext **")] ISpeechRecoContext** NewContext)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ISpeechRecoContext**, int>)(lpVtbl[22]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), NewContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormat(SpeechFormatType Type, [NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** Format)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, SpeechFormatType, ISpeechAudioFormat**, int>)(lpVtbl[23]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Type, Format);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPropertyNumber([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("long")] int Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, int, short*, int>)(lpVtbl[24]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyNumber([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("long *")] int* Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, int*, short*, int>)(lpVtbl[25]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPropertyString([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("const BSTR")] ushort* Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, ushort*, short*, int>)(lpVtbl[26]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyString([NativeTypeName("const BSTR")] ushort* Name, [NativeTypeName("BSTR *")] ushort** Value, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, ushort**, short*, int>)(lpVtbl[27]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), Name, Value, Supported);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, VARIANT*, short*, int>)(lpVtbl[28]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Supported);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("long")] int hWndParent, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, int, ushort*, ushort*, VARIANT*, int>)(lpVtbl[29]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), hWndParent, Title, TypeOfUI, ExtraData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecognizers([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[30]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioInputs([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[31]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfiles([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* stdcall<ISpeechRecognizer*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[32]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }
    }
}
