// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetErrorReportingFlags([NativeTypeName("UINT32 *")] uint* pflags);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoSetErrorReportingFlags([NativeTypeName("UINT32")] uint flags);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoResolveRestrictedErrorInfoReference([NativeTypeName("PCWSTR")] ushort* reference, IRestrictedErrorInfo** ppRestrictedErrorInfo);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetRestrictedErrorInfo(IRestrictedErrorInfo* pRestrictedErrorInfo);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetRestrictedErrorInfo(IRestrictedErrorInfo** ppRestrictedErrorInfo);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL RoOriginateErrorW([NativeTypeName("HRESULT")] int error, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("PCWSTR")] ushort* message);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL RoOriginateError([NativeTypeName("HRESULT")] int error, [NativeTypeName("HSTRING")] IntPtr message);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL RoTransformErrorW([NativeTypeName("HRESULT")] int oldError, [NativeTypeName("HRESULT")] int newError, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("PCWSTR")] ushort* message);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL RoTransformError([NativeTypeName("HRESULT")] int oldError, [NativeTypeName("HRESULT")] int newError, [NativeTypeName("HSTRING")] IntPtr message);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoCaptureErrorContext([NativeTypeName("HRESULT")] int hr);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoFailFastWithErrorContext([NativeTypeName("HRESULT")] int hrError);

        [return: NativeTypeName("HRESULT")]
        public static int GetErrorReportingFlags([NativeTypeName("UINT32 *")] uint* pflags)
        {
            return RoGetErrorReportingFlags(pflags);
        }

        [return: NativeTypeName("HRESULT")]
        public static int SetErrorReportingFlags([NativeTypeName("UINT32")] uint flags)
        {
            return RoSetErrorReportingFlags(flags);
        }

        public static BOOL OriginateError([NativeTypeName("HRESULT")] int error, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("PCWSTR")] ushort* message)
        {
            if ((((int)(error)) >= 0))
            {
                return 0;
            }

            return RoOriginateErrorW(error, cchMax, message);
        }

        public static BOOL OriginateError([NativeTypeName("HRESULT")] int error, [NativeTypeName("HSTRING")] IntPtr message)
        {
            if ((((int)(error)) >= 0))
            {
                return 0;
            }

            return RoOriginateError(error, message);
        }

        public static BOOL TransformError([NativeTypeName("HRESULT")] int oldError, [NativeTypeName("HRESULT")] int newError, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("PCWSTR")] ushort* message)
        {
            if ((oldError == newError) || ((((int)(oldError)) >= 0) && (((int)(newError)) >= 0)))
            {
                return 0;
            }

            return RoTransformErrorW(oldError, newError, cchMax, message);
        }

        public static BOOL TransformError([NativeTypeName("HRESULT")] int oldError, [NativeTypeName("HRESULT")] int newError, [NativeTypeName("HSTRING")] IntPtr message)
        {
            if ((oldError == newError) || ((((int)(oldError)) >= 0) && (((int)(newError)) >= 0)))
            {
                return 0;
            }

            return RoTransformError(oldError, newError, message);
        }

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL RoOriginateLanguageException([NativeTypeName("HRESULT")] int error, [NativeTypeName("HSTRING")] IntPtr message, IUnknown* languageException);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoClearError();

        [DllImport("api-ms-win-core-winrt-error-l1-1-1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoReportUnhandledError(IRestrictedErrorInfo* pRestrictedErrorInfo);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoInspectThreadErrorInfo([NativeTypeName("UINT_PTR")] nuint targetTebAddress, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_MEMORY_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, int> readMemoryCallback, [NativeTypeName("PVOID")] void* context, [NativeTypeName("UINT_PTR *")] nuint* targetErrorInfoAddress);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoInspectCapturedStackBackTrace([NativeTypeName("UINT_PTR")] nuint targetErrorInfoAddress, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_MEMORY_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, int> readMemoryCallback, [NativeTypeName("PVOID")] void* context, [NativeTypeName("UINT32 *")] uint* frameCount, [NativeTypeName("UINT_PTR *")] nuint* targetBackTraceAddress);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoReportFailedDelegate(IUnknown* punkDelegate, IRestrictedErrorInfo* pRestrictedErrorInfo);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL IsErrorPropagationEnabled();

        [NativeTypeName("#define MAX_ERROR_MESSAGE_CHARS 512")]
        public const int MAX_ERROR_MESSAGE_CHARS = 512;

        [NativeTypeName("#define EXCEPTION_RO_ORIGINATEERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x201))")]
        public const uint EXCEPTION_RO_ORIGINATEERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x201));

        [NativeTypeName("#define EXCEPTION_RO_TRANSFORMERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x202))")]
        public const uint EXCEPTION_RO_TRANSFORMERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x202));
    }
}
