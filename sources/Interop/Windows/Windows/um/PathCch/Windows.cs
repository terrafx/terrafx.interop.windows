// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathIsUNCEx([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("PCWSTR *")] char** ppszServer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchIsRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathCchIsRoot([NativeTypeName("PCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddBackslashEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslashEx([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] char** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddBackslash"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslash([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveBackslashEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslashEx([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] char** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveBackslash"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslash([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchSkipRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchSkipRoot([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("PCWSTR *")] char** ppszRootEnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchStripToRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripToRoot([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveFileSpec"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveFileSpec([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchFindExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchFindExtension([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR *")] char** ppszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddExtension([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] char* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRenameExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRenameExtension([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] char* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveExtension([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCanonicalizeEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalizeEx([NativeTypeName("PWSTR")] char* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] char* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCanonicalize"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalize([NativeTypeName("PWSTR")] char* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] char* pszPathIn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCombineEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombineEx([NativeTypeName("PWSTR")] char* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] char* pszPathIn, [NativeTypeName("PCWSTR")] char* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCombine"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombine([NativeTypeName("PWSTR")] char* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] char* pszPathIn, [NativeTypeName("PCWSTR")] char* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAppendEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppendEx([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] char* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAppend"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppend([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] char* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchStripPrefix"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripPrefix([NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAllocCombine"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCombine([NativeTypeName("PCWSTR")] char* pszPathIn, [NativeTypeName("PCWSTR")] char* pszMore, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] char** ppszPathOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAllocCanonicalize"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCanonicalize([NativeTypeName("PCWSTR")] char* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] char** ppszPathOut);

    [NativeTypeName("#define VOLUME_PREFIX L\"\\\\?\\Volume\"")]
    public const string VOLUME_PREFIX = "\\\\?\\Volume";

    [NativeTypeName("#define VOLUME_PREFIX_LEN (ARRAYSIZE(VOLUME_PREFIX) - 1)")]
    public const uint VOLUME_PREFIX_LEN = ((11) - 1);

    [NativeTypeName("#define PATHCCH_MAX_CCH 0x8000")]
    public const int PATHCCH_MAX_CCH = 0x8000;
}
