// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("E7D35CFA-348B-485E-B524-252725D697CA")]
[NativeTypeName("struct IWbemObjectSinkEx : IWbemObjectSink")]
[NativeInheritance("IWbemObjectSink")]
public unsafe partial struct IWbemObjectSinkEx : IWbemObjectSinkEx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, uint>)(lpVtbl[1]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, uint>)(lpVtbl[2]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject** apObjArray)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), lObjectCount, apObjArray);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStatus([NativeTypeName("long")] int lFlags, HRESULT hResult, [NativeTypeName("BSTR")] ushort* strParam, IWbemClassObject* pObjParam)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, int, HRESULT, ushort*, IWbemClassObject*, int>)(lpVtbl[4]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), lFlags, hResult, strParam, pObjParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteMessage([NativeTypeName("ULONG")] uint uChannel, [NativeTypeName("const BSTR")] ushort* strMessage)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, uint, ushort*, int>)(lpVtbl[5]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), uChannel, strMessage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteError(IWbemClassObject* pObjError, [NativeTypeName("unsigned char *")] byte* puReturned)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, IWbemClassObject*, byte*, int>)(lpVtbl[6]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), pObjError, puReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PromptUser([NativeTypeName("const BSTR")] ushort* strMessage, [NativeTypeName("unsigned char")] byte uPromptType, [NativeTypeName("unsigned char *")] byte* puReturned)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, byte, byte*, int>)(lpVtbl[7]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strMessage, uPromptType, puReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteProgress([NativeTypeName("const BSTR")] ushort* strActivity, [NativeTypeName("const BSTR")] ushort* strCurrentOperation, [NativeTypeName("const BSTR")] ushort* strStatusDescription, [NativeTypeName("ULONG")] uint uPercentComplete, [NativeTypeName("ULONG")] uint uSecondsRemaining)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, ushort*, ushort*, uint, uint, int>)(lpVtbl[8]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strActivity, strCurrentOperation, strStatusDescription, uPercentComplete, uSecondsRemaining);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteStreamParameter([NativeTypeName("const BSTR")] ushort* strName, VARIANT* vtValue, [NativeTypeName("ULONG")] uint ulType, [NativeTypeName("ULONG")] uint ulFlags)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, VARIANT*, uint, uint, int>)(lpVtbl[9]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strName, vtValue, ulType, ulFlags);
    }

    public interface Interface : IWbemObjectSink.Interface
    {
        [VtblIndex(5)]
        HRESULT WriteMessage([NativeTypeName("ULONG")] uint uChannel, [NativeTypeName("const BSTR")] ushort* strMessage);

        [VtblIndex(6)]
        HRESULT WriteError(IWbemClassObject* pObjError, [NativeTypeName("unsigned char *")] byte* puReturned);

        [VtblIndex(7)]
        HRESULT PromptUser([NativeTypeName("const BSTR")] ushort* strMessage, [NativeTypeName("unsigned char")] byte uPromptType, [NativeTypeName("unsigned char *")] byte* puReturned);

        [VtblIndex(8)]
        HRESULT WriteProgress([NativeTypeName("const BSTR")] ushort* strActivity, [NativeTypeName("const BSTR")] ushort* strCurrentOperation, [NativeTypeName("const BSTR")] ushort* strStatusDescription, [NativeTypeName("ULONG")] uint uPercentComplete, [NativeTypeName("ULONG")] uint uSecondsRemaining);

        [VtblIndex(9)]
        HRESULT WriteStreamParameter([NativeTypeName("const BSTR")] ushort* strName, VARIANT* vtValue, [NativeTypeName("ULONG")] uint ulType, [NativeTypeName("ULONG")] uint ulFlags);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, uint> Release;

        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, int, IWbemClassObject**, int> Indicate;

        [NativeTypeName("HRESULT (long, HRESULT, BSTR, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, int, HRESULT, ushort*, IWbemClassObject*, int> SetStatus;

        [NativeTypeName("HRESULT (ULONG, const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, uint, ushort*, int> WriteMessage;

        [NativeTypeName("HRESULT (IWbemClassObject *, unsigned char *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, IWbemClassObject*, byte*, int> WriteError;

        [NativeTypeName("HRESULT (const BSTR, unsigned char, unsigned char *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, ushort*, byte, byte*, int> PromptUser;

        [NativeTypeName("HRESULT (const BSTR, const BSTR, const BSTR, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, ushort*, ushort*, ushort*, uint, uint, int> WriteProgress;

        [NativeTypeName("HRESULT (const BSTR, VARIANT *, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemObjectSinkEx*, ushort*, VARIANT*, uint, uint, int> WriteStreamParameter;
    }
}
