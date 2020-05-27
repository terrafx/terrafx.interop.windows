// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E5-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetProtocolSink
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetProtocolSink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetProtocolSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetProtocolSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Switch(IInternetProtocolSink* pThis, [NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportProgress(IInternetProtocolSink* pThis, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportData(IInternetProtocolSink* pThis, [NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportResult(IInternetProtocolSink* pThis, [NativeTypeName("HRESULT")] int hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] ushort* szResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetProtocolSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Switch([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return Marshal.GetDelegateForFunctionPointer<_Switch>(lpVtbl->Switch)((IInternetProtocolSink*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReportProgress>(lpVtbl->ReportProgress)((IInternetProtocolSink*)Unsafe.AsPointer(ref this), ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReportData>(lpVtbl->ReportData)((IInternetProtocolSink*)Unsafe.AsPointer(ref this), grfBSCF, ulProgress, ulProgressMax);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportResult([NativeTypeName("HRESULT")] int hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] ushort* szResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReportResult>(lpVtbl->ReportResult)((IInternetProtocolSink*)Unsafe.AsPointer(ref this), hrResult, dwError, szResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public IntPtr Switch;

            [NativeTypeName("HRESULT (ULONG, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr ReportProgress;

            [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
            public IntPtr ReportData;

            [NativeTypeName("HRESULT (HRESULT, DWORD, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr ReportResult;
        }
    }
}
