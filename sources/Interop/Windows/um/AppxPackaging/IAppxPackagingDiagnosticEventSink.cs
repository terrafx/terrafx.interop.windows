// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("17239D47-6ADB-45D2-80F6-F9CBC3BF059D")]
    [NativeTypeName("struct IAppxPackagingDiagnosticEventSink : IUnknown")]
    public unsafe partial struct IAppxPackagingDiagnosticEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, uint>)(lpVtbl[1]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, uint>)(lpVtbl[2]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportContextChange(APPX_PACKAGING_CONTEXT_CHANGE_TYPE changeType, [NativeTypeName("LONG")] int contextId, [NativeTypeName("LPCSTR")] sbyte* contextName, [NativeTypeName("LPCWSTR")] ushort* contextMessage, [NativeTypeName("LPCWSTR")] ushort* detailsMessage)
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, APPX_PACKAGING_CONTEXT_CHANGE_TYPE, int, sbyte*, ushort*, ushort*, int>)(lpVtbl[3]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), changeType, contextId, contextName, contextMessage, detailsMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportError([NativeTypeName("LPCWSTR")] ushort* errorMessage)
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSink*, ushort*, int>)(lpVtbl[4]))((IAppxPackagingDiagnosticEventSink*)Unsafe.AsPointer(ref this), errorMessage);
        }
    }
}
