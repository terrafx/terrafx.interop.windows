// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("269316D8-57BD-11D2-9EEE-00C04F797396")]
    [NativeTypeName("struct ISpeechVoice : IDispatch")]
    public unsafe partial struct ISpeechVoice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechVoice*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechVoice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechVoice*, uint>)(lpVtbl[1]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechVoice*, uint>)(lpVtbl[2]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechVoice*, uint*, int>)(lpVtbl[3]))((ISpeechVoice*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechVoice*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechVoice*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechVoice*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechVoice*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechVoice*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ISpeechVoiceStatus **")] ISpeechVoiceStatus** Status)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechVoiceStatus**, int>)(lpVtbl[7]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Voice([NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** Voice)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechObjectToken**, int>)(lpVtbl[8]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_Voice([NativeTypeName("ISpeechObjectToken *")] ISpeechObjectToken* Voice)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechObjectToken*, int>)(lpVtbl[9]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioOutput([NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** AudioOutput)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechObjectToken**, int>)(lpVtbl[10]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_AudioOutput([NativeTypeName("ISpeechObjectToken *")] ISpeechObjectToken* AudioOutput)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechObjectToken*, int>)(lpVtbl[11]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioOutputStream([NativeTypeName("ISpeechBaseStream **")] ISpeechBaseStream** AudioOutputStream)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechBaseStream**, int>)(lpVtbl[12]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_AudioOutputStream([NativeTypeName("ISpeechBaseStream *")] ISpeechBaseStream* AudioOutputStream)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechBaseStream*, int>)(lpVtbl[13]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rate([NativeTypeName("long *")] int* Rate)
        {
            return ((delegate* stdcall<ISpeechVoice*, int*, int>)(lpVtbl[14]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rate([NativeTypeName("long")] int Rate)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, int>)(lpVtbl[15]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Volume([NativeTypeName("long *")] int* Volume)
        {
            return ((delegate* stdcall<ISpeechVoice*, int*, int>)(lpVtbl[16]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Volume([NativeTypeName("long")] int Volume)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, int>)(lpVtbl[17]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AllowAudioOutputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* stdcall<ISpeechVoice*, short, int>)(lpVtbl[18]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AllowAudioOutputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* Allow)
        {
            return ((delegate* stdcall<ISpeechVoice*, short*, int>)(lpVtbl[19]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EventInterests([NativeTypeName("SpeechVoiceEvents *")] SpeechVoiceEvents* EventInterestFlags)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoiceEvents*, int>)(lpVtbl[20]))((ISpeechVoice*)Unsafe.AsPointer(ref this), EventInterestFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_EventInterests(SpeechVoiceEvents EventInterestFlags)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoiceEvents, int>)(lpVtbl[21]))((ISpeechVoice*)Unsafe.AsPointer(ref this), EventInterestFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Priority(SpeechVoicePriority Priority)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoicePriority, int>)(lpVtbl[22]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Priority([NativeTypeName("SpeechVoicePriority *")] SpeechVoicePriority* Priority)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoicePriority*, int>)(lpVtbl[23]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AlertBoundary(SpeechVoiceEvents Boundary)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoiceEvents, int>)(lpVtbl[24]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Boundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AlertBoundary([NativeTypeName("SpeechVoiceEvents *")] SpeechVoiceEvents* Boundary)
        {
            return ((delegate* stdcall<ISpeechVoice*, SpeechVoiceEvents*, int>)(lpVtbl[25]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Boundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SynchronousSpeakTimeout([NativeTypeName("long")] int msTimeout)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, int>)(lpVtbl[26]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SynchronousSpeakTimeout([NativeTypeName("long *")] int* msTimeout)
        {
            return ((delegate* stdcall<ISpeechVoice*, int*, int>)(lpVtbl[27]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Speak([NativeTypeName("BSTR")] ushort* Text, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* stdcall<ISpeechVoice*, ushort*, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[28]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Text, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakStream([NativeTypeName("ISpeechBaseStream *")] ISpeechBaseStream* Stream, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* stdcall<ISpeechVoice*, ISpeechBaseStream*, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[29]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Stream, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<ISpeechVoice*, int>)(lpVtbl[30]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* stdcall<ISpeechVoice*, int>)(lpVtbl[31]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("const BSTR")] ushort* Type, [NativeTypeName("long")] int NumItems, [NativeTypeName("long *")] int* NumSkipped)
        {
            return ((delegate* stdcall<ISpeechVoice*, ushort*, int, int*, int>)(lpVtbl[32]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Type, NumItems, NumSkipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVoices([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* stdcall<ISpeechVoice*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[33]))((ISpeechVoice*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioOutputs([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* stdcall<ISpeechVoice*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[34]))((ISpeechVoice*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitUntilDone([NativeTypeName("long")] int msTimeout, [NativeTypeName("VARIANT_BOOL *")] short* Done)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, short*, int>)(lpVtbl[35]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout, Done);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakCompleteEvent([NativeTypeName("long *")] int* Handle)
        {
            return ((delegate* stdcall<ISpeechVoice*, int*, int>)(lpVtbl[36]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Handle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* stdcall<ISpeechVoice*, ushort*, VARIANT*, short*, int>)(lpVtbl[37]))((ISpeechVoice*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("long")] int hWndParent, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null)
        {
            return ((delegate* stdcall<ISpeechVoice*, int, ushort*, ushort*, VARIANT*, int>)(lpVtbl[38]))((ISpeechVoice*)Unsafe.AsPointer(ref this), hWndParent, Title, TypeOfUI, ExtraData);
        }
    }
}
