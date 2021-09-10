// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354153-9F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscFormat2Data : IDiscFormat2")]
    [NativeInheritance("IDiscFormat2")]
    public unsafe partial struct IDiscFormat2Data
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint>)(lpVtbl[1]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint>)(lpVtbl[2]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint*, int>)(lpVtbl[3]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsRecorderSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, short*, int>)(lpVtbl[7]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int IsCurrentMediaSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, short*, int>)(lpVtbl[8]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[9]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[10]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedMediaTypes(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[11]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_Recorder(IDiscRecorder2* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, int>)(lpVtbl[12]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_Recorder(IDiscRecorder2** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2**, int>)(lpVtbl[13]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[14]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[15]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[16]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[17]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentMediaStatus(IMAPI_FORMAT2_DATA_MEDIA_STATE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_FORMAT2_DATA_MEDIA_STATE*, int>)(lpVtbl[18]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_WriteProtectStatus(IMAPI_MEDIA_WRITE_PROTECT_STATE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_MEDIA_WRITE_PROTECT_STATE*, int>)(lpVtbl[19]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[20]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[21]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[22]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[23]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[24]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[25]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[26]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_DisableConsumerDvdCompatibilityMode([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[27]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisableConsumerDvdCompatibilityMode([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[28]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)(lpVtbl[29]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_ClientName([NativeTypeName("BSTR")] ushort* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, ushort*, int>)(lpVtbl[30]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_ClientName([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, ushort**, int>)(lpVtbl[31]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[32]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[33]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[34]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[35]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[36]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), supportedSpeeds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[37]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), supportedSpeedDescriptors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_ForceOverwrite([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[38]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_ForceOverwrite([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[39]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_MultisessionInterfaces(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[40]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int Write(IStream* data)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IStream*, int>)(lpVtbl[41]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int CancelWrite()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int>)(lpVtbl[42]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int SetWriteSpeed([NativeTypeName("LONG")] int RequestedSectorsPerSecond, [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int, short, int>)(lpVtbl[43]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), RequestedSectorsPerSecond, RotationTypeIsPureCAV);
        }
    }
}
