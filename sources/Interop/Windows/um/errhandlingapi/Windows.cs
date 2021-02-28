// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/errhandlingapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void RaiseException([NativeTypeName("DWORD")] uint dwExceptionCode, [NativeTypeName("DWORD")] uint dwExceptionFlags, [NativeTypeName("DWORD")] uint nNumberOfArguments, [NativeTypeName("const ULONG_PTR *")] nuint* lpArguments);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int UnhandledExceptionFilter([NativeTypeName("struct _EXCEPTION_POINTERS *")] EXCEPTION_POINTERS* ExceptionInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPTOP_LEVEL_EXCEPTION_FILTER")]
        public static extern delegate* unmanaged<EXCEPTION_POINTERS*, int> SetUnhandledExceptionFilter([NativeTypeName("LPTOP_LEVEL_EXCEPTION_FILTER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> lpTopLevelExceptionFilter);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLastError();

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void SetLastError([NativeTypeName("DWORD")] uint dwErrCode);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetErrorMode();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetErrorMode([NativeTypeName("UINT")] uint uMode);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* AddVectoredExceptionHandler([NativeTypeName("ULONG")] uint First, [NativeTypeName("PVECTORED_EXCEPTION_HANDLER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> Handler);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint RemoveVectoredExceptionHandler([NativeTypeName("PVOID")] void* Handle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* AddVectoredContinueHandler([NativeTypeName("ULONG")] uint First, [NativeTypeName("PVECTORED_EXCEPTION_HANDLER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> Handler);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint RemoveVectoredContinueHandler([NativeTypeName("PVOID")] void* Handle);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void RaiseFailFastException([NativeTypeName("PEXCEPTION_RECORD")] EXCEPTION_RECORD* pExceptionRecord, [NativeTypeName("PCONTEXT")] CONTEXT* pContextRecord, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FatalAppExitA([NativeTypeName("UINT")] uint uAction, [NativeTypeName("LPCSTR")] sbyte* lpMessageText);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FatalAppExitW([NativeTypeName("UINT")] uint uAction, [NativeTypeName("LPCWSTR")] ushort* lpMessageText);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThreadErrorMode();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadErrorMode([NativeTypeName("DWORD")] uint dwNewMode, [NativeTypeName("LPDWORD")] uint* lpOldMode);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void TerminateProcessOnMemoryExhaustion([NativeTypeName("SIZE_T")] nuint FailedAllocationSize);

        [NativeTypeName("#define FatalAppExit FatalAppExitW")]
        public static readonly delegate*<uint, ushort*, void> FatalAppExit = &FatalAppExitW;
    }
}
