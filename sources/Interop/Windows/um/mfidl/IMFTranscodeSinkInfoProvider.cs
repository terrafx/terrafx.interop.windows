// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8CFFCD2E-5A03-4A3A-AFF7-EDCD107C620E")]
    [NativeTypeName("struct IMFTranscodeSinkInfoProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTranscodeSinkInfoProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, uint>)(lpVtbl[1]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, uint>)(lpVtbl[2]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputFile([NativeTypeName("LPCWSTR")] ushort* pwszFileName)
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, ushort*, int>)(lpVtbl[3]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this), pwszFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputByteStream(IMFActivate* pByteStreamActivate)
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, IMFActivate*, int>)(lpVtbl[4]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this), pByteStreamActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetProfile(IMFTranscodeProfile* pProfile)
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, IMFTranscodeProfile*, int>)(lpVtbl[5]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this), pProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetSinkInfo(MF_TRANSCODE_SINK_INFO* pSinkInfo)
        {
            return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider*, MF_TRANSCODE_SINK_INFO*, int>)(lpVtbl[6]))((IMFTranscodeSinkInfoProvider*)Unsafe.AsPointer(ref this), pSinkInfo);
        }
    }
}
