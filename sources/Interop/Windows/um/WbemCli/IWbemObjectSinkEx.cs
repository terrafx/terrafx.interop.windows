// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7D35CFA-348B-485E-B524-252725D697CA")]
    [NativeTypeName("struct IWbemObjectSinkEx : IWbemObjectSink")]
    public unsafe partial struct IWbemObjectSinkEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, uint>)(lpVtbl[1]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, uint>)(lpVtbl[2]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject** apObjArray)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), lObjectCount, apObjArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("long")] int lFlags, [NativeTypeName("HRESULT")] int hResult, [NativeTypeName("BSTR")] ushort* strParam, IWbemClassObject* pObjParam)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, int, int, ushort*, IWbemClassObject*, int>)(lpVtbl[4]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), lFlags, hResult, strParam, pObjParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteMessage([NativeTypeName("ULONG")] uint uChannel, [NativeTypeName("const BSTR")] ushort* strMessage)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, uint, ushort*, int>)(lpVtbl[5]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), uChannel, strMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteError(IWbemClassObject* pObjError, [NativeTypeName("unsigned char *")] byte* puReturned)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, IWbemClassObject*, byte*, int>)(lpVtbl[6]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), pObjError, puReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PromptUser([NativeTypeName("const BSTR")] ushort* strMessage, [NativeTypeName("unsigned char")] byte uPromptType, [NativeTypeName("unsigned char *")] byte* puReturned)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, byte, byte*, int>)(lpVtbl[7]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strMessage, uPromptType, puReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteProgress([NativeTypeName("const BSTR")] ushort* strActivity, [NativeTypeName("const BSTR")] ushort* strCurrentOperation, [NativeTypeName("const BSTR")] ushort* strStatusDescription, [NativeTypeName("ULONG")] uint uPercentComplete, [NativeTypeName("ULONG")] uint uSecondsRemaining)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, ushort*, ushort*, uint, uint, int>)(lpVtbl[8]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strActivity, strCurrentOperation, strStatusDescription, uPercentComplete, uSecondsRemaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteStreamParameter([NativeTypeName("const BSTR")] ushort* strName, VARIANT* vtValue, [NativeTypeName("ULONG")] uint ulType, [NativeTypeName("ULONG")] uint ulFlags)
        {
            return ((delegate* unmanaged<IWbemObjectSinkEx*, ushort*, VARIANT*, uint, uint, int>)(lpVtbl[9]))((IWbemObjectSinkEx*)Unsafe.AsPointer(ref this), strName, vtValue, ulType, ulFlags);
        }
    }
}
