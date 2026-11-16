// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.NSTCSTYLE2;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAddDefaultPropertiesByExt"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAddDefaultPropertiesByExt([NativeTypeName("PCWSTR")] char* pszExt, IPropertyStore* pPropStore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDefaultPropertiesOp"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultPropertiesOp(IShellItem* psi, IFileOperation** ppFileOp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetDefaultProperties"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetDefaultProperties(HWND hwnd, IShellItem* psi, [NativeTypeName("DWORD")] uint dwFileOpFlags, IFileOperationProgressSink* pfops);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_NORECOMPRESS"]/*' />
    [NativeTypeName("#define SHPWHF_NORECOMPRESS 0x00000001")]
    public const int SHPWHF_NORECOMPRESS = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_NONETPLACECREATE"]/*' />
    [NativeTypeName("#define SHPWHF_NONETPLACECREATE 0x00000002")]
    public const int SHPWHF_NONETPLACECREATE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_NOFILESELECTOR"]/*' />
    [NativeTypeName("#define SHPWHF_NOFILESELECTOR 0x00000004")]
    public const int SHPWHF_NOFILESELECTOR = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_USEMRU"]/*' />
    [NativeTypeName("#define SHPWHF_USEMRU 0x00000008")]
    public const int SHPWHF_USEMRU = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_ANYLOCATION"]/*' />
    [NativeTypeName("#define SHPWHF_ANYLOCATION 0x00000100")]
    public const int SHPWHF_ANYLOCATION = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPWHF_VALIDATEVIAWEBFOLDERS"]/*' />
    [NativeTypeName("#define SHPWHF_VALIDATEVIAWEBFOLDERS 0x00010000")]
    public const int SHPWHF_VALIDATEVIAWEBFOLDERS = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACDD_VISIBLE"]/*' />
    [NativeTypeName("#define ACDD_VISIBLE 0x0001")]
    public const int ACDD_VISIBLE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSTR_EXTENSIONCOMPLETIONSTATE"]/*' />
    [NativeTypeName("#define PROPSTR_EXTENSIONCOMPLETIONSTATE L\"ExtensionCompletionState\"")]
    public const string PROPSTR_EXTENSIONCOMPLETIONSTATE = "ExtensionCompletionState";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NSTCS2_ALLMASK"]/*' />
    [NativeTypeName("#define NSTCS2_ALLMASK (NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING)")]
    public const NSTCSTYLE2 NSTCS2_ALLMASK = (NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NSTCDHPOS_ONTOP"]/*' />
    [NativeTypeName("#define NSTCDHPOS_ONTOP -1")]
    public const int NSTCDHPOS_ONTOP = -1;
}
