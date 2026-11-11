// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IPROPVALUE
{
    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_EXECUTEMODE_NONE"]/*' />
    [NativeTypeName("#define IPROPVALUE_EXECUTEMODE_NONE TEXT(\"NONE\")")]
    public const string IPROPVALUE_EXECUTEMODE_NONE = "NONE";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_EXECUTEMODE_SCRIPT"]/*' />
    [NativeTypeName("#define IPROPVALUE_EXECUTEMODE_SCRIPT TEXT(\"SCRIPT\")")]
    public const string IPROPVALUE_EXECUTEMODE_SCRIPT = "SCRIPT";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE__CARRYINGNDP_URTREINSTALL"]/*' />
    [NativeTypeName("#define IPROPVALUE__CARRYINGNDP_URTREINSTALL TEXT(\"URTREINSTALL\")")]
    public const string IPROPVALUE__CARRYINGNDP_URTREINSTALL = "URTREINSTALL";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE__CARRYINGNDP_URTUPGRADE"]/*' />
    [NativeTypeName("#define IPROPVALUE__CARRYINGNDP_URTUPGRADE TEXT(\"URTUPGRADE\")")]
    public const string IPROPVALUE__CARRYINGNDP_URTUPGRADE = "URTUPGRADE";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_MSI_RM_CONTROL_DISABLE"]/*' />
    [NativeTypeName("#define IPROPVALUE_MSI_RM_CONTROL_DISABLE TEXT(\"Disable\")")]
    public const string IPROPVALUE_MSI_RM_CONTROL_DISABLE = "Disable";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_MSI_RM_CONTROL_DISABLESHUTDOWN"]/*' />
    [NativeTypeName("#define IPROPVALUE_MSI_RM_CONTROL_DISABLESHUTDOWN TEXT(\"DisableShutdown\")")]
    public const string IPROPVALUE_MSI_RM_CONTROL_DISABLESHUTDOWN = "DisableShutdown";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_FEATURE_ALL"]/*' />
    [NativeTypeName("#define IPROPVALUE_FEATURE_ALL TEXT(\"ALL\")")]
    public const string IPROPVALUE_FEATURE_ALL = "ALL";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_RBCOST_PROMPT"]/*' />
    [NativeTypeName("#define IPROPVALUE_RBCOST_PROMPT TEXT(\"P\")")]
    public const string IPROPVALUE_RBCOST_PROMPT = "P";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_RBCOST_SILENT"]/*' />
    [NativeTypeName("#define IPROPVALUE_RBCOST_SILENT TEXT(\"D\")")]
    public const string IPROPVALUE_RBCOST_SILENT = "D";

    /// <include file='IPROPVALUE.xml' path='doc/member[@name="IPROPVALUE.IPROPVALUE_RBCOST_FAIL"]/*' />
    [NativeTypeName("#define IPROPVALUE_RBCOST_FAIL TEXT(\"F\")")]
    public const string IPROPVALUE_RBCOST_FAIL = "F";
}
