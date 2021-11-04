// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354154-8F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscFormat2TrackAtOnce : IDiscFormat2")]
    [NativeInheritance("IDiscFormat2")]
    public unsafe partial struct IDiscFormat2TrackAtOnce
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint>)(lpVtbl[1]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint>)(lpVtbl[2]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint*, int>)(lpVtbl[3]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsRecorderSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, short*, int>)(lpVtbl[7]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT IsCurrentMediaSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, short*, int>)(lpVtbl[8]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[9]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[10]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int>)(lpVtbl[11]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT PrepareMedia()
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int>)(lpVtbl[12]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT AddAudioTrack(IStream* data)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IStream*, int>)(lpVtbl[13]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CancelAddTrack()
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int>)(lpVtbl[14]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ReleaseMedia()
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int>)(lpVtbl[15]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetWriteSpeed([NativeTypeName("LONG")] int RequestedSectorsPerSecond, [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int, short, int>)(lpVtbl[16]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), RequestedSectorsPerSecond, RotationTypeIsPureCAV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_Recorder(IDiscRecorder2* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, int>)(lpVtbl[17]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_Recorder(IDiscRecorder2** value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2**, int>)(lpVtbl[18]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short, int>)(lpVtbl[19]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[20]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[21]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[22]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[23]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_UsedSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[24]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short, int>)(lpVtbl[25]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[26]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_ExpectedTableOfContents(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int>)(lpVtbl[27]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)(lpVtbl[28]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, ushort*, int>)(lpVtbl[29]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, ushort**, int>)(lpVtbl[30]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[31]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[32]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int>)(lpVtbl[33]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int>)(lpVtbl[34]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int>)(lpVtbl[35]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), supportedSpeeds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors)
        {
            return ((delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int>)(lpVtbl[36]))((IDiscFormat2TrackAtOnce*)Unsafe.AsPointer(ref this), supportedSpeedDescriptors);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, short*, int> IsRecorderSupported;

            [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, short*, int> IsCurrentMediaSupported;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_MediaPhysicallyBlank;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_MediaHeuristicallyBlank;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int> get_SupportedMediaTypes;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int> PrepareMedia;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IStream*, int> AddAudioTrack;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int> CancelAddTrack;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int> ReleaseMedia;

            [NativeTypeName("HRESULT (LONG, VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int, short, int> SetWriteSpeed;

            [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2*, int> put_Recorder;

            [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IDiscRecorder2**, int> get_Recorder;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short, int> put_BufferUnderrunFreeDisabled;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_BufferUnderrunFreeDisabled;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_NumberOfExistingTracks;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_TotalSectorsOnMedia;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_FreeSectorsOnMedia;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_UsedSectorsOnMedia;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short, int> put_DoNotFinalizeMedia;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_DoNotFinalizeMedia;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int> get_ExpectedTableOfContents;

            [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, IMAPI_MEDIA_PHYSICAL_TYPE*, int> get_CurrentPhysicalMediaType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, ushort*, int> put_ClientName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, ushort**, int> get_ClientName;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_RequestedWriteSpeed;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_RequestedRotationTypeIsPureCAV;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, int*, int> get_CurrentWriteSpeed;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, short*, int> get_CurrentRotationTypeIsPureCAV;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int> get_SupportedWriteSpeeds;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2TrackAtOnce*, SAFEARRAY**, int> get_SupportedWriteSpeedDescriptors;
        }
    }
}
