using System.Windows;

namespace FlowMind.Theme
{
    public static class ResourceKeys
    {
        #region Button

        public static ComponentResourceKey NormalButtonStyleKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "NormalButtonStyle");
        public static ComponentResourceKey MenuButtonStyleKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "MenuButtonStyle");
        public static ComponentResourceKey TableButtonStyleKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "TableButtonStyle");

        #endregion

        #region RadioButton

        public static ComponentResourceKey SidebarRadioButtonStyleKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "SidebarRadioButtonStyle");

        #endregion

        #region ToggleButton
        
        public static ComponentResourceKey SidebarToggleButtonStyleKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "SidebarToggleButtonStyle");

        #endregion

        #region Logo

        public static ComponentResourceKey LogoDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "LogoDrawingGroup");
        public static ComponentResourceKey AdminUserDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "AdminUserDrawingGroup");
        public static ComponentResourceKey NormalUserDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "NormalUserDrawingGroup");

        public static ComponentResourceKey CommandChainDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandChainDrawingGroup");
        public static ComponentResourceKey DocumemntDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "DocumemntDrawingGroup");
        public static ComponentResourceKey ExperimentDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "ExperimentDrawingGroup");
        public static ComponentResourceKey TestDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "TestDrawingGroup");
        public static ComponentResourceKey CmdRecordDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CmdRecordDrawingGroup");
        public static ComponentResourceKey ManualCmdDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "ManualCmdDrawingGroup");
        public static ComponentResourceKey UploadDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "UploadDrawingGroup");
        public static ComponentResourceKey UserManagerDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "UserManagerDrawingGroup");
        public static ComponentResourceKey AuthorityManagerDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "AuthorityManagerDrawingGroup");
        public static ComponentResourceKey SettingDrawingGroupKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "SettingDrawingGroup");

        #endregion

        #region Converter

        public static ComponentResourceKey BoolToTextDecorationsConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "BoolToTextDecorationsConverter");
        public static ComponentResourceKey EnumToVisibilityConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "EnumToVisibilityConverter");
        public static ComponentResourceKey VisibilityConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "VisibilityConverter");
        public static ComponentResourceKey VisibilityOrToVisibilityConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "VisibilityOrToVisibilityConverter");
        public static ComponentResourceKey OnlyOneItemOfItemsControlConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "OnlyOneItemOfItemsControlConverter");
        public static ComponentResourceKey StringToBoolConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "StringToBoolConverter");
        public static ComponentResourceKey LastItemOfItemsControlMultiConverterKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "LastItemOfItemsControlMultiConverter");

        #endregion

        #region Template

        public static ComponentResourceKey CommandTreeParentNodeDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandTreeParentNodeDataTemplate");
        public static ComponentResourceKey CommandTreeChildNodeDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandTreeChildNodeDataTemplate");

        public static ComponentResourceKey CommandParamOptionsDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandParamOptionsDataTemplate");
        public static ComponentResourceKey CommandParamTimeDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandParamTimeDataTemplate");
        public static ComponentResourceKey CommandParamTextDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandParamTextDataTemplate");
        public static ComponentResourceKey CommandParamNumericDataTemplateKey { get; } = new ComponentResourceKey(typeof(ResourceKeys), "CommandParamNumericDataTemplate");

        #endregion
    }
}
